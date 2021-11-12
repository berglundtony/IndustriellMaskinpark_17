using System;
using Xunit;

namespace ForDevopsTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var a = 1;
            var b = 2;
            Assert.Equal(a, b);
        }
    }
}
