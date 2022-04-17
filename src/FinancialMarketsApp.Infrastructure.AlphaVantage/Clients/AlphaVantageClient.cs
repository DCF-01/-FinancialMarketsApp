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
using System.Net;
using FinancialMarketsApp.Core.Models;

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
        public async Task<IEnumerable<TimeSeries>> GetTimeSeries(string timeSeriesFunction, string ticker, string interval, bool adjusted)
        {
            var response = await _httpClient.GetAsync($"query?function={timeSeriesFunction}&symbol={ticker}&interval={interval}&apikey={_alphaVantageOptions.APIKey}&datatype=csv");

            if (response.StatusCode != HttpStatusCode.OK)
                throw new ArgumentException("API call to AlphaVantage failed.");

            string csvContent = await response.Content.ReadAsStringAsync();

            var timeSeries = csvContent.Split("\r\n").Skip(1).SkipLast(1).Select(x =>
            {
                var columns = x.Split(',');
                return new TimeSeries
                {
                    TimeStamp = columns[0],
                    Open = columns[1],
                    High = columns[2],
                    Low = columns[3],
                    Close = columns[4],
                    Volume = columns[5]
                };
            });

            return timeSeries;
        }
    }
}
