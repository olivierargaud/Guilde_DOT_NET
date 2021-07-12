using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_CDEV_Guilde_Des_Heros
{
    public partial class FormGestionGuilde : Form
    {
        public FormGestionGuilde()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshHero();
            if(dataGridViewMembres.CurrentRow!=null)
            {
                RefreshSacoche(int.Parse(dataGridViewMembres.CurrentRow.Cells[0].Value.ToString()));
            }
            verouChampObjet(true);
            buttonSupprimerHero.Enabled = false;
            buttonModifierHero.Enabled = false;
            buttonSupprimerObjet.Enabled = false;
            buttonModifierObjet.Enabled = false;


        }

        private void dataGridViewMembres_SelectionChanged(object sender, EventArgs e)
        {
            actualiseChampHero();
        }

        private void dataGridViewSacoche_SelectionChanged(object sender, EventArgs e)
        {
            actualiseChampObjet();
        }

        private void dataGridViewMembres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            actualiseChampHero();
        }

        private void dataGridViewSacoche_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            actualiseChampObjet();
        }




        private void textBoxHeroNom_TextChanged(object sender, EventArgs e)
        {
            textBoxHeroNom.BackColor = Color.White;
        }

        private void textBoxHeroPrenom_TextChanged(object sender, EventArgs e)
        {
            textBoxHeroPrenom.BackColor = Color.White;
        }

        private void textBoxHeroSpecialite_TextChanged(object sender, EventArgs e)
        {
            textBoxHeroSpecialite.BackColor = Color.White;
        }

        private void textBoxHeroClasse_TextChanged(object sender, EventArgs e)
        {
            textBoxHeroClasse.BackColor = Color.White;
        }

        private void numericUpDownHeroLevel_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownHeroLevel.BackColor = Color.White;
        }

        private void numericUpDownHeroPuissance_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownHeroPuissance.BackColor = Color.White;
        }

        private void textBoxObjetNom_TextChanged(object sender, EventArgs e)
        {
            textBoxObjetNom.BackColor = Color.White;
        }

        private void numericUpDownObjetLevel_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownObjetLevel.BackColor = Color.White;
        }

        private void numericUpDownObjetQuantite_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownObjetQuantite.BackColor = Color.White;
        }

        private void numericUpDownObjetPrix_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownObjetPrix.BackColor = Color.White;
        }





        private void buttonNouveauHero_Click(object sender, EventArgs e)
        {
            ViderLesChampsHero();
            verouChampHero(false);
            buttonAjoutHero.Visible = true;
        }

        private void buttonAjoutHero_Click(object sender, EventArgs e)
        {
            if (checkSaisieHero())
            {
                hero hero = new hero();
                hero.her_nom = textBoxHeroNom.Text;
                hero.her_prenom = textBoxHeroPrenom.Text;
                hero.her_specialite = textBoxHeroSpecialite.Text;
                hero.her_classe = textBoxHeroClasse.Text;
                hero.her_level = (int)numericUpDownHeroLevel.Value;
                hero.her_puissance = (int)numericUpDownHeroPuissance.Value;
                hero.her_nb_mission = (int)numericUpDownHeroNbMission.Value;
                hero.her_reputation = (int)numericUpDownHeroReputation.Value;

                guilde_des_herosEntities entite = new guilde_des_herosEntities();
                entite.hero.Add(hero);
                entite.SaveChanges();

                RefreshHero();
                ViderLesChampsHero();
                buttonAjoutHero.Visible = false;
                buttonModifierHero.Enabled = false;
                buttonSupprimerHero.Enabled = false;
                verouChampHero(true);
            }
            
        }

        private void buttonModifierHero_Click(object sender, EventArgs e)
        {
            buttonValiderHero.Visible = true;
            buttonSupprimerHero.Enabled = false;
            buttonModifierHero.Enabled = false;
            verouChampHero(false);
        }

        private void buttonValiderHero_Click(object sender, EventArgs e)
        {
            if (dataGridViewMembres.CurrentCell != null)
            {
                int ligne = dataGridViewMembres.CurrentCell.RowIndex;

                guilde_des_herosEntities entite = new guilde_des_herosEntities();
                int idHero = int.Parse(dataGridViewMembres.Rows[ligne].Cells[0].Value.ToString());

                hero heroAModifier = entite.hero.Where(a => a.her_id == idHero).FirstOrDefault();
                heroAModifier.her_nom = textBoxHeroNom.Text;
                heroAModifier.her_prenom = textBoxHeroPrenom.Text;
                heroAModifier.her_specialite = textBoxHeroSpecialite.Text;
                heroAModifier.her_classe = textBoxHeroClasse.Text;
                heroAModifier.her_level = (int)numericUpDownHeroLevel.Value;
                heroAModifier.her_puissance = (int)numericUpDownHeroPuissance.Value;
                heroAModifier.her_nb_mission = (int)numericUpDownHeroNbMission.Value;
                heroAModifier.her_reputation = (int)numericUpDownHeroReputation.Value;

                entite.hero.AddOrUpdate(heroAModifier);
                entite.SaveChanges();
                RefreshHero();
                ViderLesChampsHero();

                buttonValiderHero.Visible = false;
            }
        }

        private void buttonSupprimerHero_Click(object sender, EventArgs e)
        {
            if (dataGridViewMembres.CurrentCell != null)
            {
                int ligne = dataGridViewMembres.CurrentCell.RowIndex;

                guilde_des_herosEntities entite = new guilde_des_herosEntities();
                int idHero = int.Parse(dataGridViewMembres.Rows[ligne].Cells[0].Value.ToString());

                List<objet> listeObjets = entite.objet.Where(a => a.obj_hero_id == idHero).ToList();
                hero heroASupprimer = entite.hero.Where(a => a.her_id == idHero).FirstOrDefault();
                entite.hero.Remove(heroASupprimer);

                foreach(objet o in listeObjets)
                {
                    entite.objet.Remove(o);
                }

                entite.SaveChanges();
                RefreshHero();
                dataGridViewSacoche.DataSource = null;
                ViderLesChampsObjet();
                ViderLesChampsHero();
                buttonSupprimerHero.Enabled = false;
                buttonModifierHero.Enabled = false;
            }

        }





        private void buttonNouvelObjet_Click(object sender, EventArgs e)
        {
            if (dataGridViewMembres.CurrentCell != null)
            {
                ViderLesChampsObjet();
                verouChampObjet(false);
                buttonAjouterObjet.Visible = true;
            }
        }

        private void buttonAjouterObjet_Click(object sender, EventArgs e)
        {
            if (dataGridViewMembres.CurrentCell != null && checkSaisieObjet())
            {
                int ligne = dataGridViewMembres.CurrentCell.RowIndex;

                objet o = new objet();
                o.obj_nom = textBoxObjetNom.Text;
                o.obj_description = textBoxObjetDescription.Text;
                o.obj_level = (int)numericUpDownObjetLevel.Value;
                o.obj_quantite = (int)numericUpDownObjetQuantite.Value;
                o.obj_prix = (int)numericUpDownObjetPrix.Value;
                o.obj_hero_id = int.Parse(dataGridViewMembres.Rows[ligne].Cells[0].Value.ToString());

                guilde_des_herosEntities entite = new guilde_des_herosEntities();
                entite.objet.Add(o);
                entite.SaveChanges();

                RefreshSacoche((int)o.obj_hero_id);
                ViderLesChampsObjet();
                verouChampObjet(true);
                buttonAjouterObjet.Visible = false;
               
            }
            
        }

        private void buttonModifierObjet_Click(object sender, EventArgs e)
        {
            if (dataGridViewMembres.CurrentCell != null)
            {
                buttonValiderObjet.Visible = true;
                buttonSupprimerObjet.Enabled = false;
                buttonModifierObjet.Enabled = false;
                verouChampObjet(false);
            }

        }
        
        private void buttonValiderObjet_Click(object sender, EventArgs e)
        {
            if (dataGridViewSacoche.CurrentCell != null)
            {
                int ligne = dataGridViewSacoche.CurrentCell.RowIndex;

                guilde_des_herosEntities entite = new guilde_des_herosEntities();
                int idObjet = int.Parse(dataGridViewSacoche.Rows[ligne].Cells[0].Value.ToString());

                objet objetAModifier = entite.objet.Where(a => a.obj_id == idObjet).FirstOrDefault();


                objetAModifier.obj_nom = textBoxObjetNom.Text;
                objetAModifier.obj_description = textBoxObjetDescription.Text;
                objetAModifier.obj_level = (int)numericUpDownObjetLevel.Value;
                objetAModifier.obj_quantite = (int)numericUpDownObjetQuantite.Value;
                objetAModifier.obj_prix = (int)numericUpDownObjetPrix.Value;


                entite.objet.AddOrUpdate(objetAModifier);
                entite.SaveChanges();
                RefreshSacoche((int)objetAModifier.obj_hero_id);
                ViderLesChampsObjet();

                buttonValiderObjet.Visible = false;
            }
        }

        private void buttonSupprimerObjet_Click(object sender, EventArgs e)
        {
            if (dataGridViewSacoche.CurrentCell != null)
            {
                int ligne = dataGridViewSacoche.CurrentCell.RowIndex;

                guilde_des_herosEntities entite = new guilde_des_herosEntities();
                int idObjet = int.Parse(dataGridViewSacoche.Rows[ligne].Cells[0].Value.ToString());
                
                objet objetASupprimer = entite.objet.Where(a => a.obj_id == idObjet).FirstOrDefault();
                int idHero = (int)objetASupprimer.obj_hero_id;
                entite.objet.Remove(objetASupprimer);
                entite.SaveChanges();
                RefreshSacoche(idHero);
                ViderLesChampsObjet();
                buttonSupprimerObjet.Enabled = false;
                buttonModifierObjet.Enabled = false;
            }
        }

       








        private void RefreshHero()
        {
            dataGridViewMembres.DataSource = null;
            dataGridViewSacoche.DataSource = null;
            guilde_des_herosEntities entite = new guilde_des_herosEntities();
            List<hero> listeMembres = entite.hero.ToList();
            dataGridViewMembres.DataSource = listeMembres;

            if (dataGridViewMembres.DataSource != null)
            {
                // intitulé des colonnes
                dataGridViewMembres.Columns[0].HeaderText = "Id";
                dataGridViewMembres.Columns[1].HeaderText = "Nom";
                dataGridViewMembres.Columns[2].HeaderText = "Prénom";
                dataGridViewMembres.Columns[3].HeaderText = "Spécialité";
                dataGridViewMembres.Columns[4].HeaderText = "Classe";
                dataGridViewMembres.Columns[5].HeaderText = "Level";
                dataGridViewMembres.Columns[6].HeaderText = "Puissance";
                dataGridViewMembres.Columns[7].HeaderText = "Nombre de mission réussie";
                dataGridViewMembres.Columns[8].HeaderText = "Réputation";

                //largeur colonnes
                dataGridViewMembres.Columns[0].Width = 30;
                dataGridViewMembres.Columns[1].Width = 80;
                dataGridViewMembres.Columns[2].Width = 80;
                dataGridViewMembres.Columns[3].Width = 80;
                dataGridViewMembres.Columns[4].Width = 80;
                dataGridViewMembres.Columns[5].Width = 50;
                dataGridViewMembres.Columns[6].Width = 65;
                dataGridViewMembres.Columns[7].Width = 65;
                dataGridViewMembres.Columns[8].Width = 64;

                dataGridViewMembres.Columns[9].Visible = false;

            }
            verouChampHero(true);

        }

        private void RefreshSacoche(int idHero)
        {
            dataGridViewSacoche.DataSource = null;
            guilde_des_herosEntities entite = new guilde_des_herosEntities();
            List<objet> listeObjets = entite.objet.Where(a => a.obj_hero_id == idHero).ToList();
            dataGridViewSacoche.DataSource = listeObjets;


            if (dataGridViewSacoche.DataSource != null)
            {
                // intitulé des colonnes
                dataGridViewSacoche.Columns[0].HeaderText = "Id";
                dataGridViewSacoche.Columns[1].HeaderText = "Nom";
                dataGridViewSacoche.Columns[2].HeaderText = "Level";
                dataGridViewSacoche.Columns[3].HeaderText = "Quantité";
                dataGridViewSacoche.Columns[4].HeaderText = "Description";
                dataGridViewSacoche.Columns[5].HeaderText = "Prix";

                //largeur colonnes
                dataGridViewSacoche.Columns[0].Width = 30;
                dataGridViewSacoche.Columns[1].Width = 150;
                dataGridViewSacoche.Columns[2].Width = 51;
                dataGridViewSacoche.Columns[3].Width = 51;
                dataGridViewSacoche.Columns[4].Width = 260;
                dataGridViewSacoche.Columns[5].Width = 51;

                dataGridViewSacoche.Columns[6].Visible = false;
                dataGridViewSacoche.Columns[7].Visible = false;


                dataGridViewSacoche.Columns["obj_level"].DisplayIndex = 3;
                dataGridViewSacoche.Columns["obj_quantite"].DisplayIndex = 4;
                dataGridViewSacoche.Columns["obj_description"].DisplayIndex = 2;

            }
            verouChampObjet(true);
            buttonModifierObjet.Enabled = false;
            buttonSupprimerObjet.Enabled = false;
        }

        private void ViderLesChampsHero()
        {
            textBoxHeroNom.Text = "";
            textBoxHeroPrenom.Text = "";
            textBoxHeroSpecialite.Text = "";
            textBoxHeroClasse.Text = "";
            numericUpDownHeroLevel.Value = 0;
            numericUpDownHeroPuissance.Value = 0;
            numericUpDownHeroNbMission.Value = 0;
            numericUpDownHeroReputation.Value = 0;
        }

        private void ViderLesChampsObjet()
        {
            textBoxObjetNom.Text = "";
            textBoxObjetDescription.Text = "";
            numericUpDownObjetLevel.Value = 0;
            numericUpDownObjetQuantite.Value = 0;
            numericUpDownObjetPrix.Value = 0;
        }

        private void verouChampHero(Boolean verou)
        {
            textBoxHeroNom.Enabled = !verou;
            textBoxHeroPrenom.Enabled = !verou;
            textBoxHeroSpecialite.Enabled = !verou;
            textBoxHeroClasse.Enabled = !verou;
            numericUpDownHeroLevel.Enabled = !verou;
            numericUpDownHeroPuissance.Enabled = !verou;
            numericUpDownHeroNbMission.Enabled = !verou;
            numericUpDownHeroReputation.Enabled = !verou;

        }

        private void verouChampObjet(Boolean verou)
        {

            textBoxObjetNom.Enabled = !verou;
            textBoxObjetDescription.Enabled = !verou;
            numericUpDownObjetLevel.Enabled = !verou;
            numericUpDownObjetQuantite.Enabled = !verou;
            numericUpDownObjetPrix.Enabled = !verou;
           
        }

        private void actualiseChampHero()
        {
            if (dataGridViewMembres.CurrentCell != null)
            {
                int ligne = dataGridViewMembres.CurrentCell.RowIndex;

                textBoxHeroNom.Text = dataGridViewMembres.Rows[ligne].Cells[1].Value.ToString();
                textBoxHeroPrenom.Text = dataGridViewMembres.Rows[ligne].Cells[2].Value.ToString();
                textBoxHeroSpecialite.Text = dataGridViewMembres.Rows[ligne].Cells[3].Value.ToString();
                textBoxHeroClasse.Text = dataGridViewMembres.Rows[ligne].Cells[4].Value.ToString();
                numericUpDownHeroLevel.Value = decimal.Parse(dataGridViewMembres.Rows[ligne].Cells[5].Value.ToString());
                numericUpDownHeroPuissance.Value = decimal.Parse(dataGridViewMembres.Rows[ligne].Cells[6].Value.ToString());
                numericUpDownHeroNbMission.Value = decimal.Parse(dataGridViewMembres.Rows[ligne].Cells[7].Value.ToString());
                numericUpDownHeroReputation.Value = decimal.Parse(dataGridViewMembres.Rows[ligne].Cells[8].Value.ToString());


                ViderLesChampsObjet();
                verouChampHero(true);
                buttonAjoutHero.Visible = false;
                buttonValiderHero.Visible = false;
                buttonAjouterObjet.Visible = false;
                buttonValiderObjet.Visible = false;
                buttonSupprimerHero.Enabled = true;
                buttonModifierHero.Enabled = true;
                RefreshSacoche(int.Parse(dataGridViewMembres.Rows[ligne].Cells[0].Value.ToString()));

            }
        }

        private void actualiseChampObjet()
        {
            if (dataGridViewSacoche.CurrentCell != null)
            {

                int ligne = dataGridViewSacoche.CurrentCell.RowIndex;

                textBoxObjetNom.Text = dataGridViewSacoche.Rows[ligne].Cells[1].Value.ToString();
                textBoxObjetDescription.Text = dataGridViewSacoche.Rows[ligne].Cells[4].Value.ToString();
                numericUpDownObjetLevel.Value = decimal.Parse(dataGridViewSacoche.Rows[ligne].Cells[2].Value.ToString());
                numericUpDownObjetQuantite.Value = decimal.Parse(dataGridViewSacoche.Rows[ligne].Cells[3].Value.ToString());
                numericUpDownObjetPrix.Value = decimal.Parse(dataGridViewSacoche.Rows[ligne].Cells[5].Value.ToString());

                verouChampObjet(true);
                buttonAjouterObjet.Visible = false;
                buttonValiderObjet.Visible = false;
                buttonModifierObjet.Enabled = true;
                buttonSupprimerObjet.Enabled = true;
            }
        }

        private Boolean checkSaisieHero()
        {
            Boolean checkOk = true;

            if (textBoxHeroNom.Text.Length < 1)
            {
                checkOk = false;
                textBoxHeroNom.BackColor = Color.Red;
            }

            if (textBoxHeroPrenom.Text.Length < 1)
            {
                checkOk = false;
                textBoxHeroPrenom.BackColor = Color.Red;
            }

            if (textBoxHeroSpecialite.Text.Length < 1)
            {
                checkOk = false;
                textBoxHeroSpecialite.BackColor = Color.Red;
            }

            if (textBoxHeroClasse.Text.Length < 1)
            {
                checkOk = false;
                textBoxHeroClasse.BackColor = Color.Red;
            }

            if ((int)numericUpDownHeroLevel.Value < 1)
            {
                checkOk = false;
                numericUpDownHeroLevel.BackColor = Color.Red;
            }

            if ((int)numericUpDownHeroPuissance.Value < 1)
            {
                checkOk = false;
                numericUpDownHeroPuissance.BackColor = Color.Red;
            }


            guilde_des_herosEntities entite = new guilde_des_herosEntities();
            List<hero> listeMembres = entite.hero.ToList();

            foreach (hero membre in listeMembres)
            {

                if (membre.her_nom.Equals(textBoxHeroNom.Text) && membre.her_prenom.Equals(textBoxHeroPrenom.Text))
                {
                    checkOk = false;
                    textBoxHeroNom.BackColor = Color.Red;
                    textBoxHeroPrenom.BackColor = Color.Red;
                }

            }



            return checkOk;
        }

        private Boolean checkSaisieObjet()
        {
            Boolean checkOk = true;

            if (textBoxObjetNom.Text.Length < 1)
            {
                checkOk = false;
                textBoxObjetNom.BackColor = Color.Red;
            }

            if ((int)numericUpDownObjetLevel.Value < 1)
            {
                checkOk = false;
                numericUpDownObjetLevel.BackColor = Color.Red;
            }

            if ((int)numericUpDownObjetQuantite.Value < 1)
            {
                checkOk = false;
                numericUpDownObjetQuantite.BackColor = Color.Red;
            }

            if ((int)numericUpDownObjetPrix.Value < 1)
            {
                checkOk = false;
                numericUpDownObjetPrix.BackColor = Color.Red;
            }

            int idHero = int.Parse(dataGridViewMembres.CurrentRow.Cells[0].Value.ToString());

            guilde_des_herosEntities entite = new guilde_des_herosEntities();
            List<objet> listeObjets = entite.objet.Where(a => a.obj_hero_id == idHero).ToList();

            foreach (objet o in listeObjets)
            {

                if (o.obj_nom.Equals(textBoxObjetNom.Text))
                {
                    checkOk = false;
                    textBoxObjetNom.BackColor = Color.Red;
                }

            }

            return checkOk;
        }


    }
}
