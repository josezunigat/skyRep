﻿#pragma checksum "..\..\..\vista\Modulo_Administrador.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FEA8060C5A69287F3E2FD34B4E2788C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MantenedoresCRUD.vista;
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


namespace MantenedoresCRUD.vista {
    
    
    /// <summary>
    /// Modulo_Administrador
    /// </summary>
    public partial class Modulo_Administrador : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\vista\Modulo_Administrador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCerrar;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\vista\Modulo_Administrador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\vista\Modulo_Administrador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelSaludo;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\vista\Modulo_Administrador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\vista\Modulo_Administrador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonLogout;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\vista\Modulo_Administrador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox groupBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\vista\Modulo_Administrador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox groupBox3;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\vista\Modulo_Administrador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
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
            System.Uri resourceLocater = new System.Uri("/MantenedoresCRUD;component/vista/modulo_administrador.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\vista\Modulo_Administrador.xaml"
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
            
            #line 10 "..\..\..\vista\Modulo_Administrador.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DockPanel_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonCerrar = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\vista\Modulo_Administrador.xaml"
            this.buttonCerrar.Click += new System.Windows.RoutedEventHandler(this.buttonCerrar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.labelSaludo = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.buttonLogout = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\vista\Modulo_Administrador.xaml"
            this.buttonLogout.Click += new System.Windows.RoutedEventHandler(this.buttonLogout_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.groupBox = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 8:
            this.groupBox3 = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 9:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\vista\Modulo_Administrador.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

