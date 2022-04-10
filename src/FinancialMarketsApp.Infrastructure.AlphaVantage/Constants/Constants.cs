using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialMarketsApp.Infrastructure.AlphaVantage.Constants
{
    public static class Interval
    {
        public const string MINUTES_1 = "1min";
        public const string MINUTES_5 = "5min";
        public const string MINUTES_15 = "15min";
        public const string MINUTES_30 = "30min";
        public const string MINUTES_60 = "60min";
    }

    public static class TimeSeries
    {
        const string TIME_SERIES_INTRADAY = "TIME_SERIES_INTRADAY";
        const string TIME_SERIES_INTRADAY_EXTENDED = "TIME_SERIES_INTRADAY_EXTENDED";
        const string TIME_SERIES_DAILY = "TIME_SERIES_DAILY";
        const string TIME_SERIES_DAILY_ADJUSTED = "TIME_SERIES_DAILY_ADJUSTED";
        const string TIME_SERIES_WEEKLY = "TIME_SERIES_WEEKLY";
        const string TIME_SERIES_WEEKLY_ADJUSTED = "TIME_SERIES_WEEKLY_ADJUSTED";
        const string TIME_SERIES_MONTHLY = "TIME_SERIES_MONTHLY";
        const string TIME_SERIES_MONTHLY_ADJUSTED = "TIME_SERIES_MONTHLY_ADJUSTED";
    }

    public static class OutputSize
    {
        const string COMPACT = "compact";
        const string FULL = "full";
    }

    public static class DataType
    {
        const string JSON = "json";
        const string CSV = "CSV";
    }
}
