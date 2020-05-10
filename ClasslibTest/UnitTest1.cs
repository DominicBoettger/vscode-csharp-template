using System;
using Classlib;
using Xunit;

namespace ClasslibTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(22, Class1.MyInt());
        }
    }
}