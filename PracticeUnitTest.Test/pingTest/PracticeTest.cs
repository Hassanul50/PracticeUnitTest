
using FluentAssertions;
using PracticeUnitTest.ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUnitTest.Test.pingTest
{
    public class PracticeTest
    {
        [Fact]
       public void Practice_practiceString_returnString()
        {
            //Arrange
            Practice objPractice = new Practice();
            //Act
            string result = objPractice.practiceString();
            //Assart

            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("This is a practice string");
            result.Should().Contain("This is");

        }
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,3,5)]
        public void Practice_AddNumber_returnInt(int number1, int number2,int expected) 
        {
            //Arrange

            Practice objPractice = new Practice();
            //Act
            int result=objPractice.AddNumber(number1, number2);
            //Assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
        }
    }
}
