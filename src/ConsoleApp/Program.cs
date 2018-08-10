using AutoMapper;
using ConsoleApp.Interfaces;
using ConsoleApp.Services;
using Core.Interfaces;
using Core.Services;
using Infrastructure.TextRepository;
using Unity;

namespace ConsoleApp
{
	public class Program
	{
		private static readonly UnityContainer container = new UnityContainer();

		public static void Main()
		{
			ConfigureDependecies();

			CreateLogic().Run();
		}

		private static void ConfigureDependecies()
		{
			container.RegisterType<ILogic, Logic>();
			container.RegisterType<IConsoleService, ConsoleService>();
			container.RegisterType<ITextService, TextService>();
			container.RegisterType<ITextRepository, TextRepository>();

			var config = new MapperConfiguration(_ => { });
			container.RegisterInstance(config.CreateMapper());
		}

		private static ILogic CreateLogic()
		{
			return container.Resolve<ILogic>();
		}
	}
}