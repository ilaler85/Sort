using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void заполнитьСлучайнымиЧисламиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            if (i == 0)
            {
                
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ColvoMass_Click(object sender, EventArgs e)
        {
            labVvod.Visible = true;
            vvod.Visible = true;
            butVvod.Visible = true;

        }

        private void butVvod_Click(object sender, EventArgs e)
        {
            string tmp = vvod.Text;
            if (int.TryParse(tmp, out i))
            {
                labVvod.Visible = false;
                vvod.Visible = false;
                butVvod.Visible = false;
            }
            else
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
    }
}
