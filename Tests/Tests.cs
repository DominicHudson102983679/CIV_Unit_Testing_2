using System;
using Xunit;
using MiscLib;

namespace Tests
{
    public class MiscLibTests
    {
        [Theory]
        [InlineData(5, 10, 50)]
        [InlineData(4, 7, 60)] 
        [InlineData(3, 5, 70)] 
        public void CalcRectAreaTest(int length, int width, int result)
        {
            var test = new GroupOneFunctions();
        }
    }
}
