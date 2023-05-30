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
    public partial class Form1 : Form
    {
        CrystalReport1 CR;

        private readonly OracleDataAdapter adapter;
        private DataSet ds;
        string connection_string = "User Id=scott;Password=tiger;Data Source=orcl;";
        public Form1()
        {
            InitializeComponent();
            cmb_property_type.SelectedIndex = 0;
        }

        private void checkDealsBtn_Click(object sender, EventArgs e)
        {
            if(dest_name.Text == "")
            {
                MessageBox.Show("Cannot find a deal with the destination being provided", "Error", MessageBoxButtons.OK);
                return;
            }

            var command_string = @"
            select deal_desc, price_per_night, deal_rating, fk_booking_name, deal_available 
            from deals 
            where dest_name=:dest and  
            deal_rating=:rating and 
            no_of_guests=:guests and 
            deal_property_type=:property_type and 
            deal_available='y'";

            OracleDataAdapter adapter = new OracleDataAdapter(command_string, connection_string);
            adapter.SelectCommand.Parameters.Add("dest", dest_name.Text);
            adapter.SelectCommand.Parameters.Add("rating", deal_rating.Value);
            adapter.SelectCommand.Parameters.Add("guests", no_of_guests.Value);
            adapter.SelectCommand.Parameters.Add("property_type", cmb_property_type.SelectedItem.ToString());

            ds = new DataSet();
            adapter.Fill(ds);

            dealListView.Columns.Add("Deal Description");
            dealListView.Columns.Add("Price per night");
            dealListView.Columns.Add("Rating");
            dealListView.Columns.Add("Booking platform");

            foreach (DataRow dataRow in ds.Tables[0].Rows)
                dealListView.Items.Add(new ListViewItem(new string[] {
                dataRow[0].ToString(),
                dataRow[1].ToString(),
                dataRow[2].ToString(),
                dataRow[3].ToString()
            }));
           

        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            foreach(int selectedIndex in dealListView.SelectedIndices)
            {
                ds.Tables[0].Rows[selectedIndex][4] = "n";
            }

            new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void view_report_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
