﻿#pragma checksum "..\..\DobavitClientaWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A05271A3D15D5EC0B871AC87573AF29E414CD6F1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using InsuranceCompanyMAX;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace InsuranceCompanyMAX {
    
    
    /// <summary>
    /// DobavitClientaWindow
    /// </summary>
    public partial class DobavitClientaWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\DobavitClientaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal InsuranceCompanyMAX.DobavitClientaWindow dobavitClientaWindow;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\DobavitClientaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fioBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\DobavitClientaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addressBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\DobavitClientaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox teleBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\DobavitClientaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox innBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\DobavitClientaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveBtn;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\DobavitClientaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/InsuranceCompanyMAX;component/dobavitclientawindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DobavitClientaWindow.xaml"
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
            this.dobavitClientaWindow = ((InsuranceCompanyMAX.DobavitClientaWindow)(target));
            return;
            case 2:
            this.fioBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.addressBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.teleBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\DobavitClientaWindow.xaml"
            this.teleBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.teleBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.innBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\DobavitClientaWindow.xaml"
            this.innBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.innBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.saveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\DobavitClientaWindow.xaml"
            this.saveBtn.Click += new System.Windows.RoutedEventHandler(this.saveBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cancelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\DobavitClientaWindow.xaml"
            this.cancelBtn.Click += new System.Windows.RoutedEventHandler(this.cancelBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

