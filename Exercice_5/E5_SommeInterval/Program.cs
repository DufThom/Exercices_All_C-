using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_SommeInterval
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
            Console.WriteLine("Somme d'un intervalle ... ");
            Console.WriteLine();

            /*++++ DÉBUT CODE +++++*/
            int n1;
            int n2;
            int Somme = 0;

            Console.WriteLine("Entrez un 1er nombre:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez un 2ème nombre:");
            n2 = Convert.ToInt32(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                Somme = Somme + i;
            }
            Console.WriteLine(Somme);



            /*++++ FIN CODE +++++*/
            /*++++ Ma Fin Perso ++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();

        }
    }
}
