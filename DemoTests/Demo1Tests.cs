using System;
using Demo1;
using Xunit;

namespace DemoTests
{
    public class Demo1Tests
    {
        [Fact]
        public void ToLegacyFormat_C20()
        {
            var dateTime = new DateTime(1920, 12, 31);

            Assert.Equal("0201231", dateTime.ToLegacyFormat());
        }

        [Fact]
        public void ToLegacyName()
        {
            var name = "Elton Stoneman";

            Assert.Equal("STONEMAN, ELTON", name.ToLegacyFormat());
        }
    }
}
