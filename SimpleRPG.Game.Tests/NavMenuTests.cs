using Bunit;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using SimpleRPG.Game.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SimpleRPG.Game.Tests
{
    public class NavMenuTests
    {
        [Fact]
        public void SimpleRender() 
        {
            // Arrange
            using var ctx = new TestContext();
            ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());

            // Act
            var cut = ctx.RenderComponent<NavMenu>();

            // Assert
            var expected = @"<span class=""oi oi-home"" aria-hidden=""true""></span> Home";
            Assert.Contains(expected, cut.Markup);
            expected = @"<div class=""collapse"" blazor:onclick=""2"">";
            Assert.Contains(expected, cut.Markup);
        }

        [Fact]
        public void ToggleNavMenu() 
        {
            // Arrange
            using var ctx = new TestContext();
            ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());

            // Act
            var cut = ctx.RenderComponent<NavMenu>();
            cut.Find(".navbar-toggler").Click();

            // Assert
            var expected = @"<div blazor:onclick=""2"">";
            Assert.Contains(expected, cut.Markup);
        }
    }
}
