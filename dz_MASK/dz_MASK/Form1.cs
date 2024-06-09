using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace dz_MASK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            domainUpDown1.Text = "0";
            textBox1.Text = "0.0.0.0";
            textBox_MASK.Text = "0.0.0.0";
        }
        private void domainUpDown1_Click(object sender, EventArgs e)
        {
            int DUD = Convert.ToInt32(domainUpDown1.Text);
            int DUD1 = 128;
            int DUD2 = 192;
            int DUD3 = 224;
            int DUD4 = 240;
            int DUD5 = 248;
            int DUD6 = 252;
            int DUD7 = 254;
            int DUD8 = 255;
            if (DUD == 0)
            {
                textBox_MASK.Text = "255.255.255.255";
            }
            if (DUD < 9)
            {
                if (DUD == 1) { textBox_MASK.Text = $"{DUD1}.0.0.0"; }
                if (DUD == 2) { textBox_MASK.Text = $"{DUD2}.0.0.0"; }
                if (DUD == 3) { textBox_MASK.Text = $"{DUD3}.0.0.0"; }
                if (DUD == 4) { textBox_MASK.Text = $"{DUD4}.0.0.0"; }
                if (DUD == 5) { textBox_MASK.Text = $"{DUD5}.0.0.0"; }
                if (DUD == 6) { textBox_MASK.Text = $"{DUD6}.0.0.0"; }
                if (DUD == 7) { textBox_MASK.Text = $"{DUD7}.0.0.0"; }
                if (DUD == 8) { textBox_MASK.Text = $"{DUD8}.0.0.0"; }
            }
            if (8 < DUD & DUD < 17)
            {
                if (DUD == 9) { textBox_MASK.Text = $"255.{DUD1}.0.0"; }
                else if (DUD == 10) { textBox_MASK.Text = $"255.{DUD2}.0.0"; }
                else if (DUD == 11) { textBox_MASK.Text = $"255.{DUD3}.0.0"; }
                else if (DUD == 12) { textBox_MASK.Text = $"255.{DUD4}.0.0"; }
                else if (DUD == 13) { textBox_MASK.Text = $"255.{DUD5}.0.0"; }
                else if (DUD == 14) { textBox_MASK.Text = $"255.{DUD6}.0.0"; }
                else if (DUD == 15) { textBox_MASK.Text = $"255.{DUD7}.0.0"; }
                else if(DUD == 16) { textBox_MASK.Text = $"255.{DUD8}.0.0"; }
            }
            if (16 < DUD & DUD < 25)
            {
                if (DUD == 17) { textBox_MASK.Text = $"255.255.{DUD1}.0"; }
                else if (DUD == 18) { textBox_MASK.Text = $"255.255.{DUD2}.0"; }
                else if (DUD == 19) { textBox_MASK.Text = $"255.255.{DUD3}.0"; }
                else if (DUD == 20) { textBox_MASK.Text = $"255.255.{DUD4}.0"; }
                else if (DUD == 21) { textBox_MASK.Text = $"255.255.{DUD5}.0"; }
                else if (DUD == 22) { textBox_MASK.Text = $"255.255.{DUD6}.0"; }
                else if (DUD == 23) { textBox_MASK.Text = $"255.255.{DUD7}.0"; }
                else if (DUD == 24) { textBox_MASK.Text = $"255.255.{DUD8}.0"; }
            }
            else
            {
                if (DUD == 25) { textBox_MASK.Text = $"255.255.255.{DUD1}"; }
                if (DUD == 26) { textBox_MASK.Text = $"255.255.255.{DUD2}"; }
                if (DUD == 27) { textBox_MASK.Text = $"255.255.255.{DUD3}"; }
                if (DUD == 28) { textBox_MASK.Text = $"255.255.255.{DUD4}"; }
                if (DUD == 29) { textBox_MASK.Text = $"255.255.255.{DUD5}"; }
                if (DUD == 30) { textBox_MASK.Text = $"255.255.255.{DUD6}"; }
                if (DUD == 31) { textBox_MASK.Text = $"255.255.255.{DUD7}"; }
                if (DUD == 32) { textBox_MASK.Text = $"255.255.255.{DUD8}"; }

            }
        }
        public static IPAddress Chtoto(IPAddress ipAddress, IPAddress subnetMask)
        {
            byte[] ipBytes = ipAddress.GetAddressBytes();
            byte[] maskBytes = subnetMask.GetAddressBytes();
            byte[] networkBytes = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                networkBytes[i] = (byte)(ipBytes[i] & maskBytes[i]);
            }
            return new IPAddress(networkBytes);
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            IPAddress ipAddress = IPAddress.Parse(textBox1.Text);
            IPAddress subnetMask = IPAddress.Parse(textBox_MASK.Text);
            IPAddress networkAddress = Chtoto(ipAddress, subnetMask);
            label_IP.Text = networkAddress.ToString();

            string networkAddress2 = textBox1.Text;
            string subnetMask2 = textBox_MASK.Text;
            // Проверка корректности ввода
            if (!IPAddress.TryParse(networkAddress2, out IPAddress network) ||
                !IPAddress.TryParse(subnetMask2, out IPAddress mask))
            {
                MessageBox.Show("Некорректный формат IP-адреса или маски!", "Ошибка");
                return;
            }
            int addressCount = CalculateAddressCount(network, mask);

            label_KOL.Text = addressCount.ToString();
            label_Yz.Text = (addressCount-2).ToString();

            GetBroadcastAddress();
        }
        private int CalculateAddressCount(IPAddress network, IPAddress mask)
        {
            // Преобразование IP-адресов в двоичный формат
            byte[] maskBytes = mask.GetAddressBytes();
            // Вычисление количества бит в маске
            int maskBits = 0;
            for (int i = 0; i < 4; i++)
            {
                maskBits += CountSetBits(maskBytes[i]);
            }
            // Вычисление количества доступных IP-адресов
            int addressCount = (int)Math.Pow(2, 32 - maskBits); // -2 для учета сетевого и широковещательного адресов
            return addressCount;
        }
        private int CountSetBits(byte b)
        {
            int count = 0;
            while (b != 0)
            {
                count += b & 1;
                b >>= 1;
            }
            return count;
        }
        private void GetBroadcastAddress()
        {
            string networkAddress = label_IP.Text;
            string subnetMask = textBox_MASK.Text; 
            // Преобразование в IP-адреса
            IPAddress network = IPAddress.Parse(networkAddress);
            IPAddress mask = IPAddress.Parse(subnetMask);
            // Вычисление широковещательного адреса
            byte[] networkBytes = network.GetAddressBytes();
            byte[] maskBytes = mask.GetAddressBytes();
            byte[] broadcastBytes = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                broadcastBytes[i] = (byte)(networkBytes[i] | (~maskBytes[i]));
            }
            IPAddress broadcastAddress = new IPAddress(broadcastBytes);
            label_SH.Text = broadcastAddress.ToString();
        }
    }
}
