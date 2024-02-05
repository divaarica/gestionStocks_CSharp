namespace AppSouleymaneFaye
{
    partial class FrmUtilisateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgUtilisateur = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbProfil = new System.Windows.Forms.ComboBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.bnChangerStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUtilisateur
            // 
            this.dgUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUtilisateur.Location = new System.Drawing.Point(277, 29);
            this.dgUtilisateur.Name = "dgUtilisateur";
            this.dgUtilisateur.Size = new System.Drawing.Size(319, 384);
            this.dgUtilisateur.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identifiant";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(30, 60);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(192, 24);
            this.txtIdentifiant.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Profil";
            // 
            // cbbProfil
            // 
            this.cbbProfil.FormattingEnabled = true;
            this.cbbProfil.Location = new System.Drawing.Point(30, 132);
            this.cbbProfil.Name = "cbbProfil";
            this.cbbProfil.Size = new System.Drawing.Size(192, 26);
            this.cbbProfil.TabIndex = 2;
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(30, 223);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(191, 33);
            this.btnCreer.TabIndex = 3;
            this.btnCreer.Text = "Creer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // bnChangerStatus
            // 
            this.bnChangerStatus.Location = new System.Drawing.Point(30, 271);
            this.bnChangerStatus.Name = "bnChangerStatus";
            this.bnChangerStatus.Size = new System.Drawing.Size(192, 30);
            this.bnChangerStatus.TabIndex = 4;
            this.bnChangerStatus.Text = "Changer Statut";
            this.bnChangerStatus.UseVisualStyleBackColor = true;
            // 
            // FrmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 425);
            this.ControlBox = false;
            this.Controls.Add(this.bnChangerStatus);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.cbbProfil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgUtilisateur);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUtilisateur";
            this.Text = "Utilisateur";
            this.Load += new System.EventHandler(this.FrmUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUtilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbProfil;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button bnChangerStatus;
    }
}