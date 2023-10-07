using System;





public class CalculateService
{
		public string Calculate(double num1 , double num2 , string operation)
		{
			string result;
			switch (operation)
			{
				case "+":
					result = (num1 + num2).ToString();
					return result;
                case "-":
                    result = (num1 - num2).ToString();
                    return result;
                case "*":
                    result = (num1 * num2).ToString();
                    return result;
                case "/":
                    result = (num1 / num2).ToString();
                    return result;
                default:
                    result = CalculateNotification.InvalidOperation;
                    return result;




          

            }
        }
}


