using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDevWhispering
{
    public partial class DivingReceipt : Form
    {

        private double Package1Price = 53174.47;
        private double Package2Price = 89369.36;
        private double Package3Price = 181155.74;

        private int numericPackage1 = 0;
        private int numericPackage2 = 0;
        private int numericPackage3 = 0;

        private double package1SubTotal = 0;
        private double package2SubTotal = 0;
        private double package3SubTotal = 0;

        private double totalPrice = 0;

        public static DateTime reservation;

        public DivingReceipt()
        {
            InitializeComponent();
            rjDatePicker1.MinDate = DateTime.Now;
        }

        private void discoverBtn_Click(object sender, EventArgs e)
        {
            WaterSportsActivities waterSportsActivities = new WaterSportsActivities();
            waterSportsActivities.Show();
            this.Hide();
        }

        private void BackBtn_MouseEnter(object sender, EventArgs e)
        {
            BackBtn.ForeColor = Color.White;
        }

        private void BackBtn_MouseLeave(object sender, EventArgs e)
        {
            BackBtn.ForeColor = Color.FromArgb(0x22A2E3);
        }

        private void viewReceiptBtn_MouseEnter(object sender, EventArgs e)
        {
            viewReceiptBtn.ForeColor = Color.White;
        }

        private void viewReceiptBtn_MouseLeave(object sender, EventArgs e)
        {
            viewReceiptBtn.ForeColor = Color.FromArgb(0x22A2E3);
        }



        private void package1Qnt_ValueChanged(object sender, EventArgs e)
        {
           numericPackage1 = Convert.ToInt32(package1Qnt.Value);
           package1SubTotal =  numericPackage1* Package1Price;
           package1Total.Text = "P" + package1SubTotal.ToString("N2");
           UpdateTotalPrice();
        }

        private void package2Qnt_ValueChanged(object sender, EventArgs e)
        {
            numericPackage2 = Convert.ToInt32(package2Qnt.Value);
            package2SubTotal = numericPackage2 * Package2Price;
            package2Total.Text = "P" + package2SubTotal.ToString("N2");
            UpdateTotalPrice();
        }

        private void package3Qnt_ValueChanged(object sender, EventArgs e)
        {
            numericPackage3 = Convert.ToInt32(package3Qnt.Value);
            package3SubTotal = numericPackage3 * Package3Price;
            package3Total.Text = "P" + package3SubTotal.ToString("N2");
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice() {
            totalPrice = package1SubTotal + package2SubTotal + package3SubTotal;
            overallTotal.Text = "P" + totalPrice.ToString("N2");
        }

        private void bookNowBtn_Click(object sender, EventArgs e)
        {
            if(HomeForm.currentEmail == "")
            {
                MessageBox.Show("You must log in.");
                return;
            }

            string package1Qnt = "";
            string package1FinalSubTotal = "";
            string package2Qnt = "";
            string package2FinalSubTotal = "";
            string package3Qnt = "";
            string package3FinalSubTotal = "";
            string overallFinalTotal = "";

            if (numericPackage1 > 0) {
                 package1Qnt = numericPackage1.ToString() + " x Package 1";
                 package1FinalSubTotal = package1Total.Text;
            }

            if (numericPackage2 > 0)
            {
                package2Qnt = numericPackage2.ToString() + " x Package 2";
                package2FinalSubTotal = package2Total.Text;
            }

            if (numericPackage3 > 0)
            {
                package3Qnt = numericPackage3.ToString() + " x Package 3";
                package3FinalSubTotal = package3Total.Text;
            }

            overallFinalTotal = overallTotal.Text;
            reservation = rjDatePicker1.SelectedDate;

            DivingFinalReceipt divingFinalReceipt = new DivingFinalReceipt(package1Qnt, package1FinalSubTotal, package2Qnt, package2FinalSubTotal, package3Qnt, package3FinalSubTotal,overallFinalTotal);
            divingFinalReceipt.Show();
        }

        private void viewReceiptBtn_Click(object sender, EventArgs e)
        {
            DivingFinalReceipt divingFinalReceipt = new DivingFinalReceipt();
            divingFinalReceipt.Show();
        }

        private void DivingReceipt_Load(object sender, EventArgs e)
        {

        }
    }
}
