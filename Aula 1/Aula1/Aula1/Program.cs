using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class AulaUm
    {
        static void Main(string[] args)
        {
            //Variavel
            //Tipo nome   Valor  
            string numeroUm = "22";
            string numeroDois = "22";

            int numeroInteiroUm = 22;
            int numeroInteiroDois = 22;

            //Loop
            for (int valor = 0; valor < 10; valor++)
            {
                Console.WriteLine(valor);
            }

            int incremental = 10;

            while (numeroInteiroDois > incremental)
            {
                Console.WriteLine(numeroUm + numeroDois);
                incremental += 5;
            }

            //Exibir no console
            Console.WriteLine(numeroUm + numeroDois);
            Console.WriteLine(numeroInteiroUm + numeroInteiroDois);

        }
    }
}
