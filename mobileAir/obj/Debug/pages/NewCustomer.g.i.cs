﻿#pragma checksum "..\..\..\pages\NewCustomer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3F55931BF40016DFE824CAFDCB11ED85C46F339D8A2552695A2DF9BB9B82B555"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RootLibrary.WPF.Localization;
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
using mobileAir.Pages;


namespace mobileAir.Pages {
    
    
    /// <summary>
    /// NewCustomer
    /// </summary>
    public partial class NewCustomer : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\pages\NewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtname;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\pages\NewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtaddress;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\pages\NewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtphone;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\pages\NewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbcustomertype;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\pages\NewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnsubmint;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\pages\NewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnreset;
        
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
            System.Uri resourceLocater = new System.Uri("/mobileAir;component/pages/newcustomer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\NewCustomer.xaml"
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
            this.txtname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtaddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtphone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cbbcustomertype = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.btnsubmint = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\..\pages\NewCustomer.xaml"
            this.btnsubmint.Click += new System.Windows.RoutedEventHandler(this.Btnsubmint_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnreset = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\..\pages\NewCustomer.xaml"
            this.btnreset.Click += new System.Windows.RoutedEventHandler(this.Btnreset_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

