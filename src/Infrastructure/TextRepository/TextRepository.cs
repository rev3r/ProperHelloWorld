using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.TextRepository
{
	public class TextRepository : ITextRepository
	{
		private readonly IMapper mapper;

		public TextRepository(IMapper mapper)
		{
			this.mapper = mapper;
		}

		public TextEntity GetWelcomeText()
		{
			var result = new TextData();

			return mapper.Map<TextEntity>(result);
		}
	}
}