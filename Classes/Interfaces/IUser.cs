using Classes.Enums;

namespace Classes.Interfaces
{
	public interface IUser
	{
		string  Name   { get; set; }
		int     Age    { get; set; }
		Sex     Sex    { get; set; }
	}
}