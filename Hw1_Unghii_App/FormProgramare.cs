using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hw1_Unghii_App
{
    public partial class FormProgramare : Form
    {
        public FormProgramare()
        {
            InitializeComponent();
            // Am ales un interval orar pentru a-l adauga in ComboBox
            for (int ora = 8; ora <= 17; ora++)
            {
                comboOra.Items.Add(ora.ToString("D2"));
            }
            
            // Am ales minutele posibile si le-am adaugat intr-un alt ComboBox
            comboMinute.Items.Add("00");
            comboMinute.Items.Add("15");
            comboMinute.Items.Add("30");
            comboMinute.Items.Add("45");

            // Ora default este 08:00
            comboOra.SelectedIndex = 0;
            comboMinute.SelectedIndex = 0;

        }

        private void buttonConfirma_Click(object sender, EventArgs e)
        {

            // Preiau data, ora, minutele selectate si utilizatorul + modelul ( selectat ulterior in Form1)
            DateTime data = calendarProgramare.SelectionStart;

            string ora = comboOra.SelectedItem.ToString();
            string minut = comboMinute.SelectedItem.ToString();
            string orafinala = $"{ora}:{minut}";

            string username = FormLogin.UsernameAutentificat;
            string model = Form1.ModelFinal;

            // Construiesc linia pe care apoi o adaug in fisierul programari.txt
            string linie =
                $"Utilizator: {username}\n" +
                $"Model: {model}\n" +
                $"Programare : {data.ToLongDateString()} la ora {orafinala}\n";

            File.AppendAllText("programari.txt", linie);

            // Mesajul de confirmare afisat in form-ul de confirmare
            FormConfirmare confirmare = new FormConfirmare($"Programarea ta pentru data de {data.ToLongDateString()} la ora {orafinala} a fost realizata cu succes!");
            confirmare.ShowDialog();

            

        }
    }
}
