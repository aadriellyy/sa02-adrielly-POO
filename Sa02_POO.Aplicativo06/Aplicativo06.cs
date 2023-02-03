using System;
using Sa02_POO.RegraDeNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02_POO.Aplicativo06
{
    internal class Aplicativo06
    {
        static void Main(string[] args)
        {
            Aplicativo06RN app06 = new Aplicativo06RN();

            Console.WriteLine("Quantos aviões tem em sua frota?");
            var menu = int.Parse(Console.ReadLine());

            if (menu == 1) {
                Console.WriteLine("Digite o valor do primeiro avião: ");
                double valorAviao = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite quantos deseja: ");
                int quantAvioes = int.Parse(Console.ReadLine());
                int quantAvioes1 = quantAvioes;
                double valorAviao1 = valorAviao;
                var resultado = app06.Frota01(valorAviao1, quantAvioes1);
                Console.WriteLine("O total ficou " + resultado + " reais");
                Console.ReadKey();
             }
            else if (menu == 2)
            {
                Console.WriteLine("Digite o valor do primeiro avião: ");
                double valorAviao1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite quantos deseja: ");
                int quantAvioes1 = int.Parse(Console.ReadLine());
                var resultado = app06.Frota01(valorAviao1, quantAvioes1);
                Console.WriteLine("O subtotal é de " + resultado + " reais");

                Console.WriteLine("Digite o valor do segundo avião: ");
                double valorAviao2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite quantos deseja: ");
                int quantAvioes2 = int.Parse(Console.ReadLine());
                var resultado2 = app06.Frota02(valorAviao2, quantAvioes2);
                var resultadoFinal = app06.Frota01(valorAviao1, quantAvioes1) + app06.Frota02(valorAviao2, quantAvioes2);
                Console.WriteLine("O total final é de " + resultadoFinal + " reais");
                Console.ReadKey();
            }

            else if (menu == 3)
            {
                Console.WriteLine("Digite o valor do primeiro avião: ");
                double valorAviao1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite quantos deseja: ");
                int quantAvioes1 = int.Parse(Console.ReadLine());
                var resultado = app06.Frota01(valorAviao1, quantAvioes1);
                Console.WriteLine("O subtotal é de " + resultado + " reais");

                Console.WriteLine("Digite o valor do segundo avião: ");
                double valorAviao2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite quantos deseja: ");
                int quantAvioes2 = int.Parse(Console.ReadLine());
                var resultado2 = app06.Frota02(valorAviao2, quantAvioes2);
                var subtotal2 = app06.Frota01(valorAviao1, quantAvioes1) + app06.Frota02(valorAviao2, quantAvioes2);
                Console.WriteLine("O subtotal é de " + subtotal2 + " reais");

                Console.WriteLine("Digite o valor do terceiro avião: ");
                double valorAviao3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite quantos deseja: ");
                int quantAvioes3 = int.Parse(Console.ReadLine());
                var resultado3 = app06.Frota03(valorAviao3, quantAvioes3);
                var resultadoFinal = app06.Frota01(valorAviao1, quantAvioes1) + app06.Frota02(valorAviao2, quantAvioes2) + app06.Frota03(valorAviao3, quantAvioes3);
                Console.WriteLine("O valor final é de " + resultadoFinal + " reais");
                Console.ReadKey();

            }

            else if (menu == 4)
            {
                Console.WriteLine("Digite o valor do primeiro avião: ");
                double valorAviao1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite quantos deseja: ");
                int quantAvioes1 = int.Parse(Console.ReadLine());
                var resultado = app06.Frota01(valorAviao1, quantAvioes1);
                Console.WriteLine("O subtotal é de " + resultado + " reais");

                Console.WriteLine("Digite o valor do segundo avião: ");
                double valorAviao2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite quantos deseja: ");
                int quantAvioes2 = int.Parse(Console.ReadLine());
                var resultado2 = app06.Frota02(valorAviao2, quantAvioes2);
                var subtotal2 = app06.Frota01(valorAviao1, quantAvioes1) + app06.Frota02(valorAviao2, quantAvioes2);
                Console.WriteLine("O subtotal é de " + subtotal2 + " reais");

                Console.WriteLine("Digite o valor do terceiro avião: ");
                double valorAviao3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite quantos deseja: ");
                int quantAvioes3 = int.Parse(Console.ReadLine());
                var resultado3 = app06.Frota03(valorAviao3, quantAvioes3);
                var subtotal3 = app06.Frota01(valorAviao1, quantAvioes1) + app06.Frota02(valorAviao2, quantAvioes2) + app06.Frota03(valorAviao3, quantAvioes3);
                Console.WriteLine("O subtotal é de " + subtotal3 + " reais");

                Console.WriteLine("Digite o valor do quarto avião: ");
                double valorAviao4 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite quantos deseja: ");
                int quantAvioes4 = int.Parse(Console.ReadLine());
                var resultado4 = app06.Frota04(valorAviao4, quantAvioes4);
                var resultadoFinal = app06.Frota01(valorAviao1, quantAvioes1) + app06.Frota02(valorAviao2, quantAvioes2) + app06.Frota03(valorAviao3, quantAvioes3) + app06.Frota04(valorAviao4, quantAvioes4);
                Console.WriteLine("O valor final é de " + resultadoFinal + " reais");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Sinto muito, não podemos calcular essa quantidade");
                Console.ReadKey();
            }


        }
    }
}
