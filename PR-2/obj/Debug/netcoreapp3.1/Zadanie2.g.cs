#pragma checksum "..\..\..\Zadanie2.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05BF4F525017F94E2F250BDAA710879392462553"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PR_2;
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


namespace PR_2 {
    
    
    /// <summary>
    /// Zadanie2
    /// </summary>
    public partial class Zadanie2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\Zadanie2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PR_2.Zadanie2 Zadanie_two;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\Zadanie2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_back;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Zadanie2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label l_nomer;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Zadanie2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock l_textZadaniya;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Zadanie2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_vvodStroki;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Zadanie2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label l_result;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Zadanie2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_start;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PR-2;component/zadanie2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Zadanie2.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Zadanie_two = ((PR_2.Zadanie2)(target));
            return;
            case 2:
            this.btn_back = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\Zadanie2.xaml"
            this.btn_back.Click += new System.Windows.RoutedEventHandler(this.btn_back_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.l_nomer = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.l_textZadaniya = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.tb_vvodStroki = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.l_result = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.btn_start = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Zadanie2.xaml"
            this.btn_start.Click += new System.Windows.RoutedEventHandler(this.btn_start_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

