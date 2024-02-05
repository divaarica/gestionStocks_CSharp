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
using AppSouleymaneFaye.Report;

namespace AppSouleymaneFaye
{
    public partial class FrmPrintProduit : Form
    {
        BdKireneEntities db = new BdKireneEntities();

        public FrmPrintProduit()
        {
            InitializeComponent();
        }

        private void FrmPrintProduit_Load(object sender, EventArgs e)
        {

            rptListeProduit objRpt = new rptListeProduit();
            objRpt.SetDataSource(GetTableProduit());
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
           
        }

        public DataTable GetTableProduit()
        {
            DataTable table = new DataTable();
            table.Columns.Add("CodeProduit", typeof(string));
            table.Columns.Add("DesignationProduit", typeof(string));
            table.Columns.Add("PU", typeof(double));
            table.Columns.Add("QteMin", typeof(int));
            table.Columns.Add("QteCri", typeof(int));
            table.Columns.Add("Categorie", typeof(string));

            var liste = db.Produit.ToList();
            foreach (var item in liste)
            {
                string cat = db.Categorie.Where(a => a.Codecategorie == item.CodeCategorie).FirstOrDefault().LibelleCategorie;
                table.Rows.Add(item.CodeProduit, item.DesignationProduit, item.PU, item.QteMin, item.QteCri, cat);
            }

            return table;

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
