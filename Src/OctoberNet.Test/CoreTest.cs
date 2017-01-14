using System;
using OctoberNet;
using NUnit.Framework;

namespace OctoberNet.Test
{
    [TestFixture]
    public class CoreTest
    {
        [Test]
        public void CreateMeasurementShouldReturnTrueOnSuccess()
        {
            Assert.IsTrue(OctoberNet.Metric.CreateMeasurement("test"));
        }
    }
}
