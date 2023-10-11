using Calculator.Controller;
using Calculator.Model;
using Calculator.View;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberConverterController controller = new NumberConverterController();
            NumberConverterView view = new NumberConverterView();

            NumberConverterModel model = view.GetInput();
            controller.Model = model;
            controller.ConvertNumber();
            view.Display(model);
        }
    }
}