using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppSouleymaneFaye.Model;
using AppSouleymaneFaye.Util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppSouleymaneFaye
{
    public partial class FrmProduit : Form
    {
        BdKireneEntities db = new BdKireneEntities();
        LoadComboBox load = new LoadComboBox();

        public FrmProduit()
        {
            InitializeComponent();
        }


        private void FrmProduit_Load(object sender, EventArgs e)
        {

            dgProduit.DataSource = db.Produit.ToList();//chargement de la gridviews ouu il y aura toute les produits liste 
            /*cbbCategorie.DataSource=db.Categorie.ToList();
            cbbCategorie.ValueMember = "Codecategorie";
            cbbCategorie.DisplayMember = "LibelleCategorie";*/
            //where appro.DatePeremption >= DateTime.Now &&
            //addOneMonth();

            cbbCategorie.DataSource = load.LoadCategorie();
            cbbCategorie.ValueMember = "Value";
            cbbCategorie.DisplayMember = "Text";

        }

        private void resetForm()
        {
            txtCode.Text = string.Empty;
            txtDesignation.Text = string.Empty;
            txtPU.Text = string.Empty;
            txtQteMin.Text = string.Empty;
            txtQteCri.Text = string.Empty;
            dgProduit.DataSource = db.Produit.ToList();//chargement de la gridviews ouu il y aura toute les produits liste 
            cbbCategorie.DataSource = load.LoadCategorie();
            cbbCategorie.ValueMember = "Value";
            cbbCategorie.DisplayMember = "Text";
            //addOneMonth();
            txtCode.Focus();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            if (ValiderTextBox())
            {
                Produit p = new Produit();
                p.CodeProduit = txtCode.Text;
                p.DesignationProduit = txtDesignation.Text;
                p.PU = float.Parse(txtPU.Text);
                //p.PU = CheckEnter.checkIsFloat(txtPU.Text) ? float.Parse(txtPU.Text) : 0;
                p.QteMin = int.Parse(txtQteMin.Text);
                p.QteCri = int.Parse(txtQteCri.Text);
                p.CodeCategorie = cbbCategorie.SelectedValue.ToString();
                db.Produit.Add(p);
                db.SaveChanges();
                resetForm();
            }

        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            txtCode.Text = dgProduit.CurrentRow.Cells[1].Value.ToString();
            txtDesignation.Text = dgProduit.CurrentRow.Cells[2].Value.ToString();
            txtPU.Text = dgProduit.CurrentRow.Cells[3].Value.ToString();
            txtQteMin.Text = dgProduit.CurrentRow.Cells[4].Value.ToString();
            txtQteCri.Text = dgProduit.CurrentRow.Cells[5].Value.ToString();
            cbbCategorie.SelectedValue = dgProduit.CurrentRow.Cells[6].Value;

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            if (ValiderTextBox())
            {
                int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
                Produit p = db.Produit.Find(id);
                //ou
                //db.Produit.Where(a=>a.IdProduit==id).FirstOrDefault();
                p.CodeProduit = txtCode.Text;
                p.DesignationProduit = txtDesignation.Text;
                p.PU = float.Parse(txtPU.Text);
                p.QteMin = int.Parse(txtQteMin.Text);
                p.QteCri = int.Parse(txtQteCri.Text);
                p.CodeCategorie = cbbCategorie.SelectedValue.ToString(); ;
                db.SaveChanges();
                resetForm();

            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            Produit p = db.Produit.Find(id);
            db.Produit.Remove(p);
            db.SaveChanges();
            resetForm();
        }


        private void btnAppro_Click(object sender, EventArgs e)
        {

            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            FrmApprovisionnement f = new FrmApprovisionnement();
            f.produit = db.Produit.Find(id); //on affecte le produit declarer dans le cs du frmAppro
            f.FormClosing += (senderForm, eForm) => this.Enabled = true;
            f.ShowDialog();
            this.Enabled = false;


        }

        private void addOneMonth()
        {
            DateTime limite = DateTime.Now.AddMonths(1);

            foreach (DataGridViewRow row in dgProduit.Rows)
            {
                MessageBox.Show("ok");
                row.DefaultCellStyle.BackColor = Color.Red;
            }
            
        }

        private bool ValiderTextBox()
        {

            // Vérifier la première TextBox
            if (!CheckEnter.IsAlphaNumeric(txtCode.Text))
            {
                MessageBox.Show("Erreur : le code ne peux pas contenir de caracteres speciaux!.");
                return false;

            }
            else if (!CheckEnter.IsAlphaNumeric(txtDesignation.Text)) // Vérifier la deuxième TextBox
            {
                MessageBox.Show("Erreur : La designation ne peux pas contenir de caracteres speciaux.");
                return false;

            }
            else if (!CheckEnter.checkIsNumber(txtPU.Text)) // Vérifier la troisième TextBox
            {
                MessageBox.Show("Erreur : le prix unitaire doit etre un nombre entier");
                return false;

            }
            else if (!CheckEnter.checkIsNumber(txtQteMin.Text))
            {
                MessageBox.Show("Erreur : la quantite minimale doit etre un nombre entier");
                return false;
            }
            else if (!CheckEnter.checkIsNumber(txtQteCri.Text))
            {
                MessageBox.Show("Erreur : la quantite critique doit etre un nombre entier");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtDesignation.Text) || string.IsNullOrWhiteSpace(txtPU.Text) || string.IsNullOrWhiteSpace(txtQteMin.Text) || string.IsNullOrWhiteSpace(txtQteCri.Text))
            {
                MessageBox.Show("Erreur : Tous les champs doivent être remplis.");
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            FrmPrintProduit f = new FrmPrintProduit();
            f.FormClosing += (senderForm, eForm) => this.Enabled = true;
            f.Show();
            this.Enabled = false;
        }

        /* private void dgProduit_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
         {
             foreach (DataGridViewRow row in dgProduit.Rows)
             {
                 //int? id = int.Parse(row.Cells[0].Value.ToString());
                 //Produit produit = db.Produit.Find(id); 
                 string CodeProduit = row.Cells[1].Value.ToString();
                 ApprovisionnementBis appro = db.ApprovisionnementBis.Where(a => a.CodeProduit == CodeProduit).FirstOrDefault();

                 if (appro != null)

                 {

                     if (Convert.ToInt64(row.Cells[4].Value) <= appro.QteRestante)
                     {
                         MessageBox.Show("ok");
                         row.DefaultCellStyle.BackColor = Color.Red;
                         row.DefaultCellStyle.ForeColor = Color.White;
                     }
                 }
             }
         }*/


    }

}
