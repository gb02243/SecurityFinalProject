using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacketDotNet;
using SharpPcap;

namespace MyPacketCapture
{
    public partial class frmCapture : Form
    {
        static String macString;
        public static List<String> macAddresses = new List<String>();

        CaptureDeviceList devices; // List of devices for this computer
        public static ICaptureDevice device; // The device we will be using
        public static string stringPackets = ""; // Data that is captured
        static int numPackets = 0;

        frmSend fSend;
        frmStatistics fStats;

        public frmCapture()
        {
            InitializeComponent();

            //fStats = new frmStatistics(); // creates new stats window

            // Get the list of devices
            devices = CaptureDeviceList.Instance;

            // Make sure there is at least one device
            if (devices.Count < 1)
            {
                MessageBox.Show("No Capture Devices Found");
                Application.Exit();
            }

            // Add devices to the combo box
            foreach (ICaptureDevice dev in devices)
            {
                cmbDevices.Items.Add(dev.Description);
            }

            // Get the device and display in combo box
            device = devices[3];
            cmbDevices.Text = device.Description;

            RegisterEventHandler();

            if (frmStatistics.instantiations == 0)
            {
                fStats = new frmStatistics(); // creates new traffic window
            }
        }

        private static void device_OnPacketArrival(Object sender, CaptureEventArgs packet)
        {
            // Increment the number of packets captured
            numPackets++;

            // Put the packet number in the capture window
            stringPackets += "Packet Number: " + Convert.ToString(numPackets);
            stringPackets += Environment.NewLine;

            // Array to store our data 
            byte[] data = packet.Packet.Data;

            // Keep track of the number of bytes
            int byteCounter = 0;

            stringPackets += "Destination MAC Address: ";

            // Parsing packets
            foreach (byte b in data)
            {
                // Add the byte to our string (in hexidecimal)
                if (byteCounter <= 13) stringPackets += b.ToString("X2") + " ";
                byteCounter++;

                switch (byteCounter)
                {
                    case 6:
                        stringPackets += Environment.NewLine;
                        stringPackets += "Source MAC Address:";
                        break;
                    case 12:
                        stringPackets += Environment.NewLine;
                        stringPackets += "EtherType: ";
                        break;
                    case 14:
                        if (data[12] == 8)
                        {
                            if (data[13] == 0)
                            {
                                stringPackets += "(IPv4)";
                                frmStatistics.countIPv4++;
                                if (data[23] == 6)
                                {
                                    stringPackets += Environment.NewLine;
                                    stringPackets += "Protocol: TCP";
                                    frmStatistics.countTCP++;
                                }
                            }
                            if (data[13] == 6)
                            {
                                stringPackets += "(ARP)";
                                frmStatistics.countArp++;
                            }
                        }
                        if (data[12] == 134)
                        {
                            if (data[13] == 221)
                            {
                                stringPackets += "(IPv6)";
                                frmStatistics.countIPv6++;
                                if (data[20] == 17)
                                {
                                    stringPackets += Environment.NewLine;
                                    stringPackets += "Protocol: UDP";
                                    frmStatistics.countUDP++;
                                }
                            }
                        }
                        break;
                }
            }

            // stringPackets += Environment.NewLine + Environment.NewLine;
            byteCounter = 0;
            stringPackets += Environment.NewLine + "Raw Data:" + Environment.NewLine;

            // Process each byte in our packet
            foreach (byte b in data)
            {
                // Add the byte to our string (in hexidecimal)
                stringPackets += b.ToString("X2") + " ";
                byteCounter++;

                if (byteCounter == 16)
                {
                    byteCounter = 0;
                    stringPackets += Environment.NewLine;
                }
            }
            stringPackets += Environment.NewLine;
            stringPackets += Environment.NewLine;

            // OLD MAC LIST
            for (int i = 0; i < 6; i++)
            {
                macString += data[i].ToString("X2") + " ";
            }

            if (!macAddresses.Contains(macString))
            {
                macAddresses.Add(macString);
            }

            macString = "";

            for (int i = 6; i < 12; i++)
            {
                macString += data[i].ToString("X2") + " ";
            }

            if (!macAddresses.Contains(macString))
            {
                macAddresses.Add(macString);
            }

            macString = "";
            // END OLD MAC LIST

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnStartStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnStartStop.Text == "Start")
                {
                    device.StartCapture();
                    timer1.Enabled = true;
                    btnStartStop.Text = "Stop";
                }
                else
                {
                    device.StopCapture();
                    timer1.Enabled = false;
                    btnStartStop.Text = "Start";
                }
            }
            catch (Exception ex) { }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            txtCapturedData.AppendText(stringPackets);
            stringPackets = "";
            txtNumPackets.Text = Convert.ToString(numPackets);
            // txtNumPackets.Text = numPackets + "";
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            saveFileDialog1.Title = "Save the Captured Packets";
            saveFileDialog1.ShowDialog();

            // Check if a filename was given
            if (saveFileDialog1.FileName != "")
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, txtCapturedData.Text);
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            openFileDialog1.Title = "Open Captured Packets";
            openFileDialog1.ShowDialog();

            // Check if a filename was given
            if (openFileDialog1.FileName != "")
            {
                txtCapturedData.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void TxtNumPackets_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmSend.instantiations == 0)
            {
                fSend = new frmSend(); // creates new send window
                fSend.Show();
            }
        }

        private void CmbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            device = devices[cmbDevices.SelectedIndex];
            cmbDevices.Text = device.Description;
            txtGUID.Text = device.Name;

            RegisterEventHandler();
        }

        private void RegisterEventHandler()
        {
            // Register handler function to the 'packet arrival' event
            device.OnPacketArrival += new SharpPcap.PacketArrivalEventHandler(device_OnPacketArrival);

            // Open device for capturing
            int readTimeoutMilliseconds = 1000;
            device.Open(DeviceMode.Promiscuous, readTimeoutMilliseconds);
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numPackets = 0;
            txtNumPackets.Text = Convert.ToString(numPackets);
            txtCapturedData.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frmStatistics.instantiations == 0)
            {
                btnStats.Text = "Hide Statistics";
                fStats = new frmStatistics(); // creates new stats window
                fStats.Show();
            }
            else
            {
                btnStats.Text = "Show Statistics";
                fStats.Close();
                frmStatistics.instantiations--;
                //fStats.Hide();
            }
        }
    }
}
