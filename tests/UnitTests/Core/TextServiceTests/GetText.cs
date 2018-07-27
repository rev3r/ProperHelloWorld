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
			var repository = A.Fake<ITextRepository>();
			service = new TextService(repository);

			A.CallTo(() => repository.GetWelcomeText())
				.Returns(new TextEntity("TEST"));
		}

		[Fact]
		public void Invokation_ReturnsValidEntity()
		{
			var result = service.GetText();

			Assert.Equal("TEST", result.Text);
		}
	}
}