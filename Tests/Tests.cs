using System;
using Xunit;
using MiscLib;

namespace Tests
{
    public class MiscLibTests
    {   
        [Fact]  
        
        public void CalcRectAreaTest()
        {
            GroupOneFunctions g = new GroupOneFunctions();

            Assert.Equal(20, g.CalcRectArea (5, 10));
            
        }

        /*
        public void IsFactiorialTest()
        {
            GroupOneFunctions g = new GroupOneFunctions(); 
        }

        public void CelciusToFarenheitTest()
        {
            GroupOneFunctions g = new GroupOneFunctions(); 
        }

        public void IsPalindromeTest()
        {
            GroupOneFunctions g = new GroupOneFunctions(); 
        }

        public void StringReplaceTest()
        {
            GroupOneFunctions g = new GroupOneFunctions(); 
        }

        public void CharCount()
        {
            GroupOneFunctions g = new GroupOneFunctions(); 
        }

        */
    }
}
