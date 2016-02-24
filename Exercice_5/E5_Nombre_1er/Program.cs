using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_Nombre_1er
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
            Console.WriteLine("Le nombre est-il Premier ? ");
            Console.WriteLine();

            /*++++ DÉBUT CODE +++++*/

            int Nbre;
            int Div;
            bool Prem = false;

            Console.WriteLine("Entrez un nombre :");
            Nbre = Convert.ToInt32(Console.ReadLine());

            for (Div = 2; Div <= Nbre; Div++)
            {
                if (Nbre % Div == 0)
                {
                    if (Div == Nbre)
                    {
                        Prem = true;
                    }

                    break;   // pour sortir de la boucle IF

                }
            }
            if (Prem == true)
            {
                Console.WriteLine("Nombre 1er");
            }
            else //if (Prem == false)
            {
                Console.WriteLine("Pas nombre 1er");
            }


            /*++++ FIN CODE +++++*/
            /*++++ Ma Fin Perso ++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();

        }
    }
}
