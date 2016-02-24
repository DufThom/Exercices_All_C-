using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_MiniMaxi
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
            Console.WriteLine("Mini et Maxi des entiers saisies...");
            Console.WriteLine();

            /*++++ DÉBUT CODE +++++*/

            int Mini = 0;
            int Maxi = 0;
            int Nbre;
            int Somme = 0;
            int compt = 0;

            do
            {
                Console.WriteLine("Entrez un nombre:");
                Nbre = Convert.ToInt32(Console.ReadLine());
                if (compt == 0) // comme on a du initialiser Mini et Maxi avec 0, on leur attribue une valeur d'entrée, sinon Mini resterait à 0
                {
                    Mini = Nbre;
                    Maxi = Nbre;
                }
                if (Mini > Nbre && Nbre !=0) // compare Nbre avec Mini et vérif si différent de 0 (puisque 0 ferme l'app)
                {
                    Mini = Nbre;
                }
                if (Maxi < Nbre)
                {
                    Maxi = Nbre;
                }

                Somme += Nbre;
                if (Nbre != 0)
                {
                    compt++;
                }
            } while (Nbre != 0);

            Console.WriteLine("le Mini est {0}, le Maxi est {1}, et la Moyenne est {2}",Mini, Maxi,(double)Somme / compt);


            /*++++ FIN CODE +++++*/
            /*++++ Ma Fin Perso ++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();

        }
    }
}
