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
            string nombreATester = textBox1.Text; // R�cup�ration de la valeur saisie
            if (int.TryParse(nombreATester, out int value)) // V�rification de la valeur
            {
                int nbPremier = Int32.Parse(nombreATester);
                if (nbPremier <= 1) // S'il est positif et sup�rieur ou �gal � 1
                {
                    MessageBox.Show("Le nombre saisi n'est pas un nombre premier !"); // Affichage d'une erreur de saisie
                }
                else
                {
                    var diviseurs = new List<int>(); // Cr�ation de l'Array qui va stocker les diviseurs
                    for (var i = 1; i < nbPremier; i++)
                    {
                        if (nbPremier % i == 0) // V�rification par modulo
                        {
                            diviseurs.Add(i); // Ajout dans l'Array des diviseurs
                        }
                    }
                    if (diviseurs.Count <= 2) // Si les diviseurs sont uniquement 1, alors le nombre est primaire
                    {
                        radioButton1.Checked = true; // Changement de l'�tat du bouton de radio
                    }
                    else
                    {
                        label3.Text = string.Join(",", diviseurs.ToArray()); // Affichage des diviseurs sur le label correspondant
                        radioButton2.Checked = true; // Changement de l'�tat du bouton radio
                    }
                }
            }
            else
            {
                MessageBox.Show("Le nombre saisi n'est pas une valeur valide !"); // Affichage d'une erreur de saisie
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}