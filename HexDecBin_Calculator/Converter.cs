using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HexDecBin_Calculator
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
        /// <param name="allHexDigits">The ordered array of hexadecimal digits from left to rigth.</param>
        /// <returns>The converted decimal number.</returns>
        public string ConvertInput(char[] allHexDigits)
        {
            List<object> tmpNums = new List<object>();

            for (int i = 0; i < allHexDigits.Length; i++)
            {
                tmpNums.Add(ConvertFromHexToDec(allHexDigits[i], i));
            }

            if (CheckForOverFlow(tmpNums))
            {
                MessageBox.Show("The converted number overflows the C# int datatype, switching to double datatype!");
                
                double overflowSave = 0;
                foreach (object value in tmpNums)
                {
                    if (value is int)
                    {
                        overflowSave += Convert.ToDouble(value);
                    }
                    else
                    {
                        overflowSave += (double)value;
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
        /// Converts a string containing a decimal number to its hexadecimal counterpart. 
        /// </summary>
        /// <param name="decimalNumber">The decimal number to convert.</param>
        /// <returns>Hex representation of the input number or error.</returns>
        public string ConvertInput(string decimalNumber)
        {
            ulong dividend;
            if (UInt64.TryParse(decimalNumber, out dividend))
            {
                string convertedResult = "";

                if (dividend > 15)
                {
                    while (dividend > 16)
                    {
                        ulong remainder = dividend % 16;
                        convertedResult += remainder > 9 ? ConvertFromDecToHex((int)remainder) : Convert.ToString(remainder);
                        dividend /= 16;
                    }

                    convertedResult += dividend;
                }
                else
                {
                    convertedResult = dividend > 9 ? ConvertFromDecToHex((int)dividend) : Convert.ToString(dividend);
                }

                return ReverseString(convertedResult);
            }
            else
            {
                if (!ContainsDigitsOnly(decimalNumber))
                {
                    throw new Exception("Invailded input!");
                }
                else
                {
                    return "Error UInt64 overflow!";
                }
            }
        }



        public string ConvertInputToBin(string decimalNum)
        {
            string binaryRepersentation = "";
            int num = Convert.ToInt32(decimalNum);
  
            while (num > 0)
            {
                binaryRepersentation += num % 2;
                num /= 2;
            }

            if (binaryRepersentation.Length % 4 != 0)
            {
                int numOfNibbels = (binaryRepersentation.Length/4)+1;
                while (binaryRepersentation.Length < numOfNibbels * 4)
                {
                    binaryRepersentation += 0;
                }
            }

            return binaryRepersentation.Length == 0 ? "0000" : ReverseString(binaryRepersentation);
        }



        /// <summary>
        /// Converts a single hex number based on its value and its magnintued, to its decimal counterpart.
        /// </summary>
        /// <param name="digitToConvert">The hexadecimal char.</param>
        /// <param name="digitPosition">The magnitued/position of the provided digit.</param>
        /// <returns>The decimal number as typeof int or decimal.</returns>
        private object ConvertFromHexToDec(char digitToConvert, int digitPosition)
        {
            string digit = Convert.ToString(digitToConvert);
            int num;
            if (!Int32.TryParse(digit, out num))
            {
                if (hexValues.ContainsKey(digit.ToUpper()))
                {
                    num = hexValues[digit.ToUpper()];
                } 
                else
                {
                    throw new Exception("Invailded input!");
                }
            }

            try
            {
                if (Convert.ToInt32(num * Math.Pow(16, digitPosition)) < 0)
                {
                    double overflowSave = num;
                    return overflowSave * Convert.ToDouble(Math.Pow(16, digitPosition));
                }
            } 
            catch
            {
                return Convert.ToDouble(num * Math.Pow(16, digitPosition));
            }
            

            return Convert.ToInt32(num * Math.Pow(16, digitPosition));
        }



        /// <summary>
        /// Checks if a single number or the sum of multiple numbers, inside a list of number objects, would cause integer overflow. 
        /// </summary>
        /// <param name="numbersToCheck">List with number objects like int and decimal.</param>
        /// <returns>True/false based on the result of the check.</returns>
        private bool CheckForOverFlow(List<object> numbersToCheck)
        {
            int totalSum = 0;

            foreach (object value in numbersToCheck)
            {
                if (value is double)
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
        /// Goes through each char in a string and checks if its between 0-9.
        /// </summary>
        /// <param name="str">The string which is going to be checked.</param>
        /// <returns>True if the string ony contains number chars, False if it doesn't.</returns>
        private bool ContainsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }


        /// <summary>
        /// Reverses the provided string.
        /// </summary>
        /// <param name="stringToReverse">The string to reverse.</param>
        /// <returns>The reversed string.</returns>
        public string ReverseString(string stringToReverse)
        {
            char[] array = stringToReverse.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        } 



        /// <summary>
        /// Takes a integer and looks up its hexadecimal counterpart.
        /// </summary>
        /// <param name="numberToConvert">The decimal number which needs converting.</param>
        /// <returns>Hex representation of the input number.</returns>
        public string ConvertFromDecToHex(int numberToConvert)
        {
            return hexValues.FirstOrDefault(x => x.Value == numberToConvert).Key;
        }
    }
}
