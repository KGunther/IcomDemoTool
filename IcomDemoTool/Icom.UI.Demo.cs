using System;
// using System.Runtime.InteropServices;
using System.Windows.Forms;
using Icom.CIV;

namespace Icom.UI
{
    public partial class Demo : Form
    {
        Core myCIV;
        public Demo()
        {
            InitializeComponent();
        }

        private void IcomDemo_Load(object sender, EventArgs e)
        {
            cmdDisconnect.Enabled = false;
            cmdSend.Enabled = false;
            cmdTune.Enabled = false;
            myCIV = new Core();
            string[] radios = myCIV.GetRadioNames();
            string[] ports = myCIV.GetSerialPorts();
            foreach (string radio in radios)
                lbRadios.Items.Add(radio);
            foreach (string port in ports)
                lbPorts.Items.Add(port);
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            myCIV.setRadioID(Core.Radio.IC_7300);
            if (!myCIV.OpenSerialPort(lbPorts.SelectedItem.ToString(), 19200))
            {
                string exceptionText = myCIV.GetSerialException().Message;
                MessageBox.Show("Unable to open port " + lbPorts.SelectedItem.ToString() + ": " + exceptionText, "Error opening port: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                myCIV.CommandWaiting += new CIVCommandReadyEvent(CIVDataHandler);
                cmdConnect.Enabled = false;
                cmdFind.Enabled = false;
                cmdDisconnect.Enabled = true;
                cmdSend.Enabled = true;
                cmdTune.Enabled = true;
            }
        }

        private void CIVDataHandler(object sender, EventArgs e)
        {
            Core thisCIV = (Core)sender;

            while (thisCIV.CommandQueued())
            {
                byte[] thisCommand = thisCIV.ReadCommand();
                string hex = BitConverter.ToString(thisCommand);
                this.Invoke((MethodInvoker)delegate
                {
                    mlText.AppendText(hex + "\r\n");
                });
            }
        }

        private void cmdSend_Click(object sender, EventArgs e)
        {
            // Send read frequency command to radio
            byte[] buffer = { 0x03 };
            myCIV.TransmitCommand(buffer);

            // Read response from radio
            byte[] response = myCIV.WaitForResponse(1000);
        }
    

        private void cmdFind_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CmdFind_Click entered changing cursor");
            Cursor.Current = Cursors.WaitCursor;
            MessageBox.Show("calling MyCIV.AutodetectRadio");
            Core.RadioInfo radioInfo = myCIV.AutoDetectRadio(true);
            MessageBox.Show("Back from AutodetectRadio");
            Cursor.Current = Cursors.Default;
            if (radioInfo.RadioID != Core.Radio.NULL_RADIO)
            {
                myCIV.CommandWaiting += new Icom.CIV.CIVCommandReadyEvent(CIVDataHandler);
                cmdConnect.Enabled = false;
                cmdFind.Enabled = false;
                cmdDisconnect.Enabled = true;
                cmdSend.Enabled = true;
                cmdTune.Enabled = true;
                MessageBox.Show("Found radio: " + radioInfo.RadioName + " on port " + radioInfo.CommPort + " with baud rate " + radioInfo.baudRate.ToString() + " with address " + radioInfo.RadioAddress.ToString("X2"), "Radio Autodetect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No ICOM radio(s) found", "Radio Autodetect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdDisconnect_Click(object sender, EventArgs e)
        {
            myCIV.CommandWaiting -= new Icom.CIV.CIVCommandReadyEvent(CIVDataHandler);
            myCIV.CommandWaiting -= new Icom.CIV.CIVCommandReadyEvent(CIVDataHandler);
            myCIV.CloseSerialPort();
            cmdConnect.Enabled = true;
            cmdFind.Enabled = true;
            cmdDisconnect.Enabled = false;
            cmdSend.Enabled = false;
            cmdTune.Enabled = false;
        }

        private void cmdTune_Click(object sender, EventArgs e)
        {
            double frequency;
            if (double.TryParse(txtFrequency.Text, out frequency))
            {
                myCIV.TuneFrequency(frequency, Core.RadioMode.MODE_LSB);
            }
        }
    }
}
