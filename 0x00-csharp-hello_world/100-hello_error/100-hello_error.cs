using System;
using System.IO;
using System.Numerics;

class Program
{
	static void Main(string[] args)
	{
		TextWriter errorWriter = Console.Error;
		errorWriter.WriteLine("and that piece of art is useful - Dora Korpar, 2015-10-19");
		Environment.ExitCode = 1;
	}
}
