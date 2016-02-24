using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_Factorielle
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
            Console.WriteLine("Fonction qui Calcul des factorielles...");
            Console.WriteLine();
            /*++++ DÉBUT CODE +++++*/


           Factorielle();
                    
            

            /*++++ FIN CODE +++++*/
            /*++++ Ma Fin Perso ++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();

        }

        static int GetInteger(string message) // Fonction pour lire et renvoyer un entier au clavier
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Factorielle()
        {
            int Fact = 1;
            int Nbre = GetInteger("Entrez un nombre :");

            for (int Compt = 1; Compt <= Nbre; Compt++)
            {
                Fact = Fact * Compt;
            }
            Console.WriteLine("La factorielle de {0} est {1}", Nbre, Fact);
        }
       
    }
}
