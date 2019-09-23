using System;

namespace Övning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Console.WriteLine("Mata in 5 heltal: ");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                int tal2 = Convert.ToInt32(Console.ReadLine());
                int tal3 = Convert.ToInt32(Console.ReadLine());
                int tal4 = Convert.ToInt32(Console.ReadLine());
                int tal5 = Convert.ToInt32(Console.ReadLine());

                // Syntax array:
                // type [ ] < Name_Array > = new < datatype > [size];
                // int[] array3 = { 1, 2, 3, 4, 5, 6 };
                // int [] numberHolder = new int[5];

                int resultNumber = 0;

                int[] numberHolder = {tal1, tal2, tal3, tal4, tal5};
                for (int i = 0; i < numberHolder.Length ;i++){
                    int previousNumber = numberHolder [i];
                    Console.WriteLine("Tal "+(i+1)+": "+numberHolder[i]);
                    resultNumber = resultNumber + previousNumber;
                }
                Console.WriteLine("Summan av alla tal är "+resultNumber);
            }catch{
                Console.WriteLine("Du matade inte in ett heltal med siffror (1, 2, 3 etc..)");
            }
        }
    }
}
