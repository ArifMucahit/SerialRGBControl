using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace arduinoSerialCom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        SerialPort port = new SerialPort();
        configirationFrm frm = new configirationFrm();
        byte number;
        int data;
        LED led = new LED();
        private void Form1_Load(object sender, EventArgs e)
        {  
            if (!led.SecLed) // for a better look lets hide theese
            {
                redLED1.Visible = false;
                greenLED1.Visible = false;
                blueLED1.Visible = false;
            } 
              port.DataBits = 8;
              port.PortName = led.Connection;
              port.BaudRate = 9600;
              port.Open();
            }

     
        private void redLed_Click(object sender, EventArgs e)
        {
            number = led.RedPin;
        }
        private void greenLED_Click_1(object sender, EventArgs e)
        {
            number = led.GreenPin;
        }
        private void blueLED_Click(object sender, EventArgs e)
        {
            number = led.BluePin;
        }
        private void redLED1_Click(object sender, EventArgs e)
        {
            number = led.RedPin1;
        }
        private void greenLED1_Click(object sender, EventArgs e)
        {
           number = led.GreenPin1;
        }
        private void blueLED1_Click(object sender, EventArgs e)
        {
            number = led.BluePin1;
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ledYak(number, Convert.ToByte(hScrollBar1.Value));
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {        
          if (!port.IsOpen) // if port is open don't open it again
            port.Open();
            port.WriteLine("32000"); 
            port.Close(); 
        }
        void ledYak(byte led, byte parlaklik)
        {
            data = led * 1000;  // we can't send 2 parameters via serial comminication so  i made a formula, multiple led pin with 1000 and add brightness 
            data = data + parlaklik; // and the data should look like this 11255. when we take mode of this number 255 is our brightness (to PWN) and 11 is pin number.
            if (!port.IsOpen)
            {
                port.Open();
            }
            port.WriteLine(data.ToString());
            port.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             //Go to the settings page.
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm.Close();
            this.Close();
        }
    }
}
