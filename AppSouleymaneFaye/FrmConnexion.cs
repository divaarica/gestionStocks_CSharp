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
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }

        BdKireneEntities db = new BdKireneEntities();

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            var leUser = db.Utilisateur.Where(a => a.identifiantUt == txtId.Text).FirstOrDefault();
            if(leUser != null)
            {
                string hash = leUser.motDePasse;
                using(MD5 md5hash = MD5.Create())
                {
                    if (Crypt.VerifyMd5Hash(md5hash, txtMdp.Text, hash))
                    {
                        FrmLayout f = new FrmLayout();
                        f.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Identifint ou mot de passe incorrect");
                    }
                }
            }
            else
            {
                MessageBox.Show("Identifint ou mot de passe incorrect");
            }

           

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
