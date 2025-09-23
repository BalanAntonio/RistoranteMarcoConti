namespace RistoranteCarloConti
{
    partial class Visualizza
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
            this.lbl_nc = new System.Windows.Forms.Label();
            this.lbl_tavolo = new System.Windows.Forms.Label();
            this.lst_piatti = new System.Windows.Forms.ListBox();
            this.lbl_piattiordinati = new System.Windows.Forms.Label();
            this.lbl_prezzo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nc
            // 
            this.lbl_nc.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nc.Location = new System.Drawing.Point(12, 20);
            this.lbl_nc.Name = "lbl_nc";
            this.lbl_nc.Size = new System.Drawing.Size(329, 32);
            this.lbl_nc.TabIndex = 8;
            this.lbl_nc.Text = "Nome Cognome";
            this.lbl_nc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tavolo
            // 
            this.lbl_tavolo.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tavolo.Location = new System.Drawing.Point(12, 52);
            this.lbl_tavolo.Name = "lbl_tavolo";
            this.lbl_tavolo.Size = new System.Drawing.Size(329, 32);
            this.lbl_tavolo.TabIndex = 9;
            this.lbl_tavolo.Text = "Tavolo n. 67";
            this.lbl_tavolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lst_piatti
            // 
            this.lst_piatti.FormattingEnabled = true;
            this.lst_piatti.Location = new System.Drawing.Point(12, 108);
            this.lst_piatti.Name = "lst_piatti";
            this.lst_piatti.Size = new System.Drawing.Size(329, 316);
            this.lst_piatti.TabIndex = 10;
            // 
            // lbl_piattiordinati
            // 
            this.lbl_piattiordinati.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_piattiordinati.Location = new System.Drawing.Point(12, 84);
            this.lbl_piattiordinati.Name = "lbl_piattiordinati";
            this.lbl_piattiordinati.Size = new System.Drawing.Size(99, 21);
            this.lbl_piattiordinati.TabIndex = 11;
            this.lbl_piattiordinati.Text = "Piatti ordinati:";
            this.lbl_piattiordinati.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_prezzo
            // 
            this.lbl_prezzo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prezzo.Location = new System.Drawing.Point(193, 84);
            this.lbl_prezzo.Name = "lbl_prezzo";
            this.lbl_prezzo.Size = new System.Drawing.Size(148, 21);
            this.lbl_prezzo.TabIndex = 12;
            this.lbl_prezzo.Text = "Prezzo tot.";
            this.lbl_prezzo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Visualizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 438);
            this.Controls.Add(this.lbl_prezzo);
            this.Controls.Add(this.lbl_piattiordinati);
            this.Controls.Add(this.lst_piatti);
            this.Controls.Add(this.lbl_tavolo);
            this.Controls.Add(this.lbl_nc);
            this.Name = "Visualizza";
            this.Text = "Visualizza";
            this.Load += new System.EventHandler(this.Visualizza_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_nc;
        private System.Windows.Forms.Label lbl_tavolo;
        private System.Windows.Forms.ListBox lst_piatti;
        private System.Windows.Forms.Label lbl_piattiordinati;
        private System.Windows.Forms.Label lbl_prezzo;
    }
}