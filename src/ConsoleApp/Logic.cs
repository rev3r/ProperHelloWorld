using AutoMapper;
using ConsoleApp.Interfaces;
using ConsoleApp.ViewModels;
using Core.Interfaces;

namespace ConsoleApp
{
	public class Logic : ILogic
	{
		private readonly IConsoleService consoleService;
		private readonly IMapper mapper;
		private readonly ITextService textService;

		public Logic(
			IConsoleService consoleService,
			ITextService textService,
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