namespace ARIEL_Automation_GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

        private System.ComponentModel.IContainer components = null;
        //private TextBox textBoxMessage;
        //private ComboBox comboBoxPorts;
        //private Button buttonSend;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.TextBox textBoxResponse;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.buttonSend = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(515, 509);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(308, 44);
            this.textBoxMessage.TabIndex = 0;
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(886, 498);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(238, 65);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(997, 56);
            this.comboBoxPorts.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(374, 45);
            this.comboBoxPorts.TabIndex = 2;
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxResponse.ForeColor = System.Drawing.Color.Black;
            this.textBoxResponse.Location = new System.Drawing.Point(1672, 344);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.ReadOnly = true;
            this.textBoxResponse.Size = new System.Drawing.Size(631, 412);
            this.textBoxResponse.TabIndex = 3;
            this.textBoxResponse.TextChanged += new System.EventHandler(this.textBoxResponse_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2533, 1281);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxResponse);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "MainForm";
            this.Text = "ARIEL COM send/receive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

