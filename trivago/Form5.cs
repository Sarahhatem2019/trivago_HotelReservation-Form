using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace HotelTrivago
{
    public partial class Form5 : Form
    {
        CrystalReport4 CR1;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CR1 = new CrystalReport4();
            foreach (ParameterDiscreteValue v in CR1.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR1.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = CR1;
        }
    }
}
