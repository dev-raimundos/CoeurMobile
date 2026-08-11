namespace CoeurMobile.App.Core.Services;

public interface IAuthService
{
    AuthSession? CurrentSession { get; }

    bool IsAuthenticated();

    event Action? OnChange;

    Task EnsureInitializedAsync();

    Task LogoutAsync();
}
