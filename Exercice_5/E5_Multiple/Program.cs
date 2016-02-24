using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_Multiple
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
            Console.WriteLine("Calculer les N 1er multiples d'un nombre X...");
            Console.WriteLine();

            /*++++ DÉBUT CODE +++++*/

            Console.WriteLine("Entrez un nombre ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrez un nombre ");
            int X = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, X, i * X);
            }


            /*++++ FIN CODE +++++*/
            /*++++ Ma Fin Perso ++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();

        }
    }
}
