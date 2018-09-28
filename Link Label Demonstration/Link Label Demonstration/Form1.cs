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
    }
}
