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
            this.btn_aggiungi = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_ordina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.Location = new System.Drawing.Point(12, 366);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(324, 23);
            this.btn_aggiungi.TabIndex = 0;
            this.btn_aggiungi.Text = "Piazza ordine";
            this.btn_aggiungi.UseVisualStyleBackColor = true;
            this.btn_aggiungi.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(324, 316);
            this.listBox1.TabIndex = 1;
            // 
            // lbl_ordina
            // 
            this.lbl_ordina.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ordina.Location = new System.Drawing.Point(12, 9);
            this.lbl_ordina.Name = "lbl_ordina";
            this.lbl_ordina.Size = new System.Drawing.Size(324, 32);
            this.lbl_ordina.TabIndex = 7;
            this.lbl_ordina.Text = "Ordini";
            this.lbl_ordina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ristorante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 398);
            this.Controls.Add(this.lbl_ordina);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_aggiungi);
            this.Name = "Ristorante";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_aggiungi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_ordina;
    }
}

