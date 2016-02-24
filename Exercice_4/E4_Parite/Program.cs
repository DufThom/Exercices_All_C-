using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Parite
{
    class Program
    {
        static void Main(string[] args)
        { 
            /*++++ Mon Début Perso +++++*/
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorTop = 2;
            Console.CursorLeft = 0;
            Console.WriteLine("Trouvez si le nombre est pair ou impair");
            Console.WriteLine();


            /*++++ Début CODE +++++*/
            int Nombre;
            int Calcul;

            Console.WriteLine("Tapez un nombre :");
            Nombre = Convert.ToInt32(Console.ReadLine());

            Calcul = Nombre % 2;

            if (Calcul == 0)
            {
                Console.WriteLine("Ce nombre est pair");
            }
            else
            {
                Console.WriteLine("Ce nombre est impair");
            }



            /*++++ Ma Fin Perso ++++++++++++*/
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();
        }
    }
}
