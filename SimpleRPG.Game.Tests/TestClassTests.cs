using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Xunit;

namespace SimpleRPG.Game.Tests
{
    public class TestClassTests
    {
        [Fact]
        public void DoSomething_Test() 
        {
            //Arrange
            var cut = new TestClass();

            // Act
            var result = cut.DoSomething("TestAbc");

            // Assert
            Assert.True(result);
            Assert.Equal("TestAbc", cut.Name);
        }
    }
}
