﻿using FinancialMarketsApp.Core.Interfaces;
using FinancialMarketsApp.MVC.Models;
using FinancialMarketsApp.MVC.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using FinancialMarketsApp.Infrastructure.AlphaVantage.Constants;

namespace FinancialMarketsApp.MVC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAlphaVantageClient _alphaVantageClient;

        public HomeController(ILogger<HomeController> logger, IAlphaVantageClient alphaVantageClient)
        {
            _logger = logger;
            _alphaVantageClient = alphaVantageClient;
        }

        public async Task<IActionResult> Index()
        {
            var res = await _alphaVantageClient.GetTimeSeries(timeSeriesFunction: Function.TIME_SERIES_INTRADAY, interval: Interval.MINUTES_15, symbol: "IBM", adjusted: false);

            return Ok(res);
        }
    }
}