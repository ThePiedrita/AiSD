using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IO_AISD_gr3._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tab_TextChanged(object sender, EventArgs e)
        {
            
            
        }
        int[] Convert(String napis)
        {
            var liczbyS = napis.Trim().Split(' ');
            var liczby = new int[liczbyS.Length];
            for(int i = 0; i < liczbyS.Length; i++)
                liczby[i] = int.Parse(liczbyS[i].Trim());
            return liczby;
        }

        private void bubbleSort_Click(object sender, EventArgs e)
        {
            wyjscie.Text = naString(sortBubble(Convert(wejscie.Text)));
            
        }
        int[] sortBubble(int[] tab)
        {
            bool cbz = false;
            do
            {
                cbz = false;
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        int tmp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tmp;
                        cbz = true;
                    }

                }
            } while (cbz == true);

            return tab;
        }

        private void selectSort_Click(object sender, EventArgs e)
        {
            wyjscie.Text = naString(sortSelect(Convert(wejscie.Text)));
        }
        int[] sortSelect(int[] tab)
        {
            int temp;
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = i; j < tab.Length; j++)
                {
                    if (tab[i] > tab[j])
                    {
                        temp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = temp;
                    }

                }
            }
            return tab;
        }

        String naString(int[] tab)
        {
            string znak = tab[0].ToString();
            for (int i = 1; i < tab.Length; i++)
            {
                znak = znak + ", " + tab[i].ToString();
            }
            return znak;
        }

        private void wyjscie_Click(object sender, EventArgs e)
        {
            
        }

        private void insertSort_Click(object sender, EventArgs e)
        {
            wyjscie.Text = naString(sortInsert(Convert(wejscie.Text)));
        }

        int[] sortInsert(int[] tab)
        {
            int temp;
            for (int i = 1; i < tab.Length; i++)
            {
                int k = i;
                for(int j = i-1; j >= 0; j--)
                {
                    if(tab[k] < tab[j])
                    {
                        temp=tab[j];
                        tab[j] = tab[k];
                        tab[k] = temp;
                        k--;
                    }
                }
            }
            return tab;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mergeSort_Click(object sender, EventArgs e)
        {
            
            
        }

        private void quickSort_Click(object sender, EventArgs e)
        {
            wyjscie.Text = wyjscie.Text = naString(sortQuick(Convert(wejscie.Text),0,Convert(wejscie.Text).Length-1));
        }
        int[] sortQuick(int[] tab, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = tab[leftIndex];
            while (i <= j)
            {
                while (tab[i] < pivot)
                {
                    i++;
                }

                while (tab[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = tab[i];
                    tab[i] = tab[j];
                    tab[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                sortQuick(tab, leftIndex, j);
            if (i < rightIndex)
                sortQuick(tab, i, rightIndex);
            return tab;
        }

        //int[] sortMerge(int[] tab)



    }
}