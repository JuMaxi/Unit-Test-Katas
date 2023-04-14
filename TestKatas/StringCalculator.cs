using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKatas
{
    public class StringCalculator
    {
        public int SumNumbers(string NumberString)
        {
            int Number = ConvertingNumbers(NumberString);
            return Number;
        }
        private int ConvertingNumbers(string NumberString)
        {
            if (NumberString == "0")
            {
                return 0;
            }
            else
            {
                return SplitNumbers(NumberString);
            }
        }
        private int SplitNumbers(string NumberString)
        {
            int Sum = 0;

            if (NumberString.Length > 1)
            {
                string[] NumberStringArray = NumberString.Split(',');

                for (int Position = 0; Position < NumberStringArray.Length; Position++)
                {
                    int Number = Convert.ToInt32(NumberStringArray[Position]);

                    ShowingException(Number);
                   
                    Sum = Sum + Number;
                }
            }
            else
            {
                Sum = Convert.ToInt32(NumberString);
                ShowingException(Sum);
            }
            return Sum;
        }
        private void ShowingException(int Number)
        {
            if (Number < 0)
            {
                throw new Exception("The Number is smaller than Zero. You need fill out a number bigger than zero to continue.");
            }
        }
    }
}
