using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AppsDevWhispering.MenuRestaurantFINAL;

namespace AppsDevWhispering
{
    public partial class MenuRestaurantFINAL : Form
    {
        public static List<FoodOrder> foodOrders = new List<FoodOrder>();

        decimal[] prices = new decimal[51];

        decimal num1, num2, num3, num4, num5, num6, num7, num8, num9, num10,
        num11, num12, num13, num14, num15, num16, num17, num18, num19, num20,
        num21, num22, num23, num24, num25, num26, num27, num28, num29, num30,
        num31, num32, num33, num34, num35, num36, num37, num38, num39, num40,
        num41, num42, num43, num44, num45, num46, num47, num48, num49, num50, num51;

        decimal subtotal1, subtotal2, subtotal3, subtotal4, subtotal5, subtotal6,
        subtotal7, subtotal8, subtotal9, subtotal10, subtotal11, subtotal12,
        subtotal13, subtotal14, subtotal15;

        decimal total;
        bool empty = true;
        public MenuRestaurantFINAL()
        {
            InitializeComponent();
            SetFoodPrices();

            string query = "SELECT food_price FROM foods ORDER BY food_id";

            // Define variables to store the prices
             // Array to store all 51 prices

            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                int index = 0;

                while (reader.Read() && index < 51)
                {
                    prices[index] = reader.GetDecimal(0); // Store the price in the array
                    index++;
                }

                reader.Close();
            }
        }

        private void numericUpDownFirst(object sender, EventArgs e)
        {
            

            num1 = numericUpDown1.Value * prices[0];
              num2 = numericUpDown2.Value * prices[1];
              num3 = numericUpDown3.Value * prices[2];
              subtotal1 = num1 + num2 + num3;
            labelSubInternational.Text = subtotal1.ToString("N", new CultureInfo("en-US"));

              num4 = numericUpDown4.Value * prices[3];
              num5 = numericUpDown5.Value * prices[4];
              num6 = numericUpDown6.Value * prices[5];
              num7 = numericUpDown7.Value * prices[6];
              num8 = numericUpDown8.Value * prices[7];
              num9 = numericUpDown9.Value * prices[8];
              subtotal2 = num4 + num5 + num6 + num7 + num8 + num9;
            labelSubPizza.Text = subtotal2.ToString("N", new CultureInfo("en-US"));

              num10 = numericUpDown10.Value * prices[9];
              num11 = numericUpDown11.Value * prices[10];
              num12 = numericUpDown12.Value * prices[11];
              subtotal3 = num10 + num11 + num12;
            labelSubDessert.Text = subtotal3.ToString("N", new CultureInfo("en-US"));

              num13 = numericUpDown13.Value * prices[12];
              num14 = numericUpDown14.Value * prices[13];
              num15 = numericUpDown15.Value * prices[14];
              subtotal4 = num13 + num14 + num15;
            labelSubSizzlers.Text = subtotal4.ToString("N", new CultureInfo("en-US"));

              num16 = numericUpDown16.Value * prices[15];
              num17 = numericUpDown17.Value * prices[16];
              num18 = numericUpDown18.Value * prices[17];
              subtotal5 = num16 + num17 + num18;
            labelSubSpecials.Text = subtotal5.ToString("N", new CultureInfo("en-US"));

              num19 = numericUpDown19.Value * prices[18];
              num20 = numericUpDown20.Value * prices[19];
              num21 = numericUpDown21.Value * prices[20];
              subtotal6 = num19 + num20 + num21;
            labelSubSoups.Text = subtotal6.ToString("N", new CultureInfo("en-US"));

              num22 = numericUpDown22.Value * prices[21];
              num23 = numericUpDown23.Value * prices[22];
              num24 = numericUpDown24.Value * prices[23];
              subtotal7 = num22 + num23 + num24;
            labelSubSalads.Text = subtotal7.ToString("N", new CultureInfo("en-US"));

              num25 = numericUpDown25.Value * prices[24];
              num26 = numericUpDown26.Value * prices[25];
              subtotal8 = num25 + num26;
            labelSubPastas.Text = subtotal8.ToString("N", new CultureInfo("en-US"));

              num27 = numericUpDown27.Value * prices[26];
              num28 = numericUpDown28.Value * prices[27];
              num29 = numericUpDown29.Value * prices[28];
              subtotal9 = num27 + num28 + num29;
            labelSubSteaks.Text = subtotal9.ToString("N", new CultureInfo("en-US"));

              num30 = numericUpDown30.Value * prices[29];
              num31 = numericUpDown31.Value * prices[30];
              num32 = numericUpDown32.Value * prices[31];
              subtotal10 = num30 + num31 + num32;
            labelSubShakes.Text = subtotal10.ToString("N", new CultureInfo("en-US"));

              num33 = numericUpDown33.Value * prices[32];
              num34 = numericUpDown34.Value * prices[33];
              num35 = numericUpDown35.Value * prices[34];
              subtotal11 = num33 + num34 + num35;
            labelSubPlatter.Text = subtotal11.ToString("N", new CultureInfo("en-US"));

              num36 = numericUpDown36.Value * prices[35];
              num37 = numericUpDown37.Value * prices[36];
              num38 = numericUpDown38.Value * prices[37];
              num39 = numericUpDown39.Value * prices[38];
              num40 = numericUpDown40.Value * prices[39];
              subtotal12 = num36 + num37 + num38 + num39 + num40;
            labelSubSnacks.Text = subtotal12.ToString("N", new CultureInfo("en-US"));

              num41 = numericUpDown41.Value * prices[40];
              num42 = numericUpDown42.Value * prices[41];
              num43 = numericUpDown43.Value * prices[42];
              subtotal13 = num41 + num42 + num43;
            labelSubPork.Text = subtotal13.ToString("N", new CultureInfo("en-US"));

              num44 = numericUpDown44.Value * prices[42];
              num45 = numericUpDown45.Value * prices[44];
              subtotal14 = num44 + num45;
            labelSubFish.Text = subtotal14.ToString("N", new CultureInfo("en-US"));

              num46 = numericUpDown46.Value * prices[45];
              num47 = numericUpDown47.Value * prices[46];
              num48 = numericUpDown48.Value * prices[47];
              num49 = numericUpDown49.Value * prices[48];
              num50 = numericUpDown50.Value * prices[49];
              num51 = numericUpDown51.Value * prices[50];
              subtotal15 = num46 + num47 + num48 + num49 + num50 + num51;
            labelSubCocktails.Text = subtotal15.ToString("N", new CultureInfo("en-US"));

            total = subtotal1 + subtotal2 + subtotal3 + subtotal4 + subtotal5 + subtotal6 + subtotal7 + subtotal8 + subtotal9
                + subtotal10 + subtotal11 + subtotal12 + subtotal13 + subtotal14 + subtotal15;
            labelTotal.Text = total.ToString("N", new CultureInfo("en-US"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(HomeForm.currentEmail == "")
            {
                MessageBox.Show("You must log in first.");
                return;
            }
            generateReceipt();
            if(empty)
            {
                MessageBox.Show("Please order a food item.");
                return;
            }
            ReceiptForm receipt = new ReceiptForm(total);
            receipt.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DiningHomeForm form1 = new DiningHomeForm();
            form1.Show();
            this.Hide();
        }

        private void MenuRestaurantFINAL_Load(object sender, EventArgs e)
        {
            buttonBack.Parent = MenuPic1;
            buttonBack.BackColor = Color.Transparent;
        }

        public void generateReceipt()
        {
            if (num1 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Winer Schnitzel", Quantity = (int)numericUpDown1.Value, Total = prices[0] * (int)numericUpDown1.Value };
                foodOrders.Add(order);
                empty = false;
            }
            if (num2 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Cordon Bleu", Quantity = (int)numericUpDown2.Value, Total = prices[1] * (int)numericUpDown2.Value };
                foodOrders.Add(order);
                empty = false;
            }
            if (num3 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Gescheltzeltes", Quantity = (int)numericUpDown3.Value, Total = prices[2] * (int)numericUpDown3.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num4 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Speciale", Quantity = (int)numericUpDown4.Value, Total = prices[3] * (int)numericUpDown4.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num5 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Hawaii", Quantity = (int)numericUpDown5.Value, Total = prices[4] * (int)numericUpDown5.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num6 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Napoli", Quantity = (int)numericUpDown6.Value, Total = prices[5] * (int)numericUpDown6.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num7 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Pollo", Quantity = (int)numericUpDown7.Value, Total = prices[6] * (int)numericUpDown7.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num8 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Frutti de Mare", Quantity = (int)numericUpDown8.Value, Total = prices[7] * (int)numericUpDown8.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num9 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Calzone Folded", Quantity = (int)numericUpDown9.Value, Total = prices[8] * (int)numericUpDown9.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num10 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Mango Crepe", Quantity = (int)numericUpDown10.Value, Total = prices[9] * (int)numericUpDown10.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num11 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Mango Float", Quantity = (int)numericUpDown11.Value, Total = prices[10] * (int)numericUpDown11.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num12 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Cakae of the Day", Quantity = (int)numericUpDown12.Value, Total = prices[11] * (int)numericUpDown12.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num13 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Shrimps", Quantity = (int)numericUpDown13.Value, Total = prices[12] * (int)numericUpDown13.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num14 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Squid Curry", Quantity = (int)numericUpDown14.Value, Total = prices[13] * (int)numericUpDown14.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num15 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Fish in Oyster-sauce", Quantity = (int)numericUpDown15.Value, Total = prices[14] * (int)numericUpDown15.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num16 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Best Burger", Quantity = (int)numericUpDown16.Value, Total = prices[15] * (int)numericUpDown16.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num17 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Shrimp Rool", Quantity = (int)numericUpDown17.Value, Total = prices[16] * (int)numericUpDown17.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num18 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Inin-Onan", Quantity = (int)numericUpDown18.Value, Total = prices[17] * (int)numericUpDown18.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num19 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Tomato Soup", Quantity = (int)numericUpDown19.Value, Total = prices[18] * (int)numericUpDown19.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num20 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Chicken Soup", Quantity = (int)numericUpDown20.Value, Total = prices[19] * (int)numericUpDown20.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num21 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Carrol-Ginger-Soup", Quantity = (int)numericUpDown21.Value, Total = prices[20] * (int)numericUpDown21.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num22 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Chef Salad", Quantity = (int)numericUpDown22.Value, Total = prices[21] * (int)numericUpDown22.Value };
                foodOrders.Add(order);
                empty = false;
            }
            if (num23 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Tuna Salad", Quantity = (int)numericUpDown23.Value, Total = prices[22] * (int)numericUpDown23.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num24 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Chicken Salad", Quantity = (int)numericUpDown24.Value, Total = prices[23] * (int)numericUpDown24.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num25 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Spaghetti Carbonara", Quantity = (int)numericUpDown25.Value, Total = prices[24] * (int)numericUpDown25.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num26 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Pasta Frutti de Mare", Quantity = (int)numericUpDown26.Value, Total = prices[25] * (int)numericUpDown26.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num27 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Garlic Burger Steak", Quantity = (int)numericUpDown27.Value, Total = prices[26] * (int)numericUpDown27.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num28 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Brandy Pepper Steak", Quantity = (int)numericUpDown28.Value, Total = prices[27] * (int)numericUpDown28.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num29 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Whispering Steak", Quantity = (int)numericUpDown29.Value, Total = prices[28] * (int)numericUpDown29.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num30 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Fruit Shakes", Quantity = (int)numericUpDown30.Value, Total = prices[29] * (int)numericUpDown30.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num31 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Ice-cream Shake", Quantity = (int)numericUpDown31.Value, Total = prices[30] * (int)numericUpDown31.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num32 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Ice-coffee Shake", Quantity = (int)numericUpDown32.Value, Total = prices[31] * (int)numericUpDown32.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num33 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Coconut Chicken", Quantity = (int)numericUpDown33.Value, Total = prices[32] * (int)numericUpDown33.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num34 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Seafood Platter", Quantity = (int)numericUpDown34.Value, Total = prices[33] * (int)numericUpDown34.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num35 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "BBQ Platter", Quantity = (int)numericUpDown35.Value, Total = prices[34] * (int)numericUpDown35.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num36 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Chicken Clubhouse", Quantity = (int)numericUpDown36.Value, Total = prices[35] * (int)numericUpDown36.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num37 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Tuna Sandwich", Quantity = (int)numericUpDown37.Value, Total = prices[36] * (int)numericUpDown37.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num38 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Nachos", Quantity = (int)numericUpDown38.Value, Total = prices[37] * (int)numericUpDown38.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num39 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Beef Chicken Shawarma", Quantity = (int)numericUpDown39.Value, Total = prices[38] * (int)numericUpDown39.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num40 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Shomai", Quantity = (int)numericUpDown40.Value, Total = prices[39] * (int)numericUpDown40.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num41 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Pork BBQ", Quantity = (int)numericUpDown41.Value, Total = prices[40] * (int)numericUpDown41.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num42 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Pork Humba", Quantity = (int)numericUpDown42.Value, Total = prices[41] * (int)numericUpDown42.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num43 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Pork Sweet and Sour", Quantity = (int)numericUpDown43.Value, Total = prices[42] * (int)numericUpDown43.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num44 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Cream Dori", Quantity = (int)numericUpDown44.Value, Total = prices[43] * (int)numericUpDown44.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num45 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Fish BBQ", Quantity = (int)numericUpDown45.Value, Total = prices[44] * (int)numericUpDown45.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num46 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Tequilla Sunrise", Quantity = (int)numericUpDown46.Value, Total = prices[45] * (int)numericUpDown46.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num47 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Ice-screw-driver", Quantity = (int)numericUpDown47.Value, Total = prices[46] * (int)numericUpDown47.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num48 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Pina Colanda", Quantity = (int)numericUpDown48.Value, Total = prices[47] * (int)numericUpDown48.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num49 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Rumsti Bumsti", Quantity = (int)numericUpDown49.Value, Total = prices[48] * (int)numericUpDown49.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num50 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Calamansi Caipirinha", Quantity = (int)numericUpDown50.Value, Total = prices[49] * (int)numericUpDown50.Value };
                foodOrders.Add(order);
                empty = false;
            }

            if (num51 != 0)
            {
                FoodOrder order = new FoodOrder { Item = "Coco Loco", Quantity = (int)numericUpDown51.Value, Total = prices[50] * (int)numericUpDown51.Value };
                foodOrders.Add(order);
                empty = false;
            }

        }

        public class FoodOrder
        {
            public string Item { get; set; }
            public int Quantity { get; set; }
            public decimal Total { get; set; }
            public override string ToString()
            {
                return $"{Item}: {Quantity}; \n";
            }
        }
        private void SetFoodPrices()
        {
            string query = "SELECT food_price FROM foods ORDER BY food_id";

            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                int labelIndex = 1;

                while (reader.Read() && labelIndex <= 51)
                {
                    decimal price = reader.GetDecimal(0);
                    string formattedPrice = "₱" + price.ToString(); // Adding peso sign

                    Control[] controls = this.Controls.Find("label" + labelIndex, true);
                    if (controls.Length > 0 && controls[0] is Label)
                    {
                        Label label = (Label)controls[0];
                        label.Text = formattedPrice;
                    }

                    labelIndex++;
                }

                reader.Close();
            }
        }

    }
}
