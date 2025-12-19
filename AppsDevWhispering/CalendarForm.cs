using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDevWhispering
{
    public partial class CalendarForm : Form
    {
        public static DateTime checkInDate;
        public static DateTime checkOutDate;
        public static string checkInTimeComboBox;
        public static string checkOutTimeComboBox;
        public static DateTime checkOutDateWithBreak;
        public static int totalGuest = 0;
        public CalendarForm()
        {
            InitializeComponent();
            totalGuest = 0;
            checkInCalendar.SelectedDate = DateTime.Now;
            checkOutCalendar.SelectedDate = DateTime.Now;
            checkInCalendar.MinDate = DateTime.Now;
            checkOutCalendar.MinDate = DateTime.Now;
        }

        private void searchRoom_Click_1(object sender, EventArgs e)
        {
            if(HomeForm.currentEmail == "")
            {
                MessageBox.Show("You must log in!");
                return;
            }

            if(guestNumber.Text == "0")
            {
                MessageBox.Show("Please enter the number of guests");
                return;
            }

            checkInDate = checkInCalendar.SelectedDate;
            checkOutDate = checkOutCalendar.SelectedDate;
            checkInTimeComboBox = checkInTime.Text;
            checkOutTimeComboBox = checkOutTime.Text;

            DateTime dateTime1 = DateTime.ParseExact(checkInTimeComboBox, "h:mm tt", CultureInfo.InvariantCulture);
            string militaryTime1 = dateTime1.ToString("HH:mm:ss");
            string[] split1 = militaryTime1.Split(':');
            DateTime dateTime2 = DateTime.ParseExact(checkOutTimeComboBox, "h:mm tt", CultureInfo.InvariantCulture);
            string militaryTime2 = dateTime2.ToString("HH:mm:ss");
            string[] split2 = militaryTime2.Split(':');


            int checkInYear = checkInDate.Year;
            int checkInMonth = checkInDate.Month;
            int checkInDay = checkInDate.Day;

            int checkOutYear = checkOutDate.Year;
            int checkOutMonth = checkOutDate.Month;
            int checkOutDay = checkOutDate.Day;

            int checkInHour = Convert.ToInt32(split1[0]);
            int checkInMinute = Convert.ToInt32(split1[1]);
            int checkInSecond = Convert.ToInt32(split1[2]);

            int checkOutHour = Convert.ToInt32(split2[0]);
            int checkOutMinute = Convert.ToInt32(split2[1]);
            int checkOutSecond = Convert.ToInt32(split2[2]);

            int checkOutHourWithBreak = Convert.ToInt32(split2[0]) + 2;

            CalendarForm.checkInDate = new DateTime(checkInYear, checkInMonth, checkInDay, checkInHour, checkInMinute, checkInSecond);
            CalendarForm.checkOutDate = new DateTime(checkOutYear, checkOutMonth, checkOutDay, checkOutHour, checkOutMinute, checkOutSecond);
            CalendarForm.checkOutDateWithBreak = new DateTime(checkOutYear, checkOutMonth, checkOutDay, checkOutHourWithBreak, checkOutMinute, checkOutSecond);


            //Console.WriteLine(checkInDate.ToShortDateString());
            //Console.WriteLine(checkOutDate.ToShortDateString());

            if (checkInDate > checkOutDate)
            {
                MessageBox.Show("Check-in date must be lower.");
                return;
            }
            else if(checkInDate == checkOutDate)
            {
                MessageBox.Show("Check-in date must not be equal to check-out date.");
                return;
            }

            // Check if any time is selected
            if (string.IsNullOrEmpty(checkInTimeComboBox) || string.IsNullOrEmpty(checkOutTimeComboBox))
            {
                // Handle case where no time is selected
                MessageBox.Show("Please select check-in and check-out times.");
                return;
            }

            // Get the number of guests
            int totalGuestNumber;
            if (!int.TryParse(guestNumber.Text, out totalGuestNumber))
            {
                // Handle invalid input
                MessageBox.Show("Please enter a valid number of guests.");
                return;
            }

            // Pass booking details to AvailableRooms
            AvailableRooms availableRooms = new AvailableRooms();
            availableRooms.GetBookingDetails();
            availableRooms.Show();
            this.Hide();
        }
        private void addGuestBtn_Click(object sender, EventArgs e)
        {
            totalGuest++;
            guestNumber.Text = totalGuest.ToString();
        }
        private void subtractGuestBtn_Click(object sender, EventArgs e)
        {
            if (totalGuest > 0)
            {
                totalGuest--;
                guestNumber.Text = totalGuest.ToString();
            }
        }

        private void addGuestBtn_MouseEnter_1(object sender, EventArgs e)
        {
            addGuestBtn.ForeColor = Color.White;
        }

        private void addGuestBtn_MouseLeave_1(object sender, EventArgs e)
        {
            addGuestBtn.ForeColor = Color.FromArgb(0x22A2E3);
        }

        private void subtractGuestBtn_MouseEnter_1(object sender, EventArgs e)
        {
            subtractGuestBtn.ForeColor = Color.White;
        }

        private void subtractGuestBtn_MouseLeave_1(object sender, EventArgs e)
        {
            subtractGuestBtn.ForeColor = Color.FromArgb(0x22A2E3);
        }
        private void cancelInfo_MouseEnter_1(object sender, EventArgs e)
        {
            cancelInfo.ForeColor = Color.White;
        }

        private void cancelInfo_MouseLeave_1(object sender, EventArgs e)
        {
            cancelInfo.ForeColor = Color.FromArgb(0x22A2E3);
        }

        private void cancelInfo_Click(object sender, EventArgs e)
        {
            RoomsForm roomsForm = new RoomsForm();
            roomsForm.Show();
            this.Hide();
        }

        private void checkInCalendar_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
