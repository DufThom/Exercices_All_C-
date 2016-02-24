using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorAndSound
{
    class Program
    {
        static void Main(string[] args)
        {
            /* pour changer la couleur de toute la console */
            Console.BackgroundColor = ConsoleColor.Gray;  
            Console.Clear(); /* permet de laisser la fond en couleur */ 

            /* utilise le Beep du pc, avec la fréquence voulue et la durée voulue */
            Console.Beep(200, 500);

            /* pour colorier le texte*/
            Console.ForegroundColor = ConsoleColor.White;

            /* pour colorier le fond de l'écriture*/
            Console.BackgroundColor = ConsoleColor.Green; 

            /* Pour déplacer le curseur */
            Console.CursorTop = 10;  /* à partir du haut */
            Console.CursorLeft = 10; /* à partir de la gauche, à répéter pour chaque ligne */
            Console.WriteLine("Coucou");
            Console.Beep(40, 500);
            Console.CursorTop = 10;
            Console.CursorLeft = 10;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Coucou");
            Console.Beep(440, 500);
            Console.CursorTop = 10;
            Console.CursorLeft = 10;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Coucou");
            Console.Beep(1000, 500);
            Console.CursorTop = 10;
            Console.CursorLeft = 10;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Coucou");
            Console.Beep(440, 500);
            Console.Beep(1000, 500);
            Console.Beep(440, 500);
            Console.Beep(32767, 500);

        }
    }
}
