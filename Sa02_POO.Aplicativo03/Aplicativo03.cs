using Sa02_POO.RegraDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02_POO.Aplicativo03
{
    internal class Aplicativo03
    {
        static void Main(string[] args)
        {

            Aplicativo03RN app03 = new Aplicativo03RN();

            Console.WriteLine("Informe o número total de aviões: ");
            int avioes = int.Parse(Console.ReadLine());

            Console.WriteLine("Deseja saber quantos assentos temos disponíveis em nossa frota de aviões?");
            var resposta = Console.ReadLine();

            if (resposta == "sim")
            {
                int assentos = app03.TotalAssentos(avioes);
                Console.WriteLine("O número total de assentos disponíveis é de " + assentos + " assentos.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Operação finalizada.");
                Console.ReadKey();
            }

        }
    }
}
