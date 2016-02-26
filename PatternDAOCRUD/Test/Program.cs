using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientDAO data = new ClientDAO();

            // ++++ Test du Find +++++++++++++++++++++++++++++++++++++++
            //Client c = data.Find(2);

            //Console.WriteLine(c.Nom);

            // ++++ Test du List +++++++++++++++++++++++++++++++++++++++++++
            foreach (Client c in data.List())
            {
                Console.WriteLine(c.Nom);
            }


            //++++ test du Insert +++++++++++++++++++++++++++++++++
            //Client c = new Client();
            //c.Nom = "Mitterand";
            //c.Prenom = "Jacques";
            //c.Adresse = "Pau";

            //data.Insert(c);


            //++++ test du UpDate +++++++++++++++++++++++++++++++++
            //Client c = new Client();
            //c.Id = 2;
            //c.Nom = "duduf";
            //c.Prenom = "thom";
            //c.Adresse = "Lille";

            //data.UpDate(c);


            //++++ Test du Delete ++++++++++++++++++++++++++++++++++
            //Client c = new Client();

            //c.Id = 6;

            //data.Delete(c);

        }
    }
}
