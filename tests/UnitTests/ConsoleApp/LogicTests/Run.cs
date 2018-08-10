using System;
using AutoMapper;
using ConsoleApp;
using ConsoleApp.Interfaces;
using ConsoleApp.ViewModels;
using Core.Entities;
using Core.Interfaces;
using FakeItEasy;
using Xunit;

namespace UnitTests.ConsoleApp.LogicTests
{
	public class Run
	{
		private readonly ILogic logic;

		public Run()
		{
			var consoleService = A.Fake<IConsoleService>();
			var textService = A.Fake<ITextService>();
			var mapper = A.Fake<IMapper>();
			logic = new Logic(consoleService, textService, mapper);

			A.CallTo(() => textService.GetText())
				.Returns(new TextEntity("TEST"));

			A.CallTo(() => mapper.Map<TextViewModel>(A<TextEntity>._))
				.Returns(new TextViewModel("TEST"));

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