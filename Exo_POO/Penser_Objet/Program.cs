using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penser_Objet
{
    class Program
    {
        static void Main(string[] args)
        {
            /*++++ Mon Début Perso ++++++++++++++++++++++++*/
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorTop = 1;
            Console.CursorLeft = 0;
            Console.WriteLine("Exo 1, Prog Orienté Objet, Calcul de l'Aire de Carré, cercle, Triangle... ");
            Console.WriteLine();
            /*+++++++++ DÉBUT CODE ++++++++++++++++++++++++*/



            

            Forme[] Tableau = { new Carre(2), new Cercle(3), new Carre(5), new Triangle(3,5) };
            float s = 0;
            foreach (Forme fo in Tableau)
            {
                s += fo.Aire();
            }
            Console.WriteLine(s);

            /*+++++++++ FIN CODE +++++++++++++++++++++++++*/
            /*++++ Ma Fin Perso ++++++++++++++++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();

        }
    }

    public abstract class Forme
    {
        public virtual float Aire()
        {
            return 0;
        }
    }
    public class Carre : Forme
    {
        private float cote;

        public Carre(float c)
        {
            cote = c;
        }

        public override float Aire()
        {
            return (float)Math.Pow(cote, 2);
        }
    }
    public class Cercle : Forme
    {
        private float rayon;

        public Cercle(float r)
        {
            rayon = r;
        }
        public override float Aire()
        {
            return (float)(Math.PI * Math.Pow(rayon, 2));
        }
    }

    public class Triangle : Forme
    {
        private float cote;
        private float hauteur;

        public Triangle(float c, float h)
        {
            cote = c;
            hauteur = h;
        }
        
        public override float Aire()
        {
            return (float)(((cote * hauteur)/2));
        }
    }
}
