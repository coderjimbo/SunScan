﻿#pragma checksum "..\..\..\Pages\SettingsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C3003295ED63145781938FFB761CB021"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SunScan.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SunScan.Pages {
    
    
    /// <summary>
    /// SettingsPage
    /// </summary>
    public partial class SettingsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Pages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_back;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textbox_nmapcommand;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ipRangeBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBox_overwrite;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox overwriteIPBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_saveSettings;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_clearFavorites;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Pages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textbox_settings_saved;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SunScan;component/pages/settingspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\SettingsPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.button_back = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Pages\SettingsPage.xaml"
            this.button_back.Click += new System.Windows.RoutedEventHandler(this.button_back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textbox_nmapcommand = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.ipRangeBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.checkBox_overwrite = ((System.Windows.Controls.CheckBox)(target));
            
            #line 34 "..\..\..\Pages\SettingsPage.xaml"
            this.checkBox_overwrite.Checked += new System.Windows.RoutedEventHandler(this.checkBox_overwrite_Checked);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\Pages\SettingsPage.xaml"
            this.checkBox_overwrite.Unchecked += new System.Windows.RoutedEventHandler(this.checkBox_overwrite_Unchecked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.overwriteIPBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.button_saveSettings = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Pages\SettingsPage.xaml"
            this.button_saveSettings.Click += new System.Windows.RoutedEventHandler(this.button_saveSettings_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.button_clearFavorites = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Pages\SettingsPage.xaml"
            this.button_clearFavorites.Click += new System.Windows.RoutedEventHandler(this.button_clearFavorites_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textbox_settings_saved = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

