﻿#pragma checksum "..\..\..\Pages\Autho.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "559FE7B39157EB80ABF2FD0A19D8D354792D67BC831AA54334AA69E16FA45C8E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Practical_3_Kopylov_Maxim.Pages;
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


namespace Practical_3_Kopylov_Maxim.Pages {
    
    
    /// <summary>
    /// Autho
    /// </summary>
    public partial class Autho : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Pages\Autho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextLogin;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\Autho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbLogin;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\Autho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextPassword;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\Autho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pswbPassword;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\Autho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBlockCaptcha;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\Autho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtboxCaptcha;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\Autho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBlockTimer;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\Autho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEnterGuests;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\Autho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEnter;
        
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
            System.Uri resourceLocater = new System.Uri("/Practical_3_Kopylov_Maxim;component/pages/autho.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Autho.xaml"
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
            this.TextLogin = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.txtbLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TextPassword = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.pswbPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.txtBlockCaptcha = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txtboxCaptcha = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtBlockTimer = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.btnEnterGuests = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Pages\Autho.xaml"
            this.btnEnterGuests.Click += new System.Windows.RoutedEventHandler(this.btnEnterGuests_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnEnter = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Pages\Autho.xaml"
            this.btnEnter.Click += new System.Windows.RoutedEventHandler(this.btnEnter_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
