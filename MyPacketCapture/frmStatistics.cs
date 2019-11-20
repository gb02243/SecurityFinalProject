using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPacketCapture
{
    public partial class frmStatistics : Form
    {
        public static int instantiations = 0;
        public static int countArp = 0;
        public static int countIPv4 = 0;
        public static int countIPv6 = 0;
        public static int countUDP = 0;
        public static int countTCP = 0;

        String macContent;

        public frmStatistics()
        {
            InitializeComponent();
            chEtherTypes.Titles.Add("EtherTypes");
            chProtocols.Titles.Add("Protocols");
            instantiations++;
            chEtherTypes.Series["s1"].Points.AddXY("ARP", countArp);
            chEtherTypes.Series["s1"].Points.AddXY("IPv4", countIPv4);
            chEtherTypes.Series["s1"].Points.AddXY("IPv6", countIPv6);
            chProtocols.Series["s1"].Points.AddXY("ARP", countArp);
            chProtocols.Series["s1"].Points.AddXY("TCP", countTCP);
            chProtocols.Series["s1"].Points.AddXY("UDP", countUDP);
            timer1.Start();
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            macContent = "";
            foreach (String addr in frmCapture.macAddresses)
            {
                //macContent += "MAC: " + addr + "\t|\tCount: " + Environment.NewLine;
                macContent += addr + Environment.NewLine;
            }
            chEtherTypes.Series["s1"].Points.Clear();
            chProtocols.Series["s1"].Points.Clear();
            txtMac.Text = macContent;
            chEtherTypes.Series["s1"].Points.AddXY("ARP", countArp);
            chEtherTypes.Series["s1"].Points.AddXY("IPv4", countIPv4);
            chEtherTypes.Series["s1"].Points.AddXY("IPv6", countIPv6);
            chProtocols.Series["s1"].Points.AddXY("ARP", countArp);
            chProtocols.Series["s1"].Points.AddXY("TCP", countTCP);
            chProtocols.Series["s1"].Points.AddXY("UDP", countUDP);
            txtETypes.Text = "ARP: " + countArp + Environment.NewLine + Environment.NewLine + "IPv4: " +
                countIPv4 + Environment.NewLine + Environment.NewLine + "IPv6: " + countIPv6;
            txtProtocols.Text = "ARP: " + countArp + Environment.NewLine + Environment.NewLine + "TCP: " +
                countTCP + Environment.NewLine + Environment.NewLine + "UDP: " + countUDP;
        }

        private void txtETypes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
