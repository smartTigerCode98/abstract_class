namespace Classes.Details
{
	public class Group
	{
		public string Name   { get; set; }
		public string Code   { get; set; }
		public Mentor Mentor { get; set; }

		public Group(string name, string code, Mentor mentor)
		{
			Name   = name;
			Code   = code;
			Mentor = mentor;
		}
	}
}