using System;
using System.Collections.Generic;
using System.Linq;
using Classes.Base;
using Classes.Details;
using Classes.Enums;
using Classes.Interfaces;

namespace App
{
	class Program
	{
		private static readonly string[] _outputs = { "file", "console" };

		static void Main(string[] args)
		{
			var outputType = AskOutputType();
			var output     = GetOutput(outputType);

			var controller = new Controller(new AverageSalaryCalculator(), output);
			controller.Run();

			if (output is IDisposable disposable)
			{
				disposable.Dispose();
			}

			//SOLID
			//S - single responsibility
			//O - open-closed principle
			//L - Liskov subsitution
			//I - interface segregation
			//D - dependency inversion

			//ConcreteA -> ConcreteB
			//ConcreteA -> IB, ConcreteB : IB
		}

		private static string AskOutputType()
		{
			Console.WriteLine($"Choose output type ({string.Join(',', _outputs)})");
			var outputType = Console.ReadLine();

			if (!_outputs.Contains(outputType))
			{
				Console.WriteLine("Invalid output type. Try again.");
				return AskOutputType();
			}

			return outputType;
		}

		private static IOutput GetOutput(string type)
		{
			switch (type)
			{
				case "file":
				{
					return new FileOutput("output");
				}

				case "console":
				{
					return new ConsoleOutput();
				}

				default:
				{
					throw new NotImplementedException();
				}
			}
		}
	}
}