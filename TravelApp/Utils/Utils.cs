using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TravelApp
{
    internal class Utils
    {
        public List<Control> ControlsItem { get; private set; }

        public Utils()
        {
            ControlsItem = new List<Control>();
        }

        public void AddControl(Control control)
        {
            ControlsItem.Add(control);
            
        }

        public void SetControlVisible(Control control)
        {
            foreach (Control item in ControlsItem)
            {
                item.Visible = (item == control);
            }
        }
        private static Random random = new Random();

        public static int GenerateRandomNumber(int min, int max)
        {
            return random.Next(min, max + 1);
        }
    }
}
