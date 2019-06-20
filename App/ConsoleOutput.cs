using System;

namespace App
{
	public class ConsoleOutput : IOutput
	{
		public void Write(string data)
		{
			Console.WriteLine(data);
		}
	}
}