using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Paw
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Tabel_Proiect' table. You can move, or remove it, as needed.
            tabel_ProiectTableAdapter.Fill(this.database1DataSet.Tabel_Proiect);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].XValueMember = "Denumire";
            chart1.Series[0].YValueMembers = "Denumire";

            //chart1.Series[1].XValueMember = "Cod";
            //chart1.Series[1].YValueMembers = "Cod";

            chart1.Series[2].XValueMember = "Cantitate";
            chart1.Series[2].YValueMembers = "Cantitate";

            chart1.Series[3].XValueMember = "Pret";
            chart1.Series[3].YValueMembers = "Pret";

            chart1.DataSource = database1DataSet.Tabel_Proiect;
            chart1.DataBind();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
