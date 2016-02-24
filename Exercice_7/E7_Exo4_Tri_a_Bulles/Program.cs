using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_Exo4_Tri_a_Bulles
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
            Console.WriteLine("Programme du Tri à Bulles...");
            Console.WriteLine();
            /*+++++++++ DÉBUT CODE ++++++++++++++++++++++++*/

            int[] tab = { 54, 6, 3, 87, 12, 545, 66, 44, 77, 1 };

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        int tmp = tab[i];    //utilisation d'une variable temporaire pour permuter 2 contenus
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tmp;
                    }
                }
                foreach (int v in tab)
                {
                    Console.Write(v + " ");
                }
                Console.WriteLine();
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
