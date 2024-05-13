using Automation_Samples.Properties;
using Automation_Samples.Reporting;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Globalization;
using System.IO;

namespace Automation_Samples
{
    public class Common : TestHelper
    {
        internal Settings Settings = Properties.Settings.Default;

        public enum LocalizationKeys
        {
            RequestSubmittedSuccessfullyMessage
        }

        public enum LogFiles
        {
            RequestsLogFile,
            IssuesLogFile,
            CommandsLogFile
        }

        public string LocalizedValueOf(Enum value)
        {
            return Resources.ResourceManager.GetString(value.ToString(), new CultureInfo(Settings.Language.ToString()));
        }
    }
}