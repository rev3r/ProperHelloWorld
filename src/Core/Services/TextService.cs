using Core.Entities;
using Core.Interfaces;

namespace Core.Services
{
	public class TextService : ITextService
	{
		private readonly ITextRepository repository;

		public TextService(ITextRepository repository)
		{
			this.repository = repository;
		}

		public TextEntity GetText()
		{
			return repository.GetWelcomeText();
		}
	}
}