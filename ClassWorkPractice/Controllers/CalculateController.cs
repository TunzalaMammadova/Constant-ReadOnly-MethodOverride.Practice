using System;


public class CalculateController
{
		private readonly CalculateService _calculateService;
		public CalculateController()
		{
			_calculateService = new CalculateService();
		
		}
		public void Calculate()
		{
			Console.WriteLine("Add first number:");
	        Num1: string num1 = Console.ReadLine();

	    	if (string.IsNullOrWhiteSpace(num1))
			goto Num1;
		    Console.WriteLine(CalculateNotification.InputEmptyMessage) ;

			double number1;

			bool isTrueNum1 = double.TryParse(num1, out number1);

			if (!isTrueNum1)
			{
				Console.WriteLine(CalculateNotification.CorrectInputMessage);
				goto Num1;
			}

			Console.WriteLine("Please select operation: + - * / ");

		    string operation = Console.ReadLine();


            Console.WriteLine("Add second number:");
            Num2: string num2 = Console.ReadLine();

            double number2;

            bool isTrueNum2 = double.TryParse(num2, out number2);

            if (!isTrueNum2)
            {
                Console.WriteLine(CalculateNotification.CorrectInputMessage);
                goto Num1;
            }

			if(operation == "/" && number2 == 0)
		{
			Console.WriteLine("Cant be divide by zero,please start again");
			goto Num2;
		}

			string result = _calculateService.Calculate(number1, number2, operation);

			Console.WriteLine(result);
        }
    
}

