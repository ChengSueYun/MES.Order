﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using System.Configuration;

namespace Ritek.App.Demo.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Binary)]
        public global::System.Collections.Generic.List<Ritek.App.Infrastructure.SteelPlateViewModel> AppDefaultSteelPlate {
            get {
                return ((global::System.Collections.Generic.List<Ritek.App.Infrastructure.SteelPlateViewModel>)(this["AppDefaultSteelPlate"]));
            }
            set {
                this["AppDefaultSteelPlate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CY8103")]
        public string SeriesNo {
            get {
                return ((string)(this["SeriesNo"]));
            }
            set {
                this["SeriesNo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Binary)]
        public global::System.Collections.Generic.List<Ritek.App.Infrastructure.ThicknessViewModel> AppDefaultThickness {
            get {
                return ((global::System.Collections.Generic.List<Ritek.App.Infrastructure.ThicknessViewModel>)(this["AppDefaultThickness"]));
            }
            set {
                this["AppDefaultThickness"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Binary)]
        public global::System.Collections.Generic.List<Ritek.App.Infrastructure.DevelopmentViewModel> AppDefaultDevelopment {
            get {
                return ((global::System.Collections.Generic.List<Ritek.App.Infrastructure.DevelopmentViewModel>)(this["AppDefaultDevelopment"]));
            }
            set {
                this["AppDefaultDevelopment"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Binary)]
        public global::System.Collections.Generic.List<Ritek.App.Infrastructure.LDIViewModel> AppDefaultLDI {
            get {
                return ((global::System.Collections.Generic.List<Ritek.App.Infrastructure.LDIViewModel>)(this["AppDefaultLDI"]));
            }
            set {
                this["AppDefaultLDI"] = value;
            }
        }
    }
}
