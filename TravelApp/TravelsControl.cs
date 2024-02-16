using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelApp
{
    public partial class TravelsControl : UserControl
    {
        GetDataBase getTravels = new GetDataBase();
        Cart cart = Cart.Instance;

        public TravelsControl()
        {
            InitializeComponent();
            RefreshData();
        }

        public void RefreshData()
        {
            List<object[]> data = getTravels.Connect("SELECT IDTravel, TravelsName, Address, CONVERT(varchar, Date, 104) AS FormattedDate, Price FROM Travels");
            flowLayoutPanel1.Controls.Clear();
            Travels.Instance.ClearItems();
            Travels.Instance.AddItems(data);

            foreach (object[] item in data)
            {
                Panel panel = new Panel();
                int randomNumber = Utils.GenerateRandomNumber(1, 6);
                switch (randomNumber)
                {
                    case 1:
                        panel.BackgroundImage = global::TravelApp.Properties.Resources._1;
                        break;
                    case 2:
                        panel.BackgroundImage = global::TravelApp.Properties.Resources._2;
                        break;
                    case 3:
                        panel.BackgroundImage = global::TravelApp.Properties.Resources._3;
                        break;
                    case 4:
                        panel.BackgroundImage = global::TravelApp.Properties.Resources._4;
                        break;
                    case 5:
                        panel.BackgroundImage = global::TravelApp.Properties.Resources._5;
                        break;
                    case 6:
                        panel.BackgroundImage = global::TravelApp.Properties.Resources._6;
                        break;
                }
                panel.Size = new Size(175, 210);
                panel.Margin = new Padding(16, 10, 16, 10);
                panel.Padding = new Padding(10);

                Font LargeFont = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
                Font labelFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                Label label1 = new Label();
                label1.Text = item[1].ToString();
                label1.AutoSize = true;
                label1.Location = new Point(10, 10);
                label1.BackColor = Color.Transparent;
                label1.Font = LargeFont;
                label1.ForeColor = Color.White;

                Label label2 = new Label();
                label2.Text = item[2].ToString();
                label2.AutoSize = true;
                label2.Location = new Point(10, label1.Bottom + 10);
                label2.BackColor = Color.Transparent;
                label2.Font = labelFont;
                label2.ForeColor = Color.White;

                Label label3 = new Label();
                label3.Text = item[3].ToString();
                label3.AutoSize = true;
                label3.Location = new Point(10, label2.Bottom + 10);
                label3.BackColor = Color.Transparent;
                label3.Font = labelFont;
                label3.ForeColor = Color.White;

                Label label4 = new Label();
                label4.Text = item[4].ToString();
                label4.AutoSize = true;
                label4.Location = new Point(10, label3.Bottom + 20);
                label4.BackColor = Color.Transparent;
                label4.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
                label4.ForeColor = Color.White;

                Button button = new Button();
                button.Text = "Kup teraz";
                button.Size = new Size(100, 40);
                button.Location = new Point(10, label4.Bottom + 20);
                button.BackColor = Color.Transparent;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 2;
                button.FlatAppearance.BorderColor = Color.White;
                button.ForeColor = Color.White;
                button.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);

                button.Click += (sender, e) =>
                {
                    cart.AddItem(item);
                };

                panel.Controls.Add(label1);
                panel.Controls.Add(label2);
                panel.Controls.Add(label3);
                panel.Controls.Add(label4);
                panel.Controls.Add(button);

                flowLayoutPanel1.Controls.Add(panel);
            }
            flowLayoutPanel1.AutoScroll = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
