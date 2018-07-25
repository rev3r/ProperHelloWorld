using Core.DTOs;
using Core.Interfaces;

namespace Infrastructure.TextRepository
{
	public class TextRepository : ITextRepository
    {
		public TextDto GetWelcomeText()
		{
			return new TextDto
			{
				Text = "Hello World!"
			};
		}
    }
}