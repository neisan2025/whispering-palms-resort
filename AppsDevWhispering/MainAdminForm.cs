using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppsDevWhispering
{
    public partial class MainAdminForm : Form
    {
        private readonly FinanceAdmin financeAdmin = new FinanceAdmin();
        private readonly AdminRoomsForm roomsForm = new AdminRoomsForm();
        private readonly AdminGuestInfo guestInfoForm = new AdminGuestInfo();
        private readonly AdminDiningInfo diningInfoForm = new AdminDiningInfo();
        private readonly AdminDivingInfo divingInfoForm = new AdminDivingInfo();
        private readonly AdminUpdatesForm updatesForm = new AdminUpdatesForm();
        private readonly AdminTransactionForm transactionForm = new AdminTransactionForm();
        private readonly AdminRoomBooking roomBookingForm = new AdminRoomBooking();
        private readonly AdminDiningBooking diningBookingForm = new AdminDiningBooking();
        private readonly AdminDivingBooking divingBookingForm = new AdminDivingBooking();

        public MainAdminForm()
        {
            InitializeComponent();
        }

        private void dashboardBtn_MouseEnter(object sender, EventArgs e)
        {
            dashboardBtn.Image = Properties.Resources.DashboardBtnHover;
        }

        private void dashboardBtn_MouseLeave(object sender, EventArgs e)
        {
            dashboardBtn.Image = Properties.Resources.DashboardBtn;

        }

        private void roomsBtn_MouseEnter(object sender, EventArgs e)
        {
            roomsBtn.Image = Properties.Resources.RoomBtnHover;
        }

        private void roomsBtn_MouseLeave(object sender, EventArgs e)
        {
            roomsBtn.Image = Properties.Resources.RoomBtn;
        }

        private void guestInfoBtn_MouseEnter(object sender, EventArgs e)
        {
            guestInfoBtn.Image = Properties.Resources.GuestInfoBtnHover;
        }

        private void guestInfoBtn_MouseLeave(object sender, EventArgs e)
        {
            guestInfoBtn.Image = Properties.Resources.GuestInfoBtn;
        }

        private void diningInfoBtn_MouseEnter(object sender, EventArgs e)
        {
            diningInfoBtn.Image = Properties.Resources.DiningInfoBtnHover;
        }

        private void diningInfoBtn_MouseLeave(object sender, EventArgs e)
        {
            diningInfoBtn.Image = Properties.Resources.DiningInfoBtn;
        }

        private void divingIntoBtn_MouseEnter(object sender, EventArgs e)
        {
            divingIntoBtn.Image = Properties.Resources.DivingInfoBtnHover;
        }

        private void divingIntoBtn_MouseLeave(object sender, EventArgs e)
        {
            divingIntoBtn.Image = Properties.Resources.DivingInfoBtn;
        }

        private void updatesBtn_MouseEnter(object sender, EventArgs e)
        {
            updatesBtn.Image = Properties.Resources.UpdatesBtnHover;
        }

        private void updatesBtn_MouseLeave(object sender, EventArgs e)
        {
            updatesBtn.Image = Properties.Resources.UpdatesBtn;
        }
        private void transactionBtn_MouseEnter(object sender, EventArgs e)
        {
            transactionBtn.Image = Properties.Resources.TransactionBtnHover1;
        }

        private void transactionBtn_MouseLeave(object sender, EventArgs e)
        {
            transactionBtn.Image = Properties.Resources.TransactionBtn1;
        }

        private void roomBookBtn_MouseEnter(object sender, EventArgs e)
        {
            roomBookBtn.Image = Properties.Resources.RoomBookBtnHover1;
        }

        private void roomBookBtn_MouseLeave(object sender, EventArgs e)
        {
            roomBookBtn.Image = Properties.Resources.RoomBookBtn1;
        }

        private void divingBookBtn_MouseEnter(object sender, EventArgs e)
        {
            divingBookBtn.Image = Properties.Resources.DiveBookBtnHover1;
        }

        private void divingBookBtn_MouseLeave(object sender, EventArgs e)
        {
            divingBookBtn.Image = Properties.Resources.DiveBookBtn1;
        }

        private void foodBookBtn_MouseEnter(object sender, EventArgs e)
        {
            foodBookBtn.Image = Properties.Resources.FoodBookBtnHover1;
        }

        private void foodBookBtn_MouseLeave(object sender, EventArgs e)
        {
            foodBookBtn.Image = Properties.Resources.FoodBookBtn1;
        }
        private void logoutBtn_MouseEnter(object sender, EventArgs e)
        {
            logoutBtn.Image = Properties.Resources.LogoutBtnHover;
        }

        private void logoutBtn_MouseLeave(object sender, EventArgs e)
        {
            logoutBtn.Image = Properties.Resources.LogoutBtn;
        }

        private void MainAdminForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Hello");
            LoadForm(financeAdmin);
        }
        public void LoadForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void roomsBtn_Click(object sender, EventArgs e)
        {
            LoadForm(roomsForm);
        }

        private void guestInfoBtn_Click(object sender, EventArgs e)
        {
            LoadForm(guestInfoForm);
        }

        private void diningInfoBtn_Click(object sender, EventArgs e)
        {
            LoadForm(diningInfoForm);
        }

        private void divingIntoBtn_Click(object sender, EventArgs e)
        {
            LoadForm(divingInfoForm);
        }

        private void updatesBtn_Click(object sender, EventArgs e)
        {
            LoadForm(updatesForm);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            LoadForm(financeAdmin);
        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {
            LoadForm(transactionForm);
        }

        private void roomBookBtn_Click(object sender, EventArgs e)
        {
            LoadForm(roomBookingForm);
        }

        private void divingBookBtn_Click(object sender, EventArgs e)
        {
            LoadForm(divingBookingForm);
        }

        private void foodBookBtn_Click(object sender, EventArgs e)
        {
            LoadForm(diningBookingForm);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            HomeForm.currentEmail = "";
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
