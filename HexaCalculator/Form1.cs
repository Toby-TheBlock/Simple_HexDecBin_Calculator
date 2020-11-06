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
        private int comboBoxCount;

        public Form1()
        {
            InitializeComponent();

            conversionTypeHex = true;
            comboBoxCount = 8; 
            SetComboBoxCollections("hex");
        }


        private void SetComboBoxCollections(string collectionType)
        {
            foreach(Control currentElement in plInputs.Controls)
            {
                if (currentElement is ComboBox)
                {
                    ComboBox cbo = (ComboBox) currentElement;
                    cbo.Text = "0";
                    cbo.Items.Clear();
                    if (collectionType == "hex")
                    {
                        cbo.Items.AddRange(Converter.Singleton.CollectionDigits);
                    } 
                    else if (collectionType == "dec")
                    {
                        cbo.Items.AddRange(Converter.Singleton.CollectionDigits.Take(10).ToArray());
                    }
                }
                
            }
        }

        private void ShowCalculatedValue(object sender, EventArgs e)
        {
            char[] cboValues = new char[comboBoxCount];

            foreach (Control currentElement in plInputs.Controls)
            {
                if (currentElement is ComboBox)
                {
                    ComboBox cbo = (ComboBox)currentElement;
                    cboValues[Convert.ToInt32(cbo.Name.Substring(8)) - 1] = Convert.ToChar(cbo.Text);
                }
            }

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

        private void AddExtraDigit()
        {
            comboBoxCount++;

            ComboBox newDigit = new ComboBox
            {
                Name = "cboInput" + comboBoxCount,
            };


            //cbo.SelectedIndexChanged += new EventHandler(ShowCalculatedValue);
            plInputs.Controls.Add(newDigit);
        }

        private void btnChangeConversion_Click(object sender, EventArgs e)
        {
            if (conversionTypeHex)
            {
                SetComboBoxCollections("dec");
                conversionTypeHex = false;

                lblHeadLeft.Text = "Decimal";
                lblHeadRight.Text = "Hexadecimal";

                btnChangeConversion.Text = "Convert From Hex to Dec";
            }
            else
            {
                SetComboBoxCollections("hex");
                conversionTypeHex = true;

                lblHeadLeft.Text = "Hexadecimal";
                lblHeadRight.Text = "Decimal";

                btnChangeConversion.Text = "Convert From Dec to Hex";
            }
        }

        private void btnAddDigit_Click(object sender, EventArgs e)
        {
            if ((comboBoxCount + 1) % 8 == 1)
            {
                int extraHeight = 40;
                plInputs.Height += extraHeight;
                plButtonContainer.Location = new Point(plButtonContainer.Location.X, plButtonContainer.Location.Y + extraHeight);
                this.Height += extraHeight;
            }

        }

        private void PreventManualInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
