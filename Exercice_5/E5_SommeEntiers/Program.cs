using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_SommeEntiers
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
            Console.WriteLine("Somme des Entiers");
            Console.WriteLine();

            /*++++ DÉBUT CODE +++++*/
            int Nbre;
            int Somme=0;
            int i;

            Console.WriteLine("Entrez un nombre");
            Nbre = Convert.ToInt32(Console.ReadLine());

           for (i = 0; i < Nbre; i++)
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
