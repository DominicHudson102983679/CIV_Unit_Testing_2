using System;
using Xunit;
using MiscLib;

namespace Tests
{
    public class MiscLibTests
    {   
        GroupOneFunctions g = new GroupOneFunctions ();

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(18, 6, 3)]
        [InlineData(8, 2, 4)]

        public void CalcRectAreaTest (int expected, int length, int width) 
        {
            Assert.Equal(expected, g.CalcRectArea(length, width));
        }
        
        /*
        [Fact]

        public void IsFactorialTest()
        {
            Assert.True (g.IsFactorialNum(120));
            Assert.True (g.IsFactorialNum(1));
            Assert.False (g.IsFactorialNum(40));
            Assert.False (g.IsFactorialNum(60));
        }
        
        /*

        public void CelciusToFarenheitTest()
        {
           
        }

        public void IsPalindromeTest()
        {
             
        }

        public void StringReplaceTest()
        {
             
        }

        public void CharCount()
        {
            
        }

        */
    }
}
