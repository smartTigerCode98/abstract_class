using System;
using System.Collections.Generic;
using System.Linq;
using Classes.Base;
using Classes.Details;
using Classes.Enums;
using Classes.Interfaces;

namespace App
{
	public class Controller
	{
		private readonly IAverageSalaryCalculator _calculator;
		private readonly IOutput                  _output;

		public Controller(IAverageSalaryCalculator calculator, IOutput output)
		{
			_calculator = calculator;
			_output     = output;
		}

		public void Run()
		{
			var users = new List<UserBase>
			{
				new Mentor("MIROSHNI4ENKO", 48, Sex.Male, 300),
				new Tutor("VOVA", 60, Sex.Male, 400000),
				new Tutor("VALYA", 40, Sex.Female, 48000),
				new Student("YURA", 21, Sex.Male, 1300),
				new Student("SHURIK", 20, Sex.Male, 1950),
				new Student("Elon Vladik", 20, Sex.Male, 9000)
			};

			var tutorAverage = _calculator.CalculateAverageForType<Tutor>(users.OfType<IUniversityWorker>());

			_output.Write($"Tutor average salary = {tutorAverage}");
		}
	}
}