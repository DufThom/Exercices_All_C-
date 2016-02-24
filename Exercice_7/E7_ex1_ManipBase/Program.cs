using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_ex1_ManipBase
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
            Console.WriteLine("Exo1 Manipulation de base... ");
            Console.WriteLine();
            /*+++++++++ DÉBUT CODE ++++++++++++++++++++++++*/

            int N_Case;
            int Nbre = -1;

            Console.WriteLine("Entrez un nombre de case :");
            N_Case = Convert.ToInt32(Console.ReadLine());

            int[] Tablo = new int[N_Case];
          
            int i = 0;
            while (i<N_Case)
            {
                Console.WriteLine("Entrez un nombre :");
                Nbre = Convert.ToInt32(Console.ReadLine());
                if (Nbre != 0)
                //{
                //    //N_Case++; 
                //}
                Tablo[i] = Nbre;
                i++;
            }

            Console.WriteLine();
            string Affichage_Ligne ="";
            foreach (int element in Tablo)
            {
                Console.Write(element+" ; ");
                //Affichage_Ligne += Convert.ToString(element) + ", ";
                //Affichage_Ligne = ";" + element;
            }

            Console.WriteLine(Affichage_Ligne);

            /*+++++++++ FIN CODE +++++++++++++++++++++++++*/
            /*++++ Ma Fin Perso ++++++++++++++++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();
        }
    }
}
