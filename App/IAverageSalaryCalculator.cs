using System.Collections.Generic;
using Classes.Interfaces;

namespace App
{
	public interface IAverageSalaryCalculator
	{
		decimal CalculateAverageForType<T>(IEnumerable<IUniversityWorker> users) where T : IUniversityWorker;
	}
}