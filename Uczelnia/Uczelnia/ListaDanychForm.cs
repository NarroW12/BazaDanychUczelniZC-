﻿using System;
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
    public partial class ListaDanychForm : Form
    {
        private UczniowieDataAccess uczniowieDataAccess = new UczniowieDataAccess();

        public ListaDanychForm()
        {
            InitializeComponent();
        }

        private void buttonWyswietlUczniow_Click(object sender, EventArgs e)
        {
            List<Uczniowie> listaUczniow = uczniowieDataAccess.PobierzUczniow();

            dataGridViewUczniowie.DataSource = listaUczniow;
        }

        private void buttonShowTeaher_Click(object sender, EventArgs e)
        {
            List<Teachers> listaWykladowdow = WykladowcyDataAccess.pobierzWykladowcow();
            dataGridViewUczniowie.DataSource = listaWykladowdow;

        }

        private void buttonShowHR_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowWydziały_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowKierownicyWydzialu_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowMarks_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        }
    }
}
