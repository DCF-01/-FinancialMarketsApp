using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialMarketsApp.Core.Interfaces
{
    public interface IAlphaVantageClient
    {
        public Task<T> GetTimeSeries<T>(string timeSpan, string ticker, string interval, bool adjusted, string outputSize);
    }
}
