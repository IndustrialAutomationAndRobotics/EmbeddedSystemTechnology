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

namespace RoboArmUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox_Available_SerialPort.Items.AddRange(SerialPort.GetPortNames());

            robotControl_groupbox.Enabled = false;
            button_closePort.Enabled = false;
            armControl_groupBox.Enabled = false;
            base_label.Text = base_trackBar.Value.ToString();
            Shoulder_label.Text = Shoulder_trackBar.Value.ToString();
            Elbow_label.Text = Elbow_trackBar.Value.ToString();
            Wrist_label.Text = Wrist_trackBar.Value.ToString();
            Gripper_label.Text = Gripper_trackBar.Value.ToString();
        }

        private void openPort_button_Click(object sender, EventArgs e)
        {

            if(this.comboBox_Available_SerialPort.SelectedItem == null)
            {

            }
            else
            {
                
                if (serialPort1.IsOpen)
                {
                    
                }
                else
                {
                    serialPort1.PortName = this.comboBox_Available_SerialPort.SelectedItem.ToString();
                    openPort_button.Enabled = false;
                    robotControl_groupbox.Enabled = true;
                    button_closePort.Enabled = true;
                    try
                    {
                        
                        serialPort1.Open();
                        
                    }
                    catch(UnauthorizedAccessException SerialException)
                    {
                        MessageBox.Show(SerialException.ToString());
                        serialPort1.Close();
                        openPort_button.Enabled = true;
                        robotControl_groupbox.Enabled = false;
                        button_closePort.Enabled = false;
                    }
                    catch(System.IO.IOException SerialException)
                    {
                        MessageBox.Show(SerialException.ToString());
                        serialPort1.Close();
                        openPort_button.Enabled = true;
                        robotControl_groupbox.Enabled = false;
                        button_closePort.Enabled = false;
                    }
                    catch(InvalidOperationException SerialException)
                    {
                        MessageBox.Show(SerialException.ToString());
                        serialPort1.Close();
                        openPort_button.Enabled = true;
                        robotControl_groupbox.Enabled = false;
                        button_closePort.Enabled = false;
                    }
                    catch
                    {
                        MessageBox.Show("ERROR in Opening Serial PORT -- Unknown ERROR");
                        serialPort1.Close();
                        openPort_button.Enabled = true;
                        robotControl_groupbox.Enabled = false;
                        button_closePort.Enabled = false;
                    }

                    
                }
            }

            
        }

        private void button_closePort_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                button_closePort.Enabled = false;
                openPort_button.Enabled = true;
                robotControl_groupbox.Enabled = false;
            }
            else
            {
                MessageBox.Show("No Port Open");
            }
        }

        private void robotOn_button_Click(object sender, EventArgs e)
        {
            int unicode = 89;
            char character = (char)unicode;
            serialPort1.Write(character.ToString());
            armControl_groupBox.Enabled = true;
        }

        private void robotOff_button_Click(object sender, EventArgs e)
        {
            int unicode = 78;
            char character = (char)unicode;
            serialPort1.Write(character.ToString());
            armControl_groupBox.Enabled = false;
        }

        private void base_trackBar_MouseUp(object sender, MouseEventArgs e)
        {
            int unicode = 49;
            int trackbarValue = base_trackBar.Value;
            char charTrackBar = (char)trackbarValue;
            char character = (char)unicode;
            base_label.Text = base_trackBar.Value.ToString();
            serialPort1.Write(character.ToString() + charTrackBar.ToString());
            
        }

        private void Shoulder_trackBar_MouseUp(object sender, MouseEventArgs e)
        {
            int unicode = 50;
            int trackbarValue = Shoulder_trackBar.Value;
            char charTrackBar = (char)trackbarValue;
            char character = (char)unicode;
            Shoulder_label.Text = Shoulder_trackBar.Value.ToString();
            serialPort1.Write(character.ToString() + charTrackBar.ToString());
        }

        private void Elbow_trackBar_MouseUp(object sender, MouseEventArgs e)
        {
            int unicode = 51;
            int trackbarValue = Elbow_trackBar.Value;
            char charTrackBar = (char)trackbarValue;
            char character = (char)unicode;
            Elbow_label.Text = Elbow_trackBar.Value.ToString();
            serialPort1.Write(character.ToString() + charTrackBar.ToString());
        }

        private void Wrist_trackBar_MouseUp(object sender, MouseEventArgs e)
        {
            int unicode = 52;
            int trackbarValue = Wrist_trackBar.Value;
            char charTrackBar = (char)trackbarValue;
            char character = (char)unicode;
            Wrist_label.Text = Wrist_trackBar.Value.ToString();
            serialPort1.Write(character.ToString() + charTrackBar.ToString());
        }

        private void Gripper_trackBar_MouseUp(object sender, MouseEventArgs e)
        {
            int unicode = 53;
            int trackbarValue = Gripper_trackBar.Value;
            char charTrackBar = (char)trackbarValue;
            char character = (char)unicode;
            Gripper_label.Text = Gripper_trackBar.Value.ToString();
            serialPort1.Write(character.ToString() + charTrackBar.ToString());
        }
    }
}
