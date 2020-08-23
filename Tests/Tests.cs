using System;
using Xunit;
using MiscLib;

namespace Tests
{
    public class MiscLibTests
    {
        
        [Theory]
        [InlineData(5, 10)]      
        
        public void CalcRectAreaTest(int length, int width)
        {
            var g = new GroupOneFunctions();

            Assert.Equal(15, g.CalcRectArea(length, width));
            
        }
    }
}
