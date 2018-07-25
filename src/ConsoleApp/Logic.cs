using AutoMapper;
using ConsoleApp.Interfaces;
using ConsoleApp.ViewModels;
using Core.Interfaces;

namespace ConsoleApp
{
	public class Logic : ILogic
	{
		private readonly ITextService textService;
		private readonly IConsoleService consoleService;
		private readonly IMapper mapper;

		public Logic(
			ITextService textService,
			IConsoleService consoleService,
			IMapper mapper)
		{
			this.consoleService = consoleService;
			this.mapper = mapper;
			this.textService = textService;
		}

		public void Run()
		{
			var entity = textService.GetText();

			var viewModel = mapper.Map<TextViewModel>(entity);
			consoleService.Display(viewModel);
		}
	}
}