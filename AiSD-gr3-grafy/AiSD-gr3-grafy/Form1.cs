namespace AiSD_gr3_grafy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var w1 = new Wêze³(5);
            var w2 = new Wêze³(2);
            var w3 = new Wêze³(1);
            var w4 = new Wêze³(3);
            var w5 = new Wêze³(4);
            var w6 = new Wêze³(6);
            w1.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            w1.dzieci.Add(w4);
            w2.dzieci.Add(w5);
            w2.dzieci.Add(w6);
            int[] tab = new int[6];
            A(w1,tab);
            MessageBox.Show(naString(tab));
        }
        void A(Wêze³ w, int[] tab)
        {
            tab.Append(w.wartoœæ);
            foreach (var dziecko in w.dzieci)
            {
                
                A(dziecko,tab);
                
            }
            MessageBox.Show(naString(tab));

        }
        
       /* void A(Wêze³ w)
        {
            MessageBox.Show(w.wartoœæ.ToString());
            foreach (var dziecko in w.dzieci)
            {

                A(dziecko);

            }
            

        }*/
        String naString(int[] tab)
        {
            string znak = tab[0].ToString();
            for (int i = 1; i < tab.Length; i++)
            {
                znak = znak + ", " + tab[i].ToString();
            }
            return znak;
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
}