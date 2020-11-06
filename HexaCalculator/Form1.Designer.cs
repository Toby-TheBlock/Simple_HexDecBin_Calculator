namespace HexaCalculator
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
            this.cboInput1 = new System.Windows.Forms.ComboBox();
            this.plInputs = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboInput8 = new System.Windows.Forms.ComboBox();
            this.cboInput7 = new System.Windows.Forms.ComboBox();
            this.cboInput6 = new System.Windows.Forms.ComboBox();
            this.cboInput5 = new System.Windows.Forms.ComboBox();
            this.cboInput4 = new System.Windows.Forms.ComboBox();
            this.cboInput3 = new System.Windows.Forms.ComboBox();
            this.cboInput2 = new System.Windows.Forms.ComboBox();
            this.lblHeadLeft = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnChangeConversion = new System.Windows.Forms.Button();
            this.lblHeadRight = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddDigit = new System.Windows.Forms.Button();
            this.btnRemoveDigit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.plButtonContainer = new System.Windows.Forms.Panel();
            this.plInputs.SuspendLayout();
            this.plButtonContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboInput1
            // 
            this.cboInput1.FormattingEnabled = true;
            this.cboInput1.Location = new System.Drawing.Point(416, 26);
            this.cboInput1.Margin = new System.Windows.Forms.Padding(4);
            this.cboInput1.Name = "cboInput1";
            this.cboInput1.Size = new System.Drawing.Size(49, 24);
            this.cboInput1.TabIndex = 0;
            this.cboInput1.Text = "0";
            this.cboInput1.SelectedIndexChanged += new System.EventHandler(this.ShowCalculatedValue);
            this.cboInput1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventManualInput);
            // 
            // plInputs
            // 
            this.plInputs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plInputs.Controls.Add(this.label8);
            this.plInputs.Controls.Add(this.label7);
            this.plInputs.Controls.Add(this.label6);
            this.plInputs.Controls.Add(this.label5);
            this.plInputs.Controls.Add(this.label4);
            this.plInputs.Controls.Add(this.label3);
            this.plInputs.Controls.Add(this.label2);
            this.plInputs.Controls.Add(this.label1);
            this.plInputs.Controls.Add(this.cboInput8);
            this.plInputs.Controls.Add(this.cboInput7);
            this.plInputs.Controls.Add(this.cboInput6);
            this.plInputs.Controls.Add(this.cboInput5);
            this.plInputs.Controls.Add(this.cboInput4);
            this.plInputs.Controls.Add(this.cboInput3);
            this.plInputs.Controls.Add(this.cboInput2);
            this.plInputs.Controls.Add(this.cboInput1);
            this.plInputs.Location = new System.Drawing.Point(16, 54);
            this.plInputs.Margin = new System.Windows.Forms.Padding(4);
            this.plInputs.Name = "plInputs";
            this.plInputs.Size = new System.Drawing.Size(477, 67);
            this.plInputs.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Digit 8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Digit 7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Digit 6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Digit 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Digit 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Digit 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Digit 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digit 1";
            // 
            // cboInput8
            // 
            this.cboInput8.FormattingEnabled = true;
            this.cboInput8.Location = new System.Drawing.Point(5, 26);
            this.cboInput8.Margin = new System.Windows.Forms.Padding(4);
            this.cboInput8.Name = "cboInput8";
            this.cboInput8.Size = new System.Drawing.Size(49, 24);
            this.cboInput8.TabIndex = 7;
            this.cboInput8.Text = "0";
            this.cboInput8.SelectedIndexChanged += new System.EventHandler(this.ShowCalculatedValue);
            this.cboInput8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventManualInput);
            // 
            // cboInput7
            // 
            this.cboInput7.FormattingEnabled = true;
            this.cboInput7.Location = new System.Drawing.Point(64, 26);
            this.cboInput7.Margin = new System.Windows.Forms.Padding(4);
            this.cboInput7.Name = "cboInput7";
            this.cboInput7.Size = new System.Drawing.Size(49, 24);
            this.cboInput7.TabIndex = 6;
            this.cboInput7.Text = "0";
            this.cboInput7.SelectedIndexChanged += new System.EventHandler(this.ShowCalculatedValue);
            this.cboInput7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventManualInput);
            // 
            // cboInput6
            // 
            this.cboInput6.FormattingEnabled = true;
            this.cboInput6.Location = new System.Drawing.Point(123, 26);
            this.cboInput6.Margin = new System.Windows.Forms.Padding(4);
            this.cboInput6.Name = "cboInput6";
            this.cboInput6.Size = new System.Drawing.Size(49, 24);
            this.cboInput6.TabIndex = 5;
            this.cboInput6.Text = "0";
            this.cboInput6.SelectedIndexChanged += new System.EventHandler(this.ShowCalculatedValue);
            this.cboInput6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventManualInput);
            // 
            // cboInput5
            // 
            this.cboInput5.FormattingEnabled = true;
            this.cboInput5.Location = new System.Drawing.Point(181, 26);
            this.cboInput5.Margin = new System.Windows.Forms.Padding(4);
            this.cboInput5.Name = "cboInput5";
            this.cboInput5.Size = new System.Drawing.Size(49, 24);
            this.cboInput5.TabIndex = 4;
            this.cboInput5.Text = "0";
            this.cboInput5.SelectedIndexChanged += new System.EventHandler(this.ShowCalculatedValue);
            this.cboInput5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventManualInput);
            // 
            // cboInput4
            // 
            this.cboInput4.FormattingEnabled = true;
            this.cboInput4.Location = new System.Drawing.Point(240, 26);
            this.cboInput4.Margin = new System.Windows.Forms.Padding(4);
            this.cboInput4.Name = "cboInput4";
            this.cboInput4.Size = new System.Drawing.Size(49, 24);
            this.cboInput4.TabIndex = 3;
            this.cboInput4.Text = "0";
            this.cboInput4.SelectedIndexChanged += new System.EventHandler(this.ShowCalculatedValue);
            this.cboInput4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventManualInput);
            // 
            // cboInput3
            // 
            this.cboInput3.FormattingEnabled = true;
            this.cboInput3.Location = new System.Drawing.Point(299, 26);
            this.cboInput3.Margin = new System.Windows.Forms.Padding(4);
            this.cboInput3.Name = "cboInput3";
            this.cboInput3.Size = new System.Drawing.Size(49, 24);
            this.cboInput3.TabIndex = 2;
            this.cboInput3.Text = "0";
            this.cboInput3.SelectedIndexChanged += new System.EventHandler(this.ShowCalculatedValue);
            this.cboInput3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventManualInput);
            // 
            // cboInput2
            // 
            this.cboInput2.FormattingEnabled = true;
            this.cboInput2.Location = new System.Drawing.Point(357, 26);
            this.cboInput2.Margin = new System.Windows.Forms.Padding(4);
            this.cboInput2.Name = "cboInput2";
            this.cboInput2.Size = new System.Drawing.Size(49, 24);
            this.cboInput2.TabIndex = 1;
            this.cboInput2.Text = "0";
            this.cboInput2.SelectedIndexChanged += new System.EventHandler(this.ShowCalculatedValue);
            this.cboInput2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventManualInput);
            // 
            // lblHeadLeft
            // 
            this.lblHeadLeft.AutoSize = true;
            this.lblHeadLeft.Location = new System.Drawing.Point(204, 21);
            this.lblHeadLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadLeft.Name = "lblHeadLeft";
            this.lblHeadLeft.Size = new System.Drawing.Size(88, 17);
            this.lblHeadLeft.TabIndex = 2;
            this.lblHeadLeft.Text = "Hexadecimal";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(520, 82);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(195, 22);
            this.txtOutput.TabIndex = 3;
            this.txtOutput.Text = "0";
            // 
            // btnChangeConversion
            // 
            this.btnChangeConversion.Location = new System.Drawing.Point(516, 22);
            this.btnChangeConversion.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeConversion.Name = "btnChangeConversion";
            this.btnChangeConversion.Size = new System.Drawing.Size(196, 28);
            this.btnChangeConversion.TabIndex = 0;
            this.btnChangeConversion.Text = "Convert From Hex to Dec";
            this.btnChangeConversion.UseVisualStyleBackColor = true;
            this.btnChangeConversion.Click += new System.EventHandler(this.btnChangeConversion_Click);
            // 
            // lblHeadRight
            // 
            this.lblHeadRight.AutoSize = true;
            this.lblHeadRight.Location = new System.Drawing.Point(597, 54);
            this.lblHeadRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadRight.Name = "lblHeadRight";
            this.lblHeadRight.Size = new System.Drawing.Size(58, 17);
            this.lblHeadRight.TabIndex = 5;
            this.lblHeadRight.Text = "Decimal";
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(12, 26);
            this.textInput.Margin = new System.Windows.Forms.Padding(4);
            this.textInput.Name = "textInput";
            this.textInput.ReadOnly = true;
            this.textInput.Size = new System.Drawing.Size(195, 22);
            this.textInput.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Manual Input";
            // 
            // btnAddDigit
            // 
            this.btnAddDigit.Location = new System.Drawing.Point(244, 22);
            this.btnAddDigit.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDigit.Name = "btnAddDigit";
            this.btnAddDigit.Size = new System.Drawing.Size(119, 28);
            this.btnAddDigit.TabIndex = 8;
            this.btnAddDigit.Text = "Add Digit";
            this.btnAddDigit.UseVisualStyleBackColor = true;
            this.btnAddDigit.Click += new System.EventHandler(this.btnAddDigit_Click);
            // 
            // btnRemoveDigit
            // 
            this.btnRemoveDigit.Location = new System.Drawing.Point(371, 22);
            this.btnRemoveDigit.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveDigit.Name = "btnRemoveDigit";
            this.btnRemoveDigit.Size = new System.Drawing.Size(119, 28);
            this.btnRemoveDigit.TabIndex = 9;
            this.btnRemoveDigit.Text = "Remove Digit";
            this.btnRemoveDigit.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(536, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Result:";
            // 
            // plButtonContainer
            // 
            this.plButtonContainer.Controls.Add(this.btnRemoveDigit);
            this.plButtonContainer.Controls.Add(this.btnAddDigit);
            this.plButtonContainer.Controls.Add(this.textInput);
            this.plButtonContainer.Controls.Add(this.btnChangeConversion);
            this.plButtonContainer.Controls.Add(this.label9);
            this.plButtonContainer.Location = new System.Drawing.Point(4, 129);
            this.plButtonContainer.Margin = new System.Windows.Forms.Padding(4);
            this.plButtonContainer.Name = "plButtonContainer";
            this.plButtonContainer.Size = new System.Drawing.Size(719, 64);
            this.plButtonContainer.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 208);
            this.Controls.Add(this.plButtonContainer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblHeadRight);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblHeadLeft);
            this.Controls.Add(this.plInputs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.plInputs.ResumeLayout(false);
            this.plInputs.PerformLayout();
            this.plButtonContainer.ResumeLayout(false);
            this.plButtonContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboInput1;
        private System.Windows.Forms.Panel plInputs;
        private System.Windows.Forms.ComboBox cboInput8;
        private System.Windows.Forms.ComboBox cboInput7;
        private System.Windows.Forms.ComboBox cboInput6;
        private System.Windows.Forms.ComboBox cboInput5;
        private System.Windows.Forms.ComboBox cboInput4;
        private System.Windows.Forms.ComboBox cboInput3;
        private System.Windows.Forms.ComboBox cboInput2;
        private System.Windows.Forms.Label lblHeadLeft;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnChangeConversion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHeadRight;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddDigit;
        private System.Windows.Forms.Button btnRemoveDigit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel plButtonContainer;
    }
}

