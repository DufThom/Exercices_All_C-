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

namespace Exo3_Rech_JeuLign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Tous");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection Connex = new SqlConnection("server = .; database = papyrus; integrated security = true");
            Connex.Open();

            SqlCommand Reqt = new SqlCommand("select * from stg07.Fournis", Connex);

            SqlDataReader Result = Reqt.ExecuteReader();

            while (Result.Read())
            {
                comboBox1.Items.Add(Result["nomfou"].ToString());
            }

            Connex.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {

                listBox1.Items.Clear();
                SqlConnection Connex = new SqlConnection("server=.; database= papyrus; integrated security = true");
                Connex.Open();

                SqlDataReader Result = null;

                if (comboBox1.SelectedIndex == 0)
                {
                    SqlCommand Reqt = new SqlCommand("Select * from stg07.FOURNIS F join stg07.ENTCOM E on F.NUMFOU = E.NUMFOU", Connex);

                    Result = Reqt.ExecuteReader();
                }
                else
                {
                    SqlCommand Reqt = new SqlCommand("Select * from stg07.FOURNIS F join stg07.ENTCOM E on F.NUMFOU = E.NUMFOU where f.nomfou=@nomfou", Connex);
                    Reqt.Parameters.AddWithValue("@nomfou", comboBox1.SelectedItem);
                    Result = Reqt.ExecuteReader();
                }

                while (Result.Read())
                {
                    string d = Convert.ToDateTime(Result["DATCOM"]).ToShortDateString();
                    listBox1.Items.Add(Result["nomfou"].ToString() + " " + Result["numcom"].ToString() +" "+ d );
                }

                Connex.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
