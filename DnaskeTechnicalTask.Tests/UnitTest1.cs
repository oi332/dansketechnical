using System;
using Xunit;
using DanskeTechnicalTask.Main;

namespace DanskeTechnicalTask.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var height = 3;
            var pyramid = DanskeTechnicalTask.Main.Program.ProducePyramid(height);
            var expected =
                $@"    *
                      **
                     ***";

            Assert.Equal(pyramid, expected);
        }
    }
}
