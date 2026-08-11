using System.Net;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using CoeurMobile.App.Core.Services;

namespace CoeurMobile.App.Core.DataAccess.Http;

public class ApiExceptionHandler(ToastService toastService, TokenAccessor tokenAccessor) : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        HttpResponseMessage response;

        try
        {
            response = await base.SendAsync(request, cancellationToken);
        }
        catch (HttpRequestException)
        {
            toastService.Show("Não foi possível conectar ao servidor. Verifique sua conexão.");
            throw;
        }

        if (response.IsSuccessStatusCode)
        {
            return response;
        }

        if (response.StatusCode == HttpStatusCode.Unauthorized)
        {
            tokenAccessor.NotifyUnauthorized();
        }

        ProblemDetailsPayload? problem = null;
        try
        {
            problem = await response.Content.ReadFromJsonAsync<ProblemDetailsPayload>(cancellationToken: cancellationToken);
        }
        catch (Exception)
        {
        }

        var message = problem?.Toast?.Message ?? problem?.Detail ?? "Ocorreu um erro inesperado.";

        var severity = problem?.Toast?.Type switch
        {
            "warning" => ToastSeverity.Warning,
            "info" => ToastSeverity.Info,
            _ => ToastSeverity.Error,
        };

        toastService.Show(message, severity);
        throw new CoeurApiException(message, response.StatusCode);
    }

    private sealed record ToastPayload(
        [property: JsonPropertyName("type")] string? Type,
        [property: JsonPropertyName("message")] string? Message);

    private sealed record ProblemDetailsPayload(
        [property: JsonPropertyName("detail")] string? Detail,
        [property: JsonPropertyName("toast")] ToastPayload? Toast);
}
