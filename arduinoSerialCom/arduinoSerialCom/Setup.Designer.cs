namespace arduinoSerialCom
{
    partial class configirationFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.redTxt = new System.Windows.Forms.TextBox();
            this.greenTxt = new System.Windows.Forms.TextBox();
            this.blueTxt = new System.Windows.Forms.TextBox();
            this.redTxt1 = new System.Windows.Forms.TextBox();
            this.greenTxt1 = new System.Windows.Forms.TextBox();
            this.blueTxt1 = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red LED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green LED";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue LED";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = " Red LED 2";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = " Green LED 2";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = " Blue LED 2";
            this.label6.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(134, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Second LED";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // redTxt
            // 
            this.redTxt.Location = new System.Drawing.Point(69, 2);
            this.redTxt.Name = "redTxt";
            this.redTxt.Size = new System.Drawing.Size(42, 20);
            this.redTxt.TabIndex = 7;
            // 
            // greenTxt
            // 
            this.greenTxt.Location = new System.Drawing.Point(70, 30);
            this.greenTxt.Name = "greenTxt";
            this.greenTxt.Size = new System.Drawing.Size(42, 20);
            this.greenTxt.TabIndex = 8;
            // 
            // blueTxt
            // 
            this.blueTxt.Location = new System.Drawing.Point(70, 56);
            this.blueTxt.Name = "blueTxt";
            this.blueTxt.Size = new System.Drawing.Size(42, 20);
            this.blueTxt.TabIndex = 9;
            // 
            // redTxt1
            // 
            this.redTxt1.Location = new System.Drawing.Point(325, 9);
            this.redTxt1.Name = "redTxt1";
            this.redTxt1.Size = new System.Drawing.Size(49, 20);
            this.redTxt1.TabIndex = 10;
            this.redTxt1.Visible = false;
            // 
            // greenTxt1
            // 
            this.greenTxt1.Location = new System.Drawing.Point(325, 33);
            this.greenTxt1.Name = "greenTxt1";
            this.greenTxt1.Size = new System.Drawing.Size(49, 20);
            this.greenTxt1.TabIndex = 11;
            this.greenTxt1.Visible = false;
            // 
            // blueTxt1
            // 
            this.blueTxt1.Location = new System.Drawing.Point(325, 59);
            this.blueTxt1.Name = "blueTxt1";
            this.blueTxt1.Size = new System.Drawing.Size(49, 20);
            this.blueTxt1.TabIndex = 12;
            this.blueTxt1.Visible = false;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(141, 87);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(88, 23);
            this.confirmBtn.TabIndex = 13;
            this.confirmBtn.Text = "Set up my pins";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Connection Port";
            // 
            // configirationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 122);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.blueTxt1);
            this.Controls.Add(this.greenTxt1);
            this.Controls.Add(this.redTxt1);
            this.Controls.Add(this.blueTxt);
            this.Controls.Add(this.greenTxt);
            this.Controls.Add(this.redTxt);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "configirationFrm";
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox redTxt;
        private System.Windows.Forms.TextBox greenTxt;
        private System.Windows.Forms.TextBox blueTxt;
        private System.Windows.Forms.TextBox redTxt1;
        private System.Windows.Forms.TextBox greenTxt1;
        private System.Windows.Forms.TextBox blueTxt1;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
    }
}