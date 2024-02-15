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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = tbNumeControl.Text;
            string text2 = tbParolaControl.Text;

            if (text1 == "Sabin" && text2 == "230802")
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
            else
            {
                MessageBox.Show("Username sau parola gresita!");
            }
        }
    }
}
