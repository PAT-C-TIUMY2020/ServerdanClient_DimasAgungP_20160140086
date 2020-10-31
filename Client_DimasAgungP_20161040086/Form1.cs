using ServiceMtk_P1_20160140086;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_DimasAgungP_20161040086
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BasicHttpBinding bind = new BasicHttpBinding(); ChannelFactory<IMatematika> 
            objChannel = new ChannelFactory<IMatematika>(bind, "http://localhost:1909");
            IMatematika obj = objChannel.CreateChannel(); 
            double hasilTambah = obj.Tambah(1, 2); 
            Console.WriteLine("1 + 2 = " + hasilTambah); 
            double hasilKurang = obj.Kurang(3, 2); 
            Console.WriteLine("3 - 2 = " + hasilKurang); 
            double hasilKali = obj.Kali(2, 2); 
            Console.WriteLine("2 x 2 = " + hasilKali); 
            double hasilBagi = obj.Bagi(2, 2); 
            Console.WriteLine("2 / 2 = " + hasilBagi); 
            Console.ReadLine();



            penjumlahan.Text = ("" + hasilTambah);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_hasil_Click(object sender, EventArgs e)
        {

        }
    }
}
