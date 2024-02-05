using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppSouleymaneFaye.Model;
using AppSouleymaneFaye.Util;

namespace AppSouleymaneFaye
{
    public partial class FrmUtilisateur : Form
    {
        public FrmUtilisateur()
        {
            InitializeComponent();
        }

        BdKireneEntities db = new BdKireneEntities();
        LoadComboBox load = new LoadComboBox();

        private void FrmUtilisateur_Load(object sender, EventArgs e)
        {
            dgUtilisateur.DataSource = db.Utilisateur.Select(x => new {x.idUt, x.identifiantUt, x.codeProfil}).ToList();
            cbbProfil.DataSource = load.LoadProfil();
            cbbProfil.DisplayMember = "Text";
            cbbProfil.ValueMember = "Value";
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            using(MD5 md5Hash = MD5.Create())
            {
                Utilisateur ut = new Utilisateur();
                ut.identifiantUt = txtIdentifiant.Text;
                ut.motDePasse = Crypt.GetMd5Hash(md5Hash, "passer123");
                ut.codeProfil = cbbProfil.SelectedValue.ToString();
                db.Utilisateur.Add(ut);
                db.SaveChanges();
                resetForm();
            }
        }

        private void resetForm()
        {
            txtIdentifiant.Text = string.Empty;
            dgUtilisateur.DataSource = db.Utilisateur.Select(x => new { x.idUt, x.identifiantUt, x.codeProfil }).ToList();
            cbbProfil.DataSource = load.LoadProfil();
            cbbProfil.DisplayMember = "Text";
            cbbProfil.ValueMember = "Value";
            txtIdentifiant.Focus();

        }
    }
}
