using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversDuree
{
    class Program
    {
        static void Main(string[] args)
        {   /*Mon Début Perso */
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorTop = 10;
            Console.CursorLeft = 0;
            Console.WriteLine("Convertir une durée expriméé en secondes, en Heure, Minutes, Secondes");
            Console.WriteLine();


            string reponse;
            int secondes, heures, minutes = 0;
            int reste;


            Console.WriteLine("Entrez un nombre :");
            reponse = Console.ReadLine();
            secondes = Convert.ToInt32(reponse);

            heures = secondes / 3600;

            //reste = secondes - (heures * 3600);
            reste = secondes % 3600;

            minutes = reste / 60;

            secondes = reste % 60;

            Console.WriteLine("{0}:{1}:{2}", heures, minutes, secondes);


            /* Ma Fin Perso */
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();
        }
    }
}
