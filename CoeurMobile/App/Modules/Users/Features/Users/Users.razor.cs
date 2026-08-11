using CoeurMobile.App.Modules.Users.Components.Ui.UserDetailsDialog;
using CoeurMobile.App.Modules.Users.DataAccess;
using CoeurMobile.App.Modules.Users.DataAccess.Dtos;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CoeurMobile.App.Modules.Users.Features.Users;

public partial class Users
{
    [Inject]
    protected UsersApiClient ApiClient { get; set; } = default!;

    [Inject]
    protected IDialogService DialogService { get; set; } = default!;

    private List<UserAccountResponse> _users = [];

    private bool _isLoading = true;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            var page = await ApiClient.GetUsersAsync();
            _users = page.Items;
        }
        catch (Exception)
        {
        }
        finally
        {
            _isLoading = false;
        }
    }

    private async Task ShowUserDetailsAsync(UserAccountResponse user)
    {
        var parameters = new DialogParameters<UserDetailsDialog>
        {
            { x => x.User, user }
        };

        await DialogService.ShowAsync<UserDetailsDialog>("Detalhes do usuário", parameters);
    }
}
