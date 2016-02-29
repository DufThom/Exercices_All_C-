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

        string action = ""; //Init de la variable "Action", qui servira à capter le bouton choisi (ajout, modif, supp)

        public Form1()
        {

            InitializeComponent();

            this.Width = 401; // Ouvrira l'Interface en masquant les Détails

        }

        private void button1_Click(object sender, EventArgs e) //Btn Ajouter + Ouvre la partie Détails, active le GroupBox
        {
            this.Width = 669; // Fera apparaître la partie Détails lors du clic sur le Btn

            action = "ajouter";

        }

        private void button2_Click(object sender, EventArgs e) // Btn "Modifier"...
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != -1)
                {
                    this.Width = 669;

                    action = "modifier";

                    //textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();// Récupère la 1ère ligne séléctionnée (0), avec la 1ère cellule visible (Nom)
                    //textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    //textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                    // +++ ou, avec "Find": 
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    Client cli = data.Find(id);
                    textBox1.Text = cli.Nom;
                    textBox2.Text = cli.Prenom;
                    textBox3.Text = cli.Adresse;


                }
                
            }
            catch
            {
                MessageBox.Show("Veuillez séléctionner un client !!!");
            }
        }

        private void button3_Click(object sender, EventArgs e) // Btn "Supprimer" ...  
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != -1)
                {
                    this.Width = 669;

                    action = "supprimer";

                    textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Veuillez séléctionner un client !!!");
            }


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

                dataGridView1.DataSource = data.List();
                this.Width = 401;
            }

            if (action == "modifier")
            {
                Client c = new Client();

                c.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value); //Récupère la valeur de la cellule (non visible, l'ID) de la ligne séléctionnée
                c.Nom = textBox1.Text;
                c.Prenom = textBox2.Text;
                c.Adresse = textBox3.Text;

                data.UpDate(c);

                dataGridView1.DataSource = data.List();
                this.Width = 401;
            }

            if (action == "supprimer")
            {
                Client c = new Client();

                c.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value); //Récupère la valeur de la cellule (non visible, l'ID) de la ligne séléctionnée
                //c.Nom = textBox1.Text;
                //c.Prenom = textBox2.Text;
                //c.Adresse = textBox3.Text;

                data.Delete(c);

                dataGridView1.DataSource = data.List();
                this.Width = 401;
            }

        }

        private void button5_Click(object sender, EventArgs e) // Btn Annuler l'Ajout, Modif, Supp & Masque la partie Détails 
        {

            action = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dataGridView1.DataSource = data.List();
            this.Width = 401;
        }

        private void button6_Click(object sender, EventArgs e) //Affiche la liste des Clients dans le DataGridView
        {
            ClientDAO data = new ClientDAO();

            dataGridView1.DataSource = data.List(); //Charge la Table Client dans la DataGridView
            dataGridView1.Columns[0].Visible = false; // Masque la 1ère colonne du DGView
            dataGridView1.RowHeadersVisible = false; //Masque la colonne contenant l'en-tête (Id_Client)
            dataGridView1.ReadOnly = true; // En lecture Seule
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Séléctionne la ligne entière  
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;// Ajuste la taille des colonnes pour remplir tout le cadre
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells; //Ajuste la hauterur des cellules

        }
    }
}
