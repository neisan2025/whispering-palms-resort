using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AppsDevWhispering
{    
    public partial class ProfileInformationForm : Form
    {
        string firstName, lastName, displayName, email, contact;

        public ProfileInformationForm(string firstName, string lastName, string displayName, string email, string contact)
        {
            InitializeComponent();
            this.firstName = firstName;
            this.lastName = lastName;
            this.displayName = displayName;
            this.email = email;
            this.contact = contact;
        }

        private void ProfileInformationForm_Load(object sender, EventArgs e)
        {
            labelFirstName.Parent = panel1;
            labelLastName.Parent = panel1;
            labelDisplayName.Parent = panel1;
            labelEmail.Parent = panel1;
            labelContact.Parent = panel1;

            labelFirstName.Text = firstName;
            labelLastName.Text = lastName;
            labelDisplayName.Text = displayName;
            labelEmail.Text = email;
            labelContact.Text = contact;
        }
    }
}
