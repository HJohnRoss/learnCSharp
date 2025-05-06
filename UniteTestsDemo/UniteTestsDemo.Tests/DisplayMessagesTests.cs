using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniteTestsDemo.Tests
{
    public class DisplayMessagesTests
    {
        //[Fact]
        //public void GreetingShouldReturnGoodMorningMessage()
        //{
        //    DisplayMessages messages = new DisplayMessages();
        //    string expected = "Good morning John";
        //    string actual = messages.Greeting("John", 2);
        //    Assert.Equal(expected, actual);
        //}
        //[Fact]
        //public void GreetingShouldReturnGoodAfternoonMessage()
        //{
        //    DisplayMessages messages = new DisplayMessages();
        //    string expected = "Good afternoon John";
        //    string actual = messages.Greeting("John", 13);
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void GreetingShouldReturnGoodEveningMessage()
        //{
        //    DisplayMessages messages = new DisplayMessages();
        //    string expected = "Good evening John";
        //    string actual = messages.Greeting("John", 20);
        //    Assert.Equal(expected, actual);
        //}

        [Theory]
        [InlineData("John", 0, "Good morning John")]
        [InlineData("John", 1, "Good morning John")]
        [InlineData("John", 2, "Good morning John")]
        [InlineData("John", 3, "Good morning John")]
        [InlineData("John", 4, "Good morning John")]
        [InlineData("John", 5, "Good morning John")]
        [InlineData("John", 6, "Good morning John")]
        [InlineData("John", 7, "Good morning John")]
        [InlineData("John", 8, "Good morning John")]
        [InlineData("John", 9, "Good morning John")]
        [InlineData("John", 10, "Good morning John")]
        [InlineData("John", 11, "Good morning John")]
        [InlineData("John", 12, "Good afternoon John")]
        [InlineData("John", 13, "Good afternoon John")]
        [InlineData("John", 14, "Good afternoon John")]
        [InlineData("John", 15, "Good afternoon John")]
        [InlineData("John", 16, "Good afternoon John")]
        [InlineData("John", 17, "Good afternoon John")]
        [InlineData("John", 18, "Good evening John")]
        [InlineData("John", 19, "Good evening John")]
        [InlineData("John", 20, "Good evening John")]
        [InlineData("John", 21, "Good evening John")]
        [InlineData("John", 22, "Good evening John")]
        [InlineData("John", 23, "Good evening John")]
        [InlineData("John", 24, "Good evening John")]
        public void GreetingShouldReturnExpectedValue(string firstName, int hourOfDay, string expected)
        {
            DisplayMessages messages = new DisplayMessages();
            string actual = messages.Greeting(firstName, hourOfDay);
            Assert.Equal(expected, actual);
        }
    }
}
