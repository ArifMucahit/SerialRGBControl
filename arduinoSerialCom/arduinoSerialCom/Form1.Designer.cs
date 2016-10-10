using System;

namespace arduinoSerialCom
{
    partial class MainForm
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
            this.redLed = new System.Windows.Forms.Button();
            this.greenLED = new System.Windows.Forms.Button();
            this.blueLED = new System.Windows.Forms.Button();
            this.redLED1 = new System.Windows.Forms.Button();
            this.greenLED1 = new System.Windows.Forms.Button();
            this.blueLED1 = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.closeBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redLed
            // 
            this.redLed.Location = new System.Drawing.Point(12, 12);
            this.redLed.Name = "redLed";
            this.redLed.Size = new System.Drawing.Size(75, 23);
            this.redLed.TabIndex = 0;
            this.redLed.Text = "RED";
            this.redLed.UseVisualStyleBackColor = true;
            this.redLed.Click += new System.EventHandler(this.redLed_Click);
            // 
            // greenLED
            // 
            this.greenLED.Location = new System.Drawing.Point(121, 12);
            this.greenLED.Name = "greenLED";
            this.greenLED.Size = new System.Drawing.Size(75, 23);
            this.greenLED.TabIndex = 3;
            this.greenLED.Text = "GREEN";
            this.greenLED.UseVisualStyleBackColor = true;
            this.greenLED.Click += new System.EventHandler(this.greenLED_Click_1);
            // 
            // blueLED
            // 
            this.blueLED.Location = new System.Drawing.Point(216, 12);
            this.blueLED.Name = "blueLED";
            this.blueLED.Size = new System.Drawing.Size(75, 23);
            this.blueLED.TabIndex = 4;
            this.blueLED.Text = "BLUE";
            this.blueLED.UseVisualStyleBackColor = true;
            this.blueLED.Click += new System.EventHandler(this.blueLED_Click);
            // 
            // redLED1
            // 
            this.redLED1.Location = new System.Drawing.Point(12, 89);
            this.redLED1.Name = "redLED1";
            this.redLED1.Size = new System.Drawing.Size(75, 23);
            this.redLED1.TabIndex = 5;
            this.redLED1.Text = "RED 2";
            this.redLED1.UseVisualStyleBackColor = true;
            this.redLED1.Click += new System.EventHandler(this.redLED1_Click);
            // 
            // greenLED1
            // 
            this.greenLED1.Location = new System.Drawing.Point(121, 89);
            this.greenLED1.Name = "greenLED1";
            this.greenLED1.Size = new System.Drawing.Size(75, 23);
            this.greenLED1.TabIndex = 6;
            this.greenLED1.Text = "GREEN 2";
            this.greenLED1.UseVisualStyleBackColor = true;
            this.greenLED1.Click += new System.EventHandler(this.greenLED1_Click);
            // 
            // blueLED1
            // 
            this.blueLED1.Location = new System.Drawing.Point(225, 89);
            this.blueLED1.Name = "blueLED1";
            this.blueLED1.Size = new System.Drawing.Size(75, 23);
            this.blueLED1.TabIndex = 7;
            this.blueLED1.Text = "BLUE 2";
            this.blueLED1.UseVisualStyleBackColor = true;
            this.blueLED1.Click += new System.EventHandler(this.blueLED1_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(12, 48);
            this.hScrollBar1.Maximum = 255;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(288, 16);
            this.hScrollBar1.TabIndex = 255;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(83, 138);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(150, 23);
            this.closeBtn.TabIndex = 256;
            this.closeBtn.Text = "CLOSE ALL";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_1);
            // 
            // button1
            // 
            this.button1.Image = global::arduinoSerialCom.Properties.Resources.settings;
            this.button1.Location = new System.Drawing.Point(12, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 39);
            this.button1.TabIndex = 257;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(247, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 39);
            this.button2.TabIndex = 258;
            this.button2.Text = "CLOSE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 189);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.blueLED1);
            this.Controls.Add(this.greenLED1);
            this.Controls.Add(this.redLED1);
            this.Controls.Add(this.blueLED);
            this.Controls.Add(this.greenLED);
            this.Controls.Add(this.redLed);
            this.Name = "MainForm";
            this.Text = "Arduino RGB LED Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

       



        #endregion

        private System.Windows.Forms.Button redLed;
        private System.Windows.Forms.Button greenLED;
        private System.Windows.Forms.Button blueLED;
        private System.Windows.Forms.Button redLED1;
        private System.Windows.Forms.Button greenLED1;
        private System.Windows.Forms.Button blueLED1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button closeBtn;
        private EventHandler greenLED_Click;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

