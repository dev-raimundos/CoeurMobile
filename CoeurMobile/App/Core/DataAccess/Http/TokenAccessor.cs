namespace CoeurMobile.App.Core.DataAccess.Http;

public class TokenAccessor
{
    public string? Token { get; set; }

    public event Action? OnUnauthorized;

    public void NotifyUnauthorized()
    {
        OnUnauthorized?.Invoke();
    }
}
