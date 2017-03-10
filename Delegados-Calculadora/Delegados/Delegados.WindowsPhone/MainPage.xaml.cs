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
using ClassLibrary1;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Delegados
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Operaciones Operaciones;
        public MainPage()
        {
            this.InitializeComponent();
            Operaciones = new Operaciones();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void btn_Sumar(object sender, RoutedEventArgs e)
        {
            tbResultado.Text = "" + Operaciones.Sumar(tbOperador1, tbOperador2);
        }

        private void btn_Restar(object sender, RoutedEventArgs e)
        {
            tbResultado.Text = "" + Operaciones.Restar(tbOperador1, tbOperador2);
        }

        //Uso de Delegados para Practicas
        public delegate ulong MultiplicarDelegate(TextBox a, TextBox b);

        private void btn_Multiplicar(object sender, RoutedEventArgs e)
        {
            MultiplicarDelegate multiplicarD = new MultiplicarDelegate(Operaciones.Multiplicar);
            tbResultado.Text = "" + multiplicarD(tbOperador1, tbOperador2);
        }

        private void btn_Dividir(object sender, RoutedEventArgs e)
        {
            tbResultado.Text = "" + Operaciones.Dividir(tbOperador1, tbOperador2);
        }

        //Uso de Delegados para practicas
        public delegate int factorialDelegate(int num);

        private void btn_Factorial(object sender, RoutedEventArgs e)
        {
            factorialDelegate factorialD = new factorialDelegate(Operaciones.factorial);
            int num1 = int.Parse(tbOperador1.Text);
            tbResultado.Text = "" + factorialD(num1);
        }

        private void btn_Clear(object sender, RoutedEventArgs e)
        {
            tbOperador1.Text = "";
            tbOperador2.Text = "";
            tbResultado.Text = "";
        }
    }
}
