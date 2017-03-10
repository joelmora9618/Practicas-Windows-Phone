using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ClassLibrary1
{
    public class Operaciones
    {
        public ulong Sumar(TextBox Op1, TextBox Op2)
        {
            UInt64 num1 = UInt64.Parse(Op1.Text);
            UInt64 num2 = UInt64.Parse(Op2.Text);

            return num1 + num2;
        }

        public ulong Restar(TextBox Op1, TextBox Op2)
        {
            UInt64 num1 = UInt64.Parse(Op1.Text);
            UInt64 num2 = UInt64.Parse(Op2.Text);

            return num1 - num2;
        }

        public ulong Multiplicar(TextBox Op1, TextBox Op2)
        {
            UInt64 num1 = UInt64.Parse(Op1.Text);
            UInt64 num2 = UInt64.Parse(Op2.Text);

            return num1 * num2;
        }

        public ulong Dividir(TextBox Op1, TextBox Op2)
        {
            UInt64 num1 = UInt64.Parse(Op1.Text);
            UInt64 num2 = UInt64.Parse(Op2.Text);

            return num1 / num2;
        }

        public static int factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

    }
}
