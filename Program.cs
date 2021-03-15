using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
         string tradução;
         
         Console.Write("Digite uma frase:");
         tradução =Console.ReadLine();
         Console.WriteLine();
         Console.Write($"Sua frase traduzida em Leet:{tradução.Replace ("a" , "4").Replace("e" , "3").Replace("i" , "1").Replace("o" , "0").Replace ("t" , "7").Replace("s" , "5") }");



            
        }
    }
}
