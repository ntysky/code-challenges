using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    public class MediaAritimetica
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

            int result = Media(lista);

            Console.WriteLine(result);
            
        }
        static int Media(int[] lista) 
        {
            int result = 0;
            int media = 0;
            for (int i = 0; i < lista.Length; i++)
            {
                result = result + lista[i];
                media = result/lista.Length;
            }
            return media;
        }

    }

}
