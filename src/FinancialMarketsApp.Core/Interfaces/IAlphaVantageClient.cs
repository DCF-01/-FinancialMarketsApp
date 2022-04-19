using FinancialMarketsApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialMarketsApp.Core.Interfaces
{
    public interface IAlphaVantageClient
    {
        public Task<IEnumerable<TimeSeries>> GetTimeSeries(string timeSeriesFunction, string symbol, string interval, bool adjusted);
    }
}
