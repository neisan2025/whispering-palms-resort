using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDevWhispering
{
    public partial class AdminUpdatesEdit : Form
    {
        private byte[] imageBytes = null;
        public AdminUpdatesEdit()
        {
            InitializeComponent();
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                UploadImgPic.Image = Image.FromFile(openFileDialog.FileName);
                LoadImageButton.Visible = true;

                string filePath = openFileDialog.FileName;
                imageBytes = File.ReadAllBytes(filePath);
                LoadImageButton.Visible = true;
            }
        }
    }
}
