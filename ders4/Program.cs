using System;

namespace ders4
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!!!!");

            //1-den n-else kimi 7ye bolunen ededler

            int n = int.Parse(Console.ReadLine());

            for (int i = 7; i < n; i+=10)
            {
               
               Console.WriteLine(i);

            }
        }
    }
}
