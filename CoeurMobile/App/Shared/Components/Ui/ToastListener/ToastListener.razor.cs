using CoeurMobile.App.Core.Services;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CoeurMobile.App.Shared.Components.Ui.ToastListener;

public partial class ToastListener : IDisposable
{
    [Inject]
    protected ToastService ToastService { get; set; } = default!;

    [Inject]
    protected ISnackbar Snackbar { get; set; } = default!;

    protected override void OnInitialized()
    {
        ToastService.OnToast += HandleToast;
    }

    private void HandleToast(ToastMessage toast)
    {
        InvokeAsync(() => Snackbar.Add(toast.Text, ToSeverity(toast.Severity)));
    }

    private static Severity ToSeverity(ToastSeverity severity)
    {
        return severity switch
        {
            ToastSeverity.Warning => Severity.Warning,
            ToastSeverity.Info => Severity.Info,
            _ => Severity.Error,
        };
    }

    public void Dispose()
    {
        ToastService.OnToast -= HandleToast;
    }
}
