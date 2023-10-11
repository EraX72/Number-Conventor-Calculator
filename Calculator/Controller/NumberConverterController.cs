using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Model;
using Calculator.View;

namespace Calculator.Controller
{
    public class NumberConverterController
    {
        public NumberConverterModel Model { get; set; }

        public NumberConverterController()
        {
            Model = new NumberConverterModel();
        }

        public void ConvertNumber()
        {
            int decimalNumber = ConvertToDecimal(Model.InputNumber, Model.SourceBase);
            Model.Result = ConvertFromDecimal(decimalNumber, Model.TargetBase);
        }

        private int ConvertToDecimal(string number, int sourceBase)
        {
            int result = 0;
            int power = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                char digit = number[i];
                int value = char.IsDigit(digit) ? digit - '0' : char.ToUpper(digit) - 'A' + 10;
                result += value * (int)Math.Pow(sourceBase, power);
                power++;
            }

            return result; 
        }

        private string ConvertFromDecimal(int decimalNumber, int targetBase)
        {
            string result = "";

            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % targetBase;
                char digit = (char)(remainder < 10 ? remainder + '0' : remainder - 10 + 'A');
                result = digit + result;
                decimalNumber /= targetBase;
            }

            return result; 
        }
    }
}