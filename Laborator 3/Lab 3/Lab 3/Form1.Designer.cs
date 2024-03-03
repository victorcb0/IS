namespace Lab_3
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
            this.comboBoxMAC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPlain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMAC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMACHEX = new System.Windows.Forms.TextBox();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMAC
            // 
            this.comboBoxMAC.FormattingEnabled = true;
            this.comboBoxMAC.Items.AddRange(new object[] {
            "SHA1",
            "MD5",
            "RIPEMD",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.comboBoxMAC.Location = new System.Drawing.Point(76, 38);
            this.comboBoxMAC.Name = "comboBoxMAC";
            this.comboBoxMAC.Size = new System.Drawing.Size(161, 24);
            this.comboBoxMAC.TabIndex = 0;
            this.comboBoxMAC.Text = "SHA1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(356, 38);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.ReadOnly = true;
            this.textBoxKey.Size = new System.Drawing.Size(195, 22);
            this.textBoxKey.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ASCII";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "ASCII";
            // 
            // textBoxPlain
            // 
            this.textBoxPlain.Location = new System.Drawing.Point(356, 123);
            this.textBoxPlain.Name = "textBoxPlain";
            this.textBoxPlain.Size = new System.Drawing.Size(195, 22);
            this.textBoxPlain.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Plain Text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "ASCII";
            // 
            // textBoxMAC
            // 
            this.textBoxMAC.Location = new System.Drawing.Point(356, 207);
            this.textBoxMAC.Name = "textBoxMAC";
            this.textBoxMAC.ReadOnly = true;
            this.textBoxMAC.Size = new System.Drawing.Size(195, 22);
            this.textBoxMAC.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "MAC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "HEX";
            // 
            // textBoxMACHEX
            // 
            this.textBoxMACHEX.Location = new System.Drawing.Point(356, 235);
            this.textBoxMACHEX.Name = "textBoxMACHEX";
            this.textBoxMACHEX.Size = new System.Drawing.Size(195, 22);
            this.textBoxMACHEX.TabIndex = 12;
            // 
            // buttonCompute
            // 
            this.buttonCompute.Location = new System.Drawing.Point(76, 118);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(161, 33);
            this.buttonCompute.TabIndex = 14;
            this.buttonCompute.Text = "Compute MAC";
            this.buttonCompute.UseVisualStyleBackColor = true;
            this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click);
            // 
            // buttonVerify
            // 
            this.buttonVerify.Location = new System.Drawing.Point(76, 221);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(161, 33);
            this.buttonVerify.TabIndex = 15;
            this.buttonVerify.Text = "Verify MAC";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.buttonCompute);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxMACHEX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMAC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPlain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMAC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMAC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPlain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMAC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMACHEX;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.Button buttonVerify;
    }
}

