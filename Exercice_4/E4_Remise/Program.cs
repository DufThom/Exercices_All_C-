using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Remise
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
            Console.WriteLine("Calcul Remise & Frais de Port ... ");
            Console.WriteLine();

            /*++++ DÉBUT CODE +++++*/
            Double PU;
            int QTECOM;
            Double PAP;
            Double PORT = 0;
            Double TOT;
            Double REM = 0;

            Console.WriteLine("Entrez le Prix Unitaire: ");
            PU = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entrez la Quantité: ");
            QTECOM = Convert.ToInt32(Console.ReadLine());
            TOT = PU * QTECOM;
            
            if ((TOT >= 100) & (TOT <=200)) // Calcul de la remise
            {
                REM = (TOT * 0.05);
            }
            if (TOT > 200) 
            {
                REM = (TOT * 0.1);
            }
                             
            if (TOT > 500)
            {
                PORT = 0;
            }
            else if (TOT < 500)  // Calcul des frais de port
            {
                PORT = (TOT *0.02);
            }
            else if ((TOT < 500) && (PORT < 6))
            {
                PORT = 6;
            }

            PAP = TOT - REM + PORT;
            Console.WriteLine("Le Prix à Payer = {0} , moins {1} de remise, plus {2} de frais de port", PAP, REM, PORT);
            


            /*++++ FIN CODE +++++*/
            /*++++ Ma Fin Perso ++++++++++++*/
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();
        }
    }
}
