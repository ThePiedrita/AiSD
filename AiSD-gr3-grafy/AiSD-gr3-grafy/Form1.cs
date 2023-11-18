namespace AiSD_gr3_grafy
{
    public partial class Form1 : Form
    {
        string napis = "";
        List<Wêze³2> odwiedzone = new List<Wêze³2>();
        List<Wêze³2> queue = new List<Wêze³2>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var w1 = new Wêze³2(1);
            var w2 = new Wêze³2(2);
            var w3 = new Wêze³2(4);
            var w4 = new Wêze³2(6);
            var w5 = new Wêze³2(7);
            var w6 = new Wêze³2(3);
            var w7 = new Wêze³2(5);
            w1.s¹siedzi.Add(w2);
            w1.s¹siedzi.Add(w6);
            w2.s¹siedzi.Add(w3);
            w3.s¹siedzi.Add(w4);
            w3.s¹siedzi.Add(w5);
            w3.s¹siedzi.Add(w6);
            w4.s¹siedzi.Add(w5);
            w6.s¹siedzi.Add(w7);
            napis = "";
            A2(w1);
            MessageBox.Show(napis);
            
        }
        //BFS DO DOMU

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

        void A2(Wêze³2 w)
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
        }

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
}