using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Calculette
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
            Console.WriteLine("Saisie 2 nombres entiers, puis signe opération ...");
            Console.WriteLine();

            /*++++ DÉBUT CODE +++++*/
            int Nbre1;
            int Nbre2;
            char Signe;
          
            Console.WriteLine("Entrez un 1er nombre :");
            Nbre1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez un 2ème nombre :");
            Nbre2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez un signe opérateur");
            Signe = Convert.ToChar(Console.ReadLine());
            

            if ( (Signe != '*') && (Signe != '/') && (Signe != '+') && (Signe != '-'))//Contrôle du signe... 
            {
                Console.WriteLine("Erreur de Signe");
            }
            if (Nbre2 == 0 && Signe == '/' ) //Contrôle division par 0... 
            {
                Console.WriteLine("Opération impossible");
            }
            if (Signe == '+')
            {
               // Console.WriteLine("Résultat = {0}", (Nbre1 + Nbre2));
                Console.WriteLine("résultat : {0} + {1} = {2}", Nbre1, Nbre2, (Nbre1 + Nbre2));
            }
            if (Signe == '-')
            {
                // Console.WriteLine("Résultat = {0}", (Nbre1 - Nbre2));
                Console.WriteLine("résultat : {0} - {1} = {2}", Nbre1, Nbre2, (Nbre1 - Nbre2));
            }
            if (Signe == '/')
            {
                // Console.WriteLine("Résultat = {0}", (Nbre1 / Nbre2));
                Console.WriteLine("résultat : {0} / {1} = {2}", Nbre1, Nbre2, (Nbre1 / Nbre2));
            }
            if (Signe == '*')
            {
                // Console.WriteLine("Résultat = {0}", (Nbre1 * Nbre2));
                Console.WriteLine("résultat : {0} * {1} = {2}", Nbre1, Nbre2, (Nbre1 * Nbre2));
            }
            
            /*++++ FIN CODE +++++*/
            /*++++ Ma Fin Perso ++++++++++++*/
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();



       /* Autre méthode, on élimine d'abord chaque possibilité d'opération, et si aucune n'est bonne, 
              alors on affiche l'erreur ... (mais çà reviend au même !!!)

          if (Nbre2 == 0 && Signe == '/')
          {
              Console.WriteLine("Opération impossible");
          }
          else if (Signe == '+')
          {
              // Console.WriteLine("Résultat = {0}", (Nbre1 + Nbre2));
              Console.WriteLine("résultat : {0} + {1} = {2}", Nbre1, Nbre2, (Nbre1 + Nbre2));
          }
          else if (Signe == '-')
          {
              // Console.WriteLine("Résultat = {0}", (Nbre1 + Nbre2));
              Console.WriteLine("résultat : {0} - {1} = {2}", Nbre1, Nbre2, (Nbre1 - Nbre2));
          }
          else if (Signe == '/')
          {
              // Console.WriteLine("Résultat = {0}", (Nbre1 + Nbre2));
              Console.WriteLine("résultat : {0} / {1} = {2}", Nbre1, Nbre2, (Nbre1 / Nbre2));
          }
          else if (Signe == '*')
          {
              // Console.WriteLine("Résultat = {0}", (Nbre1 + Nbre2));
              Console.WriteLine("résultat : {0} * {1} = {2}", Nbre1, Nbre2, (Nbre1 * Nbre2));
          }
          else 
          {
              Console.WriteLine("Erreur de Signe");
          } */


        }
    }
}
