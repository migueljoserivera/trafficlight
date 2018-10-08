using System;
using Xunit;

namespace TrafficLight.Tests
{
    public class TestTrafficLight
    {
        [Fact]
        public void DefaultColor_mustBeRed()
        {
            TrafficLight trafficLight = new TrafficLight();

            Assert.Equal(TrafficLight.Color.Red, trafficLight.CurrentColor);
        }

        [Fact]
        public void ChangeIfIsRed_mustChangeToGreen()
        {
            TrafficLight trafficLight = new TrafficLight();

            trafficLight.Change();

            Assert.Equal(TrafficLight.Color.Green, trafficLight.CurrentColor);
        }

        [Fact]
        public void ChangeIfIsGreen_mustChangeToYellow()
        {
            TrafficLight trafficLight = new TrafficLight();
            trafficLight.CurrentColor = TrafficLight.Color.Green;

            trafficLight.Change();

            Assert.Equal(TrafficLight.Color.Yellow, trafficLight.CurrentColor);
        }

        [Fact]
        public void ChangeIfIsYellow_mustChangeToRed()
        {
            TrafficLight trafficLight = new TrafficLight();
            trafficLight.CurrentColor = TrafficLight.Color.Yellow;

            trafficLight.Change();

            Assert.Equal(TrafficLight.Color.Red, trafficLight.CurrentColor);
        }
    }
}
