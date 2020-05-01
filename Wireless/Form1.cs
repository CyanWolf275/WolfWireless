using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wireless
{
    public partial class Form1 : Form
    {
        private bool connected = false;
        public Form1()
        {
            InitializeComponent();
            foreach (String s in System.IO.Ports.SerialPort.GetPortNames())
            {
                portlst.Items.Add(s);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rsa_Enter(object sender, EventArgs e)
        {

        }

        private void connect_Click(object sender, EventArgs e)
        {
            String port = portlst.Text;
            serialport_connect(port, 115200, Parity.None, 8, StopBits.One);

        }
        public void serialport_connect(String port, int baudrate, Parity parity, int databits, StopBits stopbits)
        {
            DateTime dt = DateTime.Now;
            String dtn = dt.ToShortTimeString();
            serialPort1 = new System.IO.Ports.SerialPort(
            port, baudrate, parity, databits, stopbits);
            try
            {
                serialPort1.Open();
                msg.AppendText("[" + dtn + "] " + "Serial port connected\n");
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serial_DataReceived);
                disconnect.Enabled = true;
                connect.Enabled = false;
                start.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }
        }
        public void serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String txt = serialPort1.ReadLine();
            if (connected)
            {
                if (txt[0].Equals("\\"))
                {
                    //Special command
                    if (txt[1].Equals("R"))
                    {
                        //RSA
                    }
                    else if (txt[1].Equals("S"))
                    {
                        //Start
                    }
                    else if (txt[1].Equals("E"))
                    {
                        //End
                    }
                }
                else
                {
                    String time = DateTime.Now.ToShortTimeString();
                    msg.AppendText("[" + time + "] " + txt + "\n");
                }
            }
            if(txt[0].Equals("\\")){
                //Special command
                if (txt[1].Equals("R"))
                {
                    //RSA
                }else if (txt[1].Equals("S"))
                {
                    //Start
                }else if (txt[1].Equals("E"))
                {
                    //End
                }
            }
            else
            {
                String time = DateTime.Now.ToShortTimeString();
                msg.AppendText("[" + time + "] " + txt + "\n");
            }
        }

        private void disconnect_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            serialPort1.Write("\\S");
            msg.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Waiting for response...\n");
            timer1.Enabled = true;
            start.Enabled = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
