using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_StringToken
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
            Console.WriteLine("Fonction String Token...");
            Console.WriteLine();
            /*+++++++++ DÉBUT CODE ++++++++++++++++++++++++*/

            string Rep = "";
            string Str1;
            char Str2;
            int Nbre;

            Console.WriteLine("Entrez des mots, séparés par un caractère choisi :");
            Str1 = Console.ReadLine();

            Console.WriteLine("Entrez le caractère choisi précedemment :");
            Str2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Entrez le N° de place choisi :");
            Nbre = Convert.ToInt32(Console.ReadLine());

            Rep = StrTok(Str1, Str2, Nbre);
            Console.WriteLine(Rep);

            /*+++++++++ FIN CODE +++++++++++++++++++++++++*/
            /*++++ Ma Fin Perso ++++++++++++++++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();
        }

        static string StrTok(string Str1, char Str2, int Nbre)
        {
            string Result = "";
            int Compt = 1;

            foreach (char c in Str1)
            {
                if (c == Str2)
                {
                    Compt++;
                }
                else
                {
                    if (Compt == Nbre)
                    {
                        Result += c;
                    }
                }
            }
            return Result;
        }
    }
}
