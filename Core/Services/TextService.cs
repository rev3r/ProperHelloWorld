using AutoMapper;
using Core.Entities;
using Core.Interfaces;

namespace Core.Services
{
    public class TextService : ITextService
    {
		private readonly ITextRepository repository;
		private readonly IMapper mapper;

		public TextService(
			ITextRepository repository,
			IMapper mapper)
		{
			this.repository = repository;
			this.mapper = mapper;
		}

		public TextEntity GetText()
		{
			var dto = repository.GetWelcomeText();

			return mapper.Map<TextEntity>(dto);
		}
    }
}
