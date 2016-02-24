using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exo2_RechLign_DB
{
    public partial class Form1 : Form
    {
        SqlConnection Connex;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connex = new SqlConnection("server=.; database=papyrus; integrated security = true");
            Connex.Open();

            try
            {
                SqlCommand Reqt = new SqlCommand("select * from stg07.FOURNIS where numfou=@numfou", Connex); //Création requête, avec 1 paramètre (@numfou)
                Reqt.Parameters.AddWithValue("@numfou", textBox1.Text); //Associe le paramètre à la textbox, donc à la valeur saisie par l'utilisateur 

                SqlDataReader Result = Reqt.ExecuteReader(); //Va exécuter la requête en lecture

                if (Result.Read()) // s'il y a des données correspondantes
                {
                    textBox2.Text = Result["nomfou"].ToString(); //va placer le nom dans la textbox correspondante
                    textBox3.Text = Result["ruefou"].ToString(); //idem pour chaque donnée, dans chaque textBox ... 
                    textBox4.Text = Result["posfou"].ToString();
                    textBox5.Text = Result["vilfou"].ToString();
                    textBox6.Text = Result["confou"].ToString();

                }
                else
                {
                    MessageBox.Show("Le code Fournisseur n'existe pas...");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }


        }
    }
}
