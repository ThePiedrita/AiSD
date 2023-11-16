namespace AiSD_gr3_grafy
{
    public partial class Form1 : Form
    {
        string wynik = "";
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
            A(w1);
            
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

         void A(Wêze³ w)
         {
             wynik += w.wartoœæ.ToString();
             foreach (var dziecko in w.dzieci)
             {
                 A(dziecko);
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
}