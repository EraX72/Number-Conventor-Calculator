using Calculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Controller;

namespace Calculator.View
{
    internal class NumberConverterView
    {
        public void Display(NumberConverterModel model)
        {
            Console.WriteLine($"Резултат: {model.Result}");
        }

        public NumberConverterModel GetInput()
        {
            NumberConverterModel model = new NumberConverterModel();

            Console.Write("Моля, въведете число: ");
            model.InputNumber = Console.ReadLine();

            Console.Write("Моля, въведете бройната система на числото: ");
            model.SourceBase = int.Parse(Console.ReadLine());

            Console.Write("Моля, въведете бройната система, в която искате да преобразувате: ");
            model.TargetBase = int.Parse(Console.ReadLine());

            return model;
        }
    }
}

