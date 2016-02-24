using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_Exo2
{
    class Toto
    {
        static int[] tab; //init variable Tableau pour l'utiliser partout

        private static void Main(string[] args)
        {/*++++ Mon Début Perso ++++++++++++++++++++++++*/
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorTop = 1;
            Console.CursorLeft = 0;
            Console.WriteLine("Menu & Tableau ...");
            Console.WriteLine();
            /*+++++++++ DÉBUT CODE ++++++++++++++++++++++++*/

            tab = null;
            int choix;

            do
            {
                Console.WriteLine("1: Création du tableau");
                Console.WriteLine("2: Saisie du tableau");
                Console.WriteLine("3: Afficher");
                Console.WriteLine("4: Info");
                Console.WriteLine("5: Recherche");
                Console.WriteLine("0: Quitter");

                choix = GetInteger("Entrez votre choix");
                switch (choix)
                {
                    case 1:
                        int n = GetInteger("Entrez la taille du tableau");
                        tab = InitTab(n);
                        break;
                    case 2:
                        SaisieTab();
                        break;
                    case 3:
                        if (tab != null)
                            AfficheTab();
                        break;
                    case 4:
                        InfoTab();
                        break;
                    case 5:
                        RechercheTab();
                        break;
                }
            } while (choix != 0);

            /*+++++++++ FIN CODE +++++++++++++++++++++++++*/
            /*++++ Ma Fin Perso ++++++++++++++++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();
        }

        private static void InfoTab()
        {
            int somme = 0;
            int max = 0;

            foreach (int v in tab)
            {
                somme += v;
                if (v > max)
                {
                    max = v;
                }
            }

            Console.WriteLine("Moyenne={0}", (float)somme / tab.Length);
            Console.WriteLine("Maximum={0}", max);
        }

        private static void RechercheTab()
        {
            int rang;

            rang = GetInteger("Entrez le numéro du poste");
            Console.WriteLine(tab[rang]);

        }

        static void AfficheTab()
        {
            foreach (int v in tab)
            {
                Console.Write(v + " ");
            }
            Console.WriteLine();
        }

        static void SaisieTab()
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = GetInteger("Valeur pour " + i);
            }
        }

        static int[] InitTab(int n)
        {
            int[] t;

            t = new int[n];

            return t;
        }

        static int GetInteger(string message)
        {
            int resultat = 0;
            string reponse;

            do
            {
                Console.WriteLine(message);
                reponse = Console.ReadLine();
            } while (Int32.TryParse(reponse, out resultat) == false);

            return resultat;

        }
    }



    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //    }

    //    static int GetInteger(string message) // Fonction pour lire et renvoyer un entier au clavier
    //    {
    //        Console.WriteLine(message);
    //        return Convert.ToInt32(Console.ReadLine());
    //    }

    //    static int InitTab(int N_Case)
    //    {
    //        N_Case = GetInteger("Entrez un nombre de case :"); 

    //        int[] Tablo = new int[N_Case];
    //        return Tablo[N_Case];
    //    }
    //}
}
