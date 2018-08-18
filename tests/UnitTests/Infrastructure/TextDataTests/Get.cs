using Infrastructure.Data;
using Xunit;

namespace UnitTests.Infrastructure.TextDataTests
{
	public class Get
	{
		private readonly TextData data;

		public Get()
		{
			data = new TextData();
		}

		[Fact]
		public void GetValue_ReturnsText()
		{
			Assert.Equal("Hello World!", data.Text);
		}
	}
}