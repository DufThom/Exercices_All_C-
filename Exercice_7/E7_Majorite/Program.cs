using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_Majorite
{
    class Program
    {
        static void Main(string[] args)
        {/*++++ Mon Début Perso ++++++++++++++++++++++++*/
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorTop = 1;
            Console.CursorLeft = 0;
            Console.WriteLine("Majeur ou non, après saisie DoB...");
            Console.WriteLine();
            /*+++++++++ DÉBUT CODE ++++++++++++++++++++++++*/

            DateTime Dj = DateTime.Now;

            Console.WriteLine("Entrez votre Date de Naissance :");
            DateTime DoB = Convert.ToDateTime(Console.ReadLine());
            /* +++++++++++++ 1ère Solution ++++++++++++++++++++++++++++++++++++++++++*/
            //TimeSpan Ecart = Dj - DoB;

            //if (Ecart.Days >= 6570) // 6570 jours = 18 * 365 ^^ 
            //{
            //    Console.WriteLine("Vous êtes Majeur");
            //}
            //else
            //{
            //    Console.WriteLine("Vous êtes Mineur");
            //}

            /* +++++++++++ 2ème Solution ++++++++++++++++++++++++++++++++++++++++++++++ */
            //int Maj = Dj.Year - DoB.Year;
            //if (Maj >= 18)
            //{
            //    Console.WriteLine("Vous êtes Majeur");
            //}
            //else
            //{
            //    Console.WriteLine("Vous êtes Mineur");
            //}

            /* ++++++++++++++++ 3ème Solution +++++++++++++++++++++++++++++++++++++++++++ */

            DateTime DateMaj = DoB.AddYears(18);

            int Resultat = DateMaj.CompareTo(Dj);
            if (Resultat == 0)
            {
                Console.WriteLine("Vous êtes Majeur");
            }
            else if (Resultat == -1)
                {
                Console.WriteLine("Vous êtes Majeur");
            }
            else
                Console.WriteLine("Vous êtes Mineur");

            Console.WriteLine(Resultat);


            /*+++++++++ FIN CODE +++++++++++++++++++++++++*/
            /*++++ Ma Fin Perso ++++++++++++++++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();


        }
    }
}
