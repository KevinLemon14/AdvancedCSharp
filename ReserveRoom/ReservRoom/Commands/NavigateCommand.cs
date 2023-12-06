using ReservRoom.Models;
using ReservRoom.Services;
using ReservRoom.Stores;
using ReservRoom.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservRoom.Commands
{
	public class NavigateCommand : CommandBase
	{
		private readonly NavigationService _navigationService;

		public NavigateCommand(NavigationService navigationService)
		{
			_navigationService = navigationService;
		}

		public override void Execute(object? parameter)
		{
			_navigationService.Navigate();
		}
	}
}
