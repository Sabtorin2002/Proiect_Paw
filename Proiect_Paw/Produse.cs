using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Paw
{
    internal class Produse : IComparable<Produse>, ICloneable, ICalculProfit
    {
        private string denumire;
        private int cod;
        private int cantitate;
        private float pret;
        private float taxe;

        public Produse()
        {
            denumire = "Necunoscuta";
            cod = 0;
            cantitate = 0;
            pret = 0;
        }

        public Produse(string denumire, int cod, int cantitate, float pret)
        {
            this.denumire = denumire;
            this.cod = cod;
            this.cantitate = cantitate;
            this.pret = pret;
        }

        public string Denumire
        {
            get { return denumire; }
            set { denumire = value; }
        }

        public int Cod
        {
            get { return cod; }
            set { cod = value;}
        }

        public int Cantitate
        {
            get { return cantitate; }
            set { cantitate = value; }
        }

        public float Pret
        { get { return pret; } 
          set {  pret = value; } 
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        //supraincarcare operator (< si >)
        public int CompareTo(object obj)
        {
            Produse p = (Produse)obj;
            if (this.pret !=p.pret)
            {
                return 1;
            }
            return this.pret.CompareTo(p.pret);
            
        }

        public static bool operator <(Produse p1, Produse p2)
        {
            return p1.CompareTo(p2)<0 ;
        }
        public static bool operator >(Produse p1, Produse p2)
        {
            return p1.CompareTo(p2) > 0;
        }

        //supraincarcare operator++
        public static Produse operator++(Produse p)
        {
            if (p.Pret < 1)
                p.pret++;
            return p;
        }

        public int CompareTo(Produse other)
        {
            throw new NotImplementedException();
        }
        //metode de prelucrare a datelor
        public float CalculProfit(float taxe)
        {
            return (cantitate * pret) - cantitate*taxe;
        }

        public override string ToString()
        {
            string mesajAfisare = "";
            mesajAfisare+="Produsul " + denumire + " are codul " + cod + " in numar de " + cantitate
                + " cu pretul " + pret ;
            return mesajAfisare;
        }
    }
}
