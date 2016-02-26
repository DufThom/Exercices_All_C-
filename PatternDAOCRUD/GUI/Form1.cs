using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace GUI
{
    public partial class Form1 : Form
    {
        ClientDAO data = new ClientDAO();

        string action = ""; //captera le bouton qui aura été cliquer (ajout, modif, supp)

        public Form1()
        {
            
            InitializeComponent();

            this.Width = 401; // Ouvrira l'Interface en masquant les Détails

        }

        private void button1_Click(object sender, EventArgs e) //Ouvre la partie Détails, active le GroupBox
        {
            this.Width = 669; // Fera apparaître la partie Détails lors du clic sur le Btn

            action = "ajouter";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Width = 669;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Width = 669;


        }

        private void button4_Click(object sender, EventArgs e) // Btn "OK" qui Valide l'Ajout, Modif et Supp
        {
            if (action == "ajouter")
            {
                Client c = new Client();

                c.Nom = textBox1.Text;
                c.Prenom = textBox2.Text;
                c.Adresse = textBox3.Text;

                data.Insert(c);
            }

        }

        private void button5_Click(object sender, EventArgs e) // Btn Annuler l'Ajout, Modif, Supp & Masque la partie Détails 
        {


            this.Width = 401;
        }

        private void button6_Click(object sender, EventArgs e) //Affiche la liste des Clients dans le DataGridView
        {
            ClientDAO data = new ClientDAO();

            dataGridView1.DataSource = data.List(); //Charge la Table Client dans la DataGridView
            dataGridView1.Columns[0].Visible = false; // Masque la 1ère colonne du DGView
            dataGridView1.RowHeadersVisible = false; //Masque la colonne contenant l'Id_Client
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

        }
    }
}
