using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorTop = 5;
            Console.CursorLeft = 0;
            Console.WriteLine("Pour donner un age à partir d'une Année donnée...");
            Console.WriteLine();


            int Saisie;
            int Year;
            int Resultat;
            Year = 2016;

            Console.WriteLine("Entrez une année de naissance :");
            Saisie = Convert.ToInt32(Console.ReadLine());

            Resultat = Year - Saisie;

            if (Resultat >= 18)
            {
                Console.WriteLine("Vous avez " + Resultat + " ans, vous êtes Majeur");
            }
            else
            {
                Console.WriteLine("Vous avez " + Resultat + " ans, vous êtes Mineur");
            }


            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();
        }
    }
}
