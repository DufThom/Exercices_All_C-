using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ClientDAO
    {

        public void Insert(Client Cli) //création requête "Insert"
        {
            SqlConnection Connex = new SqlConnection("server=.; database=TP02; integrated security= true");
            Connex.Open();

            SqlCommand Reqt = new SqlCommand("insert into client (nom_client, prenom_client, adresse_client) values (@p1, @p2, @p3)", Connex);
            Reqt.Parameters.AddWithValue("@p1", Cli.Nom);
            Reqt.Parameters.AddWithValue("@p2", Cli.Prenom);
            Reqt.Parameters.AddWithValue("@p3", Cli.Adresse);

            Reqt.ExecuteNonQuery();
            Connex.Close();
        }


        public List<Client> List()
        {
            List<Client> Liste = new List<Client>();

            SqlConnection Connex = new SqlConnection("server=.; database=TP02; integrated security= true");
            Connex.Open();

            SqlCommand Reqt = new SqlCommand("select * from client", Connex);

            SqlDataReader Result = Reqt.ExecuteReader();

            while (Result.Read())
            {
                Client Cli = new Client();
                Cli.Id = Convert.ToInt32(Result["id_client"]);
                Cli.Nom = Convert.ToString(Result["nom_client"]);
                Cli.Prenom = Convert.ToString(Result["prenom_client"]);
                Cli.Adresse = Convert.ToString(Result["adresse_client"]);

                Liste.Add(Cli);
            }

            return Liste;
        }
    }
}
