using EDSM.NET.Models;
using System.Net.Http.Json;

namespace EDSM.NET
{
    public class Status
    {
        public async static Task<StatusModel> GetStatus() 
        {
            HttpClient client = new();
            await client.GetFromJsonAsync<StatusModel>("https://www.edsm.net/api-v1/status").ContinueWith(task =>
            {
                if (task.IsCompletedSuccessfully)
                {
                    return task.Result;
                }
                else
                {
                    throw new Exception("Failed to get status from EDSM API");
                }
            });
        }
    }
}
