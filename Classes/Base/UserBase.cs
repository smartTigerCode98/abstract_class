using Classes.Enums;
using Classes.Interfaces;

namespace Classes.Base
{
	public abstract class UserBase : IUser
	{
		public string  Name   { get; set; }
		public int     Age    { get; set; }
		public Sex     Sex    { get; set; }
		public decimal Salary { get; set; }

		protected UserBase(string name, int age, Sex sex, decimal salary)
		{
			Name   = name;
			Age    = age;
			Sex    = sex;
			Salary = salary;
		}

		public bool IsAdult => Age >= 18;
	}
}