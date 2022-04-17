using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialMarketsApp.Core.Models
{
    public class TimeSeries
    {
        public string? TimeStamp { get; set; } 
        public string? Open { get; set; }
        public string? High { get; set; }
        public string? Low { get; set; }
        public string? Close { get; set; }
        public string? Volume { get; set; }
    }
}
