using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proiect_Paw
{
    public partial class Form1 : Form
    {   Transport t;
        Produse p;
        List<Transport> listaTransport= new List<Transport>();
        public Form1()
        {
            InitializeComponent();
            t = new Transport("Cargus");
            tbDenumire.Text = "Apa";
            tbCod.Text = "123";
            tbCantitate.Text = "6";
            tbPret.Text = "3.2";
            tbOras.Text = "Galati";
            tbMagazine.Text = "Kaufland,Lidl,Auchan";
            tbTaxeProdus.Text = "1.3";
            tbTaxeTransport.Text = "90";
            tbNrKM.Text = "250";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Se creeaza conexiunea la bd...");
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(@"Produse.xml");
            XmlNodeList xnList = xmlDocument.SelectNodes("/produse");
            foreach( XmlNode xn in xnList)
            {
                XmlNodeList xmlNodeList = xn.ChildNodes;
                foreach(XmlNode node in xmlNodeList)
                {
                    string denumire1 = node["denumire"].InnerText;
                    int cod1 = Convert.ToInt32(node["cod"].InnerText);
                    int cantitate1 = Convert.ToInt32(node["cantitate"].InnerText);
                    float pret1 = float.Parse(node["pret"].InnerText);

                    Produse p = new Produse(denumire1,cod1,cantitate1,pret1);
                    lbProduse.Items.Add(p.Denumire+p.Pret);
                    t.AdaugaProdus(p);
                }
            }

            ControlExtension.Draggable(btnDate, true);
            ControlExtension.Draggable(btnAfiseaza, true);
            ControlExtension.Draggable(btnCalculeaza, true);
            ControlExtension.Draggable(tbAfisareTot, true);

        }


        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            
            if(t!=null && p!=null)
            {   float sumaT = 0, sumaP=0, suma=0;
                float TaxeT= float.Parse(tbTaxeTransport.Text);
                float TaxeP = float.Parse(tbTaxeProdus.Text);
                sumaT=this.t.CalculProfit(TaxeT);
                sumaP=this.p.CalculProfit(TaxeP);
                suma = sumaT + sumaP;
                tbProfit.Text = Convert.ToString(suma);
            }
            else
            {
                MessageBox.Show("Introdu mai intai un set de date");
            }
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            try
            {
                string denumire = tbDenumire.Text;
                int cod = Convert.ToInt32(tbCod.Text);
                int cantitate = Convert.ToInt32(tbCantitate.Text);
                float pret = float.Parse(tbPret.Text);
                string oras = tbOras.Text;
                string[] magazine = tbMagazine.Text.Split(',');
                int nrKm = int.Parse(tbNrKM.Text);
                this.p = new Produse(denumire, cod, cantitate, pret);
                this.t = new Transport(oras, magazine, nrKm, denumire, cod, cantitate, pret);
                MessageBox.Show(t.ToString());
                this.listaTransport.Add(t);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            tbAfisareTot.Text = "";
            foreach(Transport tr in listaTransport)
            {
                tbAfisareTot.Text+= tr.ToString()+Environment.NewLine;
            }
           
                tbDenumire.Clear();
                tbCod.Clear();
                tbCantitate.Clear();
                tbPret.Clear();
                tbOras.Clear();
                tbMagazine.Clear();
                tbNrKM.Clear();
                tbProfit.Clear();
                tbTaxeProdus.Clear();
                tbTaxeTransport.Clear();

        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw= new StreamWriter(saveFileDialog1.FileName);
                foreach(Transport tr in listaTransport)
                {
                    sw.WriteLine(tr.ToString()+Environment.NewLine);
                }
                sw.Close();
                tbAfisareTot.Clear();
            }

        }

        private void restaurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr= new StreamReader(openFileDialog1.FileName);
                tbAfisareTot.Text+= sr.ReadToEnd();
                sr.Close();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Form4 f4 = new Form4();
                f4.Show();
        }

        private void lbProduse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbProduse.SelectedIndex;
            p = t.ListaProduse[index];
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Proiect PAW Toma Sabin-Sebastian ", 
                new Font("Times New Roman", 12,FontStyle.Regular),Brushes.Black, 
                new Point(10,10));
        }

        private void tbAfisareTot_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tbNumeControl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
