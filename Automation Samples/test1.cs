using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.Dynamics365.UIAutomation.Api;
using Field = Microsoft.Dynamics365.UIAutomation.Api.Field;
using CompositeControl = Microsoft.Dynamics365.UIAutomation.Api.CompositeControl;
using OptionSet = Microsoft.Dynamics365.UIAutomation.Api.OptionSet;
using LookupItem = Microsoft.Dynamics365.UIAutomation.Api.LookupItem;
using Automation_Samples.Properties;
using System.Globalization;
using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using SeleniumExtras.WaitHelpers;
using DocumentFormat.OpenXml.Bibliography;
using System.Xml.Linq;
using System.Drawing;
using RazorEngine.Compilation.ImpromptuInterface;
using RazorEngine.Compilation.ImpromptuInterface.Optimization;
using MongoDB.Driver.Core.Authentication;
using System.Web;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Spreadsheet;
using NUnit.Framework.Internal;

using Automation_Samples;
using NUnit.Framework;
using Automation_Samples;

namespace Automation_Samples
{
    [TestFixture]
    public class APISample : TestHelper
    {


        Microsoft.Dynamics365.UIAutomation.Api.Browser xrmBrowser;



        [Test]
        public void CRMLogin(string username, string password)
        {
            xrmBrowser.Driver.Navigate().GoToUrl(Settings.Default.DMCACRMURL);
            xrmBrowser.Driver.FindElement(By.Id("userNameInput")).SendKeys(username);
            xrmBrowser.Driver.FindElement(By.Id("passwordInput")).SendKeys(password);

            try
            {
                xrmBrowser.Driver.FindElement(By.Id("submitButton")).Click();
            }
            catch (StaleElementReferenceException notExcep) { }


            xrmBrowser.ThinkTime(10000);
            try
            {
                try
                {
                    xrmBrowser.Driver.SwitchTo().Frame("InlineDialog1_Iframe");
                    try
                    {

                        xrmBrowser.Driver.FindElement(By.Id("butBegin")).Click();
                    }
                    catch (StaleElementReferenceException notExcep) { }
                    xrmBrowser.ThinkTime(5000);
                }
                catch (Exception ex) { }
                xrmBrowser.Driver.SwitchTo().DefaultContent();
                xrmBrowser.Driver.SwitchTo().Frame("InlineDialog_Iframe");
                try
                {
                    xrmBrowser.Driver.FindElement(By.XPath("//div[@id='navTourCloseButtonImage']")).Click();
                }
                catch (StaleElementReferenceException notExcep)
                {

                }
            }
            catch (Exception e)
            {
                xrmBrowser.Driver.SwitchTo().DefaultContent();
            }
        }


        [Test]
        public void SessionSample()
        {

            BrowserOptions crmOptions = new BrowserOptions
            {
                PrivateMode = true,

                BrowserType = BrowserType.Chrome
            };
            xrmBrowser = new Microsoft.Dynamics365.UIAutomation.Api.Browser(crmOptions);

            //using (var xrmBrowser = new Microsoft.Dynamics365.UIAutomation.Api.Browser(crmOptions)){ }


            try
            { 
                CRMLogin(Properties.Settings.Default.DMCACRMAdminUsername, Properties.Settings.Default.DMCACRMAdminPassword);
                Driver.Navigate().GoToUrl(Settings.Default.DMCACRMURL);
                xrmBrowser.Driver.Navigate().GoToUrl(Settings.Default.DMCACRMURL);
                

                //site map and command bar
                xrmBrowser.Navigation.OpenSubArea("Marine Craft", "Vessel Logs");
                xrmBrowser.CommandBar.ClickCommand("New");
                xrmBrowser.ThinkTime(15000);


                //Form Fields
                xrmBrowser.Entity.SetValue("ldv_applicationtype", "New Trip");
                xrmBrowser.Entity.SetValue(new OptionSet { Name = "ldv_applicanttype", Value = "Individual" });
                xrmBrowser.Entity.SetValue("ldv_applicant", Automation_Samples.Properties.Settings.Default.portal_user_indv);
                xrmBrowser.Entity.SetValue("ldv_platenumber", "DP 7093");
                xrmBrowser.Entity.SetValue("ldv_remarks", "Test Remarks Auto");
                //vessel log form
                xrmBrowser.Entity.SetValue("ldv_numberofcrew", "2");
                xrmBrowser.Entity.SetValue("ldv_captainname", "2");
                xrmBrowser.Entity.SetValue("ldv_fuelquantity", "2");
                xrmBrowser.Entity.SetValue("ldv_departurelocation", "2");
                xrmBrowser.Entity.SetValue("ldv_arrivallocation", "2");

                xrmBrowser.Entity.SetValue("ldv_triparea", "2");
                xrmBrowser.Entity.SetValue("ldv_weathercondition", "2");
                xrmBrowser.Entity.SetValue("ldv_numberofpassengersondeparture", "2");
                xrmBrowser.Entity.SetValue("ldv_numberofpassengersonarrival", "2");

                xrmBrowser.Entity.SetValue("ldv_bilge", "2");
                xrmBrowser.Entity.SetValue("ldv_sewage", "2");
                xrmBrowser.Entity.SetValue("ldv_garbage", "2");
                xrmBrowser.Entity.SetValue("ldv_firealarmtesttwiceamonth", DateTime.Today);


                xrmBrowser.CommandBar.ClickCommand("Save");
                xrmBrowser.ThinkTime(20000);

                //get request 
                string Appnumber = xrmBrowser.Entity.GetValue("ldv_name");
                string Appstatus = xrmBrowser.Entity.GetValue(new LookupItem { Name = "ldv_applicationstatus" });

                //search in views
                xrmBrowser.Navigation.OpenSubArea("Marine Craft", "Queues");
                //Select Queue    Items available to work on
                xrmBrowser.Grid.SwitchView("Items available to work on");
                //Write in search text box
                xrmBrowser.Grid.Search(Appnumber, true, 2000);
                //Click on search button 
                //xrmBrowser.Grid.ClickElement("crmGrid_findCriteriaButton");
                //Select(not open) first record 
                xrmBrowser.Grid.SelectRecord(0, 2000);
                //Click on pick from command bar
                xrmBrowser.CommandBar.ClickCommand("Pick");
                //Click on pick in picking dialog 
                //xrmBrowser.Dialogs.PickDialog();
                xrmBrowser.Driver.SwitchTo().Frame(xrmBrowser.Driver.FindElement(By.Id("InlineDialog_Iframe")));
                xrmBrowser.Driver.FindElement(By.Id("ok_id")).Click();
                //Select Queue    Items I am working on
                xrmBrowser.Grid.SwitchView("Items I am working on");
                //Open First record
                xrmBrowser.Grid.OpenRecord(0, 2000);


                //stage 
                xrmBrowser.Navigation.OpenSubArea("Marine Crew", "Marine Crew License Applications");
                xrmBrowser.Grid.Search("APP2822024-00201", true, 2000);
                xrmBrowser.Grid.OpenRecord(0, 2000);
                xrmBrowser.ThinkTime(8000);
                xrmBrowser.Entity.SetValue(new OptionSet { Name = "header_process_ldv_rtsdecision_d", Value = "Needs More Information" });
                xrmBrowser.Entity.SetValue("header_process_ldv_rtscomment", "TestRTSCommentAutomationFady");
                xrmBrowser.ThinkTime(5000);
                xrmBrowser.BusinessProcessFlow.NextStage();

                xrmBrowser.Driver.Quit();
                xrmBrowser.Driver.Dispose();

            }
            catch (StaleElementReferenceException e)
            {
                //do nothing
            }
            catch (Exception ex)
            {

            }

        }







    }

}
