using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSM.NET.Models
{
    public class BodyModel
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string SubType { get; set; } = string.Empty;
        public long DistanceToArrival { get; set; }
        public bool IsMainStar { get; set; }
        public bool IsScoopable { get; set; }
    }
}
