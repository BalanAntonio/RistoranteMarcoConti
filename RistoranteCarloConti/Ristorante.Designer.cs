namespace RistoranteCarloConti
{
    partial class Ristorante
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_piazza = new System.Windows.Forms.Button();
            this.lst_ordini = new System.Windows.Forms.ListBox();
            this.lbl_ordini = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_piazza
            // 
            this.btn_piazza.Location = new System.Drawing.Point(12, 301);
            this.btn_piazza.Name = "btn_piazza";
            this.btn_piazza.Size = new System.Drawing.Size(324, 23);
            this.btn_piazza.TabIndex = 0;
            this.btn_piazza.Text = "Piazza ordine";
            this.btn_piazza.UseVisualStyleBackColor = true;
            this.btn_piazza.Click += new System.EventHandler(this.button1_Click);
            // 
            // lst_ordini
            // 
            this.lst_ordini.FormattingEnabled = true;
            this.lst_ordini.Location = new System.Drawing.Point(12, 44);
            this.lst_ordini.Name = "lst_ordini";
            this.lst_ordini.Size = new System.Drawing.Size(324, 251);
            this.lst_ordini.TabIndex = 1;
            this.lst_ordini.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_ordini_MouseDoubleClick);
            // 
            // lbl_ordini
            // 
            this.lbl_ordini.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ordini.Location = new System.Drawing.Point(12, 9);
            this.lbl_ordini.Name = "lbl_ordini";
            this.lbl_ordini.Size = new System.Drawing.Size(324, 32);
            this.lbl_ordini.TabIndex = 7;
            this.lbl_ordini.Text = "Ordini";
            this.lbl_ordini.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ristorante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 330);
            this.Controls.Add(this.lbl_ordini);
            this.Controls.Add(this.lst_ordini);
            this.Controls.Add(this.btn_piazza);
            this.Name = "Ristorante";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ristorante_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_piazza;
        private System.Windows.Forms.ListBox lst_ordini;
        private System.Windows.Forms.Label lbl_ordini;
    }
}

