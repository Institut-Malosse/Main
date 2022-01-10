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
            string r�sultat = "(texte vide)"; // On d�clare une variable chaine contenant "(texte vide)"
            string pr�nom = "Jean-Michel"; // On d�clare une variable chaine contenant "Jean-Michel"
            DateTime dateDeNaissance = new DateTime(1990, 07, 20); // On d�clare une variable date contenant 20/07/1990
            DateTime uneAutreDate = new DateTime(2010, 08, 22); // On d�clare une variable date contenant 22/08/2010

            if (dateDeNaissance > uneAutreDate) // Si la date de naissance est sup�rieure � l'autre date
            {
                // Oui : la date de naissance EST sup�rieure � l'autre date !
                // On concat�ne une r�ponse pour dire que la personne n'�tait pas n�e
                r�sultat = pr�nom + " n'�tait m�me pas n�(e) le " + uneAutreDate.ToString() + " !";
            }
            else
            {
                // Non : la date de naissance N'EST PAS sup�rieure � l'autre date !
                for (int i = 0; i < 99; i++) // On d�marre une boucle, avec une variable i, de type entier (it�rateur)
                {
                    if (dateDeNaissance.AddYears(i) >= uneAutreDate) // Si la date de naissance + i ann�e(s) est sup�rieure ou �gale � l'autre date
                    {
                        // Oui : la date de naissance + i ann�e(s) EST sup�rieure ou �gale � l'autre date !
                        r�sultat = pr�nom + " avait " + i.ToString() + " an(s) !"; // On indique l'age calcul� (qui vaut la valeur de i)
                        if (dateDeNaissance.Month == uneAutreDate.Month && dateDeNaissance.Day == uneAutreDate.Day)
                        {
                            r�sultat = r�sultat + " Et c'�tait pile le jour de son anniversaire !";
                        }
                        break;
                    }
                }
            }

            MessageBox.Show(r�sultat); // On affiche le r�sultat de l'algorithme dans une boite de message
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}