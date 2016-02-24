using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_TabMultip
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
            Console.WriteLine("Fonction qui affiche table de multiplication... ");
            Console.WriteLine();

            /*++++ DÉBUT CODE +++++*/
            int Nbre;

            Console.WriteLine("Entrez un nombre :");
            Nbre = Convert.ToInt32(Console.ReadLine());

            Tab2Multip(Nbre); // Appel de la fonction créé ci-dessous


            /*++++ FIN CODE +++++*/
            /*++++ Ma Fin Perso ++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();
        }


        static void Tab2Multip(int n) // ici la fonction créant la table de multiplication
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, n, i * n);
            }
        }

    }
}
