namespace Proiect_Paw
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.tbOras = new System.Windows.Forms.TextBox();
            this.tbMagazine = new System.Windows.Forms.TextBox();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbProfit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTaxeProdus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTaxeTransport = new System.Windows.Forms.TextBox();
            this.tbAfisareTot = new System.Windows.Forms.TextBox();
            this.btnDate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNrKM = new System.Windows.Forms.TextBox();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.lbProduse = new System.Windows.Forms.ListBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.tabel_ProiectTableAdapter1 = new Proiect_Paw.Database1DataSetTableAdapters.Tabel_ProiectTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denumire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantitate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Oras";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Magazine";
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(99, 24);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(100, 22);
            this.tbDenumire.TabIndex = 6;
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(99, 61);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(100, 22);
            this.tbCod.TabIndex = 7;
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(99, 95);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(100, 22);
            this.tbPret.TabIndex = 8;
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(99, 127);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(100, 22);
            this.tbCantitate.TabIndex = 9;
            // 
            // tbOras
            // 
            this.tbOras.Location = new System.Drawing.Point(99, 170);
            this.tbOras.Name = "tbOras";
            this.tbOras.Size = new System.Drawing.Size(100, 22);
            this.tbOras.TabIndex = 10;
            // 
            // tbMagazine
            // 
            this.tbMagazine.Location = new System.Drawing.Point(99, 218);
            this.tbMagazine.Multiline = true;
            this.tbMagazine.Name = "tbMagazine";
            this.tbMagazine.Size = new System.Drawing.Size(100, 54);
            this.tbMagazine.TabIndex = 11;
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.Location = new System.Drawing.Point(248, 283);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(138, 35);
            this.btnCalculeaza.TabIndex = 12;
            this.btnCalculeaza.Text = "Calculeaza";
            this.btnCalculeaza.UseVisualStyleBackColor = true;
            this.btnCalculeaza.Click += new System.EventHandler(this.btnCalculeaza_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Profit";
            // 
            // tbProfit
            // 
            this.tbProfit.Location = new System.Drawing.Point(99, 292);
            this.tbProfit.Name = "tbProfit";
            this.tbProfit.Size = new System.Drawing.Size(100, 22);
            this.tbProfit.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "TaxeProdus";
            // 
            // tbTaxeProdus
            // 
            this.tbTaxeProdus.Location = new System.Drawing.Point(99, 336);
            this.tbTaxeProdus.Name = "tbTaxeProdus";
            this.tbTaxeProdus.Size = new System.Drawing.Size(100, 22);
            this.tbTaxeProdus.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "TaxeTransport";
            // 
            // tbTaxeTransport
            // 
            this.tbTaxeTransport.Location = new System.Drawing.Point(99, 372);
            this.tbTaxeTransport.Name = "tbTaxeTransport";
            this.tbTaxeTransport.Size = new System.Drawing.Size(100, 22);
            this.tbTaxeTransport.TabIndex = 18;
            // 
            // tbAfisareTot
            // 
            this.tbAfisareTot.Location = new System.Drawing.Point(392, 24);
            this.tbAfisareTot.Multiline = true;
            this.tbAfisareTot.Name = "tbAfisareTot";
            this.tbAfisareTot.ReadOnly = true;
            this.tbAfisareTot.Size = new System.Drawing.Size(316, 239);
            this.tbAfisareTot.TabIndex = 19;
            this.tbAfisareTot.TextChanged += new System.EventHandler(this.tbAfisareTot_TextChanged);
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(248, 55);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(138, 35);
            this.btnDate.TabIndex = 20;
            this.btnDate.Text = "Adauga date";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Numar KM";
            // 
            // tbNrKM
            // 
            this.tbNrKM.Location = new System.Drawing.Point(99, 414);
            this.tbNrKM.Name = "tbNrKM";
            this.tbNrKM.Size = new System.Drawing.Size(100, 22);
            this.tbNrKM.TabIndex = 22;
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(248, 114);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(138, 35);
            this.btnAfiseaza.TabIndex = 23;
            this.btnAfiseaza.Text = "Afiseaza transporturi";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierTXTToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // fisierTXTToolStripMenuItem
            // 
            this.fisierTXTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem,
            this.restaurareToolStripMenuItem});
            this.fisierTXTToolStripMenuItem.Name = "fisierTXTToolStripMenuItem";
            this.fisierTXTToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.fisierTXTToolStripMenuItem.Text = "Fisier TXT";
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // restaurareToolStripMenuItem
            // 
            this.restaurareToolStripMenuItem.Name = "restaurareToolStripMenuItem";
            this.restaurareToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.restaurareToolStripMenuItem.Text = "Restaurare";
            this.restaurareToolStripMenuItem.Click += new System.EventHandler(this.restaurareToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 25;
            this.button1.Text = "--->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbProduse
            // 
            this.lbProduse.FormattingEnabled = true;
            this.lbProduse.ItemHeight = 16;
            this.lbProduse.Location = new System.Drawing.Point(393, 270);
            this.lbProduse.Name = "lbProduse";
            this.lbProduse.Size = new System.Drawing.Size(315, 116);
            this.lbProduse.TabIndex = 26;
            this.lbProduse.SelectedIndexChanged += new System.EventHandler(this.lbProduse_SelectedIndexChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 34);
            this.button2.TabIndex = 27;
            this.button2.Text = "Imprimare document";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabel_ProiectTableAdapter1
            // 
            this.tabel_ProiectTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbProduse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.tbNrKM);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.tbAfisareTot);
            this.Controls.Add(this.tbTaxeTransport);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbTaxeProdus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbProfit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalculeaza);
            this.Controls.Add(this.tbMagazine);
            this.Controls.Add(this.tbOras);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.TextBox tbOras;
        private System.Windows.Forms.TextBox tbMagazine;
        private System.Windows.Forms.Button btnCalculeaza;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbProfit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTaxeProdus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTaxeTransport;
        private System.Windows.Forms.TextBox tbAfisareTot;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNrKM;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierTXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbProduse;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button2;
        private Database1DataSetTableAdapters.Tabel_ProiectTableAdapter tabel_ProiectTableAdapter1;
    }
}

