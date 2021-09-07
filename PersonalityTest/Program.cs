using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja käest sisesta oma lemmikvärv
            //kui kasutaja sisestab "punane", konsool kuvab "Oled romantiline"
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas"
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber"
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled ükssarvik"

            Console.WriteLine("Mis on su lemmikvärv?");
            string UserColor = Console.ReadLine();
            
            if (UserColor == "punane")
            {
                Console.WriteLine("Sa oled romantiline.");
            }
            else if (UserColor == "sinine")
            {
                Console.WriteLine("Sa oled töökas.");
            }
            else if (UserColor == "roheline")
            {
                Console.WriteLine("Sa oled looduse sõber.");
            }
            else
            {
                Console.WriteLine("Oled ükssarvik.");
            }





        }
    }
}
