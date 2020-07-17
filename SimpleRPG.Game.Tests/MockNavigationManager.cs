using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRPG.Game.Tests
{
    public class MockNavigationManager : NavigationManager
    {
        public MockNavigationManager() 
        {
            this.Initialize("https://test.com/", "https://test.com/testlink/");
        }

        protected override void NavigateToCore(string uri, bool forceLoad)
        {
            this.Uri = uri;
        }
    }
}
