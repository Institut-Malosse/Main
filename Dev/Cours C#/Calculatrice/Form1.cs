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

            decimal résultat = 0;
            string saisi_operateur = comboBox1.Text;
            string phrase1 = "Le résultat est ";
            string résultat_finale = "";
            if (!Decimal.TryParse(textBox1.Text, out Decimal premierNombre))
            {
                MessageBox.Show("Erreur de saisie du premier nombre!");
                return;
            }
            if (!Decimal.TryParse(textBox2.Text, out Decimal deuxiemeNombre))
            {
                MessageBox.Show("Erreur de saisie du deuxième nombre!");
                return;
            }
            else if (saisi_operateur == "x")
            {
                résultat = (premierNombre * deuxiemeNombre);
                if (checkBox1.Checked)
                {
                    résultat = Math.Round(résultat, 2);
                }
                résultat_finale = phrase1 + résultat;
                MessageBox.Show(résultat_finale);

            }
            else if (saisi_operateur == "+")
            {
                résultat = (premierNombre + deuxiemeNombre);
                if (checkBox1.Checked)
                {
                    résultat = Math.Round(résultat, 2);
                }
                résultat_finale = phrase1 + résultat;
                MessageBox.Show(résultat_finale);
            }
            else if (saisi_operateur == "-")
            {
                résultat = (premierNombre - deuxiemeNombre);
                if (checkBox1.Checked)
                {
                    résultat = Math.Round(résultat, 2);
                }
                résultat_finale = phrase1 + résultat;
                MessageBox.Show(résultat_finale);
            }
            else if (saisi_operateur == "/")
            {
                résultat = (premierNombre / deuxiemeNombre);
                if (checkBox1.Checked)
                {
                    résultat = Math.Round(résultat, 2);
                }
                résultat_finale = phrase1 + résultat;
                MessageBox.Show(résultat_finale);
            }
            else if (saisi_operateur == "%")
            {
                résultat = (premierNombre % deuxiemeNombre);
                if (checkBox1.Checked)
                {
                    résultat = Math.Round(résultat, 2);
                }
                résultat_finale = phrase1 + résultat;
                MessageBox.Show(résultat_finale);
            }
            else
            {
                MessageBox.Show("L'opérateur saisi ne respecte pas le format supporté !");
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