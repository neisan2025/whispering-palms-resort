using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace AppsDevWhispering
{
    public partial class ReviewsForm : Form
    {
        public ReviewsForm()
        {
            InitializeComponent();
            load();
        }

        private void btnAddPanel_Click(object sender, EventArgs e)
        {
            string accountName = "";
            if (HomeForm.currentEmail == "")
            {
                MessageBox.Show("You must log in to comment.");
                return;
            }
            else if(HomeForm.currentEmail == ".\\admin")
            {
                MessageBox.Show("Admin are unable to comment.");
                return;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
                {
                    connection.Open();

                    string query = "SELECT username, email FROM users WHERE email = @email";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", HomeForm.currentEmail);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                accountName = reader["username"].ToString();
                            }
                        }
                    }
                }
            }
            string userInput = richUserInput.Text.Trim();

            if (!string.IsNullOrEmpty(userInput))
            {

                int parentCommentId = -1; // Default value if insertion fails

                using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
                {
                    connection.Open();

                    // Insert the comment
                    string insertQuery = "INSERT INTO parent_comments (email, username, body, posted) VALUES (@Email, @Username, @Body, @Posted); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Email", HomeForm.currentEmail);
                        command.Parameters.AddWithValue("@Username", accountName);
                        command.Parameters.AddWithValue("@Body", userInput);
                        command.Parameters.AddWithValue("@Posted", DateTime.Now);

                        // Execute the INSERT statement and retrieve the identity value
                        parentCommentId = Convert.ToInt32(command.ExecuteScalar());
                        Console.WriteLine(parentCommentId);
                    }

                    // Check if insertion was successful
                    if (parentCommentId != -1)
                    {
                        Console.WriteLine("Comment saved successfully!");

                        // Print the inserted parent_comment_id
                        Console.WriteLine($"Inserted parent_comment_id: {parentCommentId}");
                    }
                    else
                    {
                        Console.WriteLine("Failed to save the comment.");
                    }
                }

                Panel messageContainer = new Panel();
                messageContainer.BorderStyle = BorderStyle.None;
                messageContainer.AutoSize = false;
                messageContainer.Width = flowLayoutPanel1.ClientSize.Width - 50;
                messageContainer.BackColor = Color.White;

                Label accountLabel = new Label();
                accountLabel.Font = new Font("Proxima Nova", 9f, FontStyle.Regular);
                accountLabel.Text = accountName;
                accountLabel.AutoSize = true;
                accountLabel.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                accountLabel.Padding = new Padding(0, 5, 10, 3);
                messageContainer.Controls.Add(accountLabel);

                if (accountName == "Admin")
                {
                    accountLabel.ForeColor = Color.RoyalBlue;
                    accountLabel.Font = new Font("Proxima Nova", 10f, FontStyle.Bold);
                }
                else
                {
                    accountLabel.ForeColor = Color.Gray;
                }



                Label label = new Label();
                label.Font = new Font("Proxima Nova", 12f, FontStyle.Regular);
                label.Text = userInput;
                label.BackColor = Color.FromArgb(240, 242, 245, 255);
                label.AutoSize = true;
                label.Width = messageContainer.Width - 20;
                label.MaximumSize = new Size(messageContainer.Width - 20, 0);
                label.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                messageContainer.Controls.Add(label);
                label.Padding = new Padding(10, 10, 10, 10);
                int labelHeight = TextRenderer.MeasureText(label.Text, label.Font, label.MaximumSize, TextFormatFlags.WordBreak).Height;
                label.Top = accountLabel.Bottom;
                messageContainer.Height = labelHeight + label.Padding.Top + label.Padding.Bottom + accountLabel.Height;

                flowLayoutPanel1.Controls.Add(messageContainer);

                Button deleteReplyButton1 = new Button();
                deleteReplyButton1.Size = new Size(15, 15);
                deleteReplyButton1.BackColor = Color.FromArgb(240, 242, 245, 255);
                deleteReplyButton1.Anchor = AnchorStyles.Right | AnchorStyles.Top; // Place on the right
                deleteReplyButton1.Click += (deleteBtnSender, deleteBtnEventArgs) =>
                {
                    // Remove the messageContainer from flowLayoutPanel1

                    string message = "Confirm to delete message.";
                    string title = "Delete Message";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        flowLayoutPanel1.Controls.Remove(messageContainer);
                        flowLayoutPanel1.Controls.Remove(deleteReplyButton1);
                        //flowLayoutPanel1.Controls.Remove(button);


                        using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
                        {
                            connection.Open();

                            string query = "DELETE FROM parent_comments WHERE parent_comment_id = @parent_comment_id";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@parent_comment_id", parentCommentId);

                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    Console.WriteLine("Child comment deleted successfully!");
                                }
                                else
                                {
                                    Console.WriteLine("No child comment found with the provided ID.");
                                }
                            }
                        }


                    }
                };
                flowLayoutPanel1.Controls.Add(deleteReplyButton1);

               // button.Location = new Point(messageContainer.Width - button.Width, messageContainer.Top + messageContainer.Height + 10);

               // flowLayoutPanel1.Controls.Add(button);
                richUserInput.Clear();

            }
            else
            {
                MessageBox.Show("Please enter some text.");
            }
        }

        public void load()
        {
            using (SqlConnection connection1 = new SqlConnection(HomeForm.connectionString))
            {
                connection1.Open();

                string query1 = "SELECT parent_comment_id, email, username, body, posted FROM parent_comments";
                using (SqlCommand command1 = new SqlCommand(query1, connection1))
                {
                    using (SqlDataReader reader = command1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int parentCommentId = reader.GetInt32(0);
                            string email = reader.GetString(1);
                            string username = reader.GetString(2);
                            string body = reader.GetString(3);
                            DateTime posted = reader.GetDateTime(4);

                            Panel messageContainer = new Panel();
                messageContainer.BorderStyle = BorderStyle.None;
                messageContainer.AutoSize = false;
                messageContainer.Width = flowLayoutPanel1.ClientSize.Width - 50;
                messageContainer.BackColor = Color.White;

                Label accountLabel = new Label();
                accountLabel.Font = new Font("Proxima Nova", 9f, FontStyle.Regular);
                accountLabel.Text = username;
                accountLabel.AutoSize = true;
                accountLabel.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                accountLabel.Padding = new Padding(0, 5, 10, 3);
                messageContainer.Controls.Add(accountLabel);

                if (username == "Admin")
                {
                    accountLabel.ForeColor = Color.RoyalBlue;
                    accountLabel.Font = new Font("Proxima Nova", 10f, FontStyle.Bold);
                }
                else
                {
                    accountLabel.ForeColor = Color.Gray;
                }



                Label label = new Label();
                label.Font = new Font("Proxima Nova", 12f, FontStyle.Regular);
                label.Text = body;
                label.BackColor = Color.FromArgb(240, 242, 245, 255);
                label.AutoSize = true;
                label.Width = messageContainer.Width - 20;
                label.MaximumSize = new Size(messageContainer.Width - 20, 0);
                label.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                messageContainer.Controls.Add(label);
                label.Padding = new Padding(10, 10, 10, 10);
                int labelHeight = TextRenderer.MeasureText(label.Text, label.Font, label.MaximumSize, TextFormatFlags.WordBreak).Height;
                label.Top = accountLabel.Bottom;
                messageContainer.Height = labelHeight + label.Padding.Top + label.Padding.Bottom + accountLabel.Height;

                            flowLayoutPanel1.Controls.Add(messageContainer);

                Button deleteReplyButton1 = new Button();
                deleteReplyButton1.Size = new Size(15, 15);
                deleteReplyButton1.BackColor = Color.FromArgb(240, 242, 245, 255);
                deleteReplyButton1.Anchor = AnchorStyles.Right | AnchorStyles.Top; // Place on the right
                deleteReplyButton1.Click += (deleteBtnSender, deleteBtnEventArgs) =>
                {
                    // Remove the messageContainer from flowLayoutPanel1
                    if(HomeForm.currentEmail != email && HomeForm.currentEmail != ".\\admin")
                    {
                        MessageBox.Show("Unable to delete comment.");
                        return;
                    }
                    string message = "Confirm to delete message.";
                    string title = "Delete Message";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        flowLayoutPanel1.Controls.Remove(messageContainer);
                        flowLayoutPanel1.Controls.Remove(deleteReplyButton1);
                        //flowLayoutPanel1.Controls.Remove(button);


                        using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
                        {
                            connection.Open();

                            string query = "DELETE FROM parent_comments WHERE parent_comment_id = @parent_comment_id";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@parent_comment_id", parentCommentId);

                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    Console.WriteLine("Child comment deleted successfully!");
                                }
                                else
                                {
                                    Console.WriteLine("No child comment found with the provided ID.");
                                }
                            }
                        }


                    }
                };
                flowLayoutPanel1.Controls.Add(deleteReplyButton1);

                //button.Location = new Point(messageContainer.Width - button.Width, messageContainer.Top + messageContainer.Height + 10);

                //flowLayoutPanel1.Controls.Add(button);
                richUserInput.Clear();
                        }
                    }
                }
            }
        }
    }
}
