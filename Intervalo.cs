using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HackerRank
{
    public class Intervalo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o numero, o limite inferior e o limite superior:");
            string input = Console.ReadLine();

            int[] parametros = Array.ConvertAll(input.Split(" "), int.Parse);

            int numero = parametros[0];
            int limiteInferior = parametros[1];
            int limiteSuperior = parametros[2];

            if (limiteInferior > limiteSuperior) 
            {
                Console.WriteLine("Informe limites coerentes."); 
                return;
            }

            string result = ValidarIntervalo(numero, limiteInferior, limiteSuperior);
            Console.WriteLine(result);
            
        }
        static string ValidarIntervalo(int numero, int limiteInferior, int limiteSuperior) 
        {
            if(numero>=limiteInferior && numero <= limiteSuperior) 
            {
                return "PERTENCE";
            }
            else
            {
                return "NÃO PERTENCE";
            }
        }

    }

}
