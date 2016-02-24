using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_Exo3_TriPrenom
{
    class Program
    {
        static void Main(string[] args)
        {  /*++++ Mon Début Perso ++++++++++++++++++++++++*/
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorTop = 1;
            Console.CursorLeft = 0;
            Console.WriteLine("Exo3 Recherche prénom dans tableau ... ");
            Console.WriteLine();
            /*+++++++++ DÉBUT CODE ++++++++++++++++++++++++*/


            string[] tab = { "Ludovic", "Jeremy", "Thibaud", "Vincent", "Jean-Philippe", "Stellio", "Manu" };

            Console.WriteLine("Entrez un prénom");
            string recherche = Console.ReadLine();

            int position = -1;
            for (int i = 0; i < tab.Length; i++)
            {
                if (recherche == tab[i])
                {
                    position = i;
                }
            }

            if (position == -1)
            {
                Console.WriteLine("Pas trouvé");
            }
            else
            {
                Console.WriteLine("OK " + position);
                for (int i = position; i < tab.Length - 1; i++)
                {
                    tab[i] = tab[i + 1];

                }
                tab[tab.Length - 1] = "";

                foreach (string pn in tab)
                {
                    Console.WriteLine(pn);
                }
            }

            /*+++++++++ FIN CODE +++++++++++++++++++++++++*/
            /*++++ Ma Fin Perso ++++++++++++++++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();
        }
    }
}
