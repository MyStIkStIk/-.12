using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Model
    {
        public string Result(string first, string second, string operand)
        {
            double firstvalue = 0;
            double secondvalue = 0;
            bool checker = double.TryParse(first, out firstvalue);
            bool checker2 = double.TryParse(second, out secondvalue);
            if (checker && checker)
            {
                switch (operand)
                {
                    case "+":
                        return Convert.ToString(firstvalue + secondvalue);
                    case "-":
                        return Convert.ToString(firstvalue - secondvalue);
                    case "*":
                        return Convert.ToString(firstvalue * secondvalue);
                    case "/":
                            if (secondvalue != 0 && firstvalue != 0)
                                return Convert.ToString(firstvalue / secondvalue);
                            else
                                return "Попытка деления на 0, результат - 0";
                };
            }
            return "Введено недопустимое значение";

        }
    }
}
