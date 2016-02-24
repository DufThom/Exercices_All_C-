using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conv_Temperatur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversion de Fahrenheit en Celsius");
            Console.WriteLine();

            Double TempF;
            Double Resultat;
          
            Console.WriteLine("Entrez une température en Fareneit :");
            TempF = Convert.ToDouble(Console.ReadLine());
                                 
            Resultat = 5*(TempF-32)/9;

            Console.WriteLine("En Celsius, c'est :" + Resultat);

            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();
        }
    }
}
