using System;
using System.Collections.Generic;
using System.Linq;
using Classes.Interfaces;

namespace App
{
	public class AverageSalaryCalculator : IAverageSalaryCalculator
	{
		public decimal CalculateAverageForType<T>(IEnumerable<IUniversityWorker> users) where T : IUniversityWorker
		{
			return users.OfType<T>().Average(u => u.Salary);
		}

		public decimal CalculateAverageForType(IEnumerable<IUniversityWorker> users, Type userType)
		{
			return users.Where(u => u.GetType() == userType).Average(u => u.Salary);
		}
	}
}