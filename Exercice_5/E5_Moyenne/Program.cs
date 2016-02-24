using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_Moyenne
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
            Console.WriteLine("Moyenne des entiers saisies...");
            Console.WriteLine();

            /*++++ DÉBUT CODE +++++*/
            int Nbre;
            int Somme = 0;
            int compt = 0;

            do
            {
                Console.WriteLine("Entrez un nombre:");
                Nbre = Convert.ToInt32(Console.ReadLine());
                Somme += Nbre;
                if (Nbre != 0)
                {
                    compt++;
                }
            } while (Nbre != 0);

            Console.WriteLine((double)Somme / compt);


            /*++++ FIN CODE +++++*/
            /*++++ Ma Fin Perso ++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();

        }
    }
}
