using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Euroffice.Framework.Hooks
{
    class BrowserHooks
    {
        [Binding]
        public static class TestEvents
        {
            [BeforeTestRun]
            public static void SetupTest()
            {
                Browser.Open();
            }

            [AfterTestRun]
            public static void CleanupTests()
            {
                Browser.Quit();
            }
        }
    }
}
