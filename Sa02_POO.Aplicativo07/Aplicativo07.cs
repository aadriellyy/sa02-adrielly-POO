using System;
using Sa02_POO.RegraDeNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02_POO.Aplicativo07
{
    internal class Aplicativo07
    {
        static void Main(string[] args)
        {
            Aplicativo07RN app07 = new Aplicativo07RN();
            Console.WriteLine("Digite o valor da primeira peça: ");
            double peca1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da segunda peça: ");
            double peca2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da terceira peça: ");
            double peca3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da quarta peça: ");
            double peca4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da quinta peça: ");
            double peca5 = double.Parse(Console.ReadLine());

            double valor1, valor2, valor3, valor4, valor5;
            valor1 = peca1;
            valor2 = peca2;
            valor3 = peca3;
            valor4 = peca4;
            valor5 = peca5;

            var resultado = app07.Pecas(valor1, valor2, valor3, valor4, valor5);
            Console.WriteLine("O valor final a ser pago pelas peças é de " + resultado + " reais");
            Console.ReadKey();
        }
    }
}
