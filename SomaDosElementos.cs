using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class SomaDosElementos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os itens separados por vírgula:");
            string input = Console.ReadLine();

            int[] lista = Array.ConvertAll(input.Split(","), int.Parse);

            if (lista.Length > 1000)
            {
                Console.WriteLine("A lista não pode conter mais de 1000 itens.");
                return;
            }

            int result = Soma(lista);

            Console.WriteLine(result);
            
        }
        static int Soma(int[] lista) 
        {
            int result = 0;

            for (int i = 0; i < lista.Length; i++)
            {
                result = result + lista[i];
            }
            return result;
        }

    }

}
