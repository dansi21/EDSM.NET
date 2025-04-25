using System.Text.Json;
using System.Text.Json.Serialization;

namespace EDSM.NET.Models;

public class StatusModel
{
    [JsonPropertyName("lastUpdate")]
    [JsonConverter(typeof(LastUpdateConverter))]
    public DateTime LastUpdate { get; set; }
    public required string Type { get; set; }
    public required string Message { get; set; }
    public int Status { get; set; }
}

public class LastUpdateConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return DateTime.Parse(reader.GetString()!);
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
