using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconnectedModel1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbAirflight.Text == "" || tbFlightNo.Text == "" ||
                tbDestination.Text == "")
            {
                MessageBox.Show("No textboxes can be empty", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Manage data itself
                //All the columns, all the rows
                DataSet1 ds1 = new DataSet1();

                //Need another object to transfering data to the real database
                DataSet1TableAdapters.FlightInfo1TableAdapter taFlight
                    = new DataSet1TableAdapters.FlightInfo1TableAdapter();

                DataSet1.FlightInfo1Row fRow = ds1.FlightInfo1.NewFlightInfo1Row();
                fRow.AirLine = tbAirflight.Text;
                fRow.FlightNum = tbFlightNo.Text;
                fRow.Destination = tbDestination.Text;
                fRow.AirplaneType = cmbAirplane.SelectedItem.ToString();

                //In the offline database
                ds1.FlightInfo1.Rows.Add(fRow);
                //Get it back to the real database
                taFlight.Update(ds1.FlightInfo1);

                //Get the latest database
                taFlight.Fill(ds1.FlightInfo1);
                cmbFlight.DataSource = ds1.FlightInfo1;
                dataGridView1.DataSource = ds1.FlightInfo1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataSet1 ds1 = new DataSet1();
            DataSet1TableAdapters.FlightInfo1TableAdapter taFlight
                = new DataSet1TableAdapters.FlightInfo1TableAdapter();

            taFlight.Fill(ds1.FlightInfo1);//Get the lateset and put into ds1.flightinfo1

            int selected = Convert.ToInt32(cmbFlight.SelectedValue);

            DataRow[] dr = ds1.FlightInfo1.Select("ID="+selected);//Inside is where clause

            dr[0]["Airline"] = tbAirflight.Text;
            dr[0]["FlightNum"] = tbFlightNo.Text;
            dr[0]["Destination"] = tbDestination.Text;
            dr[0]["AirplaneType"] = cmbAirplane.SelectedItem.ToString();

            taFlight.Update(ds1.FlightInfo1);

            MessageBox.Show("Flight Update", "Confirm", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            taFlight.Fill(ds1.FlightInfo1);
            cmbFlight.DataSource = ds1.FlightInfo1;
            dataGridView1.DataSource = ds1.FlightInfo1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataSet1 ds1 = new DataSet1();
            DataSet1TableAdapters.FlightInfo1TableAdapter taFlight
                = new DataSet1TableAdapters.FlightInfo1TableAdapter();

            taFlight.Fill(ds1.FlightInfo1);
            int selected = Convert.ToInt32(cmbFlight.SelectedValue);

            DataRow[] dr = ds1.FlightInfo1.Select("ID=" + selected);
            dr[0].Delete();

            taFlight.Update(ds1.FlightInfo1);

            MessageBox.Show("Flight Deleted", "Confirm", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            taFlight.Fill(ds1.FlightInfo1);
            cmbFlight.DataSource = ds1.FlightInfo1;
            dataGridView1.DataSource = ds1.FlightInfo1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'week5DataSet.FlightInfo1' table. You can move, or remove it, as needed.
            this.flightInfo1TableAdapter.Fill(this.week5DataSet.FlightInfo1);
            cmbAirplane.SelectedIndex = 0;
        }

        private void cmbFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet1 ds1 = new DataSet1();
            DataSet1TableAdapters.FlightInfo1TableAdapter taFlight
                = new DataSet1TableAdapters.FlightInfo1TableAdapter();

            taFlight.Fill(ds1.FlightInfo1);

            int selected = Convert.ToInt32(cmbFlight.SelectedValue);
            DataRow[] dr = ds1.FlightInfo1.Select("ID=" + selected);


            tbAirflight.Text = dr[0]["Airline"].ToString();
            tbFlightNo.Text = dr[0]["FlightNum"].ToString();
            tbDestination.Text = dr[0]["Destination"].ToString();
            cmbAirplane.SelectedItem = dr[0]["AirplaneType"].ToString();
        }
    }
}
