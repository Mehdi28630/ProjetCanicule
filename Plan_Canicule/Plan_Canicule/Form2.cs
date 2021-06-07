using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Plan_Canicule
{
    public partial class Form2 : Form
    {
        public string Id;
        public string mdp;
        public Form2()
        {
            InitializeComponent();
        }
        
        MySqlCommand commande = new MySqlCommand();
        MySqlCommand age = new MySqlCommand();
        MySqlDataReader reader;
        MySqlDataReader lireage;
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connexion2 = new MySqlConnection("database=plan_canicule; server=localhost; user id=Test;pwd=test28630");

            try
            {
                connexion2.Open();
                dataGridView1.Visible = true;
                dataGridView1.ColumnCount = 12;
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "Sexe";
                dataGridView1.Columns[2].Name = "Nom";
                dataGridView1.Columns[3].Name = "Prenom";
                dataGridView1.Columns[4].Name = "Age";
                dataGridView1.Columns[5].Name = "Adresse";
                dataGridView1.Columns[6].Name = "Code Postal";
                dataGridView1.Columns[7].Name = "Ville";
                dataGridView1.Columns[8].Name = "Numero Tel";
                dataGridView1.Columns[9].Name = "Situation";
                dataGridView1.Columns[10].Name = "Risque";
                dataGridView1.Columns[11].Name = "Dernier Appel";

                commande.CommandText = "select * from personne_à_risques";
                age.CommandText = "SELECT (DATE_FORMAT(FROM_DAYS(TO_DAYS(NOW())-TO_DAYS(`Date_Naissance`)), '%Y')+0) as Age FROM `personne_a_risques`";
                lireage = age.ExecuteReader();
                reader = commande.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), lireage.ToString(), reader[5].ToString());
                    }
                }
                connexion2.Close();

            }
            catch
            {
                MessageBox.Show("Vous avez été déconnecté");
            }

        }




    }
}
