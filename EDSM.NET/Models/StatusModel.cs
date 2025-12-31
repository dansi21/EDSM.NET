using System;

namespace EDSM.NET.Models;

public class StatusModel
{
    public string? LastUpdate { get; set; }
    public string? Type { get; set; }
    public string? Message { get; set; }
    public int Status { get; set; }
}
