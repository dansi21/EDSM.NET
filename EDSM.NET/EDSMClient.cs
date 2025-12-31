using System.Net.Http.Json;
using EDSM.NET.Models;

namespace EDSM.NET
{
    public static class EdsmClient
    {
        private static readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://www.edsm.net")
        };

        public static async Task<StatusModel?> GetServerStatusAsync(CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetFromJsonAsync<StatusModel>(
                "/api-status-v1/elite-server",
                cancellationToken);
            return response;
        }
    }
}
