// For File.Exists, Directory.Exists
using System;
using System.IO;
using System.Collections;

namespace FolderCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chemin = textBox1.Text;
            if (Directory.Exists(chemin))
            { 
                MessageBox.Show("Le chemin sp�cifi� existe et est un r�pertoire.");
            }
            else if (File.Exists(chemin))
            {
                MessageBox.Show("Le chemin sp�cifi� est un fichier et non un r�pertoire.");
            }
            else if ((!Directory.Exists(chemin) || !File.Exists(chemin)))
            {
                MessageBox.Show("Le chemin sp�cifi� n'existe pas, est incorrect ou n'est pas accessible.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chemin = textBox1.Text;
            if (Directory.Exists(chemin))
            {
                int nbFichiers = Directory.GetFiles(chemin, "*", SearchOption.TopDirectoryOnly).Length;
                MessageBox.Show("Le r�pertoire contient " + nbFichiers + " fichiers � l'int�rieur.");
            }
            else
            {
                MessageBox.Show("Le chemin sp�cifi� n'existe pas, est incorrect ou n'est pas accessible. Impossible de compter le n�ant.");
            }
        }
    }
}