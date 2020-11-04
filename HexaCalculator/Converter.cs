using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexaCalculator
{
    class Converter
    {
        private static Converter singleton = null;
        private Dictionary<string, int> hexValues;

        private Converter()
        {
            hexValues = new Dictionary<string, int>() { { "A", 10 }, { "B", 11 }, { "C", 12 }, { "D", 13 }, { "E", 14 }, { "F", 15 } };
            CollectionDigits = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        }

        public string[] CollectionDigits { get; }

        public static Converter Singleton
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new Converter();
                }
                return singleton;
            }
        }

        /**
         * Overloaded method for conversion of hex to decimal.
         */
        public string ConvertInput(string[] allHexDigits)
        {
            List<object> tmpNums = new List<object>();

            for (int i = 0; i < allHexDigits.Length; i++)
            {
                tmpNums.Add(ConvertFromHexToDec(allHexDigits[i], i));
            }

            if (CheckForOverFlow(tmpNums))
            {
                MessageBox.Show("The converted number overflows the C# int datatype, switching to decimal datatype!");
                
                decimal overflowSave = 0;
                foreach (object value in tmpNums)
                {
                    if (value is int)
                    {
                        overflowSave += Convert.ToDecimal(value);
                    }
                    else
                    {
                        overflowSave += (decimal)value;
                    }
                }
                return Convert.ToString(overflowSave);
            }
            else
            {
                List<int> allInt = new List<int>(tmpNums.Cast<int>());
                return Convert.ToString(allInt.Sum());
            }
        }

        private object ConvertFromHexToDec(string digitToConvert, int digitPosition)
        {
            int num;
            if (!Int32.TryParse(digitToConvert, out num))
            {
                num = hexValues[digitToConvert];
            }

            if ((num * Convert.ToInt32(Math.Pow(16, digitPosition))) < 0)
            {
                decimal overflowSave = num;
                return overflowSave * Convert.ToDecimal(Math.Pow(16, digitPosition));
            }

            return num * Convert.ToInt32(Math.Pow(16, digitPosition));
        }

        private bool CheckForOverFlow(List<object> numbersToCheck)
        {
            int totalSum = 0;

            foreach (object value in numbersToCheck)
            {
                if (value is decimal)
                {
                    return true;
                }

                totalSum += (int)value;
                if (totalSum < 0)
                {
                    return true;
                }
            }

            return false;
        }

        /**
         * Overloaded method for conversion of decimal to hex.
         */
        public string ConvertInput(int decminalNumber)
        {
            string convertedResult = "";

            return convertedResult;
        }


        public string ConvertFromDecToHex(string numberToConvert)
        {
            int divider = 0;
            if (Int32.TryParse(numberToConvert, out divider))
            {

            }
            /*
            if (!Decimal.TryParse(digitToConvert, out num))
            {
                num = hexValues[digitToConvert];
            }

            return (num * Convert.ToInt32(Math.Pow(16, digitPosition)));
            */

            return "";
        }
    }
}
