using Encapsulation.Models;
using FluentAssertions;

namespace Encapsulation.Tests;


public class SecureWeatherReportTests
{
    private SecureWeatherReporter SecureWeatherReporterForLondon;
    private SecureWeatherReporter SecureWeatherReporterForCalifornia;
    private SecureWeatherReporter SecureWeatherReporterForCapeTown;

    [SetUp]
    public void Setup()
    {
        SecureWeatherReporterForLondon  = new SecureWeatherReporter("London", 9);
        SecureWeatherReporterForCalifornia = new SecureWeatherReporter("California", 25);
        SecureWeatherReporterForCapeTown = new SecureWeatherReporter("Cape Town", 40);
    }

    [Test]
    public void Display_Weather_Details_for_London()
    {
        SecureWeatherReporterForLondon.DisplayTheWeatherDetails().Should().Be("I am in London and the temperature is 9° C. It's too cold.");
    }

    [Test]
    public void Display_Weather_Details_for_California()
    {
        SecureWeatherReporterForCalifornia.DisplayTheWeatherDetails().Should().Be("I am in California and the temperature is 77° F. Ahhh...it's just right!");
    }

    [Test]
    public void Display_Weather_Details_for_CapeTown()
    {
        SecureWeatherReporterForCapeTown.DisplayTheWeatherDetails().Should().Be("I am in Cape Town and the temperature is 104° F. It's too hot.");
    }
}