﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PCI.VSP.Web.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int CRMDeploymentType {
            get {
                return ((int)(this["CRMDeploymentType"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TRICENSION")]
        public string CRMDomain {
            get {
                return ((string)(this["CRMDomain"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("house.account")]
        public string CRMUsername {
            get {
                return ((string)(this["CRMUsername"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P@ssword1")]
        public string CRMPassword {
            get {
                return ((string)(this["CRMPassword"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://pensionconsultinginc.tricension.net/MSCRMServices/2007/SPLA/CrmDiscoverySe" +
            "rvice.asmx")]
        public string CRMUrl {
            get {
                return ((string)(this["CRMUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PensionConsultingInc")]
        public string CRMOrganization {
            get {
                return ((string)(this["CRMOrganization"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Single Value</string>
  <string>Multi-Value</string>
  <string>Range</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection DefaultVendorResponseTypes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["DefaultVendorResponseTypes"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Single Value</string>
  <string>Multi-Value</string>
  <string>Range</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection DefaultClientResponseTypes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["DefaultClientResponseTypes"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Integer</string>
  <string>Text</string>
  <string>Yes/No</string>
  <string>Money</string>
  <string>Choice</string>
  <string>Date</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection DefaultQuestionDataTypes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["DefaultQuestionDataTypes"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Equal To</string>
  <string>Greater Than or Equal To</string>
  <string>Less Than or Equal To</string>
  <string>Within Range</string>
  <string>Complete Match</string>
  <string>Any Match</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection DefaultComparisonTypes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["DefaultComparisonTypes"]));
            }
        }
    }
}
