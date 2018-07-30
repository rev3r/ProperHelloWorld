using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using FakeItEasy;
using Infrastructure.Data;
using Infrastructure.TextRepository;
using Xunit;

namespace IntegrationTests
{
	public class GetWelcomeText
	{
		private readonly ITextRepository repository;

		public GetWelcomeText()
		{
			var mapper = A.Fake<IMapper>();
			repository = new TextRepository(mapper);

			A.CallTo(() => mapper.Map<TextEntity>(A<TextData>.That.Matches(td => td.Text == "Hello World!")))
				.Returns(new TextEntity("Hello World!"));
		}

		[Fact]
		public void Invokation_RetrieveValidWelcomeText()
		{
			var result = repository.GetWelcomeText();

			Assert.Equal("Hello World!", result.Text);
		}
	}
}