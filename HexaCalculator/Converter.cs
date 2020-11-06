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



        /// <summary>
        /// Converts a array of hexadecimal chars to its 10-base decimal counterpart.  
        /// </summary>
        /// <param name="allHexDigits">the ordered array of hexadecimal digits from left to rigth.</param>
        /// <returns>the converted decimal number.</returns>
        public string ConvertInput(char[] allHexDigits)
        {
            List<object> tmpNums = new List<object>();

            for (int i = 0; i < allHexDigits.Length; i++)
            {
                tmpNums.Add(ConvertFromHexToDec(Convert.ToString(allHexDigits[i]), i));
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



        /// <summary>
        /// Converts a single hex number based on its value and its magnintued, to its decimal counterpart.
        /// </summary>
        /// <param name="digitToConvert">the hexadecimal char.</param>
        /// <param name="digitPosition">the magnitued/position of the provided digit.</param>
        /// <returns>the decimal number as typeof int or decimal.</returns>
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



        /// <summary>
        /// Checks if a single number or the sum of multiple numbers, inside a list of number objects, would cause integer overflow. 
        /// </summary>
        /// <param name="numbersToCheck">list with number objects like int and decimal.</param>
        /// <returns>true/false based on the result of the check.</returns>
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



        /// <summary>
        /// Converts a string containing a decimal number to its hexadecimal counterpart. 
        /// </summary>
        /// <param name="decimalNumber">the decimal number to convert.</param>
        /// <returns>hex representation of the input number or error.</returns>
        public string ConvertInput(string decimalNumber)
        {
            int dividend;

            if (Int32.TryParse(ReverseString(decimalNumber), out dividend))
            {
                string convertedResult = "";
                
                if (dividend > 15)
                {
                    while (dividend > 16)
                    {
                        int remainder = dividend % 16;
                        convertedResult += remainder > 9 ? ConvertFromDecToHex(remainder) : Convert.ToString(remainder);
                        dividend /= 16;
                    }

                    convertedResult += dividend;
                }
                else
                {
                    convertedResult = dividend > 9 ? ConvertFromDecToHex(dividend) : Convert.ToString(dividend);
                }

                return ReverseString(convertedResult);
            }
            else
            {
                return "Error";
            }
        }



        /// <summary>
        /// Reverses the provided string.
        /// </summary>
        /// <param name="stringToReverse">the string to reverse.</param>
        /// <returns>the reversed string.</returns>
        private string ReverseString(string stringToReverse)
        {
            char[] array = stringToReverse.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        } 



        /// <summary>
        /// Takes a integer and looks up its hexadecimal counterpart.
        /// </summary>
        /// <param name="numberToConvert">the decimal number which needs converting.</param>
        /// <returns>hex representation of the input number.</returns>
        public string ConvertFromDecToHex(int numberToConvert)
        {
            return hexValues.FirstOrDefault(x => x.Value == numberToConvert).Key;
        }
    }
}
