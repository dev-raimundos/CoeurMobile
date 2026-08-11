using Microsoft.AspNetCore.Components;

namespace CoeurMobile.App.Modules.Auth.Components.Screen.RedirectToLogin;

public partial class RedirectToLogin
{
    [Inject]
    protected NavigationManager NavigationManager { get; set; } = default!;

    protected override void OnInitialized()
    {
        NavigationManager.NavigateTo("/login");
    }
}
