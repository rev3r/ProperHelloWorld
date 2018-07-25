using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.Interfaces;
using Core.Services;
using FakeItEasy;
using Xunit;

namespace UnitTests.Core.TextServiceTests
{
	public class GetText
	{
		private readonly ITextService service;

		public GetText()
		{
			var textRepository = A.Fake<ITextRepository>();
			var mapper = A.Fake<IMapper>();
			service = new TextService(textRepository, mapper);

			A.CallTo(() => textRepository.GetWelcomeText())
				.Returns(new TextDto { Text = "TEST" });

			A.CallTo(() => mapper.Map<TextEntity>(A<TextDto>._))
				.Returns(new TextEntity { Text = "TEST" });
		}

		[Fact]
		public void Invokation_ReturnsValidDto()
		{
			var result = service.GetText();

			Assert.Equal("TEST", result.Text);
		}
	}
}