﻿#pragma checksum "..\..\..\AboutUs.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E657BC274F720A6B39EC8E1C1EF96273262139C0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using SchoolManagement_ExcelData;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace SchoolManagement_ExcelData {
    
    
    /// <summary>
    /// AboutUs
    /// </summary>
    public partial class AboutUs : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 75 "..\..\..\AboutUs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Home_btn;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\AboutUs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Contactus_btn;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\AboutUs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AboutUs_btn;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\AboutUs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Courses_btn;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\AboutUs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Faculty_btn;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\AboutUs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Apply_btn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SchoolManagement_ExcelData;component/aboutus.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AboutUs.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Home_btn = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\AboutUs.xaml"
            this.Home_btn.Click += new System.Windows.RoutedEventHandler(this.Home_btn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 83 "..\..\..\AboutUs.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Contactus_btn = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\AboutUs.xaml"
            this.Contactus_btn.Click += new System.Windows.RoutedEventHandler(this.Contactus_btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AboutUs_btn = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\AboutUs.xaml"
            this.AboutUs_btn.Click += new System.Windows.RoutedEventHandler(this.AboutUs_btn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Courses_btn = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\AboutUs.xaml"
            this.Courses_btn.Click += new System.Windows.RoutedEventHandler(this.Courses_btn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Faculty_btn = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\AboutUs.xaml"
            this.Faculty_btn.Click += new System.Windows.RoutedEventHandler(this.Faculty_btn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Apply_btn = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\AboutUs.xaml"
            this.Apply_btn.Click += new System.Windows.RoutedEventHandler(this.Apply_btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

