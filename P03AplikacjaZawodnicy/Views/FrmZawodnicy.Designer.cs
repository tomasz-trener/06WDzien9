
namespace P03AplikacjaZawodnicy.Views
{
    partial class FrmZawodnicy
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
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnKolumny = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataZatrudnieniaOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDataZatrudnieniaDo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.chbDataZatrudnieniaOd = new System.Windows.Forms.CheckBox();
            this.chbDataZatrudnieniaDo = new System.Windows.Forms.CheckBox();
            this.dgvDane = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDane)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(12, 45);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(252, 264);
            this.lbDane.TabIndex = 0;
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(12, 16);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(280, 45);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(280, 74);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnEdytuj.TabIndex = 3;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(280, 103);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 4;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnKolumny
            // 
            this.btnKolumny.Location = new System.Drawing.Point(280, 133);
            this.btnKolumny.Name = "btnKolumny";
            this.btnKolumny.Size = new System.Drawing.Size(75, 23);
            this.btnKolumny.TabIndex = 5;
            this.btnKolumny.Text = "Kolumny";
            this.btnKolumny.UseVisualStyleBackColor = true;
            this.btnKolumny.Click += new System.EventHandler(this.btnKolumny_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(280, 162);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(75, 23);
            this.btnPDF.TabIndex = 6;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(361, 45);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(277, 255);
            this.webBrowser1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zatrudniony od";
            // 
            // dtpDataZatrudnieniaOd
            // 
            this.dtpDataZatrudnieniaOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataZatrudnieniaOd.Location = new System.Drawing.Point(182, 15);
            this.dtpDataZatrudnieniaOd.Name = "dtpDataZatrudnieniaOd";
            this.dtpDataZatrudnieniaOd.Size = new System.Drawing.Size(116, 20);
            this.dtpDataZatrudnieniaOd.TabIndex = 1;
            // 
            // dtpDataZatrudnieniaDo
            // 
            this.dtpDataZatrudnieniaDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataZatrudnieniaDo.Location = new System.Drawing.Point(416, 14);
            this.dtpDataZatrudnieniaDo.Name = "dtpDataZatrudnieniaDo";
            this.dtpDataZatrudnieniaDo.Size = new System.Drawing.Size(116, 20);
            this.dtpDataZatrudnieniaDo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zatrudniony Do";
            // 
            // chbDataZatrudnieniaOd
            // 
            this.chbDataZatrudnieniaOd.AutoSize = true;
            this.chbDataZatrudnieniaOd.Location = new System.Drawing.Point(304, 18);
            this.chbDataZatrudnieniaOd.Name = "chbDataZatrudnieniaOd";
            this.chbDataZatrudnieniaOd.Size = new System.Drawing.Size(15, 14);
            this.chbDataZatrudnieniaOd.TabIndex = 4;
            this.chbDataZatrudnieniaOd.UseVisualStyleBackColor = true;
            // 
            // chbDataZatrudnieniaDo
            // 
            this.chbDataZatrudnieniaDo.AutoSize = true;
            this.chbDataZatrudnieniaDo.Location = new System.Drawing.Point(539, 19);
            this.chbDataZatrudnieniaDo.Name = "chbDataZatrudnieniaDo";
            this.chbDataZatrudnieniaDo.Size = new System.Drawing.Size(15, 14);
            this.chbDataZatrudnieniaDo.TabIndex = 5;
            this.chbDataZatrudnieniaDo.UseVisualStyleBackColor = true;
            // 
            // dgvDane
            // 
            this.dgvDane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDane.Location = new System.Drawing.Point(659, 45);
            this.dgvDane.Name = "dgvDane";
            this.dgvDane.Size = new System.Drawing.Size(382, 255);
            this.dgvDane.TabIndex = 8;
            // 
            // FrmZawodnicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 323);
            this.Controls.Add(this.dgvDane);
            this.Controls.Add(this.chbDataZatrudnieniaDo);
            this.Controls.Add(this.dtpDataZatrudnieniaDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbDataZatrudnieniaOd);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnKolumny);
            this.Controls.Add(this.dtpDataZatrudnieniaOd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lbDane);
            this.Name = "FrmZawodnicy";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnKolumny;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.CheckBox chbDataZatrudnieniaDo;
        private System.Windows.Forms.CheckBox chbDataZatrudnieniaOd;
        private System.Windows.Forms.DateTimePicker dtpDataZatrudnieniaDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataZatrudnieniaOd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDane;
    }
}

