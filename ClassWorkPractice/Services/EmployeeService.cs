using System;



public class EmployeeService
{
	public Employee[] FilteredEmployeeBySalary(decimal startSalary, decimal endSalary)

	{
        Employee[] employees = GetAll();

		Employee[] filteredEmployees = employees.Where(m => m.Salary > startSalary && m.Salary < endSalary).ToArray();

        return filteredEmployees;
	}


	private Employee[] GetAll()
	{
		return new Employee[]
		{
			new Employee
			{
				Id = 1,
				Name = "Tunzale",
				Surname = "Memmedova",
				Age = 24,
				Salary = 1000
			},

            new Employee
            {
                Id = 2,
                Name = "Semed",
                Surname = "Huseynov",
                Age = 26,
				Salary = 1500
            },


            new Employee
            {
                Id = 3,
                Name = "Oruc",
                Surname = "Mehrabov",
                Age = 26,
				Salary = 1300
            },



        };

	}

	public Employee[] SortEmployees(string sortType)
	{
		var employees = GetAll();

		if (sortType == "asc")
			return employees.OrderBy(m => m.Salary).ToArray();


        return employees.OrderByDescending(m => m.Salary).ToArray();


    }


}