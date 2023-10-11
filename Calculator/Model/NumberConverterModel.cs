using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.View;
using Calculator.Controller;

namespace Calculator.Model
{
    public class NumberConverterModel
    {
        public int SourceBase { get; set; }
        public int TargetBase { get; set; }
        public string InputNumber { get; set; }
        public string Result { get; set; }
    }
}