﻿#pragma checksum "..\..\..\Pages\GenerationPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "396D328F39B75513F7EAA5751A125A26CA6D9E78979C7B76FABAABBD2AE76AFD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ScottPlot;
using Srez1.Pages;
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


namespace Srez1.Pages {
    
    
    /// <summary>
    /// GenerationPage
    /// </summary>
    public partial class GenerationPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Pages\GenerationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbSurname;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\GenerationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbGroup;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\GenerationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbAVG;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\GenerationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbFIO;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\GenerationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbGR;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\GenerationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbYear;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Pages\GenerationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGen;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\GenerationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NumSber;
        
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
            System.Uri resourceLocater = new System.Uri("/Srez1;component/pages/generationpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\GenerationPage.xaml"
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
            this.tbSurname = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.tbGroup = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.tbAVG = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.tbFIO = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbGR = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbYear = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnGen = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Pages\GenerationPage.xaml"
            this.btnGen.Click += new System.Windows.RoutedEventHandler(this.btnGen_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.NumSber = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

