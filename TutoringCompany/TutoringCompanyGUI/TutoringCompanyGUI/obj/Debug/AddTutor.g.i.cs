﻿#pragma checksum "..\..\AddTutor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F38866FE73D5CE55833177CCF6E4E3ED67510EF70D2FBF1969D0E6190217190F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TutoringCompanyGUI;


namespace TutoringCompanyGUI {
    
    
    /// <summary>
    /// AddTutor
    /// </summary>
    public partial class AddTutor : TutoringCompanyGUI.WindowBase, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\AddTutor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl TitleContent;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddTutor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tutorName;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AddTutor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tutorSurname;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AddTutor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tutorPhone;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AddTutor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tutorEmail;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AddTutor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tutorRate;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AddTutor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox tutorGender;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\AddTutor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addTutor;
        
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
            System.Uri resourceLocater = new System.Uri("/TutoringCompanyGUI;component/addtutor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddTutor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.TitleContent = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 2:
            this.tutorName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tutorSurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tutorPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tutorEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tutorRate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tutorGender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.addTutor = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\AddTutor.xaml"
            this.addTutor.Click += new System.Windows.RoutedEventHandler(this.addTutor_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

