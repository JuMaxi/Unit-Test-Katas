using Microsoft.VisualStudio.TestPlatform.Utilities;
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
            return CheckStringIsEmpty(NumberString);
        }
        private int CheckStringIsEmpty(string NumberString)
        {
            return NumberString == "" ? 0 : ProcessNumbers(NumberString);
        }
        private int ProcessNumbers(string NumberString)
        {
            int Sum = 0;

            List<int> Numbers = ReturnOnlyIntNumbers(NumberString);

            for (int Position = 0; Position < Numbers.Count; Position++)
            {
                ShowExceptionNumberSmallerThanZero(Numbers[Position]);

                Sum = Sum + ReduceNumberBiggerThan1000(Numbers[Position]);
            }
            return Sum;
        }
        private void ShowExceptionNumberSmallerThanZero(int Number)
        {
            if (Number < 0)
            {
                throw new Exception("The Number " + Number + " is smaller than Zero. You need fill out a number bigger than zero to continue.");
            }
        }
        private int ReduceNumberBiggerThan1000(int Number)
        {
            return Number > 1000 ? 0 : Number; 
        }

        private List<int> ReturnOnlyIntNumbers(string NumberString)
        {
            List<int> Numbers = new List<int>();

            string Characters = "";

            for (int PositionString = 0; PositionString < NumberString.Length; PositionString++)
            {
                if (char.IsDigit(NumberString[PositionString])
                    || NumberString[PositionString] == '-')
                {
                    Characters = Characters + NumberString[PositionString].ToString();
                }

                if (char.IsDigit(NumberString[PositionString]) == false
                    || PositionString == NumberString.Length - 1)
                {
                    if (Characters != "" && Characters != "-")
                    {
                        Numbers.Add(Convert.ToInt32(Characters));
                        Characters = "";
                    }
                }
            }
            return Numbers;
        }

    }
}
