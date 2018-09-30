using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Link_Label_Demonstration
{
    public partial class lnkDemo : Form
    {
        public lnkDemo()
        {
            InitializeComponent();
        }

        private void lnkPictureChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.boredbutton.com");
        }

        private void lnkNotepad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void lnkAddTwoNumbers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addNumbers();
        }

        int num1;
        int num2;
        private void addNumbers()
        {
            if (int.TryParse(tbxNum1.Text, out num1) && 
                (int.TryParse(tbxNum2.Text, out num2)))
            {
                int result = num1 + num2;
                lblResults.Text = $"{result}";
            }
        }

        private void lnkDemo_Load(object sender, EventArgs e)
        {
            // Add a link to the LinkLabel.
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.dotnetperls.com/";
            linkLabel1.Links.Add(link);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            Process.Start(e.Link.LinkData as string);
            linkLabel1.Enabled = false;
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //change BackColor of LinkLabel
            linkLabel1.BackColor = Color.CadetBlue;
        }
    }
}
