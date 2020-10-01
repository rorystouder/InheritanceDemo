using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Car myCar = new Car();

            string enteredMake = txtMake.Text;
            string enteredModel = txtModel.Text;
            int enteredMileage = int.Parse(txtMileage.Text);
            decimal enteredPrice = decimal.Parse(txtPrice.Text);
            int enteredDoors = int.Parse(txtDoors.Text);

            myCar.Make = enteredMake;
            myCar.Model = enteredModel;
            myCar.Mileage = enteredMileage;
            myCar.Price = enteredPrice;
            myCar.Doors = enteredDoors;

            lblMake.Text = myCar.Make;
            lblModel.Text = myCar.Model;
            lblMileage.Text = myCar.Mileage.ToString("N");
            lblPrice.Text = myCar.Price.ToString("C");
            lblDoors.Text = myCar.Doors.ToString();
        }
    }
}
