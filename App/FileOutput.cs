using System;
using System.IO;

namespace App
{
	public class FileOutput : IOutput, IDisposable
	{
		private readonly string _path;
		private readonly StreamWriter _writer;

		public FileOutput(string path)
		{
			_path = path;
			_writer = new StreamWriter(path);
		}

		public void Write(string data)
		{
			_writer.WriteLine(data);
		}

		public void Dispose()
		{
			_writer.Flush();
			_writer.Close();
			_writer.Dispose();
		}
	}
}