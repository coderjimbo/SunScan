﻿#pragma checksum "..\..\..\Pages\DeviceDetailsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C7BECB59E79EB6D9AA6C834F4C5A5B8B"
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
    /// DeviceDetailsPage
    /// </summary>
    public partial class DeviceDetailsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Pages\DeviceDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_back;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\DeviceDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_deviceTitle;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\DeviceDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_manage;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\DeviceDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_favorites;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\DeviceDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_ipAddress;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\DeviceDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_macAddress;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\DeviceDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_wmiAvailable;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Pages\DeviceDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_manufacturer;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\DeviceDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_devmodel;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\DeviceDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_pcname;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Pages\DeviceDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_currentuser;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\DeviceDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_opsys;
        
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
            System.Uri resourceLocater = new System.Uri("/SunScan;component/pages/devicedetailspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\DeviceDetailsPage.xaml"
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
            
            #line 20 "..\..\..\Pages\DeviceDetailsPage.xaml"
            this.button_back.Click += new System.Windows.RoutedEventHandler(this.button_back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBlock_deviceTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.button_manage = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Pages\DeviceDetailsPage.xaml"
            this.button_manage.Click += new System.Windows.RoutedEventHandler(this.button_manage_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button_favorites = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Pages\DeviceDetailsPage.xaml"
            this.button_favorites.Click += new System.Windows.RoutedEventHandler(this.button_favorites_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textBlock_ipAddress = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.textBlock_macAddress = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.textBlock_wmiAvailable = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.textBlock_manufacturer = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.textBlock_devmodel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.textBlock_pcname = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.textBlock_currentuser = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.textBlock_opsys = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

