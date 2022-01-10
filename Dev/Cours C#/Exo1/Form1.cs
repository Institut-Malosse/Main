namespace Exo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string r�sultat = "(texte vide)"; // On d�clare un variable chaine contenant "(texte vide)"
            string pr�nom = TxtPr�nom.Text; // On d�clare une variable chaine contenant "Jean-Michel"
            if (string.IsNullOrEmpty(pr�nom))
            {
                MessageBox.Show("Vous n'avez pas saisi de pr�nom !");
                return;
            }
            //DateTime dateDeNaissance = DateTime.Parse(TxtDateNaissance.Text); // On d�clare une variable date contenant 20/07/1990
            if (DateTime.TryParse(TxtDateNaissance.Text, out DateTime dateDeNaissance))
            {}
            else
            {
                MessageBox.Show("La date de naissance ne respecte pas le format local !");
                return;
            }
            //DateTime uneAutreDate = DateTime.Parse(TxtAutreDate.Text); // On d�clare une variable date contenant 22/08/2010
            if (DateTime.TryParse(TxtAutreDate.Text, out DateTime uneAutreDate))
            {}
            else
            {
                MessageBox.Show("La date de comparaison ne respecte pas le format local !");
                return;
            }
            int age;
            int i = 0;
            if (dateDeNaissance > uneAutreDate) // Si la date de naissance est sup�rieure � l'autre date
            {
                // Oui : la date de naissance EST sup�rieure � l'autre date !
                // On concat�ne une r�ponse pour dire que la personne n'�tait pas n�e
                r�sultat = pr�nom + " n'�tait m�me pas n�(e) le " + uneAutreDate.ToString() + " !";
            }
            else
            {
                // Non : la date de naissance N'EST PAS sup�rieure � l'autre date !
                while (true) // On d�marre une boucle, avec une variable i, de type entier (it�rateur)
                {
                    i += 1;
                    if (dateDeNaissance.AddYears(i) > uneAutreDate) // Si la date de naissance + i ann�e(s) est sup�rieure ou �gale � l'autre date
                    {
                        // Oui : la date de naissance + i ann�e(s) EST sup�rieure ou �gale � l'autre date !
                        age = i - 1;
                        r�sultat = pr�nom + " avait " + age.ToString() + " an(s) !"; // On indique l'age calcul� (qui vaut la valeur de i)
                        if (dateDeNaissance.Month == uneAutreDate.Month && dateDeNaissance.Day == uneAutreDate.Day)
                        {
                            r�sultat = r�sultat + " Et c'�tait pile le jour de son anniversaire !";
                        }
                        break;
                    }
                }

                MessageBox.Show(r�sultat); // On affiche le r�sultat de l'algorithme dans une boite de message
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}