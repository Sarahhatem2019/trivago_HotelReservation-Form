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
namespace HotelTrivago
{
    public partial class Form4 : Form
    {
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Form4()
        {
            InitializeComponent();
           
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select USER_ID from USER_INFO";
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();


            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select DEAL_ID from DEALS";
            OracleDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox2.Items.Add(dr1[0]);
            }
            dr1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = " insert into USER_DEAL values(:USER_ID,:DEAL_ID,:feedback)";
            cmd.Parameters.Add("USER_ID", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("DEAL_ID", comboBox2.SelectedItem.ToString());
            cmd.Parameters.Add("feedback", textBox2.Text);

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("Your feedback inserted");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = " VIEW_Feedback ";
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.Add("DEAL_ID", textBox1.Text);
            cmd.Parameters.Add("feedbackk", OracleDbType.RefCursor, ParameterDirection.Output);
            
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dr);
            
            
                dataGridView1.DataSource = dataTable;
                
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "count_feedback";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("deal_id", comboBox2.SelectedItem.ToString());
            cmd.Parameters.Add("count", OracleDbType.Int32, ParameterDirection.Output);
             cmd.ExecuteNonQuery();
           
                count = Convert.ToInt32(cmd.Parameters["count"].Value.ToString());
                textBox1.Text = count.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report2Form form5 = new Report2Form();
            form5.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

