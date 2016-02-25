using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo4_InsertNewFournis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Connex = new SqlConnection("server=.; database=Papyrus; integrated security = true");
            // idem que : ("data source=.; initial catalog=Papyrus; Trusted_Connection=true"); 
            Connex.Open();
            try
            {


                SqlCommand Reqt = new SqlCommand();
                Reqt.CommandText = "insert into stg07.fournis (nomfou, ruefou, posfou, vilfou, confou, satisf) values (@Nom, @Rue, @CP, @Vil, @Con, @Sat)";
                Reqt.Connection = Connex;
                Reqt.Parameters.AddWithValue("@Nom", textBox1.Text); //ici, l'Id est auto-incrémenté, donc pas besoin de l'insérer
                Reqt.Parameters.AddWithValue("@Rue", textBox2.Text);
                Reqt.Parameters.AddWithValue("@CP", textBox3.Text);
                Reqt.Parameters.AddWithValue("@Vil", textBox4.Text);
                Reqt.Parameters.AddWithValue("@Con", textBox5.Text);

                if (trackBar1.Value == 0) //Boucle permettant de laisser le trackBar à 0 (valeur "null")
                {
                    Reqt.Parameters.AddWithValue("@Sat", DBNull.Value);
                }
                else
                {
                    Reqt.Parameters.AddWithValue("@Sat", trackBar1.Value);
                }


                Reqt.ExecuteNonQuery();
                Connex.Close();

                // Si besoin d'incrémenter la clef manuellement : 
                //SqlCommand req1 = new SqlCommand("select max(numfou)+1 from fournis", con);
                //int numfou = (int)req1.ExecuteScalar();
                //numfou++;
                //SqlDataReader res1 = req1.ExecuteReader();
                //res1.Read();
                //int numfou = Convert.ToInt32(res1[0]);
                //res1.Close();
                MessageBox.Show("Ajout New Fournisseur réussie !!!");
            }
            catch
            {
                MessageBox.Show("Erreur !!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
