using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexaCalculator
{
    public partial class Form1 : Form
    {
        private bool conversionTypeHex;
        private int digitCount;

        public Form1()
        {
            InitializeComponent();

            conversionTypeHex = true;
            digitCount = 8;

            foreach (Control currentElement in plInputs.Controls.OfType<ComboBox>())
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
            if (conversionTypeHex)
            {
                cBox.Items.AddRange(Converter.Singleton.CollectionDigits);
            }
            else
            {
                cBox.Items.AddRange(Converter.Singleton.CollectionDigits.Take(10).ToArray());
            }
        }



        /// <summary>
        /// Temporarly disables a eventhandler on the control element, in order to change its text-property to the default value.
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
            
            txtOutput.Text = "0";
        }



        /// <summary>
        /// Gathers all userinput, sends it to the converter and then displayes the results.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowCalculatedValue(object sender, EventArgs e)
        {
            char[] cboValues;

            if (sender is TextBox)
            {
                cboValues = Converter.Singleton.ReverseString(txtInput.Text).ToCharArray();
            }
            else
            {
                cboValues = new char[digitCount];

                foreach (Control currentElement in plInputs.Controls.OfType<ComboBox>())
                {
                    ComboBox cbo = (ComboBox)currentElement;
                    cboValues[Convert.ToInt32(cbo.Name.Substring(8)) - 1] = Convert.ToChar(cbo.Text);
                }
            }

            try
            {
                if (conversionTypeHex)
                {
                    txtOutput.Text = Converter.Singleton.ConvertInput(cboValues);
                }
                else
                {
                    string number = new String(cboValues);
                    txtOutput.Text = Converter.Singleton.ConvertInput(number);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                txtInput.Text = txtInput.Text.Remove(txtInput.Text.Length - 1);
                txtInput.SelectionLength = txtInput.Text.Length;
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
                int extraHeight = 55 * (digitCount / (8 * (digitCount / 8))) * polarity;
                plInputs.Height += extraHeight;
                plButtonContainer.Location = new Point(plButtonContainer.Location.X, plButtonContainer.Location.Y + extraHeight);
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
            plInputs.Controls.Add(newDigit);
            plInputs.Controls.Add(newLabel);
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
                foreach (Control currentElement in plInputs.Controls)
                {
                    if (Convert.ToInt32(currentElement.Name.Substring(8)) == elementIndex)
                    {
                        plInputs.Controls.Remove(currentElement);
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



        private void btnChangeConversion_Click(object sender, EventArgs e)
        {
            if (conversionTypeHex)
            {
                conversionTypeHex = false;

                lblHeadLeft.Text = "Decimal";
                lblHeadRight.Text = "Hexadecimal";

                btnChangeConversion.Text = "Convert From Hex to Dec";
            }
            else
            {
                conversionTypeHex = true;

                lblHeadLeft.Text = "Hexadecimal";
                lblHeadRight.Text = "Decimal";

                btnChangeConversion.Text = "Convert From Dec to Hex";
            }

            ResetInput(txtInput);

            foreach (Control currentElement in plInputs.Controls.OfType<ComboBox>())
            {
                SetComboBoxCollections((ComboBox)currentElement);
            }
        }



        private void btnAddDigit_Click(object sender, EventArgs e)
        {
            digitCount++;
            SetInputPanelHeight(1);
            int multiplier = digitCount % 8 > 0 ? digitCount % 8 : 8;
            AddExtraDigit(new Point(plInputs.Width - (44*multiplier+2), plInputs.Height-30));
            SetRemovedBtnStatus();
        }



        private void btnRemoveDigit_Click(object sender, EventArgs e)
        {
            RemoveLastDigit(digitCount);
            digitCount--;
            SetInputPanelHeight(-1);
            SetRemovedBtnStatus();
        }



        private void btnClearInput_Click(object sender, EventArgs e)
        {
            foreach (Control currentElement in plInputs.Controls.OfType<ComboBox>())
            {
                ResetInput((ComboBox)currentElement);
            }

            ResetInput(txtInput);
        }
    }
}
