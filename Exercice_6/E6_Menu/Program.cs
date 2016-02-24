using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*++++ Mon Début Perso +++++*/
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorTop = 1;
            Console.CursorLeft = 0;
            Console.WriteLine("Gestion de 4 Menus avec leurs fonctions ...");
            Console.WriteLine();
            /*++++ DÉBUT CODE +++++*/

            int Choix = 0;

            while (Choix != 5)
            {
                Console.WriteLine("1- Multiples");
                Console.WriteLine("2- Somme et Moyenne");
                Console.WriteLine("3- Recherche du nombre de voyelles");
                Console.WriteLine("4- Recherche du nombre des caractères suivants");
                Console.WriteLine("5- Fermer l'appli...");
                Console.WriteLine();
                Console.WriteLine("Entrez votre option :");
                Choix = Convert.ToInt32(Console.ReadLine());

                switch (Choix)
                {
                    case (1):
                        Multiple();
                        break;
                    case (2):
                        SomMoyen();
                        break;
                    case (3):
                        NbreVoyel();
                        break;
                    case (4):
                        NbreCaract();
                        break;
                    case (5):
                        Console.WriteLine("taper une touche pour fermer");
                        Console.ReadKey();
                        break;
                }
            }
            /*++++ FIN CODE +++++*/
            /*++++ Ma Fin Perso ++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            //Console.WriteLine("taper une touche pour fermer");
            //Console.ReadKey();
        }

        static void Multiple() // Menu 1 
        {
            Console.WriteLine();
            Console.WriteLine("Affiche les Multiples de 2 nombres donnés...");

            int N = GetInteger("Entrez un nombre ");

            int X = GetInteger("Entrez un nombre ");

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, X, i * X);
            }

        }

        static void SomMoyen() // Menu 2
        {
            Console.WriteLine();
            Console.WriteLine("Affiche la moyenne des nombres donnés...");
            int nombre = 0;
            int somme = 0;
            int compteur = 0;

            do
            {
                nombre = GetInteger("Entrez un nombre");
                somme += nombre;
                if (nombre != 0)
                {
                    compteur++;
                }
            } while (nombre != 0);

            Console.WriteLine((double)somme / compteur);

        }

        static void NbreVoyel() //Menu 3
        {
            Console.WriteLine();
            Console.WriteLine("Affiche le Nombre de voyelles dans un mot donné...");
            string mot;
            int compteur = 0;
            string voyelles = "aeiouy";

            mot = GetString("Entrez un mot");
            for (int i = 0; i < mot.Length; i++)
            {
                if (voyelles.IndexOf(mot.Substring(i, 1)) != -1)
                {
                    compteur++;
                }

            }
            Console.WriteLine("{0} voyelles", compteur);
        }

        static void NbreCaract() // Menu 4
        {
            string Phrase;
            string Lettre;
            int Compt = 0;

            Phrase = GetString("Entrez une phrase :");

            Lettre = GetString("Quelle lettre voulez-vous compter :");


            for (int i = 0; i < Phrase.Length; i++)
            {
                if (Lettre.IndexOf(Phrase.Substring(i, 1)) != -1)
                {
                    Compt++;
                }
            }
            Console.WriteLine("Dans {0}, il y a {1} fois {2}", Phrase, Compt, Lettre);

            //Console.WriteLine();
            //Console.WriteLine("Menu 4");
        }

        static string GetString(string message) // Fonction pour lire et renvoyer une chaine de caractères au clavier
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        static int GetInteger(string message) // Fonction pour lire et renvoyer un entier au clavier
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
