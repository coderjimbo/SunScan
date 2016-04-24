﻿#pragma checksum "..\..\..\Pages\HomePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "844177F377E585E656FDE92EDED1E27F"
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
    /// HomePage
    /// </summary>
    public partial class HomePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_newScan;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_openScan;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_favoriteDevices;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_settings;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock scanStatusLabel;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock errorMessageLabel;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel scanProgressStackPanel;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar scanProgressBar;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock scanTimeLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/SunScan;component/pages/homepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\HomePage.xaml"
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
            this.button_newScan = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Pages\HomePage.xaml"
            this.button_newScan.Click += new System.Windows.RoutedEventHandler(this.button_newScan_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.button_openScan = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Pages\HomePage.xaml"
            this.button_openScan.Click += new System.Windows.RoutedEventHandler(this.button_openScan_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.button_favoriteDevices = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\Pages\HomePage.xaml"
            this.button_favoriteDevices.Click += new System.Windows.RoutedEventHandler(this.button_favoriteDevices_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button_settings = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\Pages\HomePage.xaml"
            this.button_settings.Click += new System.Windows.RoutedEventHandler(this.button_settings_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.scanStatusLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.errorMessageLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.scanProgressStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.scanProgressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 9:
            this.scanTimeLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

