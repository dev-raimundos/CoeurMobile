using System.Net;

namespace CoeurMobile.App.Core.DataAccess.Http;

public sealed class CoeurApiException(string message, HttpStatusCode? statusCode = null) : Exception(message)
{
    public HttpStatusCode? StatusCode { get; } = statusCode;
}
