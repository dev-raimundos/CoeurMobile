namespace CoeurMobile.App.Core.Services;

public enum ToastSeverity
{
    Info,
    Warning,
    Error,
}

public sealed record ToastMessage(string Text, ToastSeverity Severity);

public sealed class ToastService
{
    public event Action<ToastMessage>? OnToast;

    public void Show(string message, ToastSeverity severity = ToastSeverity.Error)
    {
        OnToast?.Invoke(new ToastMessage(message, severity));
    }
}
