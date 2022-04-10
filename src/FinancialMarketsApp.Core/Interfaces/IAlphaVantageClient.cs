using System;

public interface IAlphaVantageClient
{
	public dynamic GetTimeSeries(string timeSpan, string ticker, string interval, bool adjusted, string outputSize, string apiKey)
}