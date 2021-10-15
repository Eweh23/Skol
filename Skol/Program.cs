using System;

namespace Skol
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            int slump = gen.Next(100);
            int gissningar=0;
            int gissning=101;
            Console.WriteLine("Gissa ett tal mellan 1 och 100");
            while(gissning != slump){
                gissning=int.Parse(Console.ReadLine());
                gissningar++;
                if(slump<gissning){
                Console.WriteLine("Talet är lägre");
                }
                else if(slump>gissning){
                Console.WriteLine("Talet är högre");
                }
            }
            Console.WriteLine("Bra jobbat du gissade rätt på "+gissningar+" försök");
        }
    }
}
