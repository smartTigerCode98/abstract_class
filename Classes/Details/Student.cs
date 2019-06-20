using Classes.Base;
using Classes.Enums;

namespace Classes.Details
{
	public class Student : UserBase
	{
		public Student(string name, int age, Sex sex, decimal salary) : base(name, age, sex, salary) { }
	}
}