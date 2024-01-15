using Accessibility;
using System.Net.Http.Headers;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;

namespace AiSD_gr3_grafy
{
    public partial class Form1 : Form
    {
        string napis = "";
        List<Wêze³2> odwiedzone = new List<Wêze³2>();
        //List<Wêze³2> queue = new List<Wêze³2>();
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var w0 = new Wêze³4(0);
            var w1 = new Wêze³4(1);
            var w2 = new Wêze³4(2);
            var w3 = new Wêze³4(3);
            var w4 = new Wêze³4(4);
            var w5 = new Wêze³4(5);
            var w6 = new Wêze³4(6);
            var w7 = new Wêze³4(7);

            var k01 = new KrawêdŸ(w0, w1, 5);
            var k03 = new KrawêdŸ(w0, w3, 9);
            var k06 = new KrawêdŸ(w0, w6, 3);
            var k12 = new KrawêdŸ(w1, w2, 9);
            var k14 = new KrawêdŸ(w1, w4, 8);
            var k15 = new KrawêdŸ(w1, w5, 6);
            var k17 = new KrawêdŸ(w1, w7, 7);
            var k23 = new KrawêdŸ(w2, w3, 9);
            var k24 = new KrawêdŸ(w2, w4, 4);
            var k26 = new KrawêdŸ(w2, w6, 5);
            var k27 = new KrawêdŸ(w2, w7, 3);
            var k36 = new KrawêdŸ(w3, w6, 8);
            var k54 = new KrawêdŸ(w5, w4, 2);
            var k46 = new KrawêdŸ(w4, w6, 1);
            var k56 = new KrawêdŸ(w5, w6, 6);
            var k67 = new KrawêdŸ(w6, w7, 9);

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

        /*void A(Wêze³ w)
        {
            string values = GetValues(w);
            MessageBox.Show(values);
        }

        string GetValues(Wêze³ w)
        {
            string values = w.wartoœæ.ToString();

            foreach (var dziecko in w.dzieci)
            {
                values += ", " + GetValues(dziecko);
            }
            return values;
        }*/
        //BFS
        /*void A2(Wêze³2 w)
        {
            foreach (var s¹siedzi in w.s¹siedzi)
                        queue.Add(s¹siedzi);
            odwiedzone.Add(w);
            napis += w.wartoœæ.ToString() + " ";
            queue.Remove(w);
            foreach (var s¹siad in w.s¹siedzi)
            {
                if (!odwiedzone.Contains(s¹siad))
                {
                    A2(queue[0]);
                }
            }
        }*/
        void A(Wêze³2 w)
         {
             odwiedzone.Add(w);
             napis += w.wartoœæ.ToString()+" ";
             foreach (var s¹siad in w.s¹siedzi)
             {
                if (!odwiedzone.Contains(s¹siad))
                {
                    A(s¹siad);
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

    public class Wêze³
    {
        public int wartoœæ;
        public List<Wêze³> dzieci = new List<Wêze³>();
        
        public Wêze³(int liczba)
        {
            this.wartoœæ = liczba;
        }

    }
    public class Wêze³2
    {
        public int wartoœæ;
        public List<Wêze³2> s¹siedzi = new List<Wêze³2>();

        public Wêze³2(int liczba)
        {
            this.wartoœæ = liczba;
        }
    }
    public class Wêze³3
    {
        public int wartoœæ;
        public Wêze³3 rodzic;
        public Wêze³3 leweDziecko;
        public Wêze³3 praweDziecko;

        public Wêze³3(int liczba)
        {
            this.wartoœæ = liczba;
        }
        public override string ToString()
        {
            return this.wartoœæ.ToString();
        }

        internal void Add(int liczba)
        {
            var dziecko = new Wêze³3(liczba);
            dziecko.rodzic = this;
            if (liczba < this.wartoœæ)
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
        /*public Wêze³3 ZnajdzMin(Wêze³3 w)
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
        /*public Wêze³3 ZnajdzMin(Wêze³3 w)
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
        public Wêze³3 korzeñ;
        
        public DrzewoBinarne(int liczba)
        {
            this.korzeñ = new Wêze³3(liczba);
            
        }
        public void Add(int liczba)
        {
            Wêze³3 rodzic = this.ZnajdzRodzica(liczba);
            rodzic.Add(liczba);
        }
        /*public Wêze³3 Znajdz(int liczba)
        {
            var w = this.korzeñ;
            if(w.wartoœæ == liczba)
            {
                return w;
            }
            while (true)
            {
                
                if (liczba < w.wartoœæ)
                {
                    if (w.leweDziecko.wartoœæ == liczba)
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
                    if (w.praweDziecko.wartoœæ == liczba)
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
        /*public Wêze³3 ZnajdzMin(int liczba)
        {
            var w = this.Znajdz(liczba);
            var min = korzeñ.ZnajdzMin(w);
            return min;
            
        }*/
        public Wêze³3 Znajdz(int liczba)
        {
            var w = this.korzeñ;
            while(true){
                if (liczba == w.wartoœæ)
                    return w;
                if (liczba < w.wartoœæ)
                {
                    if (w.leweDziecko != null)
                        w = w.leweDziecko;
                    else
                        return null;
                }
            }

        }
        public Wêze³3 ZnajdzMin (Wêze³3 w)
        {
            while(w.leweDziecko !=null)
                w=w.leweDziecko;
            return w;
        }
        /*public Wêze³3 ZnajdzMax(int liczba)
        {
            var w = this.Znajdz(liczba);
            var max = korzeñ.ZnajdzMax(w);
            return max;
        }*/
        public Wêze³3 Nastepnik (Wêze³3 w)
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
        public Wêze³3 UsuñGdy0Dzieci(Wêze³3 w)
        {
            if(w.rodzic == null)
            {
                this.korzeñ = null;
                return w;
            }
            if (w.rodzic.leweDziecko == w)
                w.rodzic.leweDziecko = null;
            else
                w.rodzic.praweDziecko = null;
            w.rodzic = null;
            return w;
        }
        public Wêze³3 UsuñGdy1Dzieci(Wêze³3 w)
        {
            if (w.rodzic == null)
            {
                this.korzeñ = null;
                return w;
            }
            if (w.rodzic.leweDziecko == w)
                w.rodzic.leweDziecko = null;
            else
                w.rodzic.praweDziecko = null;
            w.rodzic = null;
            return w;
        }
        public Wêze³3 UsuñGdy2Dzieci(Wêze³3 w)
        {
            if (w.rodzic == null)
            {
                this.korzeñ = null;
                return w;
            }
            if (w.rodzic.leweDziecko == w)
                w.rodzic.leweDziecko = null;
            else
                w.rodzic.praweDziecko = null;
            w.rodzic = null;
            return w;
        }
        public Wêze³3 Usuñ(Wêze³3 w)
        {
            switch (w.GetLiczbaDzieci())
            {
                case 0:
                    w = this.UsuñGdy0Dzieci(w);
                    break;
                case 1:
                    w = this.UsuñGdy1Dzieci(w);
                    break;
                case 2:
                    w = this.UsuñGdy2Dzieci(w);
                    break;
            }
            return w;
        }
        private Wêze³3 ZnajdzRodzica(int liczba)
        {
            var w = this.korzeñ;
            while (true)
            {
                if (liczba < w.wartoœæ)
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
        public List<KrawêdŸ> krawêdzie;
        public List<Wêze³4> wêz³y;

        public Graf()
        {
            krawêdzie = new List<KrawêdŸ>();
            wêz³y = new List<Wêze³4>();

        }
        public Graf(KrawêdŸ k)
        {
            krawêdzie = new List<KrawêdŸ>();
            wêz³y = new List<Wêze³4>();

            this.Add(k);
        }
        
        public void DodajKrawêdŸ(KrawêdŸ k)
        {
            krawêdzie.Add(k);
        }
        public void DodajWêzê³(Wêze³4 w)
        {
            wêz³y.Add(w);
        }
        public int SprawdŸ(KrawêdŸ k)
        {
            if (wêz³y.Contains(k.pocz¹tek) && wêz³y.Contains(k.koniec))
            {
                return 0;
            }else if (wêz³y.Contains(k.koniec) || wêz³y.Contains(k.pocz¹tek))
            {
                return 1;
            }
            return 2;
        }
        public void Add(KrawêdŸ k)
        {
            if(!krawêdzie.Contains(k))
                krawêdzie.Add(k);
            
            if (!wêz³y.Contains(k.pocz¹tek))
                wêz³y.Add(k.pocz¹tek);

            if (!wêz³y.Contains(k.koniec))
                wêz³y.Add(k.koniec);
        }
        public void Join(Graf g)
        {
            foreach (var k in g.krawêdzie)
            {
                this.Add(k);
            }

            //pêtla po grafie 2 i ka¿de robie this.Add foreach-em
        }
        public Graf Kruskala()
        {
            // lista krawêdzi posortowana po wadze
            List<KrawêdŸ> k = this.krawêdzie;
            List<Wêze³4> w = this.wêz³y;
            List<KrawêdŸ> sorted = k.OrderBy(o=>o.waga).ToList();

            
            // lista grafów (ewentualnych)
            List<Graf> grafy = new List<Graf>();
            grafy.Add(new Graf(sorted[0]));
            sorted.Remove(sorted[0]);

            // pêtla po krawêdziach

            foreach (var i in sorted)
            {
                int dodaj = 0;
                foreach (var g in grafy)
                {

                    if (g.SprawdŸ(i) == 1)
                    {
                        g.Add(i);
                        dodaj++;
                    }
                    else if (g.SprawdŸ(i) == 2)
                    {
                        if (grafy[0].krawêdzie.Contains(i) == false)
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
                    if (g.krawêdzie.Count == w.Count - 1)
                    {
                        return grafy[0];
                    }

                }
            }
            return grafy[0];
        }
        
    }
    public class KrawêdŸ
    {
        public int waga;
        public Wêze³4 pocz¹tek;
        public Wêze³4 koniec;
        public KrawêdŸ(Wêze³4 w1,Wêze³4 w2, int waga)
        {
            this.pocz¹tek = w1;
            this.koniec = w2;
            this.waga = waga;
        }
    }
    public class Wêze³4
    {
        public int wartoœæ;
        /*public List<KrawêdŸ> krawêdzie;
        public Wêze³4()
        {
            krawêdzie = new List<KrawêdŸ>();
        }*/
        public Wêze³4(int wartoœæ)
        {
            this.wartoœæ = wartoœæ;
        }
    }
    public class Element
    {
        public int dystans;
        public Wêze³4 nastêpnik;
        public Dictionary<Wêze³4, Element> tabelka;

    }

}