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
    public partial class DodajKierownikaWydzialuForm : Form
    {
        public KierownikWydzialu NowyKierownikWydzialu { get; set; }
        public DodajKierownikaWydzialuForm()
        {
            InitializeComponent();
        }

        private void buttonAddKierownik_Click(object sender, EventArgs e)
        {
            NowyKierownikWydzialu = new KierownikWydzialu
            {
                Name = textBoxLastName.Text,
                LastName = textBoxLastName.Text,
                WydzialID = Convert.ToInt32(textBoxWydzialID.Text),
            };
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
