using System;

namespace PermanentDrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, kas ta on piisavalt vana
            //et juhiluba saada

            Console.WriteLine("Sisesta oma sünniaasta:");

            int YearOfBirth = Int32.Parse(Console.ReadLine());
            int Age = 2021 - YearOfBirth;

            if (Age >= 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhiluba saada.");
            }
            else
            {
                Console.WriteLine("Liiga noor, et juhiluba saada.");
            }



            /*if (Age > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhiluba saada.");
            }
            else if(Age < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhiluba saada.");
            }
            else
            {
                Console.WriteLine("Oled 18, nüüd võid juhiloa saada.");
            }*/






        }
    }
}
