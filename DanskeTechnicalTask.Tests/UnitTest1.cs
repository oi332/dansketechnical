using System;
using Xunit;

namespace DanskeTechnicalTask.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var height = 3;
            var pyramid = ProducePyramid(height);
            var expected =
                $@"   *
                     **
                    ***";

            Assert.Equal(pyramid, expected);
        }
    }
}
