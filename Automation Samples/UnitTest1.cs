using Config;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using Shouldly;
using System;

namespace Automation_Samples
{
    [TestFixture]
    public class UnitTest1 : BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            // Arrange
            var assertBoolean = true;

            // Act


            // Assert
            GetBrowserErrors(); // Keep this to capture any errors in browser console before assert

            assertBoolean.ShouldSatisfyAllConditions(
                () => assertBoolean.ShouldBeTrue(),
                () => { if (Settings.FireExceptionOnBrowserConsoleErrors) errors.ShouldBeNullOrEmpty(); });
        }

        /// <summary>
        /// Example of Test Method that takes inputs
        /// Multiple TestCase Attributes for one test method means running the same test method multiple times each with the input provided in the TestCase
        /// </summary>
        [TestCase("text example", Languages.en)]
        [TestCase("text example", Languages.ar)]
        public void TestCase1(string textExample, Languages lang)
        {
            // Arrange
            var assertBoolean = true;
            Settings.Language = lang; // Set the Setting.Language to be used in the LocalizedValueOf function in Common Class when getting from resource files

            // Act


            // Assert
            GetBrowserErrors(); // Keep this to capture any errors in browser console before assert

            assertBoolean.ShouldSatisfyAllConditions(
                () => assertBoolean.ShouldBeTrue(),
                () => { if (Settings.FireExceptionOnBrowserConsoleErrors) errors.ShouldBeNullOrEmpty(); });
        }
    }
}