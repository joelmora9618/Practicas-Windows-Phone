﻿

#pragma checksum "C:\De la facu\Practicas Windows Phone\Hilos\Hilos\Hilos.WindowsPhone\Example\HiloBasico.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7EDCE395784C74D321C1CE9AE899F21C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hilos.Example
{
    partial class HiloBasico : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 16 "..\..\Example\HiloBasico.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnIniciarProceso_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 17 "..\..\Example\HiloBasico.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnMostrarMensaje_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 18 "..\..\Example\HiloBasico.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnClear_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


