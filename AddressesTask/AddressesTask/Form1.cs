using System.Text;

namespace AddressesTask
{
    public partial class Form1 : Form
    {
        StreamWriter sw;
        public Form1()
        {
            InitializeComponent();

            Directory.CreateDirectory("C:\\Addresses");
            if (!File.Exists("C:\\Addresses\\AddressesResults.txt"))
                File.Create("C:\\Addresses\\AddressesResults.txt").Close();
            sw = new StreamWriter("C:\\Addresses\\AddressesResults.txt", true, Encoding.Unicode);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            sw.Close();
            this.Close();
        }

        public class Solution
        {
            private int a, b, c;
            double f(int D) => (-D + 1 + Math.Sqrt(D * D - 2 * D + (1 + 4 * a))) / 2;
            double g(int D) => (-D - 2 * f(D) + 1 + Math.Sqrt(Math.Pow(D + 2 * f(D) - 1, 2) + 4 * b)) / 2;
            double h(int D) => (-D - 2 * g(D) - 2 * f(D) + 1 + Math.Sqrt(Math.Pow(D + 2 * g(D) + 2 * f(D) - 1, 2) + 4 * c)) / 2;
            double S(int D) => ((2 * D + (f(D) + g(D) + h(D) - 1) * 2) * (f(D) + g(D) + h(D))) / 2;

            public Solution(int a, int b, int c) { this.a = a; this.b = b; this.c = c; }
            public string solve()
            {
                for (int D = 1; D <= a; D++)
                {
                    if (S(D) == a + b + c &&
                        f(D) == Math.Round(f(D)) &&
                        g(D) == Math.Round(g(D)) &&
                        h(D) == Math.Round(h(D)))
                    {
                        return $"Номер дома Петра: {D}\nНомер дома школы: {D + (f(D) + g(D) + h(D) - 1) * 2}";
                    }
                }
                return "Решений нет";
            }
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            Solution S = new Solution((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
            richTextBox2.Text = S.solve();

            sw.Write($"{DateTime.Now}\nШкола находится на одной стороне улицы с домом Петра. Однажды по дороге в школу он стал складывать\n" +
                $"номера домов, мимо которых проходил на своей стороне улицы, начиная с номера своего дома. Когда сумма\n" +
                $"номеров оказалась равной {(int)numericUpDown1.Value}, Петр перешел через поперечную улицу. После этого\n" +
                $"он начал заново складывать номера домов, мимо которых проходил и при сумме {(int)numericUpDown2.Value}\n" +
                $"перешел через еще одну поперечную улицу. Петр и на следующем квартале складывал номера домов.\n" +
                $"Сумма номеров домов третьего квартала оказалась равной {(int)numericUpDown3.Value}, включая номер дома школы.\n\n" +
                $"{richTextBox2.Text}\n" +
                $"--------------------------------------------------------------------------------------------------------------\n\n");
        }
    }
}
