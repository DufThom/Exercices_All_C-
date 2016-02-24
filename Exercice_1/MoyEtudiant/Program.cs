using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyEtudiant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcule Moyenne d'un étudiant dans une matière");
            Console.WriteLine();


            Double Moyen;
            Double N_ds;
            Double N_ie;
            Double N_tp;


            Console.WriteLine("Entrez la note du DS :");
            N_ds = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entrez la note de l'IE :");
            N_ie = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entrez la note de TP :");
            N_tp = Convert.ToDouble(Console.ReadLine());

            Moyen = ((N_ds * 3) + (N_ie * 2) + N_tp) / 6;

            Console.WriteLine("La moyenne est de :" + Moyen);


            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();
        }
    }
}
