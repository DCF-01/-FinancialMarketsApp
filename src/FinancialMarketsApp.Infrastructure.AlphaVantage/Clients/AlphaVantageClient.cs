using FinancialMarketsApp.Core.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;

using FinancialMarketsApp.Infrastructure.AlphaVantage.Options;

namespace FinancialMarketsApp.Infrastructure.AlphaVantage.Clients
{
    public class AlphaVantageClient : IAlphaVantageClient
    {
        HttpClient _httpClient;
        AlphaVantageOptions _alphaVantageOptions;
        public AlphaVantageClient(HttpClient client, IOptions<AlphaVantageOptions> options)
        {
            _httpClient = client;
            _alphaVantageOptions = options.Value;
        }
        public async Task<T> GetTimeSeries<T>(string timeSpan, string ticker, string interval, bool adjusted, string outputSize)
        {
            var response = await _httpClient.GetFromJsonAsync<T>($"query?function={timeSpan}&symbol={ticker}&interval={interval}&apikey={_alphaVantageOptions.APIKey}");

            if (response == null)
                throw new ArgumentException("API call to AlphaVantage failed.");
            return response;
        }
    }
}
