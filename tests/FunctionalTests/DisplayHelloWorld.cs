using System;
using System.IO;
using ConsoleApp;
using Xunit;

namespace FunctionalTests
{
	public class DisplayHelloWorld
	{
		[Fact]
		public void Invokation_DisplaysHelloWorld()
		{
			using (var sw = new StringWriter())
			{
				Console.SetOut(sw);

				Program.Main();

				var expected = string.Format("Hello World!" + Environment.NewLine);
				Assert.Equal(expected, sw.ToString());
			}
		}
	}
}