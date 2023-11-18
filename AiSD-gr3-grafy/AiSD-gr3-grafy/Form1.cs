namespace AiSD_gr3_grafy
{
    public partial class Form1 : Form
    {
        string napis = "";
        List<W�ze�2> odwiedzone = new List<W�ze�2>();
        List<W�ze�2> queue = new List<W�ze�2>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var w1 = new W�ze�2(1);
            var w2 = new W�ze�2(2);
            var w3 = new W�ze�2(4);
            var w4 = new W�ze�2(6);
            var w5 = new W�ze�2(7);
            var w6 = new W�ze�2(3);
            var w7 = new W�ze�2(5);
            w1.s�siedzi.Add(w2);
            w1.s�siedzi.Add(w6);
            w2.s�siedzi.Add(w3);
            w3.s�siedzi.Add(w4);
            w3.s�siedzi.Add(w5);
            w3.s�siedzi.Add(w6);
            w4.s�siedzi.Add(w5);
            w6.s�siedzi.Add(w7);
            napis = "";
            A2(w1);
            MessageBox.Show(napis);
            
        }
        //BFS DO DOMU

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

        void A2(W�ze�2 w)
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
        }

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
}