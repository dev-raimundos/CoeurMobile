using CoeurMobile.App.Core.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace CoeurMobile.App;

public partial class Routes : IDisposable
{
    private const string LoginRoute = "login";

    [Inject]
    protected IAuthService AuthService { get; set; } = default!;

    [Inject]
    protected NavigationManager NavigationManager { get; set; } = default!;

    protected override void OnInitialized()
    {
        AuthService.OnChange += HandleAuthChanged;
    }

    public void Dispose()
    {
        AuthService.OnChange -= HandleAuthChanged;
    }

    private async Task OnNavigateAsync(NavigationContext context)
    {
        await AuthService.EnsureInitializedAsync();
        RedirectToLoginIfNeeded(context.Path);
    }

    private void HandleAuthChanged()
    {
        RedirectToLoginIfNeeded(NavigationManager.ToBaseRelativePath(NavigationManager.Uri));
    }

    private void RedirectToLoginIfNeeded(string path)
    {
        var isLoginRoute = path.Trim('/').Equals(LoginRoute, StringComparison.OrdinalIgnoreCase);
        if (!AuthService.IsAuthenticated() && !isLoginRoute)
        {
            NavigationManager.NavigateTo($"/{LoginRoute}", replace: true);
        }
    }
}
