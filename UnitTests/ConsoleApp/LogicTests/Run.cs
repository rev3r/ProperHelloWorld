using AutoMapper;
using ConsoleApp;
using ConsoleApp.Interfaces;
using ConsoleApp.ViewModels;
using Core.Entities;
using Core.Interfaces;
using FakeItEasy;
using System;
using Xunit;

namespace UnitTests.ConsoleApp.LogicTests
{
    public class Run
	{
		private readonly ILogic logic;

		public Run()
		{
			var textService = A.Fake<ITextService>();
			var consoleService = A.Fake<IConsoleService>();
			var mapper = A.Fake<IMapper>();
			logic = new Logic(textService, consoleService, mapper);

			A.CallTo(() => textService.GetText())
				.Returns(new TextEntity { Text = "TEST" });

			A.CallTo(() => mapper.Map<TextViewModel>(A<TextEntity>._))
				.Returns(new TextViewModel { Text = "TEST" });

			A.CallTo(() => consoleService.Display(
				A<TextViewModel>.That.Not.Matches(vm => vm.Text == "TEST")))
				.Throws<ArgumentException>();
			
		}

		[Fact]
		public void ValidEntity_PassesValidVM()
		{
			logic.Run();
		}
	}
}
