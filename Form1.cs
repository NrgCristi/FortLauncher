using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FortLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LaunchBtn_Click(object sender, EventArgs e)
        {
            string FNPath = PathTextBox.Text;
            string FNExePath = System.IO.Path.Combine(this.PathTextBox.Text, "FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping.exe");
            string FNExeName = "FortniteClient-Win64-Shipping.exe";
            string LaunchArgs = "-AUTH_LOGIN=" + MailTextBox.Text + " -AUTH_PASSWORD=" + PassTextBox.Text + " -AUTH_TYPE=epic" + "-noeac -fromfl=be -fltoken=h1h4370717422124b232eFac -epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal";
            System.Diagnostics.Process.Start(FNExePath, LaunchArgs);
        }
    }
}
