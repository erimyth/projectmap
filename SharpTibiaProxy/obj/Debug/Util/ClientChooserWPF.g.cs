﻿#pragma checksum "..\..\..\Util\ClientChooserWPF.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F9BC272A51AF440C8F0C88299F5DD100"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
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


namespace SharpTibiaProxy.Util {
    
    
    /// <summary>
    /// ClientChooserWPF
    /// </summary>
    public partial class ClientChooserWPF : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Util\ClientChooserWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox uxClients;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Util\ClientChooserWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button uxChoose;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Util\ClientChooserWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label uxLoginServerLabel;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Util\ClientChooserWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander uxUseOT;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Util\ClientChooserWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox uxLoginServer;
        
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
            System.Uri resourceLocater = new System.Uri("/SharpTibiaProxy;component/util/clientchooserwpf.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Util\ClientChooserWPF.xaml"
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
            this.uxClients = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\..\Util\ClientChooserWPF.xaml"
            this.uxClients.KeyUp += new System.Windows.Input.KeyEventHandler(this.CommonKeyUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.uxChoose = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Util\ClientChooserWPF.xaml"
            this.uxChoose.Click += new System.Windows.RoutedEventHandler(this.uxChoose_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.uxLoginServerLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.uxUseOT = ((System.Windows.Controls.Expander)(target));
            
            #line 25 "..\..\..\Util\ClientChooserWPF.xaml"
            this.uxUseOT.Expanded += new System.Windows.RoutedEventHandler(this.uxUseOT_Expanded);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\Util\ClientChooserWPF.xaml"
            this.uxUseOT.Collapsed += new System.Windows.RoutedEventHandler(this.uxUseOT_Collapsed);
            
            #line default
            #line hidden
            return;
            case 5:
            this.uxLoginServer = ((System.Windows.Controls.ComboBox)(target));
            
            #line 32 "..\..\..\Util\ClientChooserWPF.xaml"
            this.uxLoginServer.KeyUp += new System.Windows.Input.KeyEventHandler(this.CommonKeyUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

