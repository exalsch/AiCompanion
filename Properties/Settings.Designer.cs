﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AiCompanion.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.14.0.0")]
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
        public string API_Key {
            get {
                return ((string)(this["API_Key"]));
            }
            set {
                this["API_Key"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("gpt-4o-mini")]
        public string ModelLLM {
            get {
                return ((string)(this["ModelLLM"]));
            }
            set {
                this["ModelLLM"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("You are a helpful assistant for the user of this client PC. Give a direct result " +
            "that can be used directly by the user in other applications.")]
        public string PrePromt {
            get {
                return ((string)(this["PrePromt"]));
            }
            set {
                this["PrePromt"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Alt")]
        public string HotKeyMod {
            get {
                return ((string)(this["HotKeyMod"]));
            }
            set {
                this["HotKeyMod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("a")]
        public string HotKeyKey {
            get {
                return ((string)(this["HotKeyKey"]));
            }
            set {
                this["HotKeyKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool FirstLaunch {
            get {
                return ((bool)(this["FirstLaunch"]));
            }
            set {
                this["FirstLaunch"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public decimal TtsSpeed {
            get {
                return ((decimal)(this["TtsSpeed"]));
            }
            set {
                this["TtsSpeed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Fable")]
        public string TtsVoice {
            get {
                return ((string)(this["TtsVoice"]));
            }
            set {
                this["TtsVoice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <string />
  <string>correct below text for any grammar or typo mistakes.</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection prePromtSelections {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["prePromtSelections"]));
            }
            set {
                this["prePromtSelections"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en")]
        public string STT_lang {
            get {
                return ((string)(this["STT_lang"]));
            }
            set {
                this["STT_lang"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseNewUI {
            get {
                return ((bool)(this["UseNewUI"]));
            }
            set {
                this["UseNewUI"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool useDarkMode {
            get {
                return ((bool)(this["useDarkMode"]));
            }
            set {
                this["useDarkMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoStartSTT {
            get {
                return ((bool)(this["AutoStartSTT"]));
            }
            set {
                this["AutoStartSTT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoStartTTS {
            get {
                return ((bool)(this["AutoStartTTS"]));
            }
            set {
                this["AutoStartTTS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("gpt-4o-mini")]
        public string QPromptModel {
            get {
                return ((string)(this["QPromptModel"]));
            }
            set {
                this["QPromptModel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Fix all typos, misspellings, and grammar errors:")]
        public string QPrompt1 {
            get {
                return ((string)(this["QPrompt1"]));
            }
            set {
                this["QPrompt1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string QPrompt2 {
            get {
                return ((string)(this["QPrompt2"]));
            }
            set {
                this["QPrompt2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string QPrompt3 {
            get {
                return ((string)(this["QPrompt3"]));
            }
            set {
                this["QPrompt3"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string QPrompt4 {
            get {
                return ((string)(this["QPrompt4"]));
            }
            set {
                this["QPrompt4"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string QPrompt5 {
            get {
                return ((string)(this["QPrompt5"]));
            }
            set {
                this["QPrompt5"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://api.openai.com/")]
        public string API_URL {
            get {
                return ((string)(this["API_URL"]));
            }
            set {
                this["API_URL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ExcludeAiThoughts {
            get {
                return ((bool)(this["ExcludeAiThoughts"]));
            }
            set {
                this["ExcludeAiThoughts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OpenAI")]
        public string STTEngine {
            get {
                return ((string)(this["STTEngine"]));
            }
            set {
                this["STTEngine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Base")]
        public string WhisperNetModel {
            get {
                return ((string)(this["WhisperNetModel"]));
            }
            set {
                this["WhisperNetModel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Alt")]
        public string SttHotKeyMod {
            get {
                return ((string)(this["SttHotKeyMod"]));
            }
            set {
                this["SttHotKeyMod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".")]
        public string SttHotKeyKey {
            get {
                return ((string)(this["SttHotKeyKey"]));
            }
            set {
                this["SttHotKeyKey"] = value;
            }
        }
    }
}
