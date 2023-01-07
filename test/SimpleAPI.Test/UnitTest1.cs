using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace SimpleAPI.Test;

public class UnitTest1
{
	private WeatherForecastController _controller;

	private readonly IMock<ILogger<WeatherForecastController>> _mockLogger;

	public UnitTest1()
	{
		_mockLogger = new Mock<ILogger<WeatherForecastController>>();

		_controller = new WeatherForecastController(_mockLogger.Object);
	}

	[Fact]
	public void Must_result_values()
	{
		var result = _controller.Get();

		Assert.True(result.Count() > 0);
	}
}