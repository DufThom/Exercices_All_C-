using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_CompteurLettre
{
    class Program
    {
        static void Main(string[] args)
        {
            /*++++ Mon Début Perso +++++*/
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorTop = 1;
            Console.CursorLeft = 0;
            Console.WriteLine("Compter la Nombre de Lettres... ");
            Console.WriteLine();

            /*++++ DÉBUT CODE +++++*/


            ComptLettre("Phrase", "Lettre", 0);
           

            /*++++ FIN CODE +++++*/
            /*++++ Ma Fin Perso ++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();

        }

        static void ComptLettre(string Phrase, string Lettre, int Compt)
        {
            Console.WriteLine("Entrez une phrase :");
            Phrase = Console.ReadLine();
            Console.WriteLine("Quelle lettre voulez-vous compter :");
            Lettre = Console.ReadLine();


            for (int i = 0; i < Phrase.Length; i++)
            {
                if (Lettre.IndexOf(Phrase.Substring(i, 1)) != -1)
                {
                    Compt++;
                }
               
            }
            Console.WriteLine("Dans {0}, il y a {1} fois {2}", Phrase, Compt, Lettre);
        }
    }
}
