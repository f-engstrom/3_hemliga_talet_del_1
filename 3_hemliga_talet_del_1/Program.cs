using System;

namespace _hemliga_talet_del_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rndNr = new Random(); // Startar slumpgeneratorn för nummer. 

            int randomNummer =  rndNr.Next(1, 101); //Skapar ett nummer från och med 1, då minvärdet är inkluderande, upp till 100 och 101 då maxvärdet är uteslutande. 

            Console.WriteLine(randomNummer); // Skriver ut numret på konsolen.

            Console.ReadKey(); // Väntar på knapptryckning så att numret är läsbart innan konsolen går ner.
        }
    }
}
