using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_Nbre_Voyelle
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
            Console.WriteLine("Compter le nombre de voyelles dans un mot...");
            Console.WriteLine();

            /*++++ DÉBUT CODE +++++*/


            string mot;
            int compteur = 0, compteur2 = 0;
            string voyelles = "aeiouy";

            Console.WriteLine("Entrez un mot");
            mot = Console.ReadLine();

            //foreach (char c in mot)
            //{
            //    if(c=='a' || c=='e' || c=='i' || c == 'o' || c == 'u' || c == 'y')
            //    {
            //        compteur++;
            //    }
            //}

            //for (int i=0; i < mot.Length; i++)
            //{
            //    string c = mot.Substring(i, 1);
            //    if (c == "a" || c == "e" || c == "i" || c == "o" || c == "u" || c == "y")
            //    {
            //        compteur++;
            //    }
            //}

            for (int i = 0; i < mot.Length; i++)
            {
                if (voyelles.IndexOf(mot.Substring(i, 1)) != -1)
                {
                    compteur++;
                }
                else
                {
                    compteur2++;
                }
            }

            Console.WriteLine("{0} voyelles",compteur);
            Console.WriteLine("{0} consonnes",compteur2);



            /*++++ FIN CODE +++++*/
            /*++++ Ma Fin Perso ++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();

        }
    }
}
