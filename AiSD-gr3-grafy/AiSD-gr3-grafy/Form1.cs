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
            var w1 = new W�ze�(5);
            var w2 = new W�ze�(2);
            var w3 = new W�ze�(1);
            var w4 = new W�ze�(3);
            var w5 = new W�ze�(4);
            var w6 = new W�ze�(6);
            w1.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            w1.dzieci.Add(w4);
            w2.dzieci.Add(w5);
            w2.dzieci.Add(w6);
            int[] tab = new int[6];
            A(w1,tab);
            MessageBox.Show(naString(tab));
        }
        void A(W�ze� w, int[] tab)
        {
            tab.Append(w.warto��);
            foreach (var dziecko in w.dzieci)
            {
                
                A(dziecko,tab);
                
            }
            MessageBox.Show(naString(tab));

        }
        
       /* void A(W�ze� w)
        {
            MessageBox.Show(w.warto��.ToString());
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
    public class W�ze�
    {
        public int warto��;
        public List<W�ze�> dzieci = new List<W�ze�>();
        
        public W�ze�(int liczba)
        {
            this.warto�� = liczba;
        }

    }
}