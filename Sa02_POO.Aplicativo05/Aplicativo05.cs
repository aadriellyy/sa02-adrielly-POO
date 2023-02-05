using System;
using Sa02_POO.RegraDeNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02_POO.Aplicativo05
{
    internal class Aplicativo05
    {
        static void Main(string[] args)
        {
            Aplicativo05RN app05 = new Aplicativo05RN();

            Console.WriteLine("Vamos calcular a média trimestral de faturamento da VoeAirlines. \r\nInforme o valor faturado no primeiro mês:");
            double mes1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor faturado no segundo mês: ");
            double mes2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor faturado no terceiro mês: ");
            double mes3 = double.Parse(Console.ReadLine());

            double total = app05.Faturamento(mes1, mes2, mes3);

            Console.WriteLine("A média trimestral de faturamento da VoeAirlines é de " + total + " reais");
            Console.ReadKey();
        }
    }
}
