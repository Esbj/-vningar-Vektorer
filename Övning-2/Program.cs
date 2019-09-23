using System;

namespace Övning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Steg 2 - Skapa en string array med fem element. Användaren får mata in fem namn
            // via en for-loop. Programmet skriver sedan ut dessa namn med hjälp av en for-loop.
            string [] namn = new string[5];
                Console.WriteLine("Mata in 5 namn");
                for(int i =0; i < namn.Length; i++){
                    namn[i]=Console.ReadLine();
                    if (namn[i].Length == 1){
                        //felmeddelande med throw?
                    }
                }


                for(int j = 0; j < namn.Length; j++){
                    Console.WriteLine("Namn: "+ (j+1) +" är: "+namn[j]);
                }
        }
    }
}