using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte1
{
    class ParteUm
    {
        static void Main(string[] args)
        {
            //Tipo/ Nome/ recebe /  valor
            string NumeroString1 = "1";
            string NumeroString2 = "1";
            
            int numero1 = 1;
            int numero2 = 1;

            //Exibe no console
            Console.WriteLine(numero1 + numero2);
            Console.WriteLine(NumeroString1 + NumeroString2);

            
            //   variavel        Condicao     incremento +1 a variavel
            for (int numero = 0; numero < 10; numero++)
            {
                Console.WriteLine(numero1);
                Console.WriteLine(numero);
            }

            while (numero1 == 1)
            {
                Console.WriteLine("Igual");
            }
        }
    }
}
