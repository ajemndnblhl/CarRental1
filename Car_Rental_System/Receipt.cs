using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void Receipt_Load(object sender, EventArgs e)
        {

            DateTime pdate = Filloutform.pickupDate;
            DateTime rdate = Filloutform.returnDate;
            int price = 0;
            int total = 0;
            

            // Calculate total days of rent
            int totDayRent = (rdate - pdate).Days;

            label5.Text = Filloutform.pDate;
            label21.Text = Filloutform.fname + " " + Filloutform.mi + " " + Filloutform.lname;
            label22.Text = Filloutform.age;
            label24.Text = Filloutform.address;
            label25.Text = Filloutform.carRented;
            label26.Text = Filloutform.pDate;
            label27.Text = Filloutform.rDate;
            label28.Text = Convert.ToString(totDayRent);
            if (Car1.rentedCar == "YARIS CROSS 1.5 V CVT")
            {
                price = 1040;
            }
            else if (Car1.rentedCar == "VIOS 1.5 G CVT")
            {
                price = 1500;
            }
            else if (Car1.rentedCar == "RAIZE 1.0 Turbo CVT")
            {
                price = 1350;
            }
            else if (Car1.rentedCar == "MAZDA BT-50")
            {
                price = 1200;
            }
            else if (Car1.rentedCar == "MAZDA 6")
            {
                price = 1200;
            }
            label29.Text = Convert.ToString(price);
            total = totDayRent * price;
            label30.Text = Convert.ToString(total);


        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }
    }
}
