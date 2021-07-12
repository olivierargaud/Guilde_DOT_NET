
namespace TP_CDEV_Guilde_Des_Heros
{
    partial class FormGestionGuilde
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
            this.dataGridViewMembres = new System.Windows.Forms.DataGridView();
            this.dataGridViewSacoche = new System.Windows.Forms.DataGridView();
            this.buttonAjoutHero = new System.Windows.Forms.Button();
            this.buttonModifierHero = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonAjouterObjet = new System.Windows.Forms.Button();
            this.buttonModifierObjet = new System.Windows.Forms.Button();
            this.buttonSupprimerObjet = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownHeroReputation = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeroNbMission = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeroPuissance = new System.Windows.Forms.NumericUpDown();
            this.textBoxHeroClasse = new System.Windows.Forms.TextBox();
            this.textBoxHeroSpecialite = new System.Windows.Forms.TextBox();
            this.textBoxHeroPrenom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelSpecialite = new System.Windows.Forms.Label();
            this.labelClasse = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelPuissance = new System.Windows.Forms.Label();
            this.labelNbMissionReussi = new System.Windows.Forms.Label();
            this.labelReputation = new System.Windows.Forms.Label();
            this.textBoxHeroNom = new System.Windows.Forms.TextBox();
            this.numericUpDownHeroLevel = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownObjetPrix = new System.Windows.Forms.NumericUpDown();
            this.textBoxObjetNom = new System.Windows.Forms.TextBox();
            this.labelNomObjet = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxObjetDescription = new System.Windows.Forms.TextBox();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.labelLevelObjet = new System.Windows.Forms.Label();
            this.numericUpDownObjetQuantite = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownObjetLevel = new System.Windows.Forms.NumericUpDown();
            this.labelObjet = new System.Windows.Forms.Label();
            this.labelHero = new System.Windows.Forms.Label();
            this.buttonNouveauMembre = new System.Windows.Forms.Button();
            this.buttonNouvelObjet = new System.Windows.Forms.Button();
            this.buttonValiderMembre = new System.Windows.Forms.Button();
            this.buttonValiderObjet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSacoche)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeroReputation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeroNbMission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeroPuissance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeroLevel)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjetPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjetQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjetLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMembres
            // 
            this.dataGridViewMembres.AllowUserToAddRows = false;
            this.dataGridViewMembres.AllowUserToDeleteRows = false;
            this.dataGridViewMembres.AllowUserToResizeColumns = false;
            this.dataGridViewMembres.AllowUserToResizeRows = false;
            this.dataGridViewMembres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembres.Location = new System.Drawing.Point(372, 43);
            this.dataGridViewMembres.MultiSelect = false;
            this.dataGridViewMembres.Name = "dataGridViewMembres";
            this.dataGridViewMembres.ReadOnly = true;
            this.dataGridViewMembres.Size = new System.Drawing.Size(637, 240);
            this.dataGridViewMembres.TabIndex = 0;
            this.dataGridViewMembres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMembres_CellClick);
            this.dataGridViewMembres.SelectionChanged += new System.EventHandler(this.dataGridViewMembres_SelectionChanged);
            // 
            // dataGridViewSacoche
            // 
            this.dataGridViewSacoche.AllowUserToAddRows = false;
            this.dataGridViewSacoche.AllowUserToDeleteRows = false;
            this.dataGridViewSacoche.AllowUserToResizeColumns = false;
            this.dataGridViewSacoche.AllowUserToResizeRows = false;
            this.dataGridViewSacoche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSacoche.Location = new System.Drawing.Point(372, 327);
            this.dataGridViewSacoche.MultiSelect = false;
            this.dataGridViewSacoche.Name = "dataGridViewSacoche";
            this.dataGridViewSacoche.ReadOnly = true;
            this.dataGridViewSacoche.Size = new System.Drawing.Size(637, 241);
            this.dataGridViewSacoche.TabIndex = 1;
            this.dataGridViewSacoche.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSacoche_CellClick);
            this.dataGridViewSacoche.SelectionChanged += new System.EventHandler(this.dataGridViewSacoche_SelectionChanged);
            // 
            // buttonAjoutHero
            // 
            this.buttonAjoutHero.BackColor = System.Drawing.Color.Lime;
            this.buttonAjoutHero.Location = new System.Drawing.Point(207, 288);
            this.buttonAjoutHero.Name = "buttonAjoutHero";
            this.buttonAjoutHero.Size = new System.Drawing.Size(87, 23);
            this.buttonAjoutHero.TabIndex = 2;
            this.buttonAjoutHero.Text = "AJOUTER";
            this.buttonAjoutHero.UseVisualStyleBackColor = false;
            this.buttonAjoutHero.Visible = false;
            this.buttonAjoutHero.Click += new System.EventHandler(this.buttonAjoutHero_Click);
            // 
            // buttonModifierHero
            // 
            this.buttonModifierHero.BackColor = System.Drawing.Color.Blue;
            this.buttonModifierHero.ForeColor = System.Drawing.Color.White;
            this.buttonModifierHero.Location = new System.Drawing.Point(1015, 72);
            this.buttonModifierHero.Name = "buttonModifierHero";
            this.buttonModifierHero.Size = new System.Drawing.Size(87, 23);
            this.buttonModifierHero.TabIndex = 3;
            this.buttonModifierHero.Text = "MODIFIER";
            this.buttonModifierHero.UseVisualStyleBackColor = false;
            this.buttonModifierHero.Click += new System.EventHandler(this.buttonModifierHero_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.Red;
            this.buttonSupprimer.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimer.Location = new System.Drawing.Point(1015, 101);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(87, 23);
            this.buttonSupprimer.TabIndex = 4;
            this.buttonSupprimer.Text = "SUPPRIMER";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonAjouterObjet
            // 
            this.buttonAjouterObjet.BackColor = System.Drawing.Color.Lime;
            this.buttonAjouterObjet.Location = new System.Drawing.Point(207, 574);
            this.buttonAjouterObjet.Name = "buttonAjouterObjet";
            this.buttonAjouterObjet.Size = new System.Drawing.Size(87, 23);
            this.buttonAjouterObjet.TabIndex = 5;
            this.buttonAjouterObjet.Text = "AJOUTER";
            this.buttonAjouterObjet.UseVisualStyleBackColor = false;
            this.buttonAjouterObjet.Visible = false;
            this.buttonAjouterObjet.Click += new System.EventHandler(this.buttonAjouterObjet_Click);
            // 
            // buttonModifierObjet
            // 
            this.buttonModifierObjet.BackColor = System.Drawing.Color.Blue;
            this.buttonModifierObjet.ForeColor = System.Drawing.Color.White;
            this.buttonModifierObjet.Location = new System.Drawing.Point(1015, 356);
            this.buttonModifierObjet.Name = "buttonModifierObjet";
            this.buttonModifierObjet.Size = new System.Drawing.Size(87, 23);
            this.buttonModifierObjet.TabIndex = 6;
            this.buttonModifierObjet.Text = "MODIFIER";
            this.buttonModifierObjet.UseVisualStyleBackColor = false;
            this.buttonModifierObjet.Click += new System.EventHandler(this.buttonModifierObjet_Click);
            // 
            // buttonSupprimerObjet
            // 
            this.buttonSupprimerObjet.BackColor = System.Drawing.Color.Red;
            this.buttonSupprimerObjet.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimerObjet.Location = new System.Drawing.Point(1015, 385);
            this.buttonSupprimerObjet.Name = "buttonSupprimerObjet";
            this.buttonSupprimerObjet.Size = new System.Drawing.Size(87, 23);
            this.buttonSupprimerObjet.TabIndex = 7;
            this.buttonSupprimerObjet.Text = "SUPPRIMER";
            this.buttonSupprimerObjet.UseVisualStyleBackColor = false;
            this.buttonSupprimerObjet.Click += new System.EventHandler(this.buttonSupprimerObjet_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.40351F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.59649F));
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownHeroReputation, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownHeroNbMission, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownHeroPuissance, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHeroClasse, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHeroSpecialite, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHeroPrenom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPrenom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSpecialite, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelClasse, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelLevel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelPuissance, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelNbMissionReussi, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelReputation, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHeroNom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownHeroLevel, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(54, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(285, 237);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // numericUpDownHeroReputation
            // 
            this.numericUpDownHeroReputation.Location = new System.Drawing.Point(121, 197);
            this.numericUpDownHeroReputation.Name = "numericUpDownHeroReputation";
            this.numericUpDownHeroReputation.Size = new System.Drawing.Size(161, 20);
            this.numericUpDownHeroReputation.TabIndex = 15;
            // 
            // numericUpDownHeroNbMission
            // 
            this.numericUpDownHeroNbMission.Location = new System.Drawing.Point(121, 166);
            this.numericUpDownHeroNbMission.Name = "numericUpDownHeroNbMission";
            this.numericUpDownHeroNbMission.Size = new System.Drawing.Size(161, 20);
            this.numericUpDownHeroNbMission.TabIndex = 14;
            // 
            // numericUpDownHeroPuissance
            // 
            this.numericUpDownHeroPuissance.Location = new System.Drawing.Point(121, 138);
            this.numericUpDownHeroPuissance.Name = "numericUpDownHeroPuissance";
            this.numericUpDownHeroPuissance.Size = new System.Drawing.Size(161, 20);
            this.numericUpDownHeroPuissance.TabIndex = 13;
            this.numericUpDownHeroPuissance.ValueChanged += new System.EventHandler(this.numericUpDownHeroPuissance_ValueChanged);
            // 
            // textBoxHeroClasse
            // 
            this.textBoxHeroClasse.Location = new System.Drawing.Point(121, 84);
            this.textBoxHeroClasse.Name = "textBoxHeroClasse";
            this.textBoxHeroClasse.Size = new System.Drawing.Size(161, 20);
            this.textBoxHeroClasse.TabIndex = 11;
            this.textBoxHeroClasse.TextChanged += new System.EventHandler(this.textBoxHeroClasse_TextChanged);
            // 
            // textBoxHeroSpecialite
            // 
            this.textBoxHeroSpecialite.Location = new System.Drawing.Point(121, 57);
            this.textBoxHeroSpecialite.Name = "textBoxHeroSpecialite";
            this.textBoxHeroSpecialite.Size = new System.Drawing.Size(161, 20);
            this.textBoxHeroSpecialite.TabIndex = 10;
            this.textBoxHeroSpecialite.TextChanged += new System.EventHandler(this.textBoxHeroSpecialite_TextChanged);
            // 
            // textBoxHeroPrenom
            // 
            this.textBoxHeroPrenom.Location = new System.Drawing.Point(121, 30);
            this.textBoxHeroPrenom.Name = "textBoxHeroPrenom";
            this.textBoxHeroPrenom.Size = new System.Drawing.Size(161, 20);
            this.textBoxHeroPrenom.TabIndex = 9;
            this.textBoxHeroPrenom.TextChanged += new System.EventHandler(this.textBoxHeroPrenom_TextChanged);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(3, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(3, 27);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 1;
            this.labelPrenom.Text = "Prénom";
            // 
            // labelSpecialite
            // 
            this.labelSpecialite.AutoSize = true;
            this.labelSpecialite.Location = new System.Drawing.Point(3, 54);
            this.labelSpecialite.Name = "labelSpecialite";
            this.labelSpecialite.Size = new System.Drawing.Size(53, 13);
            this.labelSpecialite.TabIndex = 2;
            this.labelSpecialite.Text = "Spécialité";
            // 
            // labelClasse
            // 
            this.labelClasse.AutoSize = true;
            this.labelClasse.Location = new System.Drawing.Point(3, 81);
            this.labelClasse.Name = "labelClasse";
            this.labelClasse.Size = new System.Drawing.Size(38, 13);
            this.labelClasse.TabIndex = 3;
            this.labelClasse.Text = "Classe";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(3, 108);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(33, 13);
            this.labelLevel.TabIndex = 4;
            this.labelLevel.Text = "Level";
            // 
            // labelPuissance
            // 
            this.labelPuissance.AutoSize = true;
            this.labelPuissance.Location = new System.Drawing.Point(3, 135);
            this.labelPuissance.Name = "labelPuissance";
            this.labelPuissance.Size = new System.Drawing.Size(56, 13);
            this.labelPuissance.TabIndex = 5;
            this.labelPuissance.Text = "Puissance";
            // 
            // labelNbMissionReussi
            // 
            this.labelNbMissionReussi.AutoSize = true;
            this.labelNbMissionReussi.Location = new System.Drawing.Point(3, 163);
            this.labelNbMissionReussi.Name = "labelNbMissionReussi";
            this.labelNbMissionReussi.Size = new System.Drawing.Size(99, 26);
            this.labelNbMissionReussi.TabIndex = 6;
            this.labelNbMissionReussi.Text = "Nombre de mission réussies";
            // 
            // labelReputation
            // 
            this.labelReputation.AutoSize = true;
            this.labelReputation.Location = new System.Drawing.Point(3, 194);
            this.labelReputation.Name = "labelReputation";
            this.labelReputation.Size = new System.Drawing.Size(59, 13);
            this.labelReputation.TabIndex = 7;
            this.labelReputation.Text = "Réputation";
            // 
            // textBoxHeroNom
            // 
            this.textBoxHeroNom.Location = new System.Drawing.Point(121, 3);
            this.textBoxHeroNom.Name = "textBoxHeroNom";
            this.textBoxHeroNom.Size = new System.Drawing.Size(161, 20);
            this.textBoxHeroNom.TabIndex = 8;
            this.textBoxHeroNom.TextChanged += new System.EventHandler(this.textBoxHeroNom_TextChanged);
            // 
            // numericUpDownHeroLevel
            // 
            this.numericUpDownHeroLevel.Location = new System.Drawing.Point(121, 111);
            this.numericUpDownHeroLevel.Name = "numericUpDownHeroLevel";
            this.numericUpDownHeroLevel.Size = new System.Drawing.Size(161, 20);
            this.numericUpDownHeroLevel.TabIndex = 12;
            this.numericUpDownHeroLevel.ValueChanged += new System.EventHandler(this.numericUpDownHeroLevel_ValueChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.10526F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.89474F));
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownObjetPrix, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBoxObjetNom, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelNomObjet, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelPrix, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelDescription, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxObjetDescription, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelQuantite, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelLevelObjet, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownObjetQuantite, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownObjetLevel, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(54, 327);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.95425F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.04575F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(285, 241);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // numericUpDownObjetPrix
            // 
            this.numericUpDownObjetPrix.Location = new System.Drawing.Point(122, 210);
            this.numericUpDownObjetPrix.Name = "numericUpDownObjetPrix";
            this.numericUpDownObjetPrix.Size = new System.Drawing.Size(160, 20);
            this.numericUpDownObjetPrix.TabIndex = 19;
            this.numericUpDownObjetPrix.ValueChanged += new System.EventHandler(this.numericUpDownObjetPrix_ValueChanged);
            // 
            // textBoxObjetNom
            // 
            this.textBoxObjetNom.Location = new System.Drawing.Point(122, 3);
            this.textBoxObjetNom.Name = "textBoxObjetNom";
            this.textBoxObjetNom.Size = new System.Drawing.Size(160, 20);
            this.textBoxObjetNom.TabIndex = 16;
            this.textBoxObjetNom.TextChanged += new System.EventHandler(this.textBoxObjetNom_TextChanged);
            // 
            // labelNomObjet
            // 
            this.labelNomObjet.AutoSize = true;
            this.labelNomObjet.Location = new System.Drawing.Point(3, 0);
            this.labelNomObjet.Name = "labelNomObjet";
            this.labelNomObjet.Size = new System.Drawing.Size(29, 13);
            this.labelNomObjet.TabIndex = 10;
            this.labelNomObjet.Text = "Nom";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Location = new System.Drawing.Point(3, 207);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(24, 13);
            this.labelPrix.TabIndex = 14;
            this.labelPrix.Text = "Prix";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(3, 29);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 13;
            this.labelDescription.Text = "Description";
            // 
            // textBoxObjetDescription
            // 
            this.textBoxObjetDescription.Location = new System.Drawing.Point(122, 32);
            this.textBoxObjetDescription.Multiline = true;
            this.textBoxObjetDescription.Name = "textBoxObjetDescription";
            this.textBoxObjetDescription.Size = new System.Drawing.Size(160, 114);
            this.textBoxObjetDescription.TabIndex = 17;
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Location = new System.Drawing.Point(3, 180);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(47, 13);
            this.labelQuantite.TabIndex = 12;
            this.labelQuantite.Text = "Quantité";
            // 
            // labelLevelObjet
            // 
            this.labelLevelObjet.AutoSize = true;
            this.labelLevelObjet.Location = new System.Drawing.Point(3, 153);
            this.labelLevelObjet.Name = "labelLevelObjet";
            this.labelLevelObjet.Size = new System.Drawing.Size(33, 13);
            this.labelLevelObjet.TabIndex = 11;
            this.labelLevelObjet.Text = "Level";
            // 
            // numericUpDownObjetQuantite
            // 
            this.numericUpDownObjetQuantite.Location = new System.Drawing.Point(122, 183);
            this.numericUpDownObjetQuantite.Name = "numericUpDownObjetQuantite";
            this.numericUpDownObjetQuantite.Size = new System.Drawing.Size(160, 20);
            this.numericUpDownObjetQuantite.TabIndex = 18;
            this.numericUpDownObjetQuantite.ValueChanged += new System.EventHandler(this.numericUpDownObjetQuantite_ValueChanged);
            // 
            // numericUpDownObjetLevel
            // 
            this.numericUpDownObjetLevel.Location = new System.Drawing.Point(122, 156);
            this.numericUpDownObjetLevel.Name = "numericUpDownObjetLevel";
            this.numericUpDownObjetLevel.Size = new System.Drawing.Size(160, 20);
            this.numericUpDownObjetLevel.TabIndex = 16;
            this.numericUpDownObjetLevel.ValueChanged += new System.EventHandler(this.numericUpDownObjetLevel_ValueChanged);
            // 
            // labelObjet
            // 
            this.labelObjet.AutoSize = true;
            this.labelObjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObjet.Location = new System.Drawing.Point(56, 300);
            this.labelObjet.Name = "labelObjet";
            this.labelObjet.Size = new System.Drawing.Size(85, 24);
            this.labelObjet.TabIndex = 20;
            this.labelObjet.Text = "Sacoche";
            // 
            // labelHero
            // 
            this.labelHero.AutoSize = true;
            this.labelHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHero.Location = new System.Drawing.Point(56, 18);
            this.labelHero.Name = "labelHero";
            this.labelHero.Size = new System.Drawing.Size(52, 24);
            this.labelHero.TabIndex = 21;
            this.labelHero.Text = "Héro";
            // 
            // buttonNouveauMembre
            // 
            this.buttonNouveauMembre.BackColor = System.Drawing.Color.Lime;
            this.buttonNouveauMembre.Location = new System.Drawing.Point(1015, 43);
            this.buttonNouveauMembre.Name = "buttonNouveauMembre";
            this.buttonNouveauMembre.Size = new System.Drawing.Size(87, 23);
            this.buttonNouveauMembre.TabIndex = 22;
            this.buttonNouveauMembre.Text = "NOUVEAU";
            this.buttonNouveauMembre.UseMnemonic = false;
            this.buttonNouveauMembre.UseVisualStyleBackColor = false;
            this.buttonNouveauMembre.Click += new System.EventHandler(this.buttonNouveauMembre_Click);
            // 
            // buttonNouvelObjet
            // 
            this.buttonNouvelObjet.BackColor = System.Drawing.Color.Lime;
            this.buttonNouvelObjet.Location = new System.Drawing.Point(1015, 327);
            this.buttonNouvelObjet.Name = "buttonNouvelObjet";
            this.buttonNouvelObjet.Size = new System.Drawing.Size(87, 23);
            this.buttonNouvelObjet.TabIndex = 23;
            this.buttonNouvelObjet.Text = "NOUVEAU";
            this.buttonNouvelObjet.UseVisualStyleBackColor = false;
            this.buttonNouvelObjet.Click += new System.EventHandler(this.buttonNouvelObjet_Click);
            // 
            // buttonValiderMembre
            // 
            this.buttonValiderMembre.BackColor = System.Drawing.Color.Lime;
            this.buttonValiderMembre.Location = new System.Drawing.Point(207, 288);
            this.buttonValiderMembre.Name = "buttonValiderMembre";
            this.buttonValiderMembre.Size = new System.Drawing.Size(87, 23);
            this.buttonValiderMembre.TabIndex = 24;
            this.buttonValiderMembre.Text = "VALIDER";
            this.buttonValiderMembre.UseVisualStyleBackColor = false;
            this.buttonValiderMembre.Visible = false;
            this.buttonValiderMembre.Click += new System.EventHandler(this.buttonValiderMembre_Click);
            // 
            // buttonValiderObjet
            // 
            this.buttonValiderObjet.BackColor = System.Drawing.Color.Lime;
            this.buttonValiderObjet.Location = new System.Drawing.Point(207, 574);
            this.buttonValiderObjet.Name = "buttonValiderObjet";
            this.buttonValiderObjet.Size = new System.Drawing.Size(87, 23);
            this.buttonValiderObjet.TabIndex = 25;
            this.buttonValiderObjet.Text = "VALIDER";
            this.buttonValiderObjet.UseVisualStyleBackColor = false;
            this.buttonValiderObjet.Visible = false;
            this.buttonValiderObjet.Click += new System.EventHandler(this.buttonValiderObjet_Click);
            // 
            // FormGestionGuilde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1129, 603);
            this.Controls.Add(this.buttonValiderObjet);
            this.Controls.Add(this.buttonValiderMembre);
            this.Controls.Add(this.buttonNouvelObjet);
            this.Controls.Add(this.buttonNouveauMembre);
            this.Controls.Add(this.labelHero);
            this.Controls.Add(this.labelObjet);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonSupprimerObjet);
            this.Controls.Add(this.buttonModifierObjet);
            this.Controls.Add(this.buttonAjouterObjet);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifierHero);
            this.Controls.Add(this.buttonAjoutHero);
            this.Controls.Add(this.dataGridViewSacoche);
            this.Controls.Add(this.dataGridViewMembres);
            this.Name = "FormGestionGuilde";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSacoche)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeroReputation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeroNbMission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeroPuissance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeroLevel)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjetPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjetQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjetLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMembres;
        private System.Windows.Forms.DataGridView dataGridViewSacoche;
        private System.Windows.Forms.Button buttonAjoutHero;
        private System.Windows.Forms.Button buttonModifierHero;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonAjouterObjet;
        private System.Windows.Forms.Button buttonModifierObjet;
        private System.Windows.Forms.Button buttonSupprimerObjet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numericUpDownHeroReputation;
        private System.Windows.Forms.NumericUpDown numericUpDownHeroNbMission;
        private System.Windows.Forms.NumericUpDown numericUpDownHeroPuissance;
        private System.Windows.Forms.TextBox textBoxHeroClasse;
        private System.Windows.Forms.TextBox textBoxHeroSpecialite;
        private System.Windows.Forms.TextBox textBoxHeroPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelSpecialite;
        private System.Windows.Forms.Label labelClasse;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelPuissance;
        private System.Windows.Forms.Label labelNbMissionReussi;
        private System.Windows.Forms.Label labelReputation;
        private System.Windows.Forms.TextBox textBoxHeroNom;
        private System.Windows.Forms.NumericUpDown numericUpDownHeroLevel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown numericUpDownObjetPrix;
        private System.Windows.Forms.NumericUpDown numericUpDownObjetQuantite;
        private System.Windows.Forms.NumericUpDown numericUpDownObjetLevel;
        private System.Windows.Forms.TextBox textBoxObjetNom;
        private System.Windows.Forms.Label labelNomObjet;
        private System.Windows.Forms.Label labelLevelObjet;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.TextBox textBoxObjetDescription;
        private System.Windows.Forms.Label labelObjet;
        private System.Windows.Forms.Label labelHero;
        private System.Windows.Forms.Button buttonNouveauMembre;
        private System.Windows.Forms.Button buttonNouvelObjet;
        private System.Windows.Forms.Button buttonValiderMembre;
        private System.Windows.Forms.Button buttonValiderObjet;
    }
}

