using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelTrivago
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void giveFeedBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void viewFormReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report2Form f5 = new Report2Form();
            f5.Show();
        }

        private void searchFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DealsForm f1 = new DealsForm();
            f1.Show();
        }

        private void viewReportFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report1Form f2 = new Report1Form();
            f2.Show();
        }
    }
}
