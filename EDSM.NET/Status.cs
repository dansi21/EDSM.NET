using EDSM.NET.Models;
using System.Net.Http.Json;

namespace EDSM.NET;

public class Status
{
    public async static Task<StatusModel?> GetStatus() 
    {
        HttpClient client = new();
        HttpResponseMessage response = await client.GetAsync("https://www.edsm.net/api-status-v1/elite-server");
        
        return response.IsSuccessStatusCode
            ? await response.Content.ReadFromJsonAsync<StatusModel>(options: System.Text.Json.JsonSerializerOptions.Web)
            : throw new Exception($"Failed to get status from EDSM API. Status code: {response.StatusCode}");
    }
}
