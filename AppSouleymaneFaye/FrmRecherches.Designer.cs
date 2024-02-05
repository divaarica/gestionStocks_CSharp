namespace AppSouleymaneFaye
{
    partial class FrmRecherches
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
            this.dgRechercheProduit = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCategorie = new System.Windows.Forms.ComboBox();
            this.btnRecherches = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRechercheProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRechercheProduit
            // 
            this.dgRechercheProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRechercheProduit.Location = new System.Drawing.Point(19, 122);
            this.dgRechercheProduit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgRechercheProduit.Name = "dgRechercheProduit";
            this.dgRechercheProduit.Size = new System.Drawing.Size(784, 359);
            this.dgRechercheProduit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom Produit";
            // 
            // txtProduit
            // 
            this.txtProduit.Location = new System.Drawing.Point(20, 90);
            this.txtProduit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProduit.Name = "txtProduit";
            this.txtProduit.Size = new System.Drawing.Size(148, 24);
            this.txtProduit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categorie";
            // 
            // txtPU
            // 
            this.txtPU.Location = new System.Drawing.Point(432, 90);
            this.txtPU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(148, 24);
            this.txtPU.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prix unitaire";
            // 
            // cbbCategorie
            // 
            this.cbbCategorie.FormattingEnabled = true;
            this.cbbCategorie.Location = new System.Drawing.Point(226, 89);
            this.cbbCategorie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbCategorie.Name = "cbbCategorie";
            this.cbbCategorie.Size = new System.Drawing.Size(148, 26);
            this.cbbCategorie.TabIndex = 2;
            // 
            // btnRecherches
            // 
            this.btnRecherches.Location = new System.Drawing.Point(639, 89);
            this.btnRecherches.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecherches.Name = "btnRecherches";
            this.btnRecherches.Size = new System.Drawing.Size(148, 25);
            this.btnRecherches.TabIndex = 4;
            this.btnRecherches.Text = "&Rechercher";
            this.btnRecherches.UseVisualStyleBackColor = true;
            this.btnRecherches.Click += new System.EventHandler(this.btnRecherches_Click);
            // 
            // FrmRecherches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 494);
            this.ControlBox = false;
            this.Controls.Add(this.btnRecherches);
            this.Controls.Add(this.cbbCategorie);
            this.Controls.Add(this.txtPU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProduit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgRechercheProduit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRecherches";
            this.Text = "Recherche produit";
            this.Load += new System.EventHandler(this.FrmRecherches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRechercheProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRechercheProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbCategorie;
        private System.Windows.Forms.Button btnRecherches;
    }
}