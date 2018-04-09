namespace RoboArmUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openPort_button = new System.Windows.Forms.Button();
            this.button_closePort = new System.Windows.Forms.Button();
            this.comboBox_Available_SerialPort = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.robotControl_groupbox = new System.Windows.Forms.GroupBox();
            this.armControl_groupBox = new System.Windows.Forms.GroupBox();
            this.Gripper_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Gripper_trackBar = new System.Windows.Forms.TrackBar();
            this.Elbow_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Elbow_trackBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.Wrist_label = new System.Windows.Forms.Label();
            this.Wrist_trackBar = new System.Windows.Forms.TrackBar();
            this.base_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.base_trackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Shoulder_label = new System.Windows.Forms.Label();
            this.Shoulder_trackBar = new System.Windows.Forms.TrackBar();
            this.robotOff_button = new System.Windows.Forms.Button();
            this.robotOn_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.robotControl_groupbox.SuspendLayout();
            this.armControl_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gripper_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Elbow_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wrist_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shoulder_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openPort_button
            // 
            this.openPort_button.Location = new System.Drawing.Point(12, 67);
            this.openPort_button.Name = "openPort_button";
            this.openPort_button.Size = new System.Drawing.Size(75, 23);
            this.openPort_button.TabIndex = 0;
            this.openPort_button.Text = "Open Port";
            this.openPort_button.UseVisualStyleBackColor = true;
            this.openPort_button.Click += new System.EventHandler(this.openPort_button_Click);
            // 
            // button_closePort
            // 
            this.button_closePort.Location = new System.Drawing.Point(12, 95);
            this.button_closePort.Name = "button_closePort";
            this.button_closePort.Size = new System.Drawing.Size(75, 23);
            this.button_closePort.TabIndex = 1;
            this.button_closePort.Text = "Close Port";
            this.button_closePort.UseVisualStyleBackColor = true;
            this.button_closePort.Click += new System.EventHandler(this.button_closePort_Click);
            // 
            // comboBox_Available_SerialPort
            // 
            this.comboBox_Available_SerialPort.FormattingEnabled = true;
            this.comboBox_Available_SerialPort.Location = new System.Drawing.Point(12, 40);
            this.comboBox_Available_SerialPort.Name = "comboBox_Available_SerialPort";
            this.comboBox_Available_SerialPort.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Available_SerialPort.TabIndex = 2;
            // 
            // robotControl_groupbox
            // 
            this.robotControl_groupbox.Controls.Add(this.armControl_groupBox);
            this.robotControl_groupbox.Controls.Add(this.robotOff_button);
            this.robotControl_groupbox.Controls.Add(this.robotOn_button);
            this.robotControl_groupbox.Location = new System.Drawing.Point(148, 12);
            this.robotControl_groupbox.Name = "robotControl_groupbox";
            this.robotControl_groupbox.Size = new System.Drawing.Size(481, 339);
            this.robotControl_groupbox.TabIndex = 4;
            this.robotControl_groupbox.TabStop = false;
            this.robotControl_groupbox.Text = "Robot Control";
            // 
            // armControl_groupBox
            // 
            this.armControl_groupBox.Controls.Add(this.Gripper_label);
            this.armControl_groupBox.Controls.Add(this.label9);
            this.armControl_groupBox.Controls.Add(this.Gripper_trackBar);
            this.armControl_groupBox.Controls.Add(this.Elbow_label);
            this.armControl_groupBox.Controls.Add(this.label5);
            this.armControl_groupBox.Controls.Add(this.Elbow_trackBar);
            this.armControl_groupBox.Controls.Add(this.label6);
            this.armControl_groupBox.Controls.Add(this.Wrist_label);
            this.armControl_groupBox.Controls.Add(this.Wrist_trackBar);
            this.armControl_groupBox.Controls.Add(this.base_label);
            this.armControl_groupBox.Controls.Add(this.label1);
            this.armControl_groupBox.Controls.Add(this.base_trackBar);
            this.armControl_groupBox.Controls.Add(this.label2);
            this.armControl_groupBox.Controls.Add(this.Shoulder_label);
            this.armControl_groupBox.Controls.Add(this.Shoulder_trackBar);
            this.armControl_groupBox.Location = new System.Drawing.Point(87, 19);
            this.armControl_groupBox.Name = "armControl_groupBox";
            this.armControl_groupBox.Size = new System.Drawing.Size(377, 302);
            this.armControl_groupBox.TabIndex = 8;
            this.armControl_groupBox.TabStop = false;
            this.armControl_groupBox.Text = "Arm Control";
            // 
            // Gripper_label
            // 
            this.Gripper_label.AutoSize = true;
            this.Gripper_label.Location = new System.Drawing.Point(331, 272);
            this.Gripper_label.Name = "Gripper_label";
            this.Gripper_label.Size = new System.Drawing.Size(29, 13);
            this.Gripper_label.TabIndex = 15;
            this.Gripper_label.Text = "label";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Gripper :";
            // 
            // Gripper_trackBar
            // 
            this.Gripper_trackBar.LargeChange = 10;
            this.Gripper_trackBar.Location = new System.Drawing.Point(14, 236);
            this.Gripper_trackBar.Maximum = 180;
            this.Gripper_trackBar.Name = "Gripper_trackBar";
            this.Gripper_trackBar.Size = new System.Drawing.Size(357, 45);
            this.Gripper_trackBar.SmallChange = 3;
            this.Gripper_trackBar.TabIndex = 14;
            this.Gripper_trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Gripper_trackBar_MouseUp);
            // 
            // Elbow_label
            // 
            this.Elbow_label.AutoSize = true;
            this.Elbow_label.Location = new System.Drawing.Point(328, 164);
            this.Elbow_label.Name = "Elbow_label";
            this.Elbow_label.Size = new System.Drawing.Size(29, 13);
            this.Elbow_label.TabIndex = 9;
            this.Elbow_label.Text = "label";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Elbow :";
            // 
            // Elbow_trackBar
            // 
            this.Elbow_trackBar.LargeChange = 10;
            this.Elbow_trackBar.Location = new System.Drawing.Point(11, 128);
            this.Elbow_trackBar.Maximum = 180;
            this.Elbow_trackBar.Name = "Elbow_trackBar";
            this.Elbow_trackBar.Size = new System.Drawing.Size(357, 45);
            this.Elbow_trackBar.SmallChange = 3;
            this.Elbow_trackBar.TabIndex = 8;
            this.Elbow_trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Elbow_trackBar_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Wrist :";
            // 
            // Wrist_label
            // 
            this.Wrist_label.AutoSize = true;
            this.Wrist_label.Location = new System.Drawing.Point(329, 217);
            this.Wrist_label.Name = "Wrist_label";
            this.Wrist_label.Size = new System.Drawing.Size(29, 13);
            this.Wrist_label.TabIndex = 12;
            this.Wrist_label.Text = "label";
            // 
            // Wrist_trackBar
            // 
            this.Wrist_trackBar.LargeChange = 10;
            this.Wrist_trackBar.Location = new System.Drawing.Point(13, 185);
            this.Wrist_trackBar.Maximum = 180;
            this.Wrist_trackBar.Name = "Wrist_trackBar";
            this.Wrist_trackBar.Size = new System.Drawing.Size(357, 45);
            this.Wrist_trackBar.SmallChange = 3;
            this.Wrist_trackBar.TabIndex = 11;
            this.Wrist_trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Wrist_trackBar_MouseUp);
            // 
            // base_label
            // 
            this.base_label.AutoSize = true;
            this.base_label.Location = new System.Drawing.Point(325, 55);
            this.base_label.Name = "base_label";
            this.base_label.Size = new System.Drawing.Size(29, 13);
            this.base_label.TabIndex = 3;
            this.base_label.Text = "label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Base :";
            // 
            // base_trackBar
            // 
            this.base_trackBar.LargeChange = 10;
            this.base_trackBar.Location = new System.Drawing.Point(8, 19);
            this.base_trackBar.Maximum = 180;
            this.base_trackBar.Name = "base_trackBar";
            this.base_trackBar.Size = new System.Drawing.Size(357, 45);
            this.base_trackBar.SmallChange = 3;
            this.base_trackBar.TabIndex = 2;
            this.base_trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.base_trackBar_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Shoulder :";
            // 
            // Shoulder_label
            // 
            this.Shoulder_label.AutoSize = true;
            this.Shoulder_label.Location = new System.Drawing.Point(325, 108);
            this.Shoulder_label.Name = "Shoulder_label";
            this.Shoulder_label.Size = new System.Drawing.Size(29, 13);
            this.Shoulder_label.TabIndex = 6;
            this.Shoulder_label.Text = "label";
            // 
            // Shoulder_trackBar
            // 
            this.Shoulder_trackBar.LargeChange = 10;
            this.Shoulder_trackBar.Location = new System.Drawing.Point(9, 76);
            this.Shoulder_trackBar.Maximum = 180;
            this.Shoulder_trackBar.Name = "Shoulder_trackBar";
            this.Shoulder_trackBar.Size = new System.Drawing.Size(357, 45);
            this.Shoulder_trackBar.SmallChange = 3;
            this.Shoulder_trackBar.TabIndex = 5;
            this.Shoulder_trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Shoulder_trackBar_MouseUp);
            // 
            // robotOff_button
            // 
            this.robotOff_button.Location = new System.Drawing.Point(6, 55);
            this.robotOff_button.Name = "robotOff_button";
            this.robotOff_button.Size = new System.Drawing.Size(75, 23);
            this.robotOff_button.TabIndex = 1;
            this.robotOff_button.Text = "OFF";
            this.robotOff_button.UseVisualStyleBackColor = true;
            this.robotOff_button.Click += new System.EventHandler(this.robotOff_button_Click);
            // 
            // robotOn_button
            // 
            this.robotOn_button.Location = new System.Drawing.Point(6, 26);
            this.robotOn_button.Name = "robotOn_button";
            this.robotOn_button.Size = new System.Drawing.Size(75, 23);
            this.robotOn_button.TabIndex = 0;
            this.robotOn_button.Text = "ON";
            this.robotOn_button.UseVisualStyleBackColor = true;
            this.robotOn_button.Click += new System.EventHandler(this.robotOn_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(635, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 282);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Serial Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.robotControl_groupbox);
            this.Controls.Add(this.comboBox_Available_SerialPort);
            this.Controls.Add(this.button_closePort);
            this.Controls.Add(this.openPort_button);
            this.Name = "Form1";
            this.Text = "Robot Arm Control";
            this.robotControl_groupbox.ResumeLayout(false);
            this.armControl_groupBox.ResumeLayout(false);
            this.armControl_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gripper_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Elbow_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wrist_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shoulder_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openPort_button;
        private System.Windows.Forms.Button button_closePort;
        private System.Windows.Forms.ComboBox comboBox_Available_SerialPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox robotControl_groupbox;
        private System.Windows.Forms.Button robotOff_button;
        private System.Windows.Forms.Button robotOn_button;
        private System.Windows.Forms.TrackBar base_trackBar;
        private System.Windows.Forms.Label base_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox armControl_groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Shoulder_label;
        private System.Windows.Forms.TrackBar Shoulder_trackBar;
        private System.Windows.Forms.Label Gripper_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar Gripper_trackBar;
        private System.Windows.Forms.Label Elbow_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar Elbow_trackBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Wrist_label;
        private System.Windows.Forms.TrackBar Wrist_trackBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

