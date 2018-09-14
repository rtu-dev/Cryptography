using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cript
{
    class Calculo
    {

        public static int Calcular(string num1, string num2, string operação)
        {
            int num3 = Convert.ToInt32(num1);
            int num4 = Convert.ToInt32(num2);
            int soma = 0;

            if (operação.Equals("+"))
            {
                soma = num3 + num4;
            }
            if (operação.Equals("-"))
            {
                soma = num3 - num4;
            }
            if (operação.Equals("*"))
            {
                soma = num3 * num4;
            }
            if (operação.Equals("/"))
            {
                soma = num3 / num4;
            }
            return soma;
        }

    }
}
