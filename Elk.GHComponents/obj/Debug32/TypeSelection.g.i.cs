﻿#pragma checksum "..\..\TypeSelection.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CAED48C924E4DCE854A46FEDA85ED616"
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


namespace Elk.GHComponents {
    
    
    /// <summary>
    /// TypeSelection
    /// </summary>
    public partial class TypeSelection : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\TypeSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closeButton;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\TypeSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle closeButtonRect;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\TypeSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okButton;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\TypeSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle okButtonRect;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\TypeSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\TypeSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle addButtonRect;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\TypeSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeButton;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\TypeSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle removeButtonRect;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\TypeSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox outputsCheckbox;
        
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
            System.Uri resourceLocater = new System.Uri("/Elk.GHComponents;component/typeselection.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TypeSelection.xaml"
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
            
            #line 43 "..\..\TypeSelection.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.closeButton = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\TypeSelection.xaml"
            this.closeButton.Click += new System.Windows.RoutedEventHandler(this.closeButton_Click);
            
            #line default
            #line hidden
            
            #line 57 "..\..\TypeSelection.xaml"
            this.closeButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.closeButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 57 "..\..\TypeSelection.xaml"
            this.closeButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.closeButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.closeButtonRect = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.okButton = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\TypeSelection.xaml"
            this.okButton.Click += new System.Windows.RoutedEventHandler(this.okButton_Click);
            
            #line default
            #line hidden
            
            #line 77 "..\..\TypeSelection.xaml"
            this.okButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.okButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 77 "..\..\TypeSelection.xaml"
            this.okButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.okButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.okButtonRect = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 6:
            this.addButton = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\TypeSelection.xaml"
            this.addButton.Click += new System.Windows.RoutedEventHandler(this.addButton_Click);
            
            #line default
            #line hidden
            
            #line 104 "..\..\TypeSelection.xaml"
            this.addButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.addButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 104 "..\..\TypeSelection.xaml"
            this.addButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.addButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 7:
            this.addButtonRect = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 8:
            this.removeButton = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\TypeSelection.xaml"
            this.removeButton.Click += new System.Windows.RoutedEventHandler(this.removeButton_Click);
            
            #line default
            #line hidden
            
            #line 125 "..\..\TypeSelection.xaml"
            this.removeButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.removeButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 125 "..\..\TypeSelection.xaml"
            this.removeButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.removeButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 9:
            this.removeButtonRect = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 10:
            this.outputsCheckbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
