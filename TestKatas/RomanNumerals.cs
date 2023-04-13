using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKatas
{
    public class RomanNumerals
    {
        Dictionary<string, int> Romans = new Dictionary<string, int>();

        public RomanNumerals()
        {
            Romans.Add("I", 1);
            Romans.Add("V", 5);
            Romans.Add("X", 10);
            Romans.Add("L", 50);
            Romans.Add("C", 100);
            Romans.Add("D", 500);
            Romans.Add("M", 1000);
        }

        public int ConvertToNumber(string romans)
        {
            if(Romans.ContainsKey(romans))
            {
                return Romans[romans];
            }
            else
            {
                return ConvertToNumberNewKeys(romans);
            }
        }

        private int ConvertToNumberNewKeys(string romans)
        {
            int Number = 0;
            int result = 0;
            for (int Position = 0; Position < romans.Length; Position++)
            {
                string Key = romans[Position].ToString();
                
                int Value = 0;

                if (Romans.ContainsKey(Key))
                {
                    Value = Romans[Key];
                }
                if(Value > Number)
                {
                    result = Value - Number;
                }
                else
                {
                    result = result + Value;
                }
                Number = Value;
            }
            return result;
        }
    }
}
