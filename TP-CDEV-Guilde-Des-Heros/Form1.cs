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
        }
            

        private void RefreshHero()
        {
            dataGridViewMembres.DataSource = null;
            dataGridViewSacoche.DataSource = null;
            guilde_des_herosEntities entite = new guilde_des_herosEntities();
            List<hero> listeMembres = entite.hero.ToList();
            dataGridViewMembres.DataSource = listeMembres;
            //dataGridViewMembres.Columns["objet"].Width = 0;
            //dataGridViewMembres.Columns["her_id"].Width = 0;

        }

        private void RefreshSacoche(int idHero)
        {
            dataGridViewSacoche.DataSource = null;
            guilde_des_herosEntities entite = new guilde_des_herosEntities();
            List<objet> listeObjets = entite.objet.Where(a=>a.obj_hero_id == idHero).ToList();
            dataGridViewSacoche.DataSource = listeObjets;
            //dataGridViewMembres.Columns["obj_id"].Width = 0;
            //dataGridViewMembres.Columns["obj_hero_id"].Width = 0;
            //dataGridViewMembres.Columns["hero"].Width = 0;
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



        private void buttonAjoutHero_Click(object sender, EventArgs e)
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
        }

        private void buttonModifierHero_Click(object sender, EventArgs e)
        {
            if (dataGridViewMembres.CurrentCell != null)
            {
                int ligne = dataGridViewMembres.CurrentCell.RowIndex;

            //}
            

            //if (dataGridViewMembres.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            //{
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
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridViewMembres.CurrentCell != null)
            {
                int ligne = dataGridViewMembres.CurrentCell.RowIndex;
            //    if (dataGridViewMembres.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            //{
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
            }

        }

        private void dataGridViewMembres_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMembres.CurrentCell != null)
            {
                int ligne = dataGridViewMembres.CurrentCell.RowIndex;
                //    if (dataGridViewMembres.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                //{

                textBoxHeroNom.Text = dataGridViewMembres.Rows[ligne].Cells[1].Value.ToString();
                textBoxHeroPrenom.Text = dataGridViewMembres.Rows[ligne].Cells[2].Value.ToString();
                textBoxHeroSpecialite.Text = dataGridViewMembres.Rows[ligne].Cells[3].Value.ToString();
                textBoxHeroClasse.Text = dataGridViewMembres.Rows[ligne].Cells[4].Value.ToString();
                numericUpDownHeroLevel.Value = decimal.Parse(dataGridViewMembres.Rows[ligne].Cells[5].Value.ToString());
                numericUpDownHeroPuissance.Value = decimal.Parse(dataGridViewMembres.Rows[ligne].Cells[6].Value.ToString());
                numericUpDownHeroNbMission.Value = decimal.Parse(dataGridViewMembres.Rows[ligne].Cells[7].Value.ToString());
                numericUpDownHeroReputation.Value = decimal.Parse(dataGridViewMembres.Rows[ligne].Cells[8].Value.ToString());


                ViderLesChampsObjet();
                RefreshSacoche(int.Parse(dataGridViewMembres.Rows[ligne].Cells[0].Value.ToString()));

            }
        }

        private void buttonAjouterObjet_Click(object sender, EventArgs e)
        {
            if (dataGridViewMembres.CurrentCell != null)
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

            }
            
        }

        private void buttonModifierObjet_Click(object sender, EventArgs e)
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
            }
        }

       

        private void dataGridViewSacoche_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSacoche.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {

                textBoxObjetNom.Text = dataGridViewSacoche.SelectedRows[0].Cells[1].Value.ToString();
                textBoxObjetDescription.Text = dataGridViewSacoche.SelectedRows[0].Cells[4].Value.ToString();
                numericUpDownObjetLevel.Value = decimal.Parse(dataGridViewSacoche.SelectedRows[0].Cells[2].Value.ToString());
                numericUpDownObjetQuantite.Value = decimal.Parse(dataGridViewSacoche.SelectedRows[0].Cells[3].Value.ToString());
                numericUpDownObjetPrix.Value = decimal.Parse(dataGridViewSacoche.SelectedRows[0].Cells[5].Value.ToString());
               
            }
        }

      

        private void dataGridViewMembres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(dataGridViewMembres.CurrentCell!=null)
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
                RefreshSacoche(int.Parse(dataGridViewMembres.Rows[ligne].Cells[0].Value.ToString()));
            }

            
        }

        private void dataGridViewSacoche_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ligne = dataGridViewSacoche.CurrentCell.RowIndex;

            textBoxObjetNom.Text = dataGridViewSacoche.Rows[ligne].Cells[1].Value.ToString();
            textBoxObjetDescription.Text = dataGridViewSacoche.Rows[ligne].Cells[4].Value.ToString();
            numericUpDownObjetLevel.Value = decimal.Parse(dataGridViewSacoche.Rows[ligne].Cells[2].Value.ToString());
            numericUpDownObjetQuantite.Value = decimal.Parse(dataGridViewSacoche.Rows[ligne].Cells[3].Value.ToString());
            numericUpDownObjetPrix.Value = decimal.Parse(dataGridViewSacoche.Rows[ligne].Cells[5].Value.ToString());
        }

    }
}
