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


namespace ARIEL_Automation_GUI
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
            //Populate box with available COM ports
            LoadAvailablePorts();
        }
        //Function populate box with available com ports
        private void LoadAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Items.AddRange(ports);
            if (ports.Length > 0)
            {
                comboBoxPorts.SelectedIndex = 0;
            }
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            string portName = comboBoxPorts.SelectedItem.ToString();
            string message = textBoxMessage.Text;

            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please enter a command.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try 
            {
                using (serialPort = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One))
                {
                    serialPort.Open();
                    serialPort.WriteLine(message);
                    MessageBox.Show("Sent");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Sending Message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
