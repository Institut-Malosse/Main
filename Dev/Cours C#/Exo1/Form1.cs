namespace Exo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TxtPrénom.Text = Environment.UserName;
            TxtAutreDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string résultat = "(texte vide)"; // On déclare un variable chaine contenant "(texte vide)"
            string prénom = TxtPrénom.Text; // On déclare une variable chaine contenant "Jean-Michel"
            if (string.IsNullOrEmpty(prénom))
            {
                MessageBox.Show("Vous n'avez pas saisi de prénom !"); //Vérification du champ prénom. S'il est vide, affiche et message d'erreur.
                return;
            }
            //DateTime dateDeNaissance = DateTime.Parse(TxtDateNaissance.Text); // On déclare une variable date contenant 20/07/1990
            if (!DateTime.TryParse(TxtDateNaissance.Text, out DateTime dateDeNaissance))
            {
                MessageBox.Show("La date de naissance ne respecte pas le format local !");
                return;
            }
            //DateTime uneAutreDate = DateTime.Parse(TxtAutreDate.Text); // On déclare une variable date contenant 22/08/2010
            if (!DateTime.TryParse(TxtAutreDate.Text, out DateTime uneAutreDate))
            {
                MessageBox.Show("La date de comparaison ne respecte pas le format local !");
                return;
            }
            int age;
            int i = 0;
            if (dateDeNaissance > uneAutreDate) // Si la date de naissance est supérieure à l'autre date
            {
                // Oui : la date de naissance EST supérieure à l'autre date !
                // On concatène une réponse pour dire que la personne n'était pas née
                résultat = prénom + " n'était même pas né(e) le " + uneAutreDate.ToString() + " !";
            }
            else
            {
                // Non : la date de naissance N'EST PAS supérieure à l'autre date !
                while (true) // On démarre une boucle, avec une variable i, de type entier (itérateur)
                {
                    i += 1;
                    if (dateDeNaissance.AddYears(i) > uneAutreDate) // Si la date de naissance + i année(s) est supérieure ou égale à l'autre date
                    {
                        // Oui : la date de naissance + i année(s) EST supérieure ou égale à l'autre date !
                        age = i - 1;
                        résultat = prénom + " avait " + age.ToString() + " an(s) !"; // On indique l'age calculé (qui vaut la valeur de i)
                        if (dateDeNaissance.Month == uneAutreDate.Month && dateDeNaissance.Day == uneAutreDate.Day)
                        {
                            résultat = résultat + " Et c'était pile le jour de son anniversaire !";
                        }
                        break;
                    }
                }

                MessageBox.Show(résultat); // On affiche le résultat de l'algorithme dans une boite de message
            }
        }

       
    }
}