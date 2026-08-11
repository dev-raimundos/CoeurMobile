namespace CoeurMobile.App.Modules.Auth.Features.Login;

public static class EmailValidator
{
    public static bool HasValidFormat(string email)
    {
        return string.IsNullOrWhiteSpace(email) || email.Contains('@');
    }
}
