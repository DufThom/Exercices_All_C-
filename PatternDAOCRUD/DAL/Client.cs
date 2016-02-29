using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Client
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Adresse { get; set; }


        //++++ Pour remplir un ListBox avec plusieurs colonnnes : 
        // public string NomComplet
        // {
        //     get
        //     {
        //         return Id + " " + Nom + " " + Prenom + " " + Adresse;
        //     }
        //      set { }
        // }            // il suffira de l'appeler dans un listBox : listBox1.DisplayMember = "NomComplet";

    }
}
