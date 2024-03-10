using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpotXRevamp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Run Regular SpotX Premium Patch

            string str = @"C:\Users\l0sti\source\repos\SpotX\SpotX\bin\Debug\SpotX.Premium.Bat";
            Process process = new Process();
            process.StartInfo.FileName = str;
            process.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Run spotX in powershell

            string str = @"C:\Users\l0sti\source\repos\SpotX\SpotX\bin\Debug\runSpotX.ps1";
            Process process = new Process();
            process.StartInfo.FileName = str;
            process.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string str = @"C:\Users\l0sti\source\repos\SpotX\SpotX\bin\Debug\Unistall.bat";
            Process process = new Process();
            process.StartInfo.FileName = str;
            process.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
