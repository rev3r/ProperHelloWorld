﻿using ConsoleApp.Interfaces;
using ConsoleApp.ViewModels;
using System;

namespace ConsoleApp.Services
{
	public class ConsoleService : IConsoleService
	{
		public void Display(TextViewModel viewModel)
		{
			Console.WriteLine(viewModel.Text);
		}
	}
}