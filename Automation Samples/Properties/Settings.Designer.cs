﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Automation_Samples.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Frontend_URL {
            get {
                return ((string)(this["Frontend_URL"]));
            }
            set {
                this["Frontend_URL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public double timeToWaitInMinutes {
            get {
                return ((double)(this["timeToWaitInMinutes"]));
            }
            set {
                this["timeToWaitInMinutes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Backend_URL {
            get {
                return ((string)(this["Backend_URL"]));
            }
            set {
                this["Backend_URL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en")]
        public global::Config.Languages Language {
            get {
                return ((global::Config.Languages)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RunHeadless {
            get {
                return ((bool)(this["RunHeadless"]));
            }
            set {
                this["RunHeadless"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FireExceptionOnBrowserConsoleErrors {
            get {
                return ((bool)(this["FireExceptionOnBrowserConsoleErrors"]));
            }
            set {
                this["FireExceptionOnBrowserConsoleErrors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("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")]
        public string SENDGRID_API_KEY {
            get {
                return ((string)(this["SENDGRID_API_KEY"]));
            }
            set {
                this["SENDGRID_API_KEY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("linkdev.automationtest@gmail.com")]
        public string FromMail {
            get {
                return ((string)(this["FromMail"]));
            }
            set {
                this["FromMail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsd=\"http://www.w3." +
            "org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n  <s" +
            "tring>fady.aziz@linkdev.com</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection toMails {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["toMails"]));
            }
            set {
                this["toMails"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public string IsNewDev {
            get {
                return ((string)(this["IsNewDev"]));
            }
            set {
                this["IsNewDev"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public string IsTesting {
            get {
                return ((string)(this["IsTesting"]));
            }
            set {
                this["IsTesting"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("crew/new")]
        public string CrewNewURL {
            get {
                return ((string)(this["CrewNewURL"]));
            }
            set {
                this["CrewNewURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public string RunWithDynamics365Upgrade {
            get {
                return ((string)(this["RunWithDynamics365Upgrade"]));
            }
            set {
                this["RunWithDynamics365Upgrade"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Crm365dc.local\\crmadmin")]
        public string CMAUsername {
            get {
                return ((string)(this["CMAUsername"]));
            }
            set {
                this["CMAUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("linkP@ss")]
        public string CMAPassword {
            get {
                return ((string)(this["CMAPassword"]));
            }
            set {
                this["CMAPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://cmap2.linkdev.com/main.aspx#662006218")]
        public string CMAURLClassic {
            get {
                return ((string)(this["CMAURLClassic"]));
            }
            set {
                this["CMAURLClassic"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://dmcastag.dmca.ae/main.aspx")]
        public string DMCACRMSTGURL {
            get {
                return ((string)(this["DMCACRMSTGURL"]));
            }
            set {
                this["DMCACRMSTGURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("GROUP\\Dma.test02")]
        public string RALUsername {
            get {
                return ((string)(this["RALUsername"]));
            }
            set {
                this["RALUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("*Automation")]
        public string CorporateEmployer {
            get {
                return ((string)(this["CorporateEmployer"]));
            }
            set {
                this["CorporateEmployer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Pleasure Marine Craft Driving License-Skipper-Craft length up to (24) meters")]
        public string CrewSubCategory {
            get {
                return ((string)(this["CrewSubCategory"]));
            }
            set {
                this["CrewSubCategory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("group\\dma.test26")]
        public string InspectorUser {
            get {
                return ((string)(this["InspectorUser"]));
            }
            set {
                this["InspectorUser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P@s$w1rd2")]
        public string InspectorPassword {
            get {
                return ((string)(this["InspectorPassword"]));
            }
            set {
                this["InspectorPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://mcitqc.linkdev.com")]
        public string MCITCRMURL {
            get {
                return ((string)(this["MCITCRMURL"]));
            }
            set {
                this["MCITCRMURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mbsdc\\crmadmin")]
        public string MCITAdminUsername {
            get {
                return ((string)(this["MCITAdminUsername"]));
            }
            set {
                this["MCITAdminUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("linkP@ss")]
        public string MCITAdminPassword {
            get {
                return ((string)(this["MCITAdminPassword"]));
            }
            set {
                this["MCITAdminPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MBSDC\\TechEmployee1")]
        public string MCITTechEmp1Username {
            get {
                return ((string)(this["MCITTechEmp1Username"]));
            }
            set {
                this["MCITTechEmp1Username"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("linkP@ss")]
        public string MCITTechEmp1Password {
            get {
                return ((string)(this["MCITTechEmp1Password"]));
            }
            set {
                this["MCITTechEmp1Password"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public string IsStaging {
            get {
                return ((string)(this["IsStaging"]));
            }
            set {
                this["IsStaging"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public string IsPre {
            get {
                return ((string)(this["IsPre"]));
            }
            set {
                this["IsPre"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://eservicesuat.dmca.ae/en/")]
        public string DMCAPortalURL {
            get {
                return ((string)(this["DMCAPortalURL"]));
            }
            set {
                this["DMCAPortalURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("corfadypre")]
        public string DMCAPortalUserCor_Username {
            get {
                return ((string)(this["DMCAPortalUserCor_Username"]));
            }
            set {
                this["DMCAPortalUserCor_Username"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P@ssw0rdP")]
        public string DMCAPortalUserCor_Password {
            get {
                return ((string)(this["DMCAPortalUserCor_Password"]));
            }
            set {
                this["DMCAPortalUserCor_Password"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("indfadypre")]
        public string DMCAPortalUserInd_Username {
            get {
                return ((string)(this["DMCAPortalUserInd_Username"]));
            }
            set {
                this["DMCAPortalUserInd_Username"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P@ssw0rdP")]
        public string DMCAPortalUserInd_Password {
            get {
                return ((string)(this["DMCAPortalUserInd_Password"]));
            }
            set {
                this["DMCAPortalUserInd_Password"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://dmcauat.dmca.ae")]
        public string DMCACRMURL {
            get {
                return ((string)(this["DMCACRMURL"]));
            }
            set {
                this["DMCACRMURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DMCA.pcfc.ae\\Svc-UCRMADMIN")]
        public string DMCACRMAdminUsername {
            get {
                return ((string)(this["DMCACRMAdminUsername"]));
            }
            set {
                this["DMCACRMAdminUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P@ss4C6mu01")]
        public string DMCACRMAdminPassword {
            get {
                return ((string)(this["DMCACRMAdminPassword"]));
            }
            set {
                this["DMCACRMAdminPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P@s$w1rd2")]
        public string RALPassword {
            get {
                return ((string)(this["RALPassword"]));
            }
            set {
                this["RALPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("indfadypre")]
        public string portal_user_indv {
            get {
                return ((string)(this["portal_user_indv"]));
            }
            set {
                this["portal_user_indv"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Pleasure")]
        public string CrewCategory {
            get {
                return ((string)(this["CrewCategory"]));
            }
            set {
                this["CrewCategory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("corfadypre")]
        public string portal_user_comp {
            get {
                return ((string)(this["portal_user_comp"]));
            }
            set {
                this["portal_user_comp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("VesselLogBook/apply")]
        public string VesselLogURL {
            get {
                return ((string)(this["VesselLogURL"]));
            }
            set {
                this["VesselLogURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AppStatusSettings {
            get {
                return ((string)(this["AppStatusSettings"]));
            }
            set {
                this["AppStatusSettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AppNumberSettings {
            get {
                return ((string)(this["AppNumberSettings"]));
            }
            set {
                this["AppNumberSettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PlateNumberSettings {
            get {
                return ((string)(this["PlateNumberSettings"]));
            }
            set {
                this["PlateNumberSettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2 / 20 / 2026")]
        public string DepartureDate {
            get {
                return ((string)(this["DepartureDate"]));
            }
            set {
                this["DepartureDate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8:45 PM")]
        public string DepartureTime {
            get {
                return ((string)(this["DepartureTime"]));
            }
            set {
                this["DepartureTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2 / 20 / 2026")]
        public string ArrivalDate {
            get {
                return ((string)(this["ArrivalDate"]));
            }
            set {
                this["ArrivalDate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8:46 PM")]
        public string ArrivalTime {
            get {
                return ((string)(this["ArrivalTime"]));
            }
            set {
                this["ArrivalTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string MainStatus {
            get {
                return ((string)(this["MainStatus"]));
            }
            set {
                this["MainStatus"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string subsubstatus {
            get {
                return ((string)(this["subsubstatus"]));
            }
            set {
                this["subsubstatus"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SubStatus {
            get {
                return ((string)(this["SubStatus"]));
            }
            set {
                this["SubStatus"] = value;
            }
        }
    }
}
