
namespace Plan_Canicule
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_residents = new System.Windows.Forms.Button();
            this.b_contacts = new System.Windows.Forms.Button();
            this.B_AjoutResident = new System.Windows.Forms.Button();
            this.BoxNom = new System.Windows.Forms.TextBox();
            this.BoxPrenom = new System.Windows.Forms.TextBox();
            this.BoxSexe = new System.Windows.Forms.ComboBox();
            this.LabelSexe = new System.Windows.Forms.Label();
            this.LabelNom = new System.Windows.Forms.Label();
            this.LabelPrenom = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.BoxAdresse = new System.Windows.Forms.TextBox();
            this.BoxPostal = new System.Windows.Forms.TextBox();
            this.BoxVille = new System.Windows.Forms.TextBox();
            this.BoxRisque = new System.Windows.Forms.ComboBox();
            this.LabelAdresse = new System.Windows.Forms.Label();
            this.LabelPostal = new System.Windows.Forms.Label();
            this.LabelVille = new System.Windows.Forms.Label();
            this.LabelSituation = new System.Windows.Forms.Label();
            this.LabelRisque = new System.Windows.Forms.Label();
            this.B_EnvoyerResident = new System.Windows.Forms.Button();
            this.BoxSituation = new System.Windows.Forms.ComboBox();
            this.BoxTel = new System.Windows.Forms.TextBox();
            this.LabelTel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BoxID = new System.Windows.Forms.TextBox();
            this.LabelID = new System.Windows.Forms.Label();
            this.BoxDate = new System.Windows.Forms.MaskedTextBox();
            this.B_AjoutContact = new System.Windows.Forms.Button();
            this.B_EnvoyerContact = new System.Windows.Forms.Button();
            this.BoxIDContact = new System.Windows.Forms.TextBox();
            this.LabelContact = new System.Windows.Forms.Label();
            this.BoxQualite = new System.Windows.Forms.TextBox();
            this.LabelQualite = new System.Windows.Forms.Label();
            this.B_AppelP = new System.Windows.Forms.Button();
            this.Box_Commentaire = new System.Windows.Forms.RichTextBox();
            this.B_AppelC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.B_SupprimerP = new System.Windows.Forms.Button();
            this.BoxConfirmer = new System.Windows.Forms.TextBox();
            this.LabelConfirmer = new System.Windows.Forms.Label();
            this.B_SupprimerContact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1239, 266);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // b_residents
            // 
            this.b_residents.Location = new System.Drawing.Point(111, 37);
            this.b_residents.Name = "b_residents";
            this.b_residents.Size = new System.Drawing.Size(158, 91);
            this.b_residents.TabIndex = 6;
            this.b_residents.Text = "afficher personne";
            this.b_residents.UseVisualStyleBackColor = true;
            this.b_residents.Click += new System.EventHandler(this.b_residents_Click);
            // 
            // b_contacts
            // 
            this.b_contacts.Location = new System.Drawing.Point(297, 38);
            this.b_contacts.Name = "b_contacts";
            this.b_contacts.Size = new System.Drawing.Size(158, 90);
            this.b_contacts.TabIndex = 7;
            this.b_contacts.Text = "afficher contacts";
            this.b_contacts.UseVisualStyleBackColor = true;
            this.b_contacts.Click += new System.EventHandler(this.b_contacts_Click);
            // 
            // B_AjoutResident
            // 
            this.B_AjoutResident.Location = new System.Drawing.Point(495, 38);
            this.B_AjoutResident.Name = "B_AjoutResident";
            this.B_AjoutResident.Size = new System.Drawing.Size(158, 91);
            this.B_AjoutResident.TabIndex = 8;
            this.B_AjoutResident.Text = "ajouter personne";
            this.B_AjoutResident.UseVisualStyleBackColor = true;
            this.B_AjoutResident.Click += new System.EventHandler(this.B_AjoutResident_Click);
            // 
            // BoxNom
            // 
            this.BoxNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.BoxNom.Location = new System.Drawing.Point(634, 269);
            this.BoxNom.Name = "BoxNom";
            this.BoxNom.Size = new System.Drawing.Size(206, 26);
            this.BoxNom.TabIndex = 10;
            this.BoxNom.Visible = false;
            // 
            // BoxPrenom
            // 
            this.BoxPrenom.Location = new System.Drawing.Point(855, 269);
            this.BoxPrenom.Name = "BoxPrenom";
            this.BoxPrenom.Size = new System.Drawing.Size(173, 26);
            this.BoxPrenom.TabIndex = 11;
            this.BoxPrenom.Visible = false;
            // 
            // BoxSexe
            // 
            this.BoxSexe.FormattingEnabled = true;
            this.BoxSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.BoxSexe.Location = new System.Drawing.Point(1039, 269);
            this.BoxSexe.Name = "BoxSexe";
            this.BoxSexe.Size = new System.Drawing.Size(121, 28);
            this.BoxSexe.TabIndex = 12;
            this.BoxSexe.Visible = false;
            this.BoxSexe.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LabelSexe
            // 
            this.LabelSexe.AutoSize = true;
            this.LabelSexe.Location = new System.Drawing.Point(1068, 236);
            this.LabelSexe.Name = "LabelSexe";
            this.LabelSexe.Size = new System.Drawing.Size(45, 20);
            this.LabelSexe.TabIndex = 15;
            this.LabelSexe.Text = "Sexe";
            this.LabelSexe.Visible = false;
            // 
            // LabelNom
            // 
            this.LabelNom.AutoSize = true;
            this.LabelNom.Location = new System.Drawing.Point(704, 236);
            this.LabelNom.Name = "LabelNom";
            this.LabelNom.Size = new System.Drawing.Size(42, 20);
            this.LabelNom.TabIndex = 16;
            this.LabelNom.Text = "Nom";
            this.LabelNom.Visible = false;
            // 
            // LabelPrenom
            // 
            this.LabelPrenom.AutoSize = true;
            this.LabelPrenom.Location = new System.Drawing.Point(909, 236);
            this.LabelPrenom.Name = "LabelPrenom";
            this.LabelPrenom.Size = new System.Drawing.Size(64, 20);
            this.LabelPrenom.TabIndex = 17;
            this.LabelPrenom.Text = "Prenom";
            this.LabelPrenom.Visible = false;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(708, 451);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(213, 20);
            this.LabelDate.TabIndex = 18;
            this.LabelDate.Text = "D. Naissance (AAAA-MM-JJ)";
            this.LabelDate.Visible = false;
            // 
            // BoxAdresse
            // 
            this.BoxAdresse.Location = new System.Drawing.Point(698, 368);
            this.BoxAdresse.Name = "BoxAdresse";
            this.BoxAdresse.Size = new System.Drawing.Size(214, 26);
            this.BoxAdresse.TabIndex = 14;
            this.BoxAdresse.Visible = false;
            // 
            // BoxPostal
            // 
            this.BoxPostal.Location = new System.Drawing.Point(945, 368);
            this.BoxPostal.Name = "BoxPostal";
            this.BoxPostal.Size = new System.Drawing.Size(113, 26);
            this.BoxPostal.TabIndex = 15;
            this.BoxPostal.Visible = false;
            // 
            // BoxVille
            // 
            this.BoxVille.Location = new System.Drawing.Point(1083, 368);
            this.BoxVille.Name = "BoxVille";
            this.BoxVille.Size = new System.Drawing.Size(174, 26);
            this.BoxVille.TabIndex = 16;
            this.BoxVille.Visible = false;
            // 
            // BoxRisque
            // 
            this.BoxRisque.FormattingEnabled = true;
            this.BoxRisque.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.BoxRisque.Location = new System.Drawing.Point(1136, 496);
            this.BoxRisque.Name = "BoxRisque";
            this.BoxRisque.Size = new System.Drawing.Size(121, 28);
            this.BoxRisque.TabIndex = 19;
            this.BoxRisque.Visible = false;
            this.BoxRisque.SelectedIndexChanged += new System.EventHandler(this.BoxRisque_SelectedIndexChanged);
            // 
            // LabelAdresse
            // 
            this.LabelAdresse.AutoSize = true;
            this.LabelAdresse.Location = new System.Drawing.Point(773, 330);
            this.LabelAdresse.Name = "LabelAdresse";
            this.LabelAdresse.Size = new System.Drawing.Size(68, 20);
            this.LabelAdresse.TabIndex = 24;
            this.LabelAdresse.Text = "Adresse";
            this.LabelAdresse.Visible = false;
            // 
            // LabelPostal
            // 
            this.LabelPostal.AutoSize = true;
            this.LabelPostal.Location = new System.Drawing.Point(950, 330);
            this.LabelPostal.Name = "LabelPostal";
            this.LabelPostal.Size = new System.Drawing.Size(95, 20);
            this.LabelPostal.TabIndex = 25;
            this.LabelPostal.Text = "Code Postal";
            this.LabelPostal.Visible = false;
            // 
            // LabelVille
            // 
            this.LabelVille.AutoSize = true;
            this.LabelVille.Location = new System.Drawing.Point(1151, 330);
            this.LabelVille.Name = "LabelVille";
            this.LabelVille.Size = new System.Drawing.Size(38, 20);
            this.LabelVille.TabIndex = 26;
            this.LabelVille.Text = "Ville";
            this.LabelVille.Visible = false;
            // 
            // LabelSituation
            // 
            this.LabelSituation.AutoSize = true;
            this.LabelSituation.Location = new System.Drawing.Point(975, 451);
            this.LabelSituation.Name = "LabelSituation";
            this.LabelSituation.Size = new System.Drawing.Size(72, 20);
            this.LabelSituation.TabIndex = 27;
            this.LabelSituation.Text = "Situation";
            this.LabelSituation.Visible = false;
            // 
            // LabelRisque
            // 
            this.LabelRisque.AutoSize = true;
            this.LabelRisque.Location = new System.Drawing.Point(1115, 451);
            this.LabelRisque.Name = "LabelRisque";
            this.LabelRisque.Size = new System.Drawing.Size(59, 20);
            this.LabelRisque.TabIndex = 28;
            this.LabelRisque.Text = "Risque";
            this.LabelRisque.Visible = false;
            // 
            // B_EnvoyerResident
            // 
            this.B_EnvoyerResident.Location = new System.Drawing.Point(1116, 563);
            this.B_EnvoyerResident.Name = "B_EnvoyerResident";
            this.B_EnvoyerResident.Size = new System.Drawing.Size(141, 71);
            this.B_EnvoyerResident.TabIndex = 29;
            this.B_EnvoyerResident.Text = "Ajouter";
            this.B_EnvoyerResident.UseVisualStyleBackColor = true;
            this.B_EnvoyerResident.Visible = false;
            this.B_EnvoyerResident.Click += new System.EventHandler(this.B_EnvoyerResident_Click);
            // 
            // BoxSituation
            // 
            this.BoxSituation.FormattingEnabled = true;
            this.BoxSituation.Items.AddRange(new object[] {
            "Seul(e)",
            "A plusieurs"});
            this.BoxSituation.Location = new System.Drawing.Point(945, 496);
            this.BoxSituation.Name = "BoxSituation";
            this.BoxSituation.Size = new System.Drawing.Size(121, 28);
            this.BoxSituation.TabIndex = 18;
            this.BoxSituation.Visible = false;
            this.BoxSituation.SelectedIndexChanged += new System.EventHandler(this.BoxSituation_SelectedIndexChanged);
            // 
            // BoxTel
            // 
            this.BoxTel.Location = new System.Drawing.Point(509, 368);
            this.BoxTel.Name = "BoxTel";
            this.BoxTel.Size = new System.Drawing.Size(169, 26);
            this.BoxTel.TabIndex = 13;
            this.BoxTel.Visible = false;
            this.BoxTel.TextChanged += new System.EventHandler(this.BoxTel_TextChanged);
            // 
            // LabelTel
            // 
            this.LabelTel.AutoSize = true;
            this.LabelTel.Location = new System.Drawing.Point(552, 330);
            this.LabelTel.Name = "LabelTel";
            this.LabelTel.Size = new System.Drawing.Size(71, 20);
            this.LabelTel.TabIndex = 32;
            this.LabelTel.Text = "Num Tel.";
            this.LabelTel.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 252);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(499, 382);
            this.dataGridView2.TabIndex = 33;
            this.dataGridView2.Visible = false;
            // 
            // BoxID
            // 
            this.BoxID.Location = new System.Drawing.Point(519, 269);
            this.BoxID.Name = "BoxID";
            this.BoxID.Size = new System.Drawing.Size(102, 26);
            this.BoxID.TabIndex = 9;
            this.BoxID.Visible = false;
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(531, 226);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(80, 40);
            this.LabelID.TabIndex = 35;
            this.LabelID.Text = "Identifiant\r\n (nombre)";
            this.LabelID.Visible = false;
            this.LabelID.Click += new System.EventHandler(this.label1_Click);
            // 
            // BoxDate
            // 
            this.BoxDate.Location = new System.Drawing.Point(763, 496);
            this.BoxDate.Mask = "0000/00/00";
            this.BoxDate.Name = "BoxDate";
            this.BoxDate.Size = new System.Drawing.Size(94, 26);
            this.BoxDate.TabIndex = 17;
            this.BoxDate.ValidatingType = typeof(System.DateTime);
            this.BoxDate.Visible = false;
            // 
            // B_AjoutContact
            // 
            this.B_AjoutContact.Location = new System.Drawing.Point(696, 38);
            this.B_AjoutContact.Name = "B_AjoutContact";
            this.B_AjoutContact.Size = new System.Drawing.Size(158, 91);
            this.B_AjoutContact.TabIndex = 36;
            this.B_AjoutContact.Text = "ajouter contact";
            this.B_AjoutContact.UseVisualStyleBackColor = true;
            this.B_AjoutContact.Click += new System.EventHandler(this.B_AjoutContact_Click);
            // 
            // B_EnvoyerContact
            // 
            this.B_EnvoyerContact.Location = new System.Drawing.Point(1116, 387);
            this.B_EnvoyerContact.Name = "B_EnvoyerContact";
            this.B_EnvoyerContact.Size = new System.Drawing.Size(141, 71);
            this.B_EnvoyerContact.TabIndex = 37;
            this.B_EnvoyerContact.Text = "Ajouter";
            this.B_EnvoyerContact.UseVisualStyleBackColor = true;
            this.B_EnvoyerContact.Visible = false;
            this.B_EnvoyerContact.Click += new System.EventHandler(this.B_EnvoyerContact_Click);
            // 
            // BoxIDContact
            // 
            this.BoxIDContact.Location = new System.Drawing.Point(1058, 269);
            this.BoxIDContact.Name = "BoxIDContact";
            this.BoxIDContact.Size = new System.Drawing.Size(102, 26);
            this.BoxIDContact.TabIndex = 12;
            this.BoxIDContact.Visible = false;
            // 
            // LabelContact
            // 
            this.LabelContact.AutoSize = true;
            this.LabelContact.Location = new System.Drawing.Point(1016, 236);
            this.LabelContact.Name = "LabelContact";
            this.LabelContact.Size = new System.Drawing.Size(257, 20);
            this.LabelContact.TabIndex = 39;
            this.LabelContact.Text = "Identifiant de la personne à risques\r\n";
            this.LabelContact.Visible = false;
            // 
            // BoxQualite
            // 
            this.BoxQualite.Location = new System.Drawing.Point(715, 368);
            this.BoxQualite.Name = "BoxQualite";
            this.BoxQualite.Size = new System.Drawing.Size(142, 26);
            this.BoxQualite.TabIndex = 14;
            this.BoxQualite.Visible = false;
            // 
            // LabelQualite
            // 
            this.LabelQualite.AutoSize = true;
            this.LabelQualite.Location = new System.Drawing.Point(759, 330);
            this.LabelQualite.Name = "LabelQualite";
            this.LabelQualite.Size = new System.Drawing.Size(59, 20);
            this.LabelQualite.TabIndex = 41;
            this.LabelQualite.Text = "Qualite";
            this.LabelQualite.Visible = false;
            // 
            // B_AppelP
            // 
            this.B_AppelP.Location = new System.Drawing.Point(56, 202);
            this.B_AppelP.Name = "B_AppelP";
            this.B_AppelP.Size = new System.Drawing.Size(155, 131);
            this.B_AppelP.TabIndex = 42;
            this.B_AppelP.Text = "Laisser un commentaire sur un appel";
            this.B_AppelP.UseVisualStyleBackColor = true;
            this.B_AppelP.Visible = false;
            this.B_AppelP.Click += new System.EventHandler(this.B_Appel_Click);
            // 
            // Box_Commentaire
            // 
            this.Box_Commentaire.Location = new System.Drawing.Point(230, 202);
            this.Box_Commentaire.Name = "Box_Commentaire";
            this.Box_Commentaire.Size = new System.Drawing.Size(225, 131);
            this.Box_Commentaire.TabIndex = 43;
            this.Box_Commentaire.Text = "";
            this.Box_Commentaire.Visible = false;
            // 
            // B_AppelC
            // 
            this.B_AppelC.Location = new System.Drawing.Point(56, 202);
            this.B_AppelC.Name = "B_AppelC";
            this.B_AppelC.Size = new System.Drawing.Size(155, 131);
            this.B_AppelC.TabIndex = 44;
            this.B_AppelC.Text = "Laisser un commentaire sur un appel";
            this.B_AppelC.UseVisualStyleBackColor = true;
            this.B_AppelC.Visible = false;
            this.B_AppelC.Click += new System.EventHandler(this.B_AppelC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1159, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID = Identifiant";
            // 
            // B_SupprimerP
            // 
            this.B_SupprimerP.Location = new System.Drawing.Point(495, 163);
            this.B_SupprimerP.Name = "B_SupprimerP";
            this.B_SupprimerP.Size = new System.Drawing.Size(156, 60);
            this.B_SupprimerP.TabIndex = 46;
            this.B_SupprimerP.Text = "Supprimer une personne";
            this.B_SupprimerP.UseVisualStyleBackColor = true;
            this.B_SupprimerP.Visible = false;
            this.B_SupprimerP.Click += new System.EventHandler(this.B_SupprimerP_Click);
            // 
            // BoxConfirmer
            // 
            this.BoxConfirmer.Location = new System.Drawing.Point(680, 202);
            this.BoxConfirmer.Name = "BoxConfirmer";
            this.BoxConfirmer.Size = new System.Drawing.Size(102, 26);
            this.BoxConfirmer.TabIndex = 10;
            this.BoxConfirmer.Visible = false;
            // 
            // LabelConfirmer
            // 
            this.LabelConfirmer.AutoSize = true;
            this.LabelConfirmer.Location = new System.Drawing.Point(692, 170);
            this.LabelConfirmer.Name = "LabelConfirmer";
            this.LabelConfirmer.Size = new System.Drawing.Size(78, 20);
            this.LabelConfirmer.TabIndex = 48;
            this.LabelConfirmer.Text = "Confirmer";
            this.LabelConfirmer.Visible = false;
            // 
            // B_SupprimerContact
            // 
            this.B_SupprimerContact.Location = new System.Drawing.Point(495, 163);
            this.B_SupprimerContact.Name = "B_SupprimerContact";
            this.B_SupprimerContact.Size = new System.Drawing.Size(156, 60);
            this.B_SupprimerContact.TabIndex = 49;
            this.B_SupprimerContact.Text = "Supprimer un contact";
            this.B_SupprimerContact.UseVisualStyleBackColor = true;
            this.B_SupprimerContact.Visible = false;
            this.B_SupprimerContact.Click += new System.EventHandler(this.B_SupprimerContact_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1284, 688);
            this.Controls.Add(this.B_SupprimerContact);
            this.Controls.Add(this.LabelConfirmer);
            this.Controls.Add(this.BoxConfirmer);
            this.Controls.Add(this.B_SupprimerP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_AppelC);
            this.Controls.Add(this.Box_Commentaire);
            this.Controls.Add(this.B_AppelP);
            this.Controls.Add(this.LabelQualite);
            this.Controls.Add(this.BoxQualite);
            this.Controls.Add(this.LabelContact);
            this.Controls.Add(this.BoxIDContact);
            this.Controls.Add(this.B_EnvoyerContact);
            this.Controls.Add(this.B_AjoutContact);
            this.Controls.Add(this.BoxDate);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.BoxID);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.LabelTel);
            this.Controls.Add(this.BoxTel);
            this.Controls.Add(this.BoxSituation);
            this.Controls.Add(this.B_EnvoyerResident);
            this.Controls.Add(this.LabelRisque);
            this.Controls.Add(this.LabelSituation);
            this.Controls.Add(this.LabelVille);
            this.Controls.Add(this.LabelPostal);
            this.Controls.Add(this.LabelAdresse);
            this.Controls.Add(this.BoxRisque);
            this.Controls.Add(this.BoxVille);
            this.Controls.Add(this.BoxPostal);
            this.Controls.Add(this.BoxAdresse);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelPrenom);
            this.Controls.Add(this.LabelNom);
            this.Controls.Add(this.LabelSexe);
            this.Controls.Add(this.BoxSexe);
            this.Controls.Add(this.BoxPrenom);
            this.Controls.Add(this.BoxNom);
            this.Controls.Add(this.B_AjoutResident);
            this.Controls.Add(this.b_contacts);
            this.Controls.Add(this.b_residents);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_residents;
        private System.Windows.Forms.Button b_contacts;
        private System.Windows.Forms.Button B_AjoutResident;
        private System.Windows.Forms.TextBox BoxNom;
        private System.Windows.Forms.TextBox BoxPrenom;
        private System.Windows.Forms.ComboBox BoxSexe;
        private System.Windows.Forms.Label LabelSexe;
        private System.Windows.Forms.Label LabelNom;
        private System.Windows.Forms.Label LabelPrenom;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.TextBox BoxAdresse;
        private System.Windows.Forms.TextBox BoxPostal;
        private System.Windows.Forms.TextBox BoxVille;
        private System.Windows.Forms.ComboBox BoxRisque;
        private System.Windows.Forms.Label LabelAdresse;
        private System.Windows.Forms.Label LabelPostal;
        private System.Windows.Forms.Label LabelVille;
        private System.Windows.Forms.Label LabelSituation;
        private System.Windows.Forms.Label LabelRisque;
        private System.Windows.Forms.Button B_EnvoyerResident;
        private System.Windows.Forms.ComboBox BoxSituation;
        private System.Windows.Forms.TextBox BoxTel;
        private System.Windows.Forms.Label LabelTel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox BoxID;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.MaskedTextBox BoxDate;
        private System.Windows.Forms.Button B_AjoutContact;
        private System.Windows.Forms.Button B_EnvoyerContact;
        private System.Windows.Forms.TextBox BoxIDContact;
        private System.Windows.Forms.Label LabelContact;
        private System.Windows.Forms.TextBox BoxQualite;
        private System.Windows.Forms.Label LabelQualite;
        private System.Windows.Forms.Button B_AppelP;
        private System.Windows.Forms.RichTextBox Box_Commentaire;
        private System.Windows.Forms.Button B_AppelC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_SupprimerP;
        private System.Windows.Forms.TextBox BoxConfirmer;
        private System.Windows.Forms.Label LabelConfirmer;
        private System.Windows.Forms.Button B_SupprimerContact;
    }
}

