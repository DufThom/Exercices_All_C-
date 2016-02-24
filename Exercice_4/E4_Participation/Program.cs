using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Participation
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
            Console.WriteLine("___ Calcul Participation au Prix Repas des Employés___");
            Console.WriteLine();

            /*++++ DÉBUT CODE +++++*/

            String Statut;
            Double Salaire;
            Double Part_C = 0.2;
            Double Part_M = 0.25;
            Double Part_E = 0.1;
            Double Part_Sal = 0.1;
            int N_Enfant;
            Double Montant;

            Console.WriteLine("Votre Statut (marié M ou célibataire C):");
            Statut = Console.ReadLine();
            Console.WriteLine("Nombre d'Enfants :");
            N_Enfant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Votre Salaire :");
            Salaire = Convert.ToDouble(Console.ReadLine());

            if (Salaire < 6000)
            {
                Part_Sal = 0.1;
            }
            else Part_Sal = 0;

            if (Statut == "C")
            {
                Part_C = 0.2;
            }
            else Part_C = 0;
           
            if (Statut == "M")
            {
                Part_M = 0.25;
            }
            else Part_M = 0;

            if (N_Enfant == 0)
            {
                Part_E = 0;
            }
            else Part_E = (N_Enfant*Part_E);

            Montant = Part_C + Part_M + Part_Sal + Part_E;

            if (Montant > 0.5)
            {
                Montant = 0.5;
            }

            Console.WriteLine("Votre participation est de : {0}",Montant);

            /*++++ FIN CODE +++++*/
            /*++++ Ma Fin Perso ++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadLine();
        }
    }
}
