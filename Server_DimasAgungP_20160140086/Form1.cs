using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_DimasAgungP_20160140086
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Klik ON Untuk Menghidupkan Server";
            //label1.Text = "Server ON";
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            button2.Enabled = true;

            label2.Text = "Klik OFF Untuk Mematikan Server";
            label1.Text = "Server ON";


            server Server = new server();

            Server.ServerOn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;

            button2.Enabled = false;

            label2.Text = "Klik ON Untuk Menghidupkan Server";

            label1.Text = "Server OFF";

            server Server = new server();

            Server.ServerOff();
            
        }
    }
}
