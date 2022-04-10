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
        public const string TIME_SERIES_INTRADAY = "TIME_SERIES_INTRADAY";
        public const string TIME_SERIES_INTRADAY_EXTENDED = "TIME_SERIES_INTRADAY_EXTENDED";
        public const string TIME_SERIES_DAILY = "TIME_SERIES_DAILY";
        public const string TIME_SERIES_DAILY_ADJUSTED = "TIME_SERIES_DAILY_ADJUSTED";
        public const string TIME_SERIES_WEEKLY = "TIME_SERIES_WEEKLY";
        public const string TIME_SERIES_WEEKLY_ADJUSTED = "TIME_SERIES_WEEKLY_ADJUSTED";
        public const string TIME_SERIES_MONTHLY = "TIME_SERIES_MONTHLY";
        public const string TIME_SERIES_MONTHLY_ADJUSTED = "TIME_SERIES_MONTHLY_ADJUSTED";
    }

    public static class OutputSize
    {
        public const string COMPACT = "compact";
        public const string FULL = "full";
    }

    public static class DataType
    {
        public const string JSON = "json";
        public const string CSV = "CSV";
    }
}
