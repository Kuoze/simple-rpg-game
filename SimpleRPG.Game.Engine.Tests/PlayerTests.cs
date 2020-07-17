using SimpleRPG.Game.Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SimpleRPG.Game.Engine.Tests
{
    public class PlayerTests
    {
        [Fact]
        public void CreateSimplePlayer() 
        {
            // Arrange

            // Act
            var p = new Player()
            {
                Name = "Test",
                Level = 1,
                HitPoints = 10
            };

            // Assert
            Assert.NotNull(p);
            Assert.Equal("Test", p.Name);
            Assert.Equal(string.Empty, p.CharacterClass);
            Assert.Equal(1, p.Level);
            Assert.Equal(10, p.HitPoints);
            Assert.Equal(0, p.ExperiencePoints);
            Assert.Equal(0, p.Gold);
        }


    }
}
