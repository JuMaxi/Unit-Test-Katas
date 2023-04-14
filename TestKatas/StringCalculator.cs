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
                char[] Split = ReturnCharToSplit(NumberString);
                string [] NumberStringArray = NumberString.Split(Split, StringSplitOptions.RemoveEmptyEntries);

                for (int Position = 0; Position < NumberStringArray.Length; Position++)
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
        private char CustomizeDelimitor(string NumberString)
        {
            char Character = ' ';
            for (int Position = 0; Position < NumberString.Length; Position++)
            {
                if (Position < NumberString.Length - 1)
                {
                    if (NumberString[Position] == '/')
                    {
                        if (NumberString[Position + 1] == '/')
                        {
                            if(NumberString[Position + 2] != '[')
                            {
                                Character = NumberString[Position + 2];
                            }
                            else
                            {
                                CustomizeDelimitor2(NumberString);
                            }
                        }
                    }
                }
            }
            return Character;
        }

        private string CustomizeDelimitor2(string NumberString)
        {
            string Characteres = "'//',";

            for(int Position = 0; Position < NumberString.Length; Position++) 
            {
                if (NumberString[Position] == '[')
                {
                    Characteres = Characteres + "'["+ NumberString[Position + 1] + "]', ";
                }
            }
            return Characteres;
        }
        private char[] ReturnCharToSplit(string NumberString)
        {
            char Character = CustomizeDelimitor(NumberString);
            string Characters = CustomizeDelimitor2(NumberString);

            if (Character != ' ')
            {
                Characters = "'//" + Character + "',";
            }

            Characters = Characters + "',','\n'";
            char[] Split = new char[Characters.Length];

            for (int Position = 0; Position < Characters.Length; Position++)
            {
                Split[Position] = Characters[Position];
            }

            return Split;
        }

       
    }
}
