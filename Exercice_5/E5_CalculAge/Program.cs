using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_CalculAge
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
            Console.WriteLine("Calcul du nombre de Jeunes, Moyens, Vieux");
            Console.WriteLine();

            /*++++ DÉBUT CODE +++++*/

            int Jeune = 0; // - 20 ans
            int Moyen = 0; // 20 à 40 ans
            int Vieux = 0; // + 40 ans
            int Nbre;
           
            do
            {
                Console.CursorLeft = 1;
                Console.WriteLine("Entrez l'âge : ");
                Console.CursorLeft = 3;
                Nbre = Convert.ToInt32(Console.ReadLine());
                if (Nbre < 20)
                {
                    Jeune++;
                }
                if (Nbre >= 20 & Nbre <= 40)
                {
                    Moyen++;
                }
                if (Nbre > 40)
                {
                    Vieux++;
                }

            } while (Nbre < 100);
            
            Console.WriteLine(" il y a {0} Jeunes, {1} Moyens, {2} Vieux",Jeune, Moyen, Vieux);




            /*++++ FIN CODE +++++*/
            /*++++ Ma Fin Perso ++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();

        }
    }
}
