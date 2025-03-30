using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw1_Unghii_App
{
    public partial class FormLogin : Form
    {
        // Dictionar pentru utilizatori si parole
        Dictionary<string, string> utilizatori = new Dictionary<string, string>()
        {
            {"admin", "1234"},
            {"oana", "oana123" },
            {"ana", "ana456" },
            {"maria", "maria789" },
            {"ioana", "ioana123" },
            {"sofia", "sofia456" }

        };
        public FormLogin()
        {
            InitializeComponent();

            // Parola va avea caracterele ascunse( cu *)
            textBoxParola.UseSystemPasswordChar = true;
        }
        // Retin utilizatorul care s-a logat
        public static string UsernameAutentificat;
        private void button1_Click(object sender, EventArgs e)
        {
            // Preluarea username-ului si a parolei introduse de utilizator
            string username = textBoxUsername.Text;
            string parola = textBoxParola.Text;

            // Verific daca username-ul exista si daca parola corespunde
            // dupa aceea salvez numele utilizatorului logat 
            // si deschid form-ul principal
            if(utilizatori.ContainsKey(username) && utilizatori[username] == parola)
            {
                UsernameAutentificat = username;

                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Utilizator sau parola incorecte!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
