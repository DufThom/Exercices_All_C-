using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_NbreMagiq_Random
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
            Console.WriteLine("xxxxxxx_TITRE_xxxxxxxx");
            Console.WriteLine();

            /*++++ DÉBUT CODE +++++*/

            int nombre;

            Random r = new Random();
            int magic = r.Next(1, 101);
            //Console.WriteLine(magic);

            do
            {
                Console.WriteLine("Entrez un nombre ");
                nombre = Convert.ToInt32(Console.ReadLine());
                if (nombre < magic)
                {
                    Console.WriteLine("Plus grand");
                }
                if (nombre > magic)
                {
                    Console.WriteLine("Plus petit");
                }
            } while (nombre != magic);

            Console.WriteLine("Gagné !!!");



            /*++++ FIN CODE +++++*/
            /*++++ Ma Fin Perso ++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();

        }
    }
}
