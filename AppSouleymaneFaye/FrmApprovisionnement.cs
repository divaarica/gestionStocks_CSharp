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

namespace AppSouleymaneFaye
{
    public partial class FrmApprovisionnement : Form
    {
        public Produit produit;
        BdKireneEntities db = new BdKireneEntities();

        public FrmApprovisionnement()
        {
            InitializeComponent();
            txtDatePer.MinDate = DateTime.Today;
        }

        private void FrmApprovisionnement_Load(object sender, EventArgs e)
        {

            lblProduit.Text = produit.DesignationProduit;
            dgAppro.DataSource = db.ApprovisionnementBis.Where(a => a.CodeProduit == produit.CodeProduit && a.QteRestante > 0).OrderBy(a => a.DatePeremption).ToList();
            addOneMonth();
            txtQuantite.Focus();

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void resetForm()
        {
            txtDatePer.Value = DateTime.Now;
            txtQuantite.Text = String.Empty;
            dgAppro.DataSource = db.ApprovisionnementBis.Where(a => a.CodeProduit == produit.CodeProduit && a.QteRestante > 0).OrderBy(a => a.DatePeremption).ToList();
            addOneMonth();
            txtQuantite.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ApprovisionnementBis a = new ApprovisionnementBis();
            if( int.Parse(txtQuantite.Text) > 0)
            {
                a.QteAppro = int.Parse(txtQuantite.Text);
                a.DatePeremption = txtDatePer.Value;
                a.QteRestante = int.Parse(txtQuantite.Text);
                a.DateAppro = DateTime.Now.Date;
                a.CodeProduit = produit.CodeProduit;
                db.ApprovisionnementBis.Add(a);
                db.SaveChanges();
                resetForm();
            }
            else
            {
                MessageBox.Show("La quantite approvisionner ne peuut pas etre inferieur a 1");
            }
           

        }


        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgAppro.CurrentRow.Cells[0].Value.ToString());
            ApprovisionnementBis a = db.ApprovisionnementBis.Find(id);
            db.ApprovisionnementBis.Remove(a);
            db.SaveChanges();
            resetForm();
        }

        private void addOneMonth()
        {
            DateTime limite = DateTime.Now.AddMonths(1);

            foreach (DataGridViewRow row in dgAppro.Rows)
            {
                //databound item renvoie l'objet de données auquel la ligne est liée , ici le produit
                // as approvisonement , on tente de convertir l'objet associé à la ligne en un objet de type ApprovisionnementBis.
                ApprovisionnementBis appro = row.DataBoundItem as ApprovisionnementBis;

                if (appro != null && appro.DatePeremption <= limite)
                {
                    // Mettre en rouge le texte en rouge
                    //row.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    // Mettre en rouge la ligen en rouge
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}
