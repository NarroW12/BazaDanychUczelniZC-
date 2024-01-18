using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uczelnia
{
    public partial class DodajNauczycielaForm : Form
    {
        public Teachers NowyNauczyciel { get; set; }
        public DodajNauczycielaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NowyNauczyciel = new Teachers
            {
                Name = textBoxName.Text,
                LastName = textBoxLastName.Text,
                Stopien = textBoxStopien.Text,
                Specjalizacja = textBoxSpecjalizacja.Text,
            };
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
