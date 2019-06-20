using Classes.Base;
using Classes.Enums;
using Classes.Interfaces;

namespace Classes.Details
{
	public class Mentor : UserBase, IUniversityWorker
	{
		public Mentor(string name, int age, Sex sex, decimal salary) : base(name, age, sex, salary) { }
	}
}