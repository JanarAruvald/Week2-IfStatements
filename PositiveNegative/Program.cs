using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub sisestada numbrit
            //programm kontroliib numbrit
            //kui number on positiivne, konsool kuvab "number on positiivne"
            //kui number on negatiivne, konsool kuvab "number on negatiivne"
            //kui sisestatud number on 0, konsool kuvab "null"
            //NB!Int32.Parse asemel kasutame Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Palun sisesta number.");

            int Number = Convert.ToInt32(Console.ReadLine());


            if (Number < 0)
            {
                Console.WriteLine("Number on negatiivne.");
            }
            else if (Number > 0)
            {
                Console.WriteLine("Number on positiivne.");
            }
            else 
            {
                Console.WriteLine("Null.");
            }





        }
    }
}