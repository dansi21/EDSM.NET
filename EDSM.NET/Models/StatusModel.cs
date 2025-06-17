using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;
using EDSM.NET.Converters;

namespace EDSM.NET.Models;

public class StatusModel
{
    [JsonPropertyName("lastUpdate")]
    [JsonConverter(typeof(Converters.DateTimeConverter))]
    public DateTime LastUpdate { get; set; }
    public required string Type { get; set; }
    public required string Message { get; set; }
    public int Status { get; set; }
}
