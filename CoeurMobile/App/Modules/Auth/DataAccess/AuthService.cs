using System.Net;
using System.Text.Json;
using CoeurMobile.App.Core.DataAccess.Http;
using CoeurMobile.App.Core.Services;

namespace CoeurMobile.App.Modules.Auth.DataAccess;

public class AuthService : IAuthService
{
    private readonly AuthApiClient _apiClient;
    private readonly TokenAccessor _tokenAccessor;
    private readonly MauiSecureSessionStore _sessionStore;
    private readonly Task _initialization;

    public AuthService(AuthApiClient apiClient, TokenAccessor tokenAccessor, MauiSecureSessionStore sessionStore)
    {
        _apiClient = apiClient;
        _tokenAccessor = tokenAccessor;
        _sessionStore = sessionStore;

        _tokenAccessor.OnUnauthorized += () => _ = LogoutAsync();

        _initialization = LoadSessionAsync();
    }

    public AuthSession? CurrentSession { get; private set; }

    public bool IsAuthenticated()
    {
        return CurrentSession is not null;
    }

    public event Action? OnChange;

    public Task EnsureInitializedAsync()
    {
        return _initialization;
    }

    public async Task LoginAsync(string email, string password)
    {
        var auth = await _apiClient.LoginAsync(email, password);

        CurrentSession = new AuthSession(auth.User.Id, auth.User.Name, auth.User.Email, auth.Token);
        _tokenAccessor.Token = auth.Token;
        await _sessionStore.SetAsync(JsonSerializer.Serialize(CurrentSession));
        OnChange?.Invoke();
    }

    public Task LogoutAsync()
    {
        CurrentSession = null;
        _tokenAccessor.Token = null;
        _sessionStore.Remove();
        OnChange?.Invoke();
        return Task.CompletedTask;
    }

    private async Task LoadSessionAsync()
    {
        AuthSession? session;
        try
        {
            var json = await _sessionStore.GetAsync();
            if (string.IsNullOrEmpty(json))
            {
                return;
            }

            session = JsonSerializer.Deserialize<AuthSession>(json);
        }
        catch
        {
            return;
        }

        if (session is null)
        {
            return;
        }

        _tokenAccessor.Token = session.Token;
        CurrentSession = session;

        try
        {
            await _apiClient.GetMeAsync();
        }
        catch (CoeurApiException ex) when (ex.StatusCode == HttpStatusCode.Unauthorized)
        {
        }
        catch
        {
        }
    }
}
