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
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Plan_Canicule
{
    public partial class Form1 : Form
    {

        private MySqlConnection connexion;
        private string server;
        private string bdd;
        private string utilisateur;
        private string mdp;
        public Form1()
        {
            InitializeComponent();
            server = "localhost";
            bdd = "plan_canicule";
            utilisateur = "root";
            mdp = "kalashnikov28";
            string ConnexionString;
            ConnexionString = "SERVER=" + server + ";" + "DATABASE=" + bdd + ";" + "UID=" + utilisateur + ";" + "PASSWORD=" + mdp + ";";

            connexion = new MySqlConnection(ConnexionString);

            BoxSexe.SelectedIndex = 0;
            BoxRisque.SelectedIndex = 0;
            BoxSituation.SelectedIndex = 0;
        }

        private bool OpenConnection()
        {
            try
            {
                connexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Impossible de se connecter au serveur de la base de données. Pensez à ouvrir WAMP");
                        break;
                    case 1045:
                        MessageBox.Show("Identifiants invalides");
                        break;
                }
                return false;
            }
        }


        private void b_residents_Click(object sender, EventArgs e)
        {
            if (this.OpenConnection() == true)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                //label
                LabelID.Visible = true;
                LabelConfirmer.Visible = true;
                LabelSexe.Visible = false;
                LabelNom.Visible = false;
                LabelPrenom.Visible = false;
                LabelDate.Visible = false;
                LabelAdresse.Visible = false;
                LabelPostal.Visible = false;
                LabelVille.Visible = false;
                LabelTel.Visible = false;
                LabelSituation.Visible = false;
                LabelRisque.Visible = false;
                dataGridView1.Visible = false;
                LabelContact.Visible = false;
                LabelQualite.Visible = false;

                //textbox

                BoxID.Visible = true;
                BoxConfirmer.Visible = true;
                BoxSexe.Visible = false;
                BoxNom.Visible = false;
                BoxPrenom.Visible = false;
                BoxDate.Visible = false;
                BoxAdresse.Visible = false;
                BoxPostal.Visible = false;
                BoxVille.Visible = false;
                BoxTel.Visible = false;
                BoxSituation.Visible = false;
                BoxRisque.Visible = false;
                dataGridView2.Visible = false;
                BoxIDContact.Visible = false;
                BoxQualite.Visible = false;
                Box_Commentaire.Visible = true;

                //bouton
                B_EnvoyerResident.Visible = false;
                B_EnvoyerContact.Visible = false;
                B_AppelP.Visible = true;
                B_AppelC.Visible = false;
                B_SupprimerP.Visible = true;
                B_SupprimerContact.Visible = false;

                dataGridView1.Visible = true;
                dataGridView1.ColumnCount = 13;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "Sexe";
                dataGridView1.Columns[2].Name = "Nom";
                dataGridView1.Columns[3].Name = "Prenom";
                dataGridView1.Columns[4].Name = "Age";
                dataGridView1.Columns[5].Name = "Adresse";
                dataGridView1.Columns[6].Name = "Code Postal";
                dataGridView1.Columns[7].Name = "Ville";
                dataGridView1.Columns[8].Name = "Numero de Telephone";
                dataGridView1.Columns[9].Name = "Situation";
                dataGridView1.Columns[10].Name = "Risque";
                dataGridView1.Columns[11].Name = "Dernier Appel";
                dataGridView1.Columns[12].Name = "Commentaire";


                string commande = "select personne_a_risques.ID, SEXE, NOM, Prenom, (DATE_FORMAT(FROM_DAYS(TO_DAYS(NOW())-TO_DAYS(`Date_Naissance`)), '%Y')+0) as Age, ADRESSE,  CODE_POSTAL, VILLE, NUMERO_TEL, SITUATION, RISQUE, appel.Date, appel.Commentaire from personne_a_risques left join appel on personne_a_risques.id = appel.ID_Personne ORDER BY RISQUE DESC;";
                MySqlCommand CommandeAfficher = new MySqlCommand(commande, connexion); //commande sql pour afficher les resultats

                MySqlDataReader reader; //recupere les resultats pour les affecter dans une variable et les afficher
                reader = CommandeAfficher.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString());
                    }

                }
            }
            connexion.Close();
        }
        private void b_contacts_Click(object sender, EventArgs e)
        {
            if (this.OpenConnection() == true)
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                //label
                LabelID.Visible = true;
                LabelConfirmer.Visible = true;
                LabelSexe.Visible = false;
                LabelNom.Visible = false;
                LabelPrenom.Visible = false;
                LabelDate.Visible = false;
                LabelAdresse.Visible = false;
                LabelPostal.Visible = false;
                LabelVille.Visible = false;
                LabelTel.Visible = false;
                LabelSituation.Visible = false;
                LabelRisque.Visible = false;
                dataGridView1.Visible = false;
                LabelContact.Visible = false;
                LabelQualite.Visible = false;

                //textbox

                BoxID.Visible = true;
                BoxConfirmer.Visible = true;
                BoxSexe.Visible = false;
                BoxNom.Visible = false;
                BoxPrenom.Visible = false;
                BoxDate.Visible = false;
                BoxAdresse.Visible = false;
                BoxPostal.Visible = false;
                BoxVille.Visible = false;
                BoxTel.Visible = false;
                BoxSituation.Visible = false;
                BoxRisque.Visible = false;
                dataGridView2.Visible = false;
                BoxIDContact.Visible = false;
                BoxQualite.Visible = false;
                Box_Commentaire.Visible = true;


                //bouton
                B_EnvoyerResident.Visible = false;
                B_EnvoyerContact.Visible = false;
                B_AppelP.Visible = false;
                B_AppelC.Visible = true;
                B_SupprimerP.Visible = false;
                B_SupprimerContact.Visible = true;


                dataGridView1.Visible = true;
                dataGridView1.ColumnCount = 11;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "Nom";
                dataGridView1.Columns[2].Name = "Prenom";
                dataGridView1.Columns[3].Name = "Qualité";
                dataGridView1.Columns[4].Name = "Num. Telephone";
                dataGridView1.Columns[5].Name = "ID Personne";
                dataGridView1.Columns[6].Name = "Nom Personne à surveiller";
                dataGridView1.Columns[7].Name = "Prenom Personne à surveiller ";
                dataGridView1.Columns[8].Name = "Num Tel à surveiller";
                dataGridView1.Columns[9].Name = "Dernier Appel";
                dataGridView1.Columns[10].Name = "Commentaire";
                //dataGridView1.Columns[11].Name = "Dernier Appel";
                string commande = "select contact.ID, contact.Nom, contact.Prenom, contact.QUALITE, contact.NUM_TELEPHONE, personne_a_risques.ID, personne_a_risques.NOM, personne_a_risques.PRENOM, personne_a_risques.NUMERO_TEL, appelc.DATE, appelc.Commentaire from contact left JOIN est_lie_a on contact.ID = est_lie_a.ID_CONTACT left JOIN personne_a_risques on est_lie_a.ID_Personne = personne_a_risques.ID left join appelc on contact.ID = appelc.ID_CONTACT";
                MySqlCommand CommandeAfficher = new MySqlCommand(commande, connexion); //commande sql pour afficher les resultats

                MySqlDataReader reader; //recupere les resultats pour les affecter dans une variable et les afficher
                reader = CommandeAfficher.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString());
                    }

                }

                connexion.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoxSexe.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void B_AjoutResident_Click(object sender, EventArgs e)
        {

            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            //label
            LabelID.Visible = true;
            LabelSexe.Visible = true;
            LabelNom.Visible = true;
            LabelPrenom.Visible = true;
            LabelDate.Visible = true;
            LabelAdresse.Visible = true;
            LabelPostal.Visible = true;
            LabelVille.Visible = true;
            LabelTel.Visible = true;
            LabelSituation.Visible = true;
            LabelRisque.Visible = true;
            LabelConfirmer.Visible = false;
            LabelContact.Visible = false;
            LabelQualite.Visible = false;
            dataGridView1.Visible = false;

            //textbox

            BoxID.Visible = true;
            BoxSexe.Visible = true;
            BoxNom.Visible = true;
            BoxPrenom.Visible = true;
            BoxDate.Visible = true;
            BoxAdresse.Visible = true;
            BoxPostal.Visible = true;
            BoxVille.Visible = true;
            BoxTel.Visible = true;
            BoxSituation.Visible = true;
            BoxRisque.Visible = true;
            BoxConfirmer.Visible = false;
            BoxIDContact.Visible = false;
            BoxQualite.Visible = false;
            Box_Commentaire.Visible = false;


            //bouton
            B_EnvoyerResident.Visible = true;
            B_EnvoyerContact.Visible = false;
            B_AppelP.Visible = false;
            B_AppelC.Visible = false;
            B_SupprimerP.Visible = false;
            B_SupprimerContact.Visible = false;

            //DatagridView2
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView2.Visible = true;
            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Name = "ID";
            dataGridView2.Columns[1].Name = "Nom";
            dataGridView2.Columns[2].Name = "Prenom";

            string commande = "select ID, NOM, Prenom from personne_a_risques ORDER BY ID";
            MySqlCommand CommandeAfficher = new MySqlCommand(commande, connexion); //commande sql pour afficher les resultats
            connexion.Open();
            MySqlDataReader reader; //recupere les resultats pour les affecter dans une variable et les afficher
            reader = CommandeAfficher.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
                }

            }
            connexion.Close();
        }
        private void B_AjoutContact_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();

            LabelID.Visible = true;
            LabelNom.Visible = true;
            LabelPrenom.Visible = true;
            LabelTel.Visible = true;
            LabelContact.Visible = true;
            LabelQualite.Visible = true;
            LabelConfirmer.Visible = false;
            LabelSexe.Visible = false;
            LabelAdresse.Visible = false;
            LabelVille.Visible = false;
            LabelPostal.Visible = false;
            LabelSituation.Visible = false;
            LabelDate.Visible = false;
            LabelRisque.Visible = false;

            BoxSexe.Visible = false;
            BoxAdresse.Visible = false;
            BoxVille.Visible = false;
            BoxPostal.Visible = false;
            BoxSituation.Visible = false;
            BoxDate.Visible = false;
            BoxConfirmer.Visible = false;
            BoxRisque.Visible = false;
            Box_Commentaire.Visible = false;
            BoxQualite.Visible = true;
            BoxID.Visible = true;
            BoxNom.Visible = true;
            BoxPrenom.Visible = true;
            BoxTel.Visible = true;
            BoxIDContact.Visible = true;

            //boutons
            B_EnvoyerContact.Visible = true;
            B_EnvoyerResident.Visible = false;
            B_AppelP.Visible = false;
            B_AppelC.Visible = false;
            B_SupprimerP.Visible = false;
            B_SupprimerContact.Visible = false;

            dataGridView1.Visible = false;
            //DatagridView2
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView2.Visible = true;
            dataGridView2.ColumnCount = 6;
            dataGridView2.Columns[0].Name = "ID Personne";
            dataGridView2.Columns[1].Name = "Nom Personne";
            dataGridView2.Columns[2].Name = "Prenom Personne";
            dataGridView2.Columns[3].Name = "Id Contact";
            dataGridView2.Columns[4].Name = "Nom Contact";
            dataGridView2.Columns[5].Name = "Prenom Contact";

            string commande = "select personne_a_risques.ID, personne_a_risques.NOM, personne_a_risques.Prenom, contact.ID, contact.Nom, contact.Prenom from personne_a_risques left join est_lie_a on personne_a_risques.ID = est_lie_a.ID_PERSONNE left join contact on est_lie_a.ID_contact = contact.ID ORDER BY personne_a_risques.ID";
            MySqlCommand AfficherContact = new MySqlCommand(commande, connexion); //commande sql pour afficher les resultats
            connexion.Open();
            MySqlDataReader reader; //recupere les resultats pour les affecter dans une variable et les afficher
            reader = AfficherContact.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                }

            }
            connexion.Close();
        }



        private void B_EnvoyerResident_Click(object sender, EventArgs e)
        {
            if (BoxID.Text == "")
            {
                MessageBox.Show("Veuillez rentrer un Identifiant \nAttention à ne pas en mettre un déjà pris");
            }
            else if (BoxNom.Text == "")
            {
                MessageBox.Show("Veuillez rentrer un nom");
            }
            else if (BoxPrenom.Text == "")
            {
                MessageBox.Show("Veuillez rentrer un prénom");
            }
            else if (BoxDate.Text == "")
            {
                MessageBox.Show("Veuillez entrer une date valide (AAAA-MM-JJ");
            }
            else if (BoxAdresse.Text == "")
            {
                MessageBox.Show("Veuillez entrer une adresse");
            }
            else if (BoxPostal.Text == "")
            {
                MessageBox.Show("Veuillez entrer un code postal");
            }
            else if (BoxVille.Text == "")
            {
                MessageBox.Show("Veuillez entrer une ville");
            }
            else if (BoxTel.Text == "")
            {
                MessageBox.Show("Veuillez entrer un numéro de téléphone");
            }

            else
            {
                if (this.OpenConnection() == true)
                {

                    MySqlCommand AjouterR = new MySqlCommand();
                    AjouterR.CommandText = "insert into personne_a_risques (ID, Sexe, Nom, Prenom, Date_Naissance, Adresse, Code_Postal, Ville, Numero_Tel, Situation, Risque) values (@id, @sexe, @nom, @prenom, @datenaissance, @adresse, @codepostal, @ville, @numtel, @situation, @risque);";
                    AjouterR.Parameters.AddWithValue("@id", BoxID.Text);
                    AjouterR.Parameters.AddWithValue("@sexe", BoxSexe.SelectedItem);
                    AjouterR.Parameters.AddWithValue("@nom", BoxNom.Text);
                    AjouterR.Parameters.AddWithValue("@prenom", BoxPrenom.Text);
                    AjouterR.Parameters.AddWithValue("@datenaissance", BoxDate.Text);
                    AjouterR.Parameters.AddWithValue("@adresse", BoxAdresse.Text);
                    AjouterR.Parameters.AddWithValue("@codepostal", BoxPostal.Text);
                    AjouterR.Parameters.AddWithValue("@ville", BoxVille.Text);
                    AjouterR.Parameters.AddWithValue("@numtel", BoxTel.Text);
                    AjouterR.Parameters.AddWithValue("@situation", BoxSituation.SelectedItem);
                    AjouterR.Parameters.AddWithValue("@risque", BoxRisque.SelectedItem);
                    AjouterR.Connection = connexion;
                    AjouterR.ExecuteNonQuery();
                    MessageBox.Show("Les données ont bien été envoyées à la base de données.");
                    BoxID.Clear();
                    BoxNom.Clear();
                    BoxPrenom.Clear();
                    BoxAdresse.Clear();
                    BoxPostal.Clear();
                    BoxVille.Clear();
                    BoxTel.Clear();

                    connexion.Close();
                }
            }
        }

        private void B_EnvoyerContact_Click(object sender, EventArgs e)
        {
            if (BoxID.Text == "")
            {
                MessageBox.Show("Veuillez rentrer un Identifiant \nAttention à ne pas en mettre un déjà pris");
            }
            else if (BoxNom.Text == "")
            {
                MessageBox.Show("Veuillez rentrer un nom");
            }
            else if (BoxPrenom.Text == "")
            {
                MessageBox.Show("Veuillez rentrer un prénom");
            }
            else if (BoxIDContact.Text == "")
            {
                MessageBox.Show("Veuillez entrer un ID pour la personne à risques");
            }
            else if (BoxQualite.Text == "")
            {
                MessageBox.Show("Veuillez entrer le lien entre le contact et la personne à risques");
            }
            else
            {
                if (this.OpenConnection() == true)
                {
                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    MySqlCommand AjouterC = new MySqlCommand();
                    AjouterC.CommandText = "insert into contact (ID, Nom, Prenom, NUM_TELEPHONE, QUALITE) values (@id, @nom, @prenom, @numtel, @qualite); INSERT INTO est_lie_a (ID_PERSONNE, ID_CONTACT) values (@idrisque, @id);";
                    AjouterC.Parameters.AddWithValue("@id", BoxID.Text);
                    AjouterC.Parameters.AddWithValue("@nom", BoxNom.Text);
                    AjouterC.Parameters.AddWithValue("@prenom", BoxPrenom.Text);
                    AjouterC.Parameters.AddWithValue("@numtel", BoxTel.Text);
                    AjouterC.Parameters.AddWithValue("@qualite", BoxQualite.Text);
                    AjouterC.Parameters.AddWithValue("@idrisque", BoxIDContact.Text);
                    AjouterC.Connection = connexion;
                    AjouterC.ExecuteNonQuery();
                    MessageBox.Show("Le contact a bien été ajouté à la base de données.");
                    BoxID.Clear();
                    BoxNom.Clear();
                    BoxPrenom.Clear();
                    BoxTel.Clear();
                    BoxQualite.Clear();
                    BoxIDContact.Clear();
                    dataGridView2.Rows.Clear();
                    dataGridView2.Refresh();


                    connexion.Close();
                }
            }
        }

        private void BoxSituation_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoxSituation.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BoxRisque_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoxRisque.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void B_Appel_Click(object sender, EventArgs e)
        {
            if (BoxID.Text == "")
            {
                MessageBox.Show("Veuillez rentrer l'identifiant de la personne appelée");
            }
            else if (Box_Commentaire.Text == "")
            {
                MessageBox.Show("Vous n'avez pas laissé de commentaire. \n Si vous ne voulez pas en laisser, mettez un espace.");
            }

            else
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand AjouterC = new MySqlCommand();
                    AjouterC.CommandText = "insert into appel (ID, ID_PERSONNE, COMMENTAIRE, DATE) values (@id, @id, @commentaire, NOW()) ON DUPLICATE KEY UPDATE ID = ID, ID_PERSONNE = ID_PERSONNE, COMMENTAIRE = @commentaire, DATE=NOW()";
                    AjouterC.Parameters.AddWithValue("@id", BoxID.Text);
                    AjouterC.Parameters.AddWithValue("@commentaire", Box_Commentaire.Text);
                    AjouterC.Connection = connexion;
                    AjouterC.ExecuteNonQuery();
                    MessageBox.Show("L'appel a bien été ajouté à la base de données.");
                    BoxID.Clear();
                    Box_Commentaire.Clear();

                    connexion.Close();
                }

            }
        }

        private void B_AppelC_Click(object sender, EventArgs e)
        {
            if (BoxID.Text == "")
            {
                MessageBox.Show("Veuillez rentrer l'identifiant de la personne appelée");
            }
            else if (Box_Commentaire.Text == "")
            {
                MessageBox.Show("Vous n'avez pas laissé de commentaire. \n Si vous ne voulez pas en laisser, mettez un espace.");
            }

            else
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand AjouterC = new MySqlCommand();
                    AjouterC.CommandText = "insert into appelC (ID, ID_Contact, COMMENTAIRE, DATE) values (@id, @id, @commentaire, NOW())ON DUPLICATE KEY UPDATE ID = ID, ID_CONTACT = ID_CONTACT, COMMENTAIRE = @commentaire, DATE=NOW();";
                    AjouterC.Parameters.AddWithValue("@id", BoxID.Text);
                    AjouterC.Parameters.AddWithValue("@commentaire", Box_Commentaire.Text);
                    AjouterC.Connection = connexion;
                    AjouterC.ExecuteNonQuery();
                    MessageBox.Show("L'appel a bien été ajouté à la base de données.");
                    BoxID.Clear();
                    Box_Commentaire.Clear();

                    connexion.Close();
                }

            }
        }

        private void B_SupprimerP_Click(object sender, EventArgs e)
        {
            if (BoxID.Text == "")
            {
                MessageBox.Show("Veuillez rentrer l'identifiant de la personne à supprimer");
            }
            else if (BoxConfirmer.Text != "Confirmer")
            {
                MessageBox.Show("/!\\ ATTENTION /!\\ \n Vous allez supprimer définitivement une personne à risques de la base de données. \n Tapez \"Confirmer\" si vous souhaitez vraiment supprimer la personne indiquée.");
            }
            else
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand Supprimer = new MySqlCommand();
                    Supprimer.CommandText = "delete personne_a_risques, contact, est_lie_a, appel, appelc from personne_a_risques left join est_lie_a on personne_a_risques.ID = est_lie_a.ID_PERSONNE left join contact on est_lie_a.ID_CONTACT= contact.ID left join appel on personne_a_risques.ID= appel.ID_PERSONNE left join appelc on contact.ID=appelc.ID_contact WHERE personne_a_risques.ID = @id;";
                    Supprimer.Parameters.AddWithValue("@id", BoxID.Text);
                    Supprimer.Connection = connexion;
                    Supprimer.ExecuteNonQuery();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    MessageBox.Show("La personne a bien été supprimée de la base de données.");
                    BoxID.Clear();
                    BoxConfirmer.Clear();

                    connexion.Close();
                }
            }
        }

        private void B_SupprimerContact_Click(object sender, EventArgs e)
        {
            if (BoxID.Text == "")
            {
                MessageBox.Show("Veuillez rentrer l'identifiant de la personne à supprimer");
            }
            else if (BoxConfirmer.Text != "Confirmer")
            {
                MessageBox.Show("/!\\ ATTENTION /!\\ \n Vous allez supprimer définitivement un contact de la base de données. \n Tapez \"Confirmer\" si vous souhaitez vraiment supprimer le contact indiqué.");
            }
            else
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand Supprimer = new MySqlCommand();
                    Supprimer.CommandText = "delete contact, appelc, est_lie_a from contact left join appelc on contact.ID= appelc.ID_CONTACT left join est_lie_a on contact.ID = est_lie_a.ID_CONTACT WHERE contact.ID = @id;";
                    Supprimer.Parameters.AddWithValue("@id", BoxID.Text);
                    Supprimer.Connection = connexion;
                    Supprimer.ExecuteNonQuery();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    MessageBox.Show("Le contact a bien été supprimée de la base de données.");
                    BoxID.Clear();
                    BoxConfirmer.Clear();

                    connexion.Close();
                }
            }
        }

        private void BoxTel_TextChanged(object sender, EventArgs e)
        {
            Regex pattern = new Regex("[0-9]{10}");
            string valueFromTextBox = BoxTel.Text;

            if (Regex.IsMatch(valueFromTextBox, @"^[0-9]{0,10}$"))
            {
                //works
            }
            else
            {
                MessageBox.Show("Veuillez entrer un numéro de téléphone valide");
            }
        }
    }
}