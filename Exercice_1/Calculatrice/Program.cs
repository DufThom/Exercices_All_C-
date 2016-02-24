using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculatrice qui affiche la somme de 2 nombres");
            Console.WriteLine();

            String N1;
            double n1;
            String N2;
            double n2;
            double Somme; 

            Console.WriteLine("tapez un 1er nombre :");
            N1 = Console.ReadLine();

            Console.WriteLine("tapez un 2ème nombre :");
            N2 = Console.ReadLine();

            n1 = Convert.ToDouble(N1);

            n2 = Convert.ToDouble(N2);

            Somme = n1 / n2;

            Console.WriteLine("la somme de ces 2 nombre est :" + Somme);
           
            /*Pour permettre de laisser la console ouverte et demander à l'utilisateur de la fermer en tapant une touche */
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();
        }
    }
}
