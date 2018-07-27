using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using FakeItEasy;
using Infrastructure.Data;
using Infrastructure.TextRepository;
using Xunit;

namespace UnitTests.Infrastructure.TextRepositoryTests
{
	public class GetWelcomeText
	{
		private readonly ITextRepository repository;

		public GetWelcomeText()
		{
			var mapper = A.Fake<IMapper>();
			repository = new TextRepository(mapper);

			A.CallTo(() => mapper.Map<TextEntity>(A<TextData>._))
				.Returns(new TextEntity("TEST"));
		}

		[Fact]
		public void ValidData_ReturnsValidEntity()
		{
			var result = repository.GetWelcomeText();

			Assert.Equal("TEST", result.Text);
		}
	}
}