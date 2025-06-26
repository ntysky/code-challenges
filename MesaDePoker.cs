using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HackerRank
{
    public class MesaDePoker
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valores:");
            string input = Console.ReadLine();
            int[] valores = Array.ConvertAll(input.Split(" "), int.Parse);

            if (valores.Length > 1000) 
            {
                Console.WriteLine("A lista deve conter no máximo 1000 itens.");
                return;
            }

            Console.WriteLine("Min:");
            int minimo = int.Parse(Console.ReadLine());

            Console.WriteLine("Max:");
            int maximo = int.Parse(Console.ReadLine());


            List<int> result = ValidarValores(maximo, minimo, valores);
            Console.WriteLine(string.Join(", ", result));
            
        }
        static List<int> ValidarValores(int max, int min, int[] valor) 
        {
            List<int> list = new List<int>();

            for (int i = 0; i < valor.Length; i++)
            {
                if (valor[i] >= min && valor[i] <= max) 
                {
                    list.Add(valor[i]);
                }
                else { continue;  }
            }
            return list;
        }
    }

}
