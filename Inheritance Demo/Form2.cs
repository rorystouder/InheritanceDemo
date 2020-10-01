using System;
using System.Windows.Forms;

namespace Inheritance_Demo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Truck myTruck = new Truck();
            myTruck.Make = "Ford";
            myTruck.Model = "F150";
            myTruck.Mileage = 75000;
            myTruck.Price = 15000;
            myTruck.Drive = "Four Wheel Drive";

            WorkTruck myWorkTruck = new WorkTruck();
            myWorkTruck.Make = "International";
            myWorkTruck.Mileage = 10000;
            myWorkTruck.Price = 35000;
            myWorkTruck.Model = "WorkStar";
            myWorkTruck.Weight = 5000;
            myWorkTruck.Drive = "Two Wheel Drive";

            DisplayTruckInformation(myTruck);
            DisplayTruckInformation(myWorkTruck);

            //DisplayWorkTruckInformation(myTruck);
            DisplayWorkTruckInformation(myWorkTruck);
        }

        private void DisplayTruckInformation(Truck t)
        {
            string information = t.Make + " " + t.Model + ", with " + t.Mileage.ToString("N") + " miles, and Drive: " + t.Drive +
                " for " + t.Price.ToString("C");

            MessageBox.Show(information);
        }

        private void DisplayWorkTruckInformation(WorkTruck t)
        {
            string information = t.Make + " " + t.Model + ", with " + t.Mileage.ToString("N") + " miles, Drive: " + t.Drive +
                ", and Weight: " + t.Weight.ToString("N") + " for " + t.Price.ToString("C");

            MessageBox.Show(information);
        }
    }
}