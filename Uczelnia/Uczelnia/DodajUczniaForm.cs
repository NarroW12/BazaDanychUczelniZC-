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
    public partial class DodajUczniaForm : Form
    {
        public Uczniowie NowyUczen { get; private set; }

        public DodajUczniaForm()
        {
            InitializeComponent();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            NowyUczen = new Uczniowie
            {
                Name = NametextBox.Text,
                LastName = LastNametextBox.Text,
                IndexNumber = IndexNumbertextBox.Text,
                Semester = Convert.ToInt32(SemestertextBox.Text)
            };

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

    
    }
}
