namespace HexDecBin_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cboInput1 = new System.Windows.Forms.ComboBox();
            this.panInputs = new System.Windows.Forms.Panel();
            this.lblInput8 = new System.Windows.Forms.Label();
            this.lblInput7 = new System.Windows.Forms.Label();
            this.lblInput6 = new System.Windows.Forms.Label();
            this.lblInput5 = new System.Windows.Forms.Label();
            this.lblInput4 = new System.Windows.Forms.Label();
            this.lblInput3 = new System.Windows.Forms.Label();
            this.lblInput2 = new System.Windows.Forms.Label();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.cboInput8 = new System.Windows.Forms.ComboBox();
            this.cboInput7 = new System.Windows.Forms.ComboBox();
            this.cboInput6 = new System.Windows.Forms.ComboBox();
            this.cboInput5 = new System.Windows.Forms.ComboBox();
            this.cboInput4 = new System.Windows.Forms.ComboBox();
            this.cboInput3 = new System.Windows.Forms.ComboBox();
            this.cboInput2 = new System.Windows.Forms.ComboBox();
            this.lblMainHeader = new System.Windows.Forms.Label();
            this.txtOutputTop = new System.Windows.Forms.TextBox();
            this.lblOutputTop = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddDigit = new System.Windows.Forms.Button();
            this.btnRemoveDigit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panButtonContainer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboConversionType = new System.Windows.Forms.ComboBox();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.txtOutputBottom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutputBottom = new System.Windows.Forms.Label();
            this.panInputs.SuspendLayout();
            this.panButtonContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboInput1
            // 
            this.cboInput1.FormattingEnabled = true;
            this.cboInput1.Location = new System.Drawing.Point(315, 35);
            this.cboInput1.Name = "cboInput1";
            this.cboInput1.Size = new System.Drawing.Size(38, 21);
            this.cboInput1.TabIndex = 0;
            this.cboInput1.Text = "0";
            this.cboInput1.SelectedIndexChanged += new System.EventHandler(this.ShowCalculatedValue);
            this.cboInput1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventManualInput);
            // 
            // panInputs
            // 
            this.panInputs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panInputs.Controls.Add(this.lblInput8);
            this.panInputs.Controls.Add(this.lblInput7);
            this.panInputs.Controls.Add(this.lblInput6);
            this.panInputs.Controls.Add(this.lblInput5);
            this.panInputs.Controls.Add(this.lblInput4);
            this.panInputs.Controls.Add(this.lblInput3);
            this.panInputs.Controls.Add(this.lblInput2);
            this.panInputs.Controls.Add(this.lblInput1);
            this.panInputs.Controls.Add(this.cboInput8);
            this.panInputs.Controls.Add(this.cboInput7);
            this.panInputs.Controls.Add(this.cboInput6);
            this.panInputs.Controls.Add(this.cboInput5);
            this.panInputs.Controls.Add(this.cboInput4);
            this.panInputs.Controls.Add(this.cboInput3);
            this.panInputs.Controls.Add(this.cboInput2);
            this.panInputs.Controls.Add(this.cboInput1);
            this.panInputs.Location = new System.Drawing.Point(12, 36);
            this.panInputs.Name = "panInputs";
            this.panInputs.Size = new System.Drawing.Size(361, 65);
            this.panInputs.TabIndex = 1;
            // 
            // lblInput8
            // 
            this.lblInput8.AutoSize = true;
            this.lblInput8.Location = new System.Drawing.Point(9, 19);
            this.lblInput8.Name = "lblInput8";
            this.lblInput8.Size = new System.Drawing.Size(37, 13);
            this.lblInput8.TabIndex = 14;
            this.lblInput8.Text = "Digit 8";
            // 
            // lblInput7
            // 
            this.lblInput7.AutoSize = true;
            this.lblInput7.Location = new System.Drawing.Point(52, 19);
            this.lblInput7.Name = "lblInput7";
            this.lblInput7.Size = new System.Drawing.Size(37, 13);
            this.lblInput7.TabIndex = 13;
            this.lblInput7.Text = "Digit 7";
            // 
            // lblInput6
            // 
            this.lblInput6.AutoSize = true;
            this.lblInput6.Location = new System.Drawing.Point(97, 19);
            this.lblInput6.Name = "lblInput6";
            this.lblInput6.Size = new System.Drawing.Size(37, 13);
            this.lblInput6.TabIndex = 12;
            this.lblInput6.Text = "Digit 6";
            // 
            // lblInput5
            // 
            this.lblInput5.AutoSize = true;
            this.lblInput5.Location = new System.Drawing.Point(140, 19);
            this.lblInput5.Name = "lblInput5";
            this.lblInput5.Size = new System.Drawing.Size(37, 13);
            this.lblInput5.TabIndex = 11;
            this.lblInput5.Text = "Digit 5";
            // 
            // lblInput4
            // 
            this.lblInput4.AutoSize = true;
            this.lblInput4.Location = new System.Drawing.Point(184, 19);
            this.lblInput4.Name = "lblInput4";
            this.lblInput4.Size = new System.Drawing.Size(37, 13);
            this.lblInput4.TabIndex = 10;
            this.lblInput4.Text = "Digit 4";
            // 
            // lblInput3
            // 
            this.lblInput3.AutoSize = true;
            this.lblInput3.Location = new System.Drawing.Point(228, 19);
            this.lblInput3.Name = "lblInput3";
            this.lblInput3.Size = new System.Drawing.Size(37, 13);
            this.lblInput3.TabIndex = 11;
            this.lblInput3.Text = "Digit 3";
            // 
            // lblInput2
            // 
            this.lblInput2.AutoSize = true;
            this.lblInput2.Location = new System.Drawing.Point(273, 19);
            this.lblInput2.Name = "lblInput2";
            this.lblInput2.Size = new System.Drawing.Size(37, 13);
            this.lblInput2.TabIndex = 12;
            this.lblInput2.Text = "Digit 2";
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.Location = new System.Drawing.Point(316, 19);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(37, 13);
            this.lblInput1.TabIndex = 8;
            this.lblInput1.Text = "Digit 1";
            // 
            // cboInput8
            // 
            this.cboInput8.FormattingEnabled = true;
            this.cboInput8.Location = new System.Drawing.Point(7, 35);
            this.cboInput8.Name = "cboInput8";
            this.cboInput8.Size = new System.Drawing.Size(38, 21);
            this.cboInput8.TabIndex = 7;
            this.cboInput8.Text = "0";
            this.cboInput8.SelectedIndexChanged += new System.EventHandler(this.ShowCalculatedValue);
            this.cboInput8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventManualInput);
            // 
            // cboInput7
            // 
            this.cboInput7.FormattingEnabled = true;
            this.cboInput7.Location = new System.Drawing.Point(51, 35);
            this.cboInput7.Name = "cboInput7";
            this.cboInput7.Size = new System.Drawing.Size(38, 21);
            this.cboInput7.TabIndex = 6;
            this.cboInput7.Text = "0";
            this.cboInput7.SelectedIndexChanged += new System.EventHandler(this.ShowCalculatedValue);
            this.cboInput7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventManualInput);
            // 
            // cboInput6
            // 
            this.cboInput6.FormattingEnabled = true;
            this.cboInput6.Location = new System.Drawing.Point(95, 35);
            this.cboInput6.Name = "cboInput6";
            this.cboInput6.Size = new System.Drawing.Size(38, 21);
            this.cboInput6.TabIndex = 5;
            this.cboInput6.Text = "0";
            this.cboInput6.SelectedIndexChanged += new System.EventHandler(this.ShowCalculatedValue);
            this.cboInput6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventManualInput);
            // 
            // cboInput5
            // 
            this.cboInput5.FormattingEnabled = true;
            this.cboInput5.Location = new System.Drawing.Point(139, 35);
            this.cboInput5.Name = "cboInput5";
            this.cboInput5.Size = new System.Drawing.Size(38, 21);
            this.cboInput5.TabIndex = 4;
            this.cboInput5.Text = "0";
            this.cboInput5.SelectedIndexChanged += new System.EventHandler(this.ShowCalculatedValue);
            this.cboInput5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventManualInput);
            // 
            // cboInput4
            // 
            this.cboInput4.FormattingEnabled = true;
            this.cboInput4.Location = new System.Drawing.Point(183, 35);
            this.cboInput4.Name = "cboInput4";
            this.cboInput4.Size = new System.Drawing.Size(38, 21);
            this.cboInput4.TabIndex = 3;
            this.cboInput4.Text = "0";
            this.cboInput4.SelectedIndexChanged += new System.EventHandler(this.ShowCalculatedValue);
            this.cboInput4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventManualInput);
            // 
            // cboInput3
            // 
            this.cboInput3.FormattingEnabled = true;
            this.cboInput3.Location = new System.Drawing.Point(227, 35);
            this.cboInput3.Name = "cboInput3";
            this.cboInput3.Size = new System.Drawing.Size(38, 21);
            this.cboInput3.TabIndex = 2;
            this.cboInput3.Text = "0";
            this.cboInput3.SelectedIndexChanged += new System.EventHandler(this.ShowCalculatedValue);
            this.cboInput3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventManualInput);
            // 
            // cboInput2
            // 
            this.cboInput2.FormattingEnabled = true;
            this.cboInput2.Location = new System.Drawing.Point(271, 35);
            this.cboInput2.Name = "cboInput2";
            this.cboInput2.Size = new System.Drawing.Size(38, 21);
            this.cboInput2.TabIndex = 1;
            this.cboInput2.Text = "0";
            this.cboInput2.SelectedIndexChanged += new System.EventHandler(this.ShowCalculatedValue);
            this.cboInput2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventManualInput);
            // 
            // lblMainHeader
            // 
            this.lblMainHeader.AutoSize = true;
            this.lblMainHeader.Location = new System.Drawing.Point(153, 17);
            this.lblMainHeader.Name = "lblMainHeader";
            this.lblMainHeader.Size = new System.Drawing.Size(68, 13);
            this.lblMainHeader.TabIndex = 2;
            this.lblMainHeader.Text = "Hexadecimal";
            // 
            // txtOutputTop
            // 
            this.txtOutputTop.Location = new System.Drawing.Point(379, 36);
            this.txtOutputTop.Name = "txtOutputTop";
            this.txtOutputTop.ReadOnly = true;
            this.txtOutputTop.Size = new System.Drawing.Size(175, 20);
            this.txtOutputTop.TabIndex = 3;
            this.txtOutputTop.Text = "0";
            // 
            // lblOutputTop
            // 
            this.lblOutputTop.AutoSize = true;
            this.lblOutputTop.Location = new System.Drawing.Point(468, 17);
            this.lblOutputTop.Name = "lblOutputTop";
            this.lblOutputTop.Size = new System.Drawing.Size(45, 13);
            this.lblOutputTop.TabIndex = 5;
            this.lblOutputTop.Text = "Decimal";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(96, 3);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(214, 20);
            this.txtInput.TabIndex = 6;
            this.txtInput.TextChanged += new System.EventHandler(this.ShowCalculatedValue);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Manual Input:";
            // 
            // btnAddDigit
            // 
            this.btnAddDigit.Location = new System.Drawing.Point(8, 35);
            this.btnAddDigit.Name = "btnAddDigit";
            this.btnAddDigit.Size = new System.Drawing.Size(82, 23);
            this.btnAddDigit.TabIndex = 8;
            this.btnAddDigit.Text = "Add Digit";
            this.btnAddDigit.UseVisualStyleBackColor = true;
            this.btnAddDigit.Click += new System.EventHandler(this.btnAddDigit_Click);
            // 
            // btnRemoveDigit
            // 
            this.btnRemoveDigit.Enabled = false;
            this.btnRemoveDigit.Location = new System.Drawing.Point(96, 35);
            this.btnRemoveDigit.Name = "btnRemoveDigit";
            this.btnRemoveDigit.Size = new System.Drawing.Size(82, 23);
            this.btnRemoveDigit.TabIndex = 9;
            this.btnRemoveDigit.Text = "Remove Digit";
            this.btnRemoveDigit.UseVisualStyleBackColor = true;
            this.btnRemoveDigit.Click += new System.EventHandler(this.btnRemoveDigit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Result:";
            // 
            // panButtonContainer
            // 
            this.panButtonContainer.Controls.Add(this.label3);
            this.panButtonContainer.Controls.Add(this.cboConversionType);
            this.panButtonContainer.Controls.Add(this.btnClearInput);
            this.panButtonContainer.Controls.Add(this.btnRemoveDigit);
            this.panButtonContainer.Controls.Add(this.btnAddDigit);
            this.panButtonContainer.Controls.Add(this.txtInput);
            this.panButtonContainer.Controls.Add(this.label9);
            this.panButtonContainer.Location = new System.Drawing.Point(12, 110);
            this.panButtonContainer.Name = "panButtonContainer";
            this.panButtonContainer.Size = new System.Drawing.Size(550, 64);
            this.panButtonContainer.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Conversion Type";
            // 
            // cboConversionType
            // 
            this.cboConversionType.FormattingEnabled = true;
            this.cboConversionType.Items.AddRange(new object[] {
            "Convert From Hex to Dec & Bin",
            "Convert From Dec to Hex & Bin",
            "Convert From Bin to Dec & Hex"});
            this.cboConversionType.Location = new System.Drawing.Point(367, 26);
            this.cboConversionType.Name = "cboConversionType";
            this.cboConversionType.Size = new System.Drawing.Size(173, 21);
            this.cboConversionType.TabIndex = 11;
            this.cboConversionType.Text = "Convert From Hex to Dec & Bin";
            this.cboConversionType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnClearInput
            // 
            this.btnClearInput.Location = new System.Drawing.Point(228, 35);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(82, 23);
            this.btnClearInput.TabIndex = 10;
            this.btnClearInput.Text = "Clear Input";
            this.btnClearInput.UseVisualStyleBackColor = true;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
            // 
            // txtOutputBottom
            // 
            this.txtOutputBottom.Location = new System.Drawing.Point(379, 81);
            this.txtOutputBottom.Name = "txtOutputBottom";
            this.txtOutputBottom.ReadOnly = true;
            this.txtOutputBottom.Size = new System.Drawing.Size(175, 20);
            this.txtOutputBottom.TabIndex = 12;
            this.txtOutputBottom.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Result:";
            // 
            // lblOutputBottom
            // 
            this.lblOutputBottom.AutoSize = true;
            this.lblOutputBottom.Location = new System.Drawing.Point(468, 64);
            this.lblOutputBottom.Name = "lblOutputBottom";
            this.lblOutputBottom.Size = new System.Drawing.Size(36, 13);
            this.lblOutputBottom.TabIndex = 13;
            this.lblOutputBottom.Text = "Binary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOutputBottom);
            this.Controls.Add(this.txtOutputBottom);
            this.Controls.Add(this.panButtonContainer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblOutputTop);
            this.Controls.Add(this.txtOutputTop);
            this.Controls.Add(this.lblMainHeader);
            this.Controls.Add(this.panInputs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hex/Dec/Bin Calculator";
            this.panInputs.ResumeLayout(false);
            this.panInputs.PerformLayout();
            this.panButtonContainer.ResumeLayout(false);
            this.panButtonContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboInput1;
        private System.Windows.Forms.Panel panInputs;
        private System.Windows.Forms.ComboBox cboInput8;
        private System.Windows.Forms.ComboBox cboInput7;
        private System.Windows.Forms.ComboBox cboInput6;
        private System.Windows.Forms.ComboBox cboInput5;
        private System.Windows.Forms.ComboBox cboInput4;
        private System.Windows.Forms.ComboBox cboInput3;
        private System.Windows.Forms.ComboBox cboInput2;
        private System.Windows.Forms.Label lblMainHeader;
        private System.Windows.Forms.TextBox txtOutputTop;
        private System.Windows.Forms.Label lblInput3;
        private System.Windows.Forms.Label lblInput2;
        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.Label lblInput8;
        private System.Windows.Forms.Label lblInput7;
        private System.Windows.Forms.Label lblInput6;
        private System.Windows.Forms.Label lblInput5;
        private System.Windows.Forms.Label lblInput4;
        private System.Windows.Forms.Label lblOutputTop;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddDigit;
        private System.Windows.Forms.Button btnRemoveDigit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panButtonContainer;
        private System.Windows.Forms.Button btnClearInput;
        private System.Windows.Forms.TextBox txtOutputBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOutputBottom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboConversionType;
    }
}

