namespace AppSouleymaneFaye
{
    partial class FrmApprovisionnement
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.txtDatePeremption = new System.Windows.Forms.Label();
            this.txtDatePer = new System.Windows.Forms.DateTimePicker();
            this.dgAppro = new System.Windows.Forms.DataGridView();
            this.lblProduit = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantite";
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(32, 72);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(156, 24);
            this.txtQuantite.TabIndex = 1;
            // 
            // txtDatePeremption
            // 
            this.txtDatePeremption.AutoSize = true;
            this.txtDatePeremption.Location = new System.Drawing.Point(289, 51);
            this.txtDatePeremption.Name = "txtDatePeremption";
            this.txtDatePeremption.Size = new System.Drawing.Size(137, 18);
            this.txtDatePeremption.TabIndex = 2;
            this.txtDatePeremption.Text = "Date de peremption";
            // 
            // txtDatePer
            // 
            this.txtDatePer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDatePer.Location = new System.Drawing.Point(292, 72);
            this.txtDatePer.Name = "txtDatePer";
            this.txtDatePer.Size = new System.Drawing.Size(182, 24);
            this.txtDatePer.TabIndex = 4;
            // 
            // dgAppro
            // 
            this.dgAppro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAppro.Location = new System.Drawing.Point(33, 142);
            this.dgAppro.Name = "dgAppro";
            this.dgAppro.Size = new System.Drawing.Size(441, 338);
            this.dgAppro.TabIndex = 5;
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.ForeColor = System.Drawing.Color.DeepPink;
            this.lblProduit.Location = new System.Drawing.Point(30, 18);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(46, 18);
            this.lblProduit.TabIndex = 6;
            this.lblProduit.Text = "label2";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(33, 108);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(130, 28);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(183, 108);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(130, 28);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(333, 108);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(130, 28);
            this.btnFermer.TabIndex = 9;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FrmApprovisionnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 492);
            this.ControlBox = false;
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblProduit);
            this.Controls.Add(this.dgAppro);
            this.Controls.Add(this.txtDatePer);
            this.Controls.Add(this.txtDatePeremption);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmApprovisionnement";
            this.Text = "Approvisionnement";
            this.Load += new System.EventHandler(this.FrmApprovisionnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAppro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.Label txtDatePeremption;
        private System.Windows.Forms.DateTimePicker txtDatePer;
        private System.Windows.Forms.DataGridView dgAppro;
        private System.Windows.Forms.Label lblProduit;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnFermer;
    }
}