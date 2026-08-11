using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using CoeurMobile.App.Core.Config;
using CoeurMobile.App.Core.DataAccess.Http;
using CoeurMobile.App.Core.Services;
using CoeurMobile.App.Modules.Auth.DataAccess;
using CoeurMobile.App.Modules.Users.DataAccess;
using CoeurMobile.App.Shared.Components.Ui.ToastListener;

namespace CoeurMobile
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<CoeurApplication>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddMudServices();
            builder.Services.AddSingleton<ThemeService>();

            builder.Services.AddAuthorizationCore(options =>
            {
                options.FallbackPolicy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
            });
            builder.Services.AddScoped<AuthenticationStateProvider, CoeurAuthenticationStateProvider>();
            builder.Services.AddSingleton<TokenAccessor>();
            builder.Services.AddSingleton<MauiSecureSessionStore>();
            builder.Services.AddSingleton<AuthService>();
            builder.Services.AddSingleton<IAuthService>(sp => sp.GetRequiredService<AuthService>());
            builder.Services.AddSingleton<ToastService>();
            builder.Services.AddTransient<BearerTokenHandler>();
            builder.Services.AddTransient<ApiExceptionHandler>();
            builder.Services.AddHttpClient<AuthApiClient>(client =>
            {
                client.BaseAddress = new Uri(AppConfig.ApiBaseUrl);
            })
                .AddHttpMessageHandler<BearerTokenHandler>()
                .AddHttpMessageHandler<ApiExceptionHandler>();
            builder.Services.AddHttpClient<UsersApiClient>(client =>
            {
                client.BaseAddress = new Uri(AppConfig.ApiBaseUrl);
            })
                .AddHttpMessageHandler<BearerTokenHandler>()
                .AddHttpMessageHandler<ApiExceptionHandler>();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
