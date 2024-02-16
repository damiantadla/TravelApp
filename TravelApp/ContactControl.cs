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
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
            AddLinkToLabel(); 
        }

        private void AddLinkToLabel()
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://github.com/damiantadla/ObjectOrientedProgramming";
            linkLabel1.Links.Add(link);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
