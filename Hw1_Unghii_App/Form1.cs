using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Variabila pentru retinerea combinatiei finale de lungime + forma + culoare + model + finisaj
        public static string ModelFinal = "";

        private void buttonGenerare_Click(object sender, EventArgs e)
        {
           
            // Utilizez un TrackBar pt. lungimea unghiei
            string lungimeUnghie = "";
            switch (trackBarLungime.Value)
            {
                case 1: lungimeUnghie = "scurta"; break;
                case 2: lungimeUnghie = "medie"; break;
                case 3: lungimeUnghie = "lunga"; break;
                default: lungimeUnghie = "medie"; break;
            }


            // Utilizez 3 RadioButton-uri pentru forma unghiei
            string formaUnghie = "";
            if (radioPatrata.Checked) formaUnghie = "patrata";
            if (radioOvala.Checked) formaUnghie = "ovala";
            if (radioMigdala.Checked) formaUnghie = "migdala";


            // Selectez culoarea unghiei dintr-un ListBox, iar negru e culoarea default, daca utilizatorul nu selecteaza altceva
            string culoareUnghie = listBoxCulori.SelectedItem?.ToString()?.ToLower() ?? "negru";


            // Selectez modelul unghiei dintr-un ListBox, iar simplu e modelul default, daca utilizatorul nu selecteaza altceva
            string modelUnghie = listBoxModel.SelectedItem?.ToString()?.ToLower() ?? "simplu";


            // Utilizez 2 RadioButton-uri pentru finisajul unghiei
            string finisaj = "";
            if (radioMat.Checked) finisaj = "mat";
            if (radioLucios.Checked) finisaj = "lucios";


            // Numele imaginii construit pe baza combinarilor (108 in total)
            string numeImagine = $"{lungimeUnghie}_{formaUnghie}_{culoareUnghie}_{modelUnghie}_{finisaj}.jpg";


            // Combinatia finala salvata pentru a fi folosita la programare
            ModelFinal = $"{lungimeUnghie}, {formaUnghie}, {culoareUnghie}, {modelUnghie}, {finisaj}";


            // Construiesc calea catre imagine pentru ca mai apoi sa pot verifica daca imaginea exista
            string caleImagine = Path.Combine(Application.StartupPath, "imagini", numeImagine);

            if (File.Exists(caleImagine))
            {
                // Verific daca PictureBox-ul contine deja o imagine ( daca da, o elimin din memorie)
                if (pictureBoxRezultat.Image != null)
                {
                    pictureBoxRezultat.Image.Dispose();
                    pictureBoxRezultat.Image = null;
                }

                // Deschid imaginea si o redimensionez pentru a fi potrivita in PictureBox
                using (FileStream fs = new FileStream(caleImagine, FileMode.Open, FileAccess.Read))
                using (Image img = Image.FromStream(fs))
                {
                    int maxWidth = 300;
                    int maxHeight = 300;

                    int width = img.Width;
                    int height = img.Height;
                    
                    // Calculez cat trebuie reduse dimensiunile 
                    // apoi creez imaginea redimensionat  si o introduc in PictureBox
                    float scale = Math.Min((float)maxWidth / width, (float)maxHeight / height);
                    int newWidth = (int)(width * scale);
                    int newHeight = (int)(height * scale);

                    Bitmap resizedImg = new Bitmap(img, new Size(newWidth, newHeight));
                    pictureBoxRezultat.Image = resizedImg;
                }
            }
            else
            {
                MessageBox.Show($"Imaginea „{numeImagine}” nu a fost găsită.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonFaProgramare_Click(object sender, EventArgs e)
        {
            // Pop-up cu formularul de programare
            FormProgramare fProg = new FormProgramare();
            fProg.ShowDialog();
        }
    }
}
