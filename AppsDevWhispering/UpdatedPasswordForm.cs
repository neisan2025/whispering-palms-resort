using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppsDevWhispering
{
    public partial class UpdatedPasswordForm : Form
    {
        string currentPass, newPass, confirmPass;

        public UpdatedPasswordForm(string currentPass, string newPass, string confirmPass)
        {
            InitializeComponent();
            this.currentPass = currentPass;
            this.newPass = newPass;
            this.confirmPass = confirmPass;
        }

        private void UpdatedPasswordForm_Load(object sender, EventArgs e)
        {
            labelCurrentPass.Parent = panel1;
            labelNewPass.Parent = panel1;
            labelConfirmPass.Parent = panel1;

            labelCurrentPass.Text = currentPass;
            labelNewPass.Text = newPass;
            labelConfirmPass.Text = confirmPass;
        }
    }
}
