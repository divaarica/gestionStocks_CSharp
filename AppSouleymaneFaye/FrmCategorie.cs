using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppSouleymaneFaye.Model;
using AppSouleymaneFaye.Util;

namespace AppSouleymaneFaye
{
    public partial class FrmCategorie : Form
    {
        BdKireneEntities db = new BdKireneEntities();
        public FrmCategorie()
        {
            InitializeComponent();
        }

        private void FrmCategorie_Load(object sender, EventArgs e)
        {
            dgCategorie.DataSource = db.Categorie.ToList();
        }

        private void resetForm()
        {
            txtCode.Text = string.Empty;
            txtLibelle.Text = string.Empty;
            dgCategorie.DataSource = db.Categorie.ToList();
            txtCode.Focus();
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Categorie c = new Categorie();
            c.Codecategorie = txtCode.Text;
            c.LibelleCategorie = txtLibelle.Text;
            db.Categorie.Add(c);
            db.SaveChanges();
            resetForm();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgCategorie.CurrentRow.Cells[0].Value.ToString());
            Categorie c = db.Categorie.Find(id);
            c.Codecategorie = txtCode.Text;
            c.LibelleCategorie = txtLibelle.Text;
            db.SaveChanges();
            resetForm();
        }



        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            //int? c'est juste pour prendre en compte le null et eviter le tryparse
            int? id = int.Parse(dgCategorie.CurrentRow.Cells[0].Value.ToString());
            Categorie c = db.Categorie.Find(id);
            db.Categorie.Remove(c);
            db.SaveChanges();
            resetForm();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtCode.Text = dgCategorie.CurrentRow.Cells[1].Value.ToString();
            txtLibelle.Text = dgCategorie.CurrentRow.Cells[2].Value.ToString();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLibelle_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValiderTextBox()
        {

            // Vérifier la première TextBox
            if (!CheckEnter.IsAlphaNumeric(txtCode.Text))
            {
                MessageBox.Show("Erreur : le code ne peux pas contenir de caracteres speciaux!.");
                return false;

            }
            else if (!CheckEnter.IsAlphaNumeric(txtLibelle.Text)) // Vérifier la deuxième TextBox
            {
                MessageBox.Show("Erreur : La designation ne peux pas contenir de caracteres speciaux.");
                return false;

            }
            else if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtLibelle.Text))
            {
                MessageBox.Show("Erreur : Tous les champs doivent être remplis.");
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
