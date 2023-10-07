using System;



public class EmployeeController
{
	private EmployeeService _employeeService;

	public EmployeeController()
	{
		_employeeService = new EmployeeService();
	}

	public void GetFilteredEmployee()
	{

		decimal start = 1000;
		decimal end = 2000;

		foreach (Employee employee in _employeeService.FilteredEmployeeBySalary(start,end))
		{
			string result = $"{employee.Id} - {employee.Name} - {employee.Surname} - {employee.Age} - {employee.Salary}";

			Console.WriteLine(result);
		}
	}

	public void SortEmployees()
	{
		Console.WriteLine("Choose on option for sorting");

		string sortText = Console.ReadLine();

        foreach (Employee employee in _employeeService.SortEmployees(sortText))
        {
            string result = $"{employee.Id} - {employee.Name} - {employee.Surname} - {employee.Age} - {employee.Salary}";

            Console.WriteLine(result);
        }
    }
}


