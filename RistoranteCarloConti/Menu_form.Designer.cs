namespace RistoranteCarloConti
{
    partial class Menu_form
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
            this.lst_menu = new System.Windows.Forms.ListBox();
            this.txt_cerca = new System.Windows.Forms.TextBox();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.btn_cerca = new System.Windows.Forms.Button();
            this.btn_aggiungi = new System.Windows.Forms.Button();
            this.lbl_ordina = new System.Windows.Forms.Label();
            this.txt_nomeOrdine = new System.Windows.Forms.TextBox();
            this.lst_ordini = new System.Windows.Forms.ListBox();
            this.btn_conferma = new System.Windows.Forms.Button();
            this.nmr_quantitaOrdine = new System.Windows.Forms.NumericUpDown();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_totale = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_quantitaOrdine)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_menu
            // 
            this.lst_menu.FormattingEnabled = true;
            this.lst_menu.Location = new System.Drawing.Point(12, 73);
            this.lst_menu.Name = "lst_menu";
            this.lst_menu.Size = new System.Drawing.Size(318, 368);
            this.lst_menu.TabIndex = 0;
            // 
            // txt_cerca
            // 
            this.txt_cerca.Font = new System.Drawing.Font("Calibri", 9F);
            this.txt_cerca.Location = new System.Drawing.Point(43, 44);
            this.txt_cerca.Name = "txt_cerca";
            this.txt_cerca.Size = new System.Drawing.Size(192, 22);
            this.txt_cerca.TabIndex = 1;
            this.txt_cerca.Text = "Cerca piatto...";
            this.txt_cerca.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txt_cerca_MouseUp);
            // 
            // lbl_menu
            // 
            this.lbl_menu.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.Location = new System.Drawing.Point(12, 9);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(318, 32);
            this.lbl_menu.TabIndex = 2;
            this.lbl_menu.Text = "Menù";
            this.lbl_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cerca
            // 
            this.btn_cerca.Font = new System.Drawing.Font("Calibri", 9F);
            this.btn_cerca.Location = new System.Drawing.Point(241, 44);
            this.btn_cerca.Name = "btn_cerca";
            this.btn_cerca.Size = new System.Drawing.Size(89, 23);
            this.btn_cerca.TabIndex = 3;
            this.btn_cerca.Text = "cerca";
            this.btn_cerca.UseVisualStyleBackColor = true;
            this.btn_cerca.Click += new System.EventHandler(this.btn_cerca_Click);
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.Font = new System.Drawing.Font("Calibri", 9F);
            this.btn_aggiungi.Location = new System.Drawing.Point(578, 44);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(89, 23);
            this.btn_aggiungi.TabIndex = 7;
            this.btn_aggiungi.Text = "aggiungi";
            this.btn_aggiungi.UseVisualStyleBackColor = true;
            this.btn_aggiungi.Click += new System.EventHandler(this.btn_aggiungi_Click);
            // 
            // lbl_ordina
            // 
            this.lbl_ordina.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ordina.Location = new System.Drawing.Point(349, 9);
            this.lbl_ordina.Name = "lbl_ordina";
            this.lbl_ordina.Size = new System.Drawing.Size(318, 32);
            this.lbl_ordina.TabIndex = 6;
            this.lbl_ordina.Text = "Ordina";
            this.lbl_ordina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nomeOrdine
            // 
            this.txt_nomeOrdine.Font = new System.Drawing.Font("Calibri", 9F);
            this.txt_nomeOrdine.Location = new System.Drawing.Point(349, 44);
            this.txt_nomeOrdine.Name = "txt_nomeOrdine";
            this.txt_nomeOrdine.Size = new System.Drawing.Size(171, 22);
            this.txt_nomeOrdine.TabIndex = 5;
            this.txt_nomeOrdine.Text = "Nome piatto...";
            this.txt_nomeOrdine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txt_nomeOrdine_MouseUp);
            // 
            // lst_ordini
            // 
            this.lst_ordini.FormattingEnabled = true;
            this.lst_ordini.Location = new System.Drawing.Point(349, 73);
            this.lst_ordini.Name = "lst_ordini";
            this.lst_ordini.Size = new System.Drawing.Size(318, 316);
            this.lst_ordini.TabIndex = 4;
            // 
            // btn_conferma
            // 
            this.btn_conferma.Font = new System.Drawing.Font("Calibri", 9F);
            this.btn_conferma.Location = new System.Drawing.Point(349, 421);
            this.btn_conferma.Name = "btn_conferma";
            this.btn_conferma.Size = new System.Drawing.Size(318, 23);
            this.btn_conferma.TabIndex = 8;
            this.btn_conferma.Text = "Conferma ordini";
            this.btn_conferma.UseVisualStyleBackColor = true;
            this.btn_conferma.Click += new System.EventHandler(this.btn_conferma_Click);
            // 
            // nmr_quantitaOrdine
            // 
            this.nmr_quantitaOrdine.Location = new System.Drawing.Point(526, 46);
            this.nmr_quantitaOrdine.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmr_quantitaOrdine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmr_quantitaOrdine.Name = "nmr_quantitaOrdine";
            this.nmr_quantitaOrdine.Size = new System.Drawing.Size(46, 20);
            this.nmr_quantitaOrdine.TabIndex = 9;
            this.nmr_quantitaOrdine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Calibri", 9F);
            this.txt_nome.Location = new System.Drawing.Point(349, 395);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(188, 22);
            this.txt_nome.TabIndex = 10;
            this.txt_nome.Text = "Nome e cognome...";
            this.txt_nome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txt_nome_MouseUp);
            // 
            // lbl_totale
            // 
            this.lbl_totale.Font = new System.Drawing.Font("Calibri", 9F);
            this.lbl_totale.Location = new System.Drawing.Point(543, 395);
            this.lbl_totale.Name = "lbl_totale";
            this.lbl_totale.Size = new System.Drawing.Size(124, 22);
            this.lbl_totale.TabIndex = 11;
            this.lbl_totale.Text = "Tot. 0 euro";
            this.lbl_totale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 9F);
            this.btn_refresh.Location = new System.Drawing.Point(12, 44);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(25, 23);
            this.btn_refresh.TabIndex = 12;
            this.btn_refresh.Text = "⟳";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.lbl_totale);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.nmr_quantitaOrdine);
            this.Controls.Add(this.btn_conferma);
            this.Controls.Add(this.btn_aggiungi);
            this.Controls.Add(this.lbl_ordina);
            this.Controls.Add(this.txt_nomeOrdine);
            this.Controls.Add(this.lst_ordini);
            this.Controls.Add(this.btn_cerca);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.txt_cerca);
            this.Controls.Add(this.lst_menu);
            this.Name = "Menu_form";
            this.Text = "Menu_form";
            this.Load += new System.EventHandler(this.Menu_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_quantitaOrdine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_menu;
        private System.Windows.Forms.TextBox txt_cerca;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Button btn_cerca;
        private System.Windows.Forms.Button btn_aggiungi;
        private System.Windows.Forms.Label lbl_ordina;
        private System.Windows.Forms.TextBox txt_nomeOrdine;
        private System.Windows.Forms.ListBox lst_ordini;
        private System.Windows.Forms.Button btn_conferma;
        private System.Windows.Forms.NumericUpDown nmr_quantitaOrdine;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_totale;
        private System.Windows.Forms.Button btn_refresh;
    }
}