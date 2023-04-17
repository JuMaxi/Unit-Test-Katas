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
            int Number = ConvertingNumbers(NumberString);
            return Number;
        }
        private int ConvertingNumbers(string NumberString)
        {
            if (NumberString == "")
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
                List<string> NumberStringArray = ReturnJustNumbers(NumberString);

                for (int Position = 0; Position < NumberStringArray.Count; Position++)
                {
                    int Number = Convert.ToInt32(NumberStringArray[Position]);

                    ShowingException(Number);

                    Number = ReducingNumberBiggerThan1000(Number);

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
                throw new Exception("The Number " + Number + " is smaller than Zero. You need fill out a number bigger than zero to continue.");
            }
        }
        private int ReducingNumberBiggerThan1000(int Number)
        {
            if (Number > 1000)
            {
                return 0;
            }
            return Number;
        }
        private List<string> ReturnJustNumbers(string NumberString)
        {
            List<string> Numbers = new List<string>();

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
                        Numbers.Add(Characters);
                        Characters = "";
                    }
                }

            }
            return Numbers;
        }
      





    }
}
