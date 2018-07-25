using Core.Interfaces;
using Infrastructure.TextRepository;
using Xunit;

namespace UnitTests.Infrastructure.TextRepositoryTests
{
    public class GetWelcomeText
    {
		private readonly ITextRepository repository;

		public GetWelcomeText()
		{
			repository = new TextRepository();
		}

		[Fact]
		public void Invokation_ReturnsHelloWorldDto()
		{
			var result = repository.GetWelcomeText();

			Assert.Equal("Hello World!", result.Text);
		}
	}
}
