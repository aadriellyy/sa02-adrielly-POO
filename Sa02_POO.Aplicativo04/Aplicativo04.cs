using System;
using Sa02_POO.RegraDeNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02_POO.Aplicativo04
{
    internal class Aplicativo04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A VoeAirLines sorteou um valor de 5000 reais entre 10 sorteados. Verifique se você está entre eles: ");
            
            Aplicativo04RN app04 = new Aplicativo04RN();

            int valorNew = 5000;
            int participantesNew = 10;

            int valor, participantes;
            valor = valorNew;
            participantes = participantesNew;

            Console.WriteLine("Digite a senha para confiar que você é um dos sortudos: ");
            string senha = Console.ReadLine();
            
            if (senha == "senai")
            {
                var premio = app04.DividirValor(valor, participantes);
                Console.WriteLine("Parabéns, você ganhou " + premio + " reais");
            }
            else
            {
                Console.WriteLine("Infelizmente você não está entre os sorteados :( ");
            }
            Console.ReadKey();
        }
    }
}
