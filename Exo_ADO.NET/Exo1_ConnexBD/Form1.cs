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

namespace Exo1_ConnexBD
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
            //création de la connexion, nommé "Connex", en récupérant les valeurs des textbox pour le nom Serveur et le nom DB 
            Connex = new SqlConnection("server=" + textBox1.Text + "; database=" + textBox2.Text + "; integrated security=true;");
            try //try-catch pour récupérer d'éventuelles erreurs
            {
                Connex.Open(); //ouverure DB
                label4.Text = Connex.State.ToString(); // State = donne l'état DB (open ou  Closed)
            }
            catch (Exception er)
            {
                textBox3.Text = er.Message; //Affiche le message Exception dans la textbox
                label4.Text = Connex.State.ToString();
            }
            finally
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Connex != null) // Si une connexion est déjà ouverte, sinon provoque une erreur
            {
                Connex.Close();
                label4.Text = Connex.State.ToString();
            }

            // Si pas de vérif d'ouverture de DB avec boucle, récupérer l'Exception avec un Try-Catch : 
            // try 
            // {
            //    con.Close();
            //    label1.Text = con.State.ToString();
            // }
            // catch (Exception er)
            // {
            //    textBox3.Text = er.Message;
            // }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
