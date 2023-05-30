using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using CrystalDecisions.Shared;

namespace HotelTrivago
{
    public partial class Report1Form : Form
    {
        CrystalReport1 CR;

        public Report1Form()
        {
           
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);

            foreach (ParameterDiscreteValue v1 in CR.ParameterFields[1].DefaultValues)
                comboBox2.Items.Add(v1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, comboBox1.Text);
            CR.SetParameterValue(1, comboBox2.Text);
            crystalReportViewer1.ReportSource = CR;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
