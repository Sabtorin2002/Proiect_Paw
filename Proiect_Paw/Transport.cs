using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Paw
{
    internal class Transport:Produse
    {
        private string oras;
        private string[] magazine;
        int nrKm;
        float taxe;
        private List<Produse> listaProduse;
        private TextBox tbDenumire;
        private string denumireTransport;

        public Transport(string oras, string[]magazine, int nrKm, string denumire, int cod, int cantitate,
           float pret):base(denumire, cod, cantitate, pret)
        {
            this.oras = oras;
            this.magazine = new string[magazine.Length];
            for(int i=0;i<magazine.Length; i++)
            {
                this.magazine[i] = magazine[i];
            }
            this.nrKm = nrKm;
            listaProduse=new List<Produse>();
        }
        public Transport(string denumireTrasnport)
        {
            this.denumireTransport = denumireTransport;
            this.listaProduse=new List<Produse>();
        }

        public List<Produse>ListaProduse
        {
            get { return listaProduse; }
            set { listaProduse = value; }
        }

        public Transport(TextBox tbDenumire)
        {
            this.tbDenumire = tbDenumire;
        }

        public void AdaugaProdus(Produse p)
        {
            listaProduse.Add(p);
        }

        public string Oras
        {
            get { return this.oras; }
            set { this.oras = value; }
        }

        public int NrKm
        {
            get { return this.nrKm; }
            set { this.nrKm = value; }
        }
        
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < magazine.Length)
                {
                    return magazine[index];
                }
                else
                {
                    return null;
                }
            }

            set
            {
                magazine[index] = value;
            }
        }

        public float CalculProfit(float taxe)
        {
            return (float)((nrKm * 1.69) - taxe);
        }

        public override string ToString()
        {
            string mesajAfisare = "";
            mesajAfisare+=base.ToString() + " a fost livrat in orasul " + oras + " in magazinele ";
            foreach(string denumire in magazine)
            {
                mesajAfisare += denumire + ", ";
            }
            mesajAfisare += " pe o distanta de " + nrKm + " KM.";
            return mesajAfisare;
        }
    }
}
