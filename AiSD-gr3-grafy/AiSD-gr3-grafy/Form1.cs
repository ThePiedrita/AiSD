using Accessibility;
using System.Net.Http.Headers;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;

namespace AiSD_gr3_grafy
{
    public partial class Form1 : Form
    {
        string napis = "";
        List<W�ze�2> odwiedzone = new List<W�ze�2>();
        //List<W�ze�2> queue = new List<W�ze�2>();
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var w0 = new W�ze�4(0);
            var w1 = new W�ze�4(1);
            var w2 = new W�ze�4(2);
            var w3 = new W�ze�4(3);
            var w4 = new W�ze�4(4);
            var w5 = new W�ze�4(5);
            var w6 = new W�ze�4(6);
            var w7 = new W�ze�4(7);

            var k01 = new Kraw�d�(w0, w1, 5);
            var k03 = new Kraw�d�(w0, w3, 9);
            var k06 = new Kraw�d�(w0, w6, 3);
            var k12 = new Kraw�d�(w1, w2, 9);
            var k14 = new Kraw�d�(w1, w4, 8);
            var k15 = new Kraw�d�(w1, w5, 6);
            var k17 = new Kraw�d�(w1, w7, 7);
            var k23 = new Kraw�d�(w2, w3, 9);
            var k24 = new Kraw�d�(w2, w4, 4);
            var k26 = new Kraw�d�(w2, w6, 5);
            var k27 = new Kraw�d�(w2, w7, 3);
            var k36 = new Kraw�d�(w3, w6, 8);
            var k54 = new Kraw�d�(w5, w4, 2);
            var k46 = new Kraw�d�(w4, w6, 1);
            var k56 = new Kraw�d�(w5, w6, 6);
            var k67 = new Kraw�d�(w6, w7, 9);

            var g = new Graf(k01);
            g.Add(k03);
            g.Add(k06);
            g.Add(k12);
            g.Add(k14);
            g.Add(k15);
            g.Add(k17);
            g.Add(k23);
            g.Add(k24);
            g.Add(k26);
            g.Add(k27);
            g.Add(k36);
            g.Add(k54);
            g.Add(k46);
            g.Add(k56);
            g.Add(k67);
            var graf = g.Kruskala();
        }

        /*void A(W�ze� w)
        {
            string values = GetValues(w);
            MessageBox.Show(values);
        }

        string GetValues(W�ze� w)
        {
            string values = w.warto��.ToString();

            foreach (var dziecko in w.dzieci)
            {
                values += ", " + GetValues(dziecko);
            }
            return values;
        }*/
        //BFS
        /*void A2(W�ze�2 w)
        {
            foreach (var s�siedzi in w.s�siedzi)
                        queue.Add(s�siedzi);
            odwiedzone.Add(w);
            napis += w.warto��.ToString() + " ";
            queue.Remove(w);
            foreach (var s�siad in w.s�siedzi)
            {
                if (!odwiedzone.Contains(s�siad))
                {
                    A2(queue[0]);
                }
            }
        }*/
        void A(W�ze�2 w)
         {
             odwiedzone.Add(w);
             napis += w.warto��.ToString()+" ";
             foreach (var s�siad in w.s�siedzi)
             {
                if (!odwiedzone.Contains(s�siad))
                {
                    A(s�siad);
                }
             }
         }
        private void drzewoB_Click(object sender, EventArgs e)
        {
            var d = new DrzewoBinarne(5);
            
            
            d.Add(16);
            d.Add(13);
            d.Add(10);
            d.Add(20);
            d.Add(3);
            d.Add(16);
            d.Add(18);
            d.Add(15);
            d.Add(14);
            d.Add(13);
            
            
        }
        private void liczbaUD_ValueChanged(object sender, EventArgs e)
        {

        }
    }

    public class W�ze�
    {
        public int warto��;
        public List<W�ze�> dzieci = new List<W�ze�>();
        
        public W�ze�(int liczba)
        {
            this.warto�� = liczba;
        }

    }
    public class W�ze�2
    {
        public int warto��;
        public List<W�ze�2> s�siedzi = new List<W�ze�2>();

        public W�ze�2(int liczba)
        {
            this.warto�� = liczba;
        }
    }
    public class W�ze�3
    {
        public int warto��;
        public W�ze�3 rodzic;
        public W�ze�3 leweDziecko;
        public W�ze�3 praweDziecko;

        public W�ze�3(int liczba)
        {
            this.warto�� = liczba;
        }
        public override string ToString()
        {
            return this.warto��.ToString();
        }

        internal void Add(int liczba)
        {
            var dziecko = new W�ze�3(liczba);
            dziecko.rodzic = this;
            if (liczba < this.warto��)
            {
                this.leweDziecko = dziecko;
            }
            else
            {
                this.praweDziecko = dziecko;
            }
        }
        public int GetLiczbaDzieci()
        {
            int wynik = 0;
            if (this.leweDziecko != null)
                ++wynik;
            if (this.praweDziecko != null)
                ++wynik;
            return wynik;
        }
        /*public W�ze�3 ZnajdzMin(W�ze�3 w)
        {
            var min = w;
            while (true)
            {
                min = min.leweDziecko;
                if(min.leweDziecko == null)
                {

                    return min;
                }
                
            }

        }*/
        /*public W�ze�3 ZnajdzMin(W�ze�3 w)
        {
            var min = w;
            while (true)
            {
                min = min.leweDziecko;
                if (min.leweDziecko == null)
                {

                    return min;
                }

            }

        }*/



    }
    public class DrzewoBinarne
    {
        public W�ze�3 korze�;
        
        public DrzewoBinarne(int liczba)
        {
            this.korze� = new W�ze�3(liczba);
            
        }
        public void Add(int liczba)
        {
            W�ze�3 rodzic = this.ZnajdzRodzica(liczba);
            rodzic.Add(liczba);
        }
        /*public W�ze�3 Znajdz(int liczba)
        {
            var w = this.korze�;
            if(w.warto�� == liczba)
            {
                return w;
            }
            while (true)
            {
                
                if (liczba < w.warto��)
                {
                    if (w.leweDziecko.warto�� == liczba)
                    {
                        return w.leweDziecko;
                    }
                    else
                    {
                        w = w.leweDziecko;
                    }

                }
                else
                {
                    if (w.praweDziecko.warto�� == liczba)
                    {
                        return w.praweDziecko;
                    }
                    else
                    {
                        w = w.praweDziecko;
                    }
                }

            }
        }*/
        /*public W�ze�3 ZnajdzMin(int liczba)
        {
            var w = this.Znajdz(liczba);
            var min = korze�.ZnajdzMin(w);
            return min;
            
        }*/
        public W�ze�3 Znajdz(int liczba)
        {
            var w = this.korze�;
            while(true){
                if (liczba == w.warto��)
                    return w;
                if (liczba < w.warto��)
                {
                    if (w.leweDziecko != null)
                        w = w.leweDziecko;
                    else
                        return null;
                }
            }

        }
        public W�ze�3 ZnajdzMin (W�ze�3 w)
        {
            while(w.leweDziecko !=null)
                w=w.leweDziecko;
            return w;
        }
        /*public W�ze�3 ZnajdzMax(int liczba)
        {
            var w = this.Znajdz(liczba);
            var max = korze�.ZnajdzMax(w);
            return max;
        }*/
        public W�ze�3 Nastepnik (W�ze�3 w)
        {
            if(w.praweDziecko!=null)
                return this.ZnajdzMin(w.praweDziecko);
            while(w.rodzic != null)
            {
                if (w.rodzic.leweDziecko == w)
                    return w.rodzic;
                w = w.rodzic;
            }
            return null;
        }
        public W�ze�3 Usu�Gdy0Dzieci(W�ze�3 w)
        {
            if(w.rodzic == null)
            {
                this.korze� = null;
                return w;
            }
            if (w.rodzic.leweDziecko == w)
                w.rodzic.leweDziecko = null;
            else
                w.rodzic.praweDziecko = null;
            w.rodzic = null;
            return w;
        }
        public W�ze�3 Usu�Gdy1Dzieci(W�ze�3 w)
        {
            if (w.rodzic == null)
            {
                this.korze� = null;
                return w;
            }
            if (w.rodzic.leweDziecko == w)
                w.rodzic.leweDziecko = null;
            else
                w.rodzic.praweDziecko = null;
            w.rodzic = null;
            return w;
        }
        public W�ze�3 Usu�Gdy2Dzieci(W�ze�3 w)
        {
            if (w.rodzic == null)
            {
                this.korze� = null;
                return w;
            }
            if (w.rodzic.leweDziecko == w)
                w.rodzic.leweDziecko = null;
            else
                w.rodzic.praweDziecko = null;
            w.rodzic = null;
            return w;
        }
        public W�ze�3 Usu�(W�ze�3 w)
        {
            switch (w.GetLiczbaDzieci())
            {
                case 0:
                    w = this.Usu�Gdy0Dzieci(w);
                    break;
                case 1:
                    w = this.Usu�Gdy1Dzieci(w);
                    break;
                case 2:
                    w = this.Usu�Gdy2Dzieci(w);
                    break;
            }
            return w;
        }
        private W�ze�3 ZnajdzRodzica(int liczba)
        {
            var w = this.korze�;
            while (true)
            {
                if (liczba < w.warto��)
                {
                    if(w.leweDziecko == null)
                    {
                        return w;
                    }
                    else
                    {
                        w = w.leweDziecko;
                    }
                    
                }
                else
                {
                    if(w.praweDziecko == null)
                    {
                        return w;
                    }
                    else
                    {
                        w = w.praweDziecko;
                    }
                }
            }
        }
    }
    public class Graf
    {
        public List<Kraw�d�> kraw�dzie;
        public List<W�ze�4> w�z�y;

        public Graf()
        {
            kraw�dzie = new List<Kraw�d�>();
            w�z�y = new List<W�ze�4>();

        }
        public Graf(Kraw�d� k)
        {
            kraw�dzie = new List<Kraw�d�>();
            w�z�y = new List<W�ze�4>();

            this.Add(k);
        }
        
        public void DodajKraw�d�(Kraw�d� k)
        {
            kraw�dzie.Add(k);
        }
        public void DodajW�z�(W�ze�4 w)
        {
            w�z�y.Add(w);
        }
        public int Sprawd�(Kraw�d� k)
        {
            if (w�z�y.Contains(k.pocz�tek) && w�z�y.Contains(k.koniec))
            {
                return 0;
            }else if (w�z�y.Contains(k.koniec) || w�z�y.Contains(k.pocz�tek))
            {
                return 1;
            }
            return 2;
        }
        public void Add(Kraw�d� k)
        {
            if(!kraw�dzie.Contains(k))
                kraw�dzie.Add(k);
            
            if (!w�z�y.Contains(k.pocz�tek))
                w�z�y.Add(k.pocz�tek);

            if (!w�z�y.Contains(k.koniec))
                w�z�y.Add(k.koniec);
        }
        public void Join(Graf g)
        {
            foreach (var k in g.kraw�dzie)
            {
                this.Add(k);
            }

            //p�tla po grafie 2 i ka�de robie this.Add foreach-em
        }
        public Graf Kruskala()
        {
            // lista kraw�dzi posortowana po wadze
            List<Kraw�d�> k = this.kraw�dzie;
            List<W�ze�4> w = this.w�z�y;
            List<Kraw�d�> sorted = k.OrderBy(o=>o.waga).ToList();

            
            // lista graf�w (ewentualnych)
            List<Graf> grafy = new List<Graf>();
            grafy.Add(new Graf(sorted[0]));
            sorted.Remove(sorted[0]);

            // p�tla po kraw�dziach

            foreach (var i in sorted)
            {
                int dodaj = 0;
                foreach (var g in grafy)
                {

                    if (g.Sprawd�(i) == 1)
                    {
                        g.Add(i);
                        dodaj++;
                    }
                    else if (g.Sprawd�(i) == 2)
                    {
                        if (grafy[0].kraw�dzie.Contains(i) == false)
                        {
                            grafy.Add(new Graf(i));
                            break;
                        }
                            
                    }
                    if(dodaj == 2)
                    {
                        grafy[0].Join(g);
                        grafy.Remove(g);
                        break;
                    }
                    if (g.kraw�dzie.Count == w.Count - 1)
                    {
                        return grafy[0];
                    }

                }
            }
            return grafy[0];
        }
        
    }
    public class Kraw�d�
    {
        public int waga;
        public W�ze�4 pocz�tek;
        public W�ze�4 koniec;
        public Kraw�d�(W�ze�4 w1,W�ze�4 w2, int waga)
        {
            this.pocz�tek = w1;
            this.koniec = w2;
            this.waga = waga;
        }
    }
    public class W�ze�4
    {
        public int warto��;
        /*public List<Kraw�d�> kraw�dzie;
        public W�ze�4()
        {
            kraw�dzie = new List<Kraw�d�>();
        }*/
        public W�ze�4(int warto��)
        {
            this.warto�� = warto��;
        }
    }
    public class Element
    {
        public int dystans;
        public W�ze�4 nast�pnik;
        public Dictionary<W�ze�4, Element> tabelka;

    }

}