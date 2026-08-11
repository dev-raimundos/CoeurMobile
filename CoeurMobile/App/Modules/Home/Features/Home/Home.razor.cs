using CoeurMobile.App.Core.Services;
using Microsoft.AspNetCore.Components;

namespace CoeurMobile.App.Modules.Home.Features.Home;

public partial class Home
{
    [Inject]
    protected IAuthService AuthService { get; set; } = default!;

    private string FirstName
    {
        get
        {
            return AuthService.CurrentSession?.Name.Split(' ')[0] ?? "Não Definido";
        }
    }
}
