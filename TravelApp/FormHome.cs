using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelApp
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnWeather_Click(object sender, EventArgs e)
        {
            SetControlVisible(weatherControl);
            LabelMain.Text = "Weather";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SetControlVisible(homeControl);
            LabelMain.Text = "Home";
            homeControl.RefreshHome();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            SetControlVisible(contactControl);
            LabelMain.Text = "Contact";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SetControlVisible(loginControl1);
            LabelMain.Text = "Employee";
        }

        private void btnTravels_Click(object sender, EventArgs e)
        {
            SetControlVisible(travelsControl);
            LabelMain.Text = "Travels";
            travelsControl.RefreshData();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            SetControlVisible(cartControl);
            LabelMain.Text = "Cart";
        }

        private void SetControlVisible(Control control)
        {
            homeControl.Visible = false;
            travelsControl.Visible = false;
            cartControl.Visible = false;
            weatherControl.Visible = false;
            contactControl.Visible = false;
            loginControl1.Visible = false;

            control.Visible = true;
        }
    }
}