namespace Deci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreATester = textBox1.Text;
            if (int.TryParse(nombreATester, out int value))
            {
                int nbPremier = Int32.Parse(nombreATester);
                if (nbPremier <= 1)
                {
                    MessageBox.Show("Le nombre saisi n'est pas un nombre premier !");
                }
                else
                {
                    var diviseurs = new List<int>();
                    for (var i = 1; i < nbPremier; i++)
                    {
                        if (nbPremier % i == 0)
                        {
                            diviseurs.Add(i);
                        }
                    }
                    if (diviseurs.Count <= 2)
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        label3.Text = string.Join(",", diviseurs.ToArray());
                        radioButton2.Checked = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Le nombre saisi n'est pas valide !");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}