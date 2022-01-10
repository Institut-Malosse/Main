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
            string résultat = "(texte vide)"; // On déclare une variable chaine contenant "(texte vide)"
            string prénom = "Jean-Michel"; // On déclare une variable chaine contenant "Jean-Michel"
            DateTime dateDeNaissance = new DateTime(1990, 07, 20); // On déclare une variable date contenant 20/07/1990
            DateTime uneAutreDate = new DateTime(2010, 08, 22); // On déclare une variable date contenant 22/08/2010

            if (dateDeNaissance > uneAutreDate) // Si la date de naissance est supérieure à l'autre date
            {
                // Oui : la date de naissance EST supérieure à l'autre date !
                // On concatène une réponse pour dire que la personne n'était pas née
                résultat = prénom + " n'était même pas né(e) le " + uneAutreDate.ToString() + " !";
            }
            else
            {
                // Non : la date de naissance N'EST PAS supérieure à l'autre date !
                for (int i = 0; i < 99; i++) // On démarre une boucle, avec une variable i, de type entier (itérateur)
                {
                    if (dateDeNaissance.AddYears(i) >= uneAutreDate) // Si la date de naissance + i année(s) est supérieure ou égale à l'autre date
                    {
                        // Oui : la date de naissance + i année(s) EST supérieure ou égale à l'autre date !
                        résultat = prénom + " avait " + i.ToString() + " an(s) !"; // On indique l'age calculé (qui vaut la valeur de i)
                        if (dateDeNaissance.Month == uneAutreDate.Month && dateDeNaissance.Day == uneAutreDate.Day)
                        {
                            résultat = résultat + " Et c'était pile le jour de son anniversaire !";
                        }
                        break;
                    }
                }
            }

            MessageBox.Show(résultat); // On affiche le résultat de l'algorithme dans une boite de message
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}