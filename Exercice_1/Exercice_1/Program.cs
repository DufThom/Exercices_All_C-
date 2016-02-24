using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCSharp
{
    class Cercle
    {
     static void Main()
        {
            Console.WriteLine("****Périmètre et surface du Cercle(V1.0, 07 / 01 / 2016) ****");
            Console.WriteLine();
            //Declaration de variables. 
            string saisie; // variable recevant la saisie
            double rayon; // rayon
            double perimetre; // périmètre
            double diametre; //diamètre 

            // Etape 1 : lecture du rayon
            Console.WriteLine("Entrez la valeur du rayon : ");
            saisie = Console.ReadLine();
            // Etape 2 : calcul et affichage du périmètre
            rayon = Convert.ToDouble(saisie);
            //Calcul du perimetre
            perimetre = 2 * Math.PI* rayon;

            //Calcul du diamètre
            diametre = 2 * rayon;
        
            Console.Write("Le cercle de rayon " + rayon);
            Console.WriteLine();
            Console.Write("a pour périmètre : " + perimetre);
            Console.WriteLine();
            Console.Write("et un diamètre de : " + diametre);
            Console.WriteLine();
            // Permet de conserver l'affichage de la console
            Console.ReadLine(); 
        }
    }
}
