using ConsoleApp.Interfaces;
using ConsoleApp.Services;
using ConsoleApp.ViewModels;
using System;
using System.IO;
using Xunit;

namespace UnitTests.ConsoleApp.ConsoleServiceTests
{
    public class Display
    {
		private readonly IConsoleService service;

		public Display()
		{
			service = new ConsoleService();
		}

		[Fact]
		public void ValidViewModel_DisplaysText()
		{
			using (var sw = new StringWriter())
			{
				Console.SetOut(sw);

				service.Display(new TextViewModel
				{
					Text = "TEST"
				});

				var expected = string.Format("TEST" + Environment.NewLine);
				Assert.Equal(expected, sw.ToString());
			}
		}
	}
}
