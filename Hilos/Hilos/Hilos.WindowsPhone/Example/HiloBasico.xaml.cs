using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Navigation;
using Windows.System.Threading;
using Windows.UI.Core;
using Windows.Phone.UI.Input;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Hilos.Example
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HiloBasico : Page
    {
        public HiloBasico()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            HardwareButtons.BackPressed -= HardwareButtons_BackPressed;
        }


        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            if(Frame.CanGoBack)
            {
                e.Handled = true;
                Frame.GoBack();
            }
        }

        private void btnMostrarMensaje_Click(object sender, RoutedEventArgs e)
        {
            tbMensaje.Text = "Hello Word";
        }

        private void btnIniciarProceso_Click(object sender, RoutedEventArgs e)
        {
            IAsyncAction WorkItem =
            ThreadPool.RunAsync(_ => Proceso(), WorkItemPriority.Normal);
        }

        async public void Proceso()
        {
            System.Threading.Tasks.Task.Delay(3000).Wait();
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                tbMensaje.Text = "Proceso Terminado";
                tb1.Text = "Probando";
            });
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbMensaje.Text = "";
            tb1.Text = "";
        }

    }
}
