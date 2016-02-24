using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_Entiers
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
            Console.WriteLine("Afficher les nombres inférieurs à N");
            Console.WriteLine();

            /*++++ DÉBUT CODE +++++*/
            int Nbre;

            Console.WriteLine("Entrez un nombre");
            Nbre = Convert.ToInt32(Console.ReadLine());

            while (Nbre != 0)
            {
                Console.WriteLine(Nbre);
                Nbre--;
            }

            //for (int i = 0; i < Nbre; i++)
            //{
            //    Console.WriteLine(i);
            //}

            /*++++ FIN CODE +++++*/
            /*++++ Ma Fin Perso ++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();

        }
    }
}
