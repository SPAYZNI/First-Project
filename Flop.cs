using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flushed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string name, hobby, birthday, animal, end;

            //input user

            //Name from user
            Console.WriteLine($"Hallo unbekannter Floppa, sag mir mal deinen namen.");
            name = Console.ReadLine();
            Console.WriteLine($"({name}): {name}");
            Console.WriteLine($"Oh, {name} ist ein schöner name. Nenn mir mal ein Hobby das dir Spaß macht (als verb)");
            
            //hobby from user
            hobby = Console.ReadLine();
            Console.WriteLine($"({name}): {hobby}");
            Console.WriteLine($"Dein Lieblings Hobby ist cool, vlt wirst du ja Profi in {hobby}");

            //birthday from user
            Console.WriteLine($"Wann hast du denn Geburtstag (in Datum 00.00.0000)");
            birthday = Console.ReadLine();
            Console.WriteLine($"({name}): {birthday}");
            Console.WriteLine($"Gut zu wissen das du am {birthday} Geburtstag hast");

            //favorite animal from User
            Console.WriteLine($"Was ist eigentlich dein Lieblingstier, also meins ist ein Floppa (nur als ein Nomen)");
            animal = Console.ReadLine();
            Console.WriteLine($"({name}): {animal}");
            Console.WriteLine($"Oh ein {animal} ist sehr cool.");

            //Story
            string Thyflushed =
                (
                $"Also {name}, dein Lieblingshobby ist {hobby} und du hast am {birthday} Geburtstag. Dein Lieblingstier ist {animal} was sehr cool ist. War schön dich kennen zu lernen, Bye"
                );

            //Story end
            Console.WriteLine(Thyflushed);
            end = Console.ReadLine();
            Console.WriteLine($"({name}): {end}");

            //Console end
            Console.ReadLine();
        }
    }
}
