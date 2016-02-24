using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exo_Pendu
{
    class Program
    {
        static void Main(string[] args)
        {/*++++ Mon Début Perso ++++++++++++++++++++++++*/
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorTop = 1;
            Console.CursorLeft = 0;
            Console.WriteLine("... Jeu du Pendu ...");
            Console.WriteLine();
            /*+++++++++ DÉBUT CODE ++++++++++++++++++++++++*/

            string MotSecret;
            string LettreTapp = "";
            string MotConst = "";
            string Lettre;
            int Error = 0;


            Console.WriteLine("Joueur 1, Entrez un mot :");
            MotSecret = Console.ReadLine();
            Console.Clear(); // cachera le mot à trouver à l'utilisateur (joueur 2)

            Console.WriteLine("... Jeu du Pendu ...");
            Console.WriteLine();
            foreach (char c in MotSecret) // Affiche des "_" pour chaque lettre du mot choisi
            {
                MotConst += "_ ";
            }
            Console.WriteLine("Mot à trouver : {0}", MotConst);

            while ((MotSecret != MotConst) & (Error < 11))
            {

                Lettre = Controle_Caract("Joueur 2, Entrez une lettre :"); //Appel fonction de contrôle lettre tapée

                if (LettreTapp.IndexOf(Lettre) == -1) // si la lettre n'a pas encore été proposée, 
                {
                    LettreTapp += Lettre;   //elle s'ajoute à LettreTapp
                }
                else
                {
                    Console.WriteLine("Vous avez déjà proposé cette lettre...");
                }
                Console.WriteLine();
                Console.WriteLine("Lettres déjà proposées : {0}", LettreTapp);
                Console.WriteLine();

                MotConst = ""; // réinitialise le MotConst à chaque tour de boucle
                foreach (char l in MotSecret)
                {
                    if (LettreTapp.IndexOf(l) != -1)// différent de -1, veut dire " l est dans LettreTapp"
                    {
                        MotConst += l; // rajoute la valeur de l dans MotConst
                    }
                    else
                    {
                        MotConst += " _"; // sinon, rajoutera des "_" à la place des lettres manquantes

                    }
                }
                if (MotSecret.IndexOf(Lettre) == -1)// == -1, veut dire "lettre n'est pas dans MotSecret"
                {
                    Error++;
                    Pendu_Fun(Error, MotSecret);
                }

                Console.WriteLine("Mot à trouver : {0}", MotConst);

            }

            if (MotSecret == MotConst)
            {
                Console.WriteLine("gagné");
            }


            /*+++++++++ FIN CODE +++++++++++++++++++++++++*/
            /*++++ Ma Fin Perso ++++++++++++++++++++++++++*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("taper une touche pour fermer");
            Console.ReadKey();

        }

        /// <summary>
        /// Fonction d'affichage graphique du pendu
        /// </summary>
        /// <param name="Error">variable s'incrémentant à chaque erreur</param>
        /// <param name="MotSecret">variable qui récupère le mot secret pour l'afficher à la fin</param>
        static void Pendu_Fun(int Error, string MotSecret)
        {

            switch (Error)
            {
                case 1:
                    Console.WriteLine("|__________");
                    Console.WriteLine("Encore 10 essais");
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|__________");
                    Console.WriteLine("Encore 9 essais");
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("_________________");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|__________");
                    Console.WriteLine("Encore 8 essais");
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("_________________");
                    Console.WriteLine("|               |");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|__________");
                    Console.WriteLine("Encore 7 essais");
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine("_________________");
                    Console.WriteLine("|               |");
                    Console.WriteLine("|               O");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|__________");
                    Console.WriteLine("Encore 6 essais");
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine("_________________");
                    Console.WriteLine("|               |");
                    Console.WriteLine("|               O");
                    Console.WriteLine(@"|              /");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|__________");
                    Console.WriteLine("Encore 5 essais");
                    Console.WriteLine();
                    break;
                case 7:
                    Console.WriteLine("_________________");
                    Console.WriteLine("|               |");
                    Console.WriteLine("|               O");
                    Console.WriteLine(@"|              /|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|__________");
                    Console.WriteLine("Encore 4 essais");
                    Console.WriteLine();
                    break;
                case 8:
                    Console.WriteLine("_________________");
                    Console.WriteLine("|               |");
                    Console.WriteLine("|               O");
                    Console.WriteLine(@"|              /|\");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|__________");
                    Console.WriteLine("Encore 3 essais");
                    Console.WriteLine();
                    break;
                case 9:
                    Console.WriteLine("_________________");
                    Console.WriteLine("|               |");
                    Console.WriteLine("|               O");
                    Console.WriteLine(@"|              /|\");
                    Console.WriteLine("|               |");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|__________");
                    Console.WriteLine("Encore 2 essais");
                    Console.WriteLine();
                    break;
                case 10:
                    Console.WriteLine("_________________");
                    Console.WriteLine("|               |");
                    Console.WriteLine("|               O");
                    Console.WriteLine(@"|              /|\");
                    Console.WriteLine("|               |");
                    Console.WriteLine(@"|              / ");
                    Console.WriteLine("|");
                    Console.WriteLine("|__________");
                    Console.WriteLine("Encore 1 essais");
                    Console.WriteLine();
                    break;
                case 11:
                    Console.WriteLine("_________________");
                    Console.WriteLine("|               |");
                    Console.WriteLine("|               O");
                    Console.WriteLine(@"|              /|\");
                    Console.WriteLine("|               |");
                    Console.WriteLine(@"|              / \");
                    Console.WriteLine("| T'es MORT !!! ");
                    Console.WriteLine("|__________");
                    Console.WriteLine();
                    Console.WriteLine("La réponse était {0}", MotSecret);
                    break;
            }



        }

        static string Controle_Caract(string message) //fonction qui contrôle  la saisie de l'utilisateur 
        {
            string Lett_ctrl;
            //string Bad_Caract = "0123456789/*-+.&é'(-è_çà)=,;:!?.§"; 
            bool saisieMauvaise = false;
            Regex Bad_Car = new Regex("^[A-Za-z]$"); // contrôle si qu'une seule lettre, et que de A à Z (min et majuscule)
            
           do
            {
                Console.WriteLine(message);
                Lett_ctrl = Console.ReadLine();

                if (Bad_Car.IsMatch(Lett_ctrl))
                {
                    saisieMauvaise = false;
                }
                else
                {
                    saisieMauvaise = true;
                    Console.WriteLine("Erreur, ne saisir qu'une seule lettre, de A à Z !!!");
                }

                
                //saisieMauvaise = false;
                //foreach (char l in Bad_Caract)
                //{
                //    if (Lett_ctrl.IndexOf(l) != -1)// différent de -1, veut dire " l est dans Lett_ctrl"
                //    {
                //        Console.WriteLine("Que des LETTRES, on t'a dit !!! Pas de chiffres !!!");
                //        saisieMauvaise = true;
                //    }
                //}
                //if (Lett_ctrl.Length > 1) //Contrôle la saisie d'un seul caractère avec le ".length"
                //{
                //    Console.WriteLine("Veuillez ne saisir qu'un seul caractère !!!");
                //    saisieMauvaise = true;
                //}
            } while (saisieMauvaise);

            return Lett_ctrl;
        }

    }
}
