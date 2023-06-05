using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ShutdownTimer
{
    public partial class Form1 : Form
    {
        const int HOUR = 3600; //number of seconds in an hour
        const int MINUTE = 60; //number of seconds in a minute

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createTimer(object sender, EventArgs e)
        {
            //MessageBox.Show($"Hello {numericUpDown1.Text} {numericUpDown2.Text} {numericUpDown3.Text} {checkBox1.Checked}");
            int shutdownTime = (int)HourUpDown.Value * HOUR;
            shutdownTime += (int)MinuteUpDown.Value * MINUTE;
            shutdownTime += (int)SecondUpDown.Value;
            string message;
            if (shutdownTime < 60)
            {
                string warning = "You've entered a time less than one minute. \nAre you sure?";
                string header = "Warning";
                var result = MessageBox.Show(warning, header, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) { return; }
            }

            if (checkBox1.Checked){
                message = "-r -t ";
            }
            else
            {
                message = "-s -t ";
            }

            message += shutdownTime.ToString();
            System.Diagnostics.Process.Start("shutdown.exe", message);
        }

        private void killTimer(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown.exe", "-a");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
