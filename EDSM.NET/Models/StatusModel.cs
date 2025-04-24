namespace EDSM.NET.Models;

public class StatusModel
{
    public DateTime LastUpdate { get; set; }
    public required string Type { get; set; }
    public required string Message { get; set; }
    public int Status { get; set; }
}
