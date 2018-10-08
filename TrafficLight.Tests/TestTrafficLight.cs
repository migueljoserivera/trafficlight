using System;
using Xunit;

namespace TrafficLight.Tests
{
    public class TestTrafficLight
    {
        [Fact]
        public void ColorMustBeRedByDefault()
        {
            TrafficLight.Color expectedColor = TrafficLight.Color.Red;
            TrafficLight.Color actualColor;

            TrafficLight trafficLight = new TrafficLight();
            actualColor = trafficLight.CurrentColor;

            Assert.Equal(expectedColor, actualColor);
        }

        [Fact]
        public void WhenColorIsRedMustChangeToGreen()
        {
            TrafficLight.Color expectedColor = TrafficLight.Color.Green;
            TrafficLight.Color actualColor;
            TrafficLight trafficLight = new TrafficLight();

            trafficLight.Change();
            actualColor = trafficLight.CurrentColor;

            Assert.Equal(expectedColor, actualColor);
        }

        [Fact]
        public void WhenColorIsGreenMustChangeToYellow()
        {
            TrafficLight.Color expectedColor = TrafficLight.Color.Yellow;
            TrafficLight.Color actualColor;
            TrafficLight trafficLight = new TrafficLight();
            trafficLight.CurrentColor = TrafficLight.Color.Green;

            trafficLight.Change();
            actualColor = trafficLight.CurrentColor;

            Assert.Equal(expectedColor, actualColor);
        }

        [Fact]
        public void WhenColorIsYellowMustChangeToRed()
        {
            TrafficLight.Color expectedColor = TrafficLight.Color.Red;
            TrafficLight.Color actualColor;
            TrafficLight trafficLight = new TrafficLight();
            trafficLight.CurrentColor = TrafficLight.Color.Yellow;

            trafficLight.Change();
            actualColor = trafficLight.CurrentColor;

            Assert.Equal(expectedColor, actualColor);
        }
    }
}
