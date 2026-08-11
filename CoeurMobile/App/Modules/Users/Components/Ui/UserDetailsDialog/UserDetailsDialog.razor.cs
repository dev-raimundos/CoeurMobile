using CoeurMobile.App.Modules.Users.DataAccess.Dtos;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CoeurMobile.App.Modules.Users.Components.Ui.UserDetailsDialog;

public partial class UserDetailsDialog
{
    [CascadingParameter]
    private IMudDialogInstance MudDialog { get; set; } = default!;

    [Parameter]
    public UserAccountResponse User { get; set; } = default!;

    private void Close()
    {
        MudDialog.Close();
    }
}
