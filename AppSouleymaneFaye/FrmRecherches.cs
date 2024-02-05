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
    public partial class FrmRecherches : Form
    {
        public FrmRecherches()
        {
            InitializeComponent();
        }

        BdKireneEntities db = new BdKireneEntities();
        LoadComboBox load = new LoadComboBox();

        private void FrmRecherches_Load(object sender, EventArgs e)
        {
            /*cbbCategorie.DataSource = db.Categorie.ToList();
            cbbCategorie.DisplayMember = "LibelleCategorie";
            cbbCategorie.ValueMember = "Codecategorie";*/


            cbbCategorie.DataSource = load.LoadCategorie();
            cbbCategorie.DisplayMember = "Text";
            cbbCategorie.ValueMember = "Value";
        }

        private void btnRecherches_Click(object sender, EventArgs e)
        {
            var liste = db.VRechercheProduit.ToList();

            if (!string.IsNullOrEmpty(txtProduit.Text) )
            {
                liste=liste.Where(a=>a.DesignationProduit.ToLower().Contains(txtProduit.Text.ToLower())).ToList();

            }

            if (!string.IsNullOrEmpty(cbbCategorie.Text))
            {
                liste = liste.Where(a => a.Codecategorie.ToLower()==cbbCategorie.SelectedValue.ToString()).ToList();

            }

            if (!string.IsNullOrEmpty(txtPU.Text))
            {
                double p = double.Parse(txtPU.Text);
                liste = liste.Where(a => a.PU <= p).ToList();

            }

            dgRechercheProduit.DataSource = liste;
        }
    }
}
