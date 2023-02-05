using Sa02_POO.RegraDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa_POO.Aplicativo01
{
    internal class Aplicativo01
    {
        static void Main(string[] args)
        {
            Aplicativo01RN app01 = new Aplicativo01RN();

            Console.WriteLine("Vamos somar o valor de dois aviões! \r\nDigite o valor do primeiro avião: ");
            double aviao1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite o valor do segundo avião: ");
            double aviao2 = double.Parse(Console.ReadLine());

            double soma = app01.SomaAvioes(aviao1, aviao2);
            Console.WriteLine("O resultado da sua soma é de " + soma + " reais");
            Console.ReadKey();
        }
    }
}
