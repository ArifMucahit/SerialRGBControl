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

namespace arduinoSerialCom
{
    public partial class configirationFrm : Form
    {
        public configirationFrm()
        {
            InitializeComponent();
        }


        private void Setup_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames(); // list the ports.
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
            try
            {
             if (led.SecLed) // load the settings
             {
                 checkBox1.Checked = true;
                 redTxt1.Text = Convert.ToString(led.RedPin1);
                 greenTxt1.Text = Convert.ToString(led.GreenPin1);
                 blueTxt1.Text = Convert.ToString(led.BluePin1);
             }
             comboBox1.SelectedItem = led.Connection.ToString();
             redTxt.Text = Convert.ToString(led.RedPin);
             greenTxt.Text = Convert.ToString(led.GreenPin);
             blueTxt.Text = Convert.ToString(led.BluePin);
            }
            catch (Exception)
            {
            } 

        }
        LED led = new LED();
        private void checkBox1_CheckedChanged(object sender, EventArgs e) // In case of 1 RGB led
        {
            if (checkBox1.Checked)
            {
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                redTxt1.Visible = true;
                greenTxt1.Visible = true;
                blueTxt1.Visible = true;
            }
            else if (!checkBox1.Checked)
            {
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                redTxt1.Visible = false;
                greenTxt1.Visible = false;
                blueTxt1.Visible = false;
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) // in case of forgetting the port.
                MessageBox.Show("Please select a connection port.");
            else
            {
                led.RedPin = Convert.ToByte(redTxt.Text); // load the datas to our class
                led.GreenPin = Convert.ToByte(greenTxt.Text);
                led.BluePin = Convert.ToByte(blueTxt.Text);
                led.Connection = comboBox1.SelectedItem.ToString();
                if (checkBox1.Checked)
                {
                    led.RedPin1 = Convert.ToByte(redTxt1.Text);
                    led.GreenPin1 = Convert.ToByte(greenTxt1.Text);
                    led.BluePin1 = Convert.ToByte(blueTxt1.Text);
                    led.SecLed = true;
                } 
                MainForm frm = new MainForm();
                frm.Show();
                this.Hide();
            }
           
        }
    }
}
