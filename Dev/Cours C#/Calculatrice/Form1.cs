namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            decimal r�sultat = 0;
            string saisi_operateur = comboBox1.Text;
            string phrase1 = "Le r�sultat est ";
            string r�sultat_finale = "";
            if (!Decimal.TryParse(textBox1.Text, out Decimal premierNombre))
            {
                MessageBox.Show("Erreur de saisie du premier nombre!");
                return;
            }
            if (!Decimal.TryParse(textBox2.Text, out Decimal deuxiemeNombre))
            {
                MessageBox.Show("Erreur de saisie du deuxi�me nombre!");
                return;
            }
            else if (saisi_operateur == "x")
            {
                r�sultat = (premierNombre * deuxiemeNombre);
                if (checkBox1.Checked)
                {
                    r�sultat = Math.Round(r�sultat, 2);
                }
                r�sultat_finale = phrase1 + r�sultat;
                MessageBox.Show(r�sultat_finale);

            }
            else if (saisi_operateur == "+")
            {
                r�sultat = (premierNombre + deuxiemeNombre);
                if (checkBox1.Checked)
                {
                    r�sultat = Math.Round(r�sultat, 2);
                }
                r�sultat_finale = phrase1 + r�sultat;
                MessageBox.Show(r�sultat_finale);
            }
            else if (saisi_operateur == "-")
            {
                r�sultat = (premierNombre - deuxiemeNombre);
                if (checkBox1.Checked)
                {
                    r�sultat = Math.Round(r�sultat, 2);
                }
                r�sultat_finale = phrase1 + r�sultat;
                MessageBox.Show(r�sultat_finale);
            }
            else if (saisi_operateur == "/")
            {
                r�sultat = (premierNombre / deuxiemeNombre);
                if (checkBox1.Checked)
                {
                    r�sultat = Math.Round(r�sultat, 2);
                }
                r�sultat_finale = phrase1 + r�sultat;
                MessageBox.Show(r�sultat_finale);
            }
            else if (saisi_operateur == "%")
            {
                r�sultat = (premierNombre % deuxiemeNombre);
                if (checkBox1.Checked)
                {
                    r�sultat = Math.Round(r�sultat, 2);
                }
                r�sultat_finale = phrase1 + r�sultat;
                MessageBox.Show(r�sultat_finale);
            }
            else
            {
                MessageBox.Show("L'op�rateur saisi ne respecte pas le format support� !");
                return;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}