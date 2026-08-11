using System.Net.Http.Json;
using CoeurMobile.App.Core.DataAccess.Http;
using CoeurMobile.App.Core.DataAccess.Dtos;
using CoeurMobile.App.Modules.Users.DataAccess.Dtos;

namespace CoeurMobile.App.Modules.Users.DataAccess;

public class UsersApiClient(HttpClient httpClient)
{
    public async Task<PagedResult<UserAccountResponse>> GetUsersAsync(CancellationToken cancellationToken = default)
    {
        var result = await httpClient.GetFromJsonAsync<PagedResult<UserAccountResponse>>("api/v1/users", cancellationToken);

        return result ?? throw new CoeurApiException("Resposta vazia do endpoint de listagem de usuários.");
    }
}
