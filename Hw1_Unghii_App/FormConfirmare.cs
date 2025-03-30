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
    public partial class FormConfirmare : Form
    {
        public FormConfirmare(string confirmare)
        {
            InitializeComponent();

            // Afisez mesajul de confirmare in label
            label1.Text = confirmare;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Close();
        }
    }
}
