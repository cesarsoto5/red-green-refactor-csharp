using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Testing.Example.Test
{
    public class FactorialServiceTests
    {
        [Fact]
        public void TestFactorialZero()
        {
            //Arrange
            FactorialService service = new FactorialService();
            
            //Act
            int result = service.Calculate(0);

            //Assert
            Assert.Equal(1, result);
        }
        
        [Fact]
        public void TestFactorialFive()
        {
            FactorialService service = new FactorialService();

            int result = service.Calculate(5);

            Assert.Equal(120, result);
        }
    }
}
