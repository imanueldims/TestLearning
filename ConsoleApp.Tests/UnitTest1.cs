using System;
using Xunit;

namespace ConsoleApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var x = 2;
            if (1 == 3) {
                return;
            }
            else if(x==4) throw new NotImplementedException();
            else {
                throw new Exception();
            }
        }
    }
}
