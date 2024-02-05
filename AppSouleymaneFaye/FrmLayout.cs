using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace AppSouleymaneFaye
{
    public partial class FrmLayout : Form
    {
        public FrmLayout()
        {
            InitializeComponent();
        }

        private void fermer()
        {
            Form[] charr = this.MdiChildren;

            //For each child form set the window state to Maximized 
            foreach (Form chform in charr)
            {
                //chform.WindowState = FormWindowState.Maximized;
                chform.Close();
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLayout_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConnexion f = new FrmConnexion();
            f.Show();
            this.Close();

        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            FrmCategorie f = new FrmCategorie();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            FrmProduit f = new FrmProduit();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void rechercheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            FrmRecherches f = new FrmRecherches();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;

        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            FrmUtilisateur f = new FrmUtilisateur();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }
    }
}
