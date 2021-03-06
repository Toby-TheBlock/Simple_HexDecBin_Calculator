﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HexDecBin_Calculator
{
    public partial class Form1 : Form
    {
        private int conversionType; // 1 = HexToDec&Bin, 2 = DecToHex&Bin, 3 = BinToDec&Hex
        private int digitCount;

        public Form1()
        {
            InitializeComponent();

            conversionType = 1;
            digitCount = 8;

            foreach (Control currentElement in panInputs.Controls.OfType<ComboBox>())
            {
                SetComboBoxCollections((ComboBox)currentElement);
            }
        }



        /// <summary>
        /// Changes the collection-property of a combobox based on which conversion type the calculator is set to. 
        /// </summary>
        /// <param name="cBox">The comboBox whos collection needs to be changed.</param>
        private void SetComboBoxCollections(ComboBox cBox)
        {
            ResetInput(cBox);
            cBox.Items.Clear();
            switch(conversionType)
            {
                case 1:
                    cBox.Items.AddRange(Converter.Singleton.CollectionDigits);
                    break;
                case 2:
                    cBox.Items.AddRange(Converter.Singleton.CollectionDigits.Take(10).ToArray());
                    break;
                case 3:
                    cBox.Items.AddRange(Converter.Singleton.CollectionDigits.Take(2).ToArray());
                    break;
            }
        }



        /// <summary>
        /// Temporarly disables a eventhandler on the control element, in order to change its text-property to a default value.
        /// </summary>
        /// <param name="element">The control element which is to be reset.</param>
        private void ResetInput(Control element)
        {
            if (element is ComboBox)
            {
                ComboBox castedElement = (ComboBox) element;
                ManageEventhandler(castedElement, false);
                element.Text = "0";
                ManageEventhandler(castedElement, true);
            }
            else
            {
                TextBox castedElement = (TextBox) element;
                ManageEventhandler(castedElement, false);
                element.Text = "";
                ManageEventhandler(castedElement, true);
            }
        }



        /// <summary>
        /// Resets all output-textboxes i the GUI to their default value.
        /// </summary>
        private void ResetOutput()
        {
            txtOutputTop.Text = "0";
            txtOutputBottom.Text = "0";
        }



        /// <summary>
        /// Gathers all userinput, sends it to the converter and then displayes the results.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowCalculatedValue(object sender, EventArgs e)
        {
            char[] cboValues;

            if (sender is TextBox && txtInput.Text.Length != 0)
            {
                cboValues = Converter.Singleton.ReverseString(txtInput.Text).ToCharArray();
            }
            else
            {
                cboValues = new char[digitCount];

                foreach (Control currentElement in panInputs.Controls.OfType<ComboBox>())
                {
                    ComboBox cbo = (ComboBox)currentElement;
                    cboValues[Convert.ToInt32(cbo.Name.Substring(8)) - 1] = Convert.ToChar(cbo.Text);
                }
            }

            try
            {
                switch (conversionType)
                {
                    case 1:
                        string resultHexToDecAndBin = Converter.Singleton.ConvertInput(cboValues);
                        txtOutputTop.Text = resultHexToDecAndBin;
                        txtOutputBottom.Text = Converter.Singleton.ConvertDecToBin(resultHexToDecAndBin);
                        break;
                    case 2:
                        string resultDecToHexAndBin = Converter.Singleton.ReverseString(new String(cboValues));
                        txtOutputTop.Text = Converter.Singleton.ConvertInput(resultDecToHexAndBin);
                        txtOutputBottom.Text = Converter.Singleton.ConvertDecToBin(resultDecToHexAndBin);
                        break;
                    case 3:
                        int[] binaryNums = Array.ConvertAll(cboValues, currentChar => (int)Char.GetNumericValue(currentChar));
                        string resultBinToHexAndDec = Converter.Singleton.ConvertInput(binaryNums);
                        txtOutputTop.Text = Converter.Singleton.ConvertInput(resultBinToHexAndDec);
                        txtOutputBottom.Text = resultBinToHexAndDec;
                        break;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                ManageEventhandler(txtInput, false);
                txtInput.Text = txtInput.Text.Remove(txtInput.Text.Length-1);
                ManageEventhandler(txtInput, true);
                txtInput.SelectionLength = txtInput.Text.Length;
                ResetOutput();
            }
        }    



        /// <summary>
        /// Changes the total height of the inputs-panel, and changes position of other affected control elements accordingly. 
        /// </summary>
        /// <param name="polarity">Positiv int to add height, negativ int to reduce height.</param>
        private void SetInputPanelHeight(int polarity)
        {
            if (polarity == 1 && digitCount % 8 == 1 || polarity == -1 && digitCount % 8 == 0)
            {
                int extraHeight = 65 * (digitCount / (8 * (digitCount / 8))) * polarity;
                panInputs.Height += extraHeight;
                panButtonContainer.Location = new Point(panButtonContainer.Location.X, panButtonContainer.Location.Y + extraHeight);
                this.Height += extraHeight;
            }
        }



        /// <summary>
        /// Adds a new digit-combobox/-label onto the inputs-panel.
        /// </summary>
        /// <param name="position">The point at which the new digit is to be positioned.</param>
        private void AddExtraDigit(Point position)
        {
            ComboBox newDigit = new ComboBox
            {
                Name = "cboInput" + digitCount,
                Location = position,
                Width = 38,
                Height = 106,
            };

            Label newLabel = new Label
            {
                Name = "lblInput" + digitCount,
                Location = new Point(position.X, position.Y - 17),
                Text = "Digit " + digitCount 
            };

            SetComboBoxCollections(newDigit);
            panInputs.Controls.Add(newDigit);
            panInputs.Controls.Add(newLabel);
        }



        /// <summary>
        /// Removed the last added digit-combobox/-label from the inputs-panel. 
        /// </summary>
        /// <param name="elementIndex">The index of the digit which is to be removed.</param>
        private void RemoveLastDigit(int elementIndex)
        {
            // For some reason the last label is always skipped on the first run of the foreach, 
            // therefore it needs to be run twice. In order to remove both label and combobox. 
            for (int i = 0; i < 2; i++)
            {
                foreach (Control currentElement in panInputs.Controls)
                {
                    if (Convert.ToInt32(currentElement.Name.Substring(8)) == elementIndex)
                    {
                        panInputs.Controls.Remove(currentElement);
                    }
                }
            }
        }



        /// <summary>
        /// Adds or removes a SelectedIndexChanged event for a combobox. 
        /// </summary>
        /// <param name="element">The combobox for which the eventhandler needs to be changed.</param>
        /// <param name="status">True = add eventhandler, false = remove eventhandler.</param>
        private void ManageEventhandler(ComboBox cbo, bool status)
        {
            if (status)
            {
                cbo.SelectedIndexChanged += new EventHandler(ShowCalculatedValue);
            } 
            else
            {
                cbo.SelectedIndexChanged -= new EventHandler(ShowCalculatedValue);
            }
        }



        /// <summary>
        /// Adds or removes a TextChanged event for a textbox. 
        /// </summary>
        /// <param name="element">The textbox for which the eventhandler needs to be changed.</param>
        /// <param name="status">True = add eventhandler, false = remove eventhandler.</param>
        private void ManageEventhandler(TextBox txt, bool status)
        {
            if (status)
            {
                txt.TextChanged += new EventHandler(ShowCalculatedValue);
            }
            else
            {
                txt.TextChanged -= new EventHandler(ShowCalculatedValue);
            }
        }



        /// <summary>
        /// Enables the "Remove digit" button if there are more than 8 digits present, otherwise disabels it. 
        /// </summary>
        private void SetRemovedBtnStatus()
        {
            btnRemoveDigit.Enabled = digitCount > 8 ? true : false;
        }



        /// <summary>
        /// Overwrites the default keypress event for a combobox, in order to prevent manual input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreventManualInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }



        private void btnAddDigit_Click(object sender, EventArgs e)
        {
            digitCount++;
            SetInputPanelHeight(1);
            int multiplier = digitCount % 8 > 0 ? digitCount % 8 : 8;
            AddExtraDigit(new Point(panInputs.Width - (44*multiplier+2), panInputs.Height-30));
            SetRemovedBtnStatus();
        }



        private void btnRemoveDigit_Click(object sender, EventArgs e)
        {
            RemoveLastDigit(digitCount);
            digitCount--;
            SetInputPanelHeight(-1);
            SetRemovedBtnStatus();
            ShowCalculatedValue(sender, e);
        }



        private void btnClearInput_Click(object sender, EventArgs e)
        {
            foreach (Control currentElement in panInputs.Controls.OfType<ComboBox>())
            {
                ResetInput((ComboBox)currentElement);
            }

            ResetInput(txtInput);
            ResetOutput();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboConversionType.SelectedIndex + 1)
            {
                case 1:
                    conversionType = 1;
                    lblMainHeader.Text = "Hexadecimal";
                    lblOutputTop.Text = "Decimal";
                    lblOutputBottom.Text = "Binary";
                    break;

                case 2:
                    conversionType = 2;
                    lblMainHeader.Text = "Decimal";
                    lblOutputTop.Text = "Hexadecimal";
                    lblOutputBottom.Text = "Binary";
                    break;

                case 3:
                    conversionType = 3;
                    lblMainHeader.Text = "Binary";
                    lblOutputTop.Text = "Hexadecimal";
                    lblOutputBottom.Text = "Decimal";
                    break;
            }

            foreach (Control currentElement in panInputs.Controls.OfType<ComboBox>())
            {
                SetComboBoxCollections((ComboBox)currentElement);
            }

            ResetInput(txtInput);
            ResetOutput();
        }
    }
}
