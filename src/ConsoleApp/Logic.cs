using AutoMapper;
using ConsoleApp.Interfaces;
using ConsoleApp.ViewModels;
using Core.Interfaces;

namespace ConsoleApp
{
	public class Logic : ILogic
	{
		private readonly ITextService textService;
		private readonly IMapper mapper;
		private readonly IConsoleService consoleService;

		public Logic(
			ITextService textService,
			IMapper mapper,
			IConsoleService consoleService)
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