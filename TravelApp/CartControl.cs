using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelApp
{
    public partial class CartControl : UserControl
    {
        Cart cart = Cart.Instance;
        SetDataBase setClient = new SetDataBase();

        public CartControl()
        {
            InitializeComponent();
            RefreshCartItems();
        }

        private void RefreshCartItems()
        {
            flowLayoutPanel1.Controls.Clear();

            IReadOnlyList<object[]> items = cart.GetItemList();

            foreach (object[] item in items)
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
                panel.Size = new Size(185, 210);
                panel.Margin = new Padding(12, 10, 12, 10);
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
                button.Text = "Usuń";
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
                    cart.RemoveItem(item);
                    RefreshCartItems();
                    int convertSumCart = cart.getSumCart();
                    labelSum.Text = $"Suma to: {convertSumCart.ToString()}zł";
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
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                RefreshCartItems();
                int convertSumCart = cart.getSumCart();
                labelSum.Text = $"Suma to: {convertSumCart.ToString()}zł";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            cart.ClearItems();
            RefreshCartItems();
            labelSum.Text = $"Suma to: 0 zł";
        }

        private void buttonShowPay_Click(object sender, EventArgs e)
        {
            panelPay.Visible = true; 

            flowLayoutPanelTravels.Controls.Clear();

            IReadOnlyList<object[]> items = cart.GetItemList();

            foreach (object[] item in items)
            {
                Label label1 = new Label();
                label1.Text = $"{item[1].ToString()} {item[4].ToString()}";
                label1.AutoSize = true;
                label1.Location = new Point(10, 10);
                label1.BackColor = Color.Transparent;
                label1.Font = new Font("Microsoft Sans Serif", 12);

                flowLayoutPanelTravels.Controls.Add(label1);
            }
            int convertSumCart = cart.getSumCart();
            labelSumPay.Text = $"Suma to: {convertSumCart.ToString()}zł";
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if(textBoxBlik.Text != "")
            {
                GetDataBase getClients = new GetDataBase();
                List<object[]> data = getClients.Connect("SELECT * FROM Clients");
                Client.Instance.AddUser(data);
                IReadOnlyList<object[]> items = Cart.Instance.GetItemList();
                int lastId = Client.Instance.GetLastUserID();
                foreach (object[] item in items)
                {
                    int idTravel = (int)item[0];
                    setClient.AddClient(++lastId, textBoxName.Text, textBoxSurname.Text, textBoxPhoneNumber.Text, idTravel);
                }
                flowLayoutPanelTravels.Controls.Clear();
                labelError.Visible = false;
                cart.ClearItems();
                RefreshCartItems();
                flowLayoutPanelTravels.Text = "";
                textBoxBlik.Text = "";
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxPhoneNumber.Text = "";
                labelSum.Text = "Suma: 0 zł";
                labelSumPay.Text = "Suma: 0zł";
                labelSuccess.Visible = true;
       
            } else
            {
                labelError.Visible = true;
            }
        }

        private void buttonExitPay_Click(object sender, EventArgs e)
        {
                labelSuccess.Visible = false;
                panelPay.Visible = false;
        }
    }
}
