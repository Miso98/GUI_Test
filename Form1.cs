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
    public partial class MainForm : Form
    {
        private SerialPort serialPort;

        public MainForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(MainForm_Load);

            //Populate box with available COM ports
            //LoadAvailablePorts();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
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

        //Send button that takes in string text and sends to com port 
        private void buttonSend_Click(object sender, EventArgs e)
        {
            string portName = comboBoxPorts.SelectedItem.ToString();
            string message = textBoxMessage.Text;

            //makes sure that there are COM ports available
            if (string.IsNullOrEmpty(portName))
            {
                MessageBox.Show("Please select a COM port.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //ensures that no blank command is sent
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

                    // Wait for a response with a timeout
                    serialPort.ReadTimeout = 5000; // 5 seconds timeout
                    string response = serialPort.ReadLine();

                    // Append the response to the existing text in textBoxResponse
                    textBoxResponse.AppendText(response + Environment.NewLine);

                    MessageBox.Show("Message received", "Received", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            //if not response received within preiod will time out 
            catch (TimeoutException)
            {
                MessageBox.Show("No response received within the timeout period.", "Timeout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //exception if message cannot be sent or receives error
            catch (Exception ex)
            {
                MessageBox.Show($"Error Sending Message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxResponse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
