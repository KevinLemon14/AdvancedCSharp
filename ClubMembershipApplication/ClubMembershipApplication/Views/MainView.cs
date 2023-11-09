using ClubMembershipApplication.FieldValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication.Views
{
	internal class MainView : IView
	{
		public IFieldValidator FieldValidator => null;

		IView _registerView = null;
		IView _loginView = null;

		public MainView(IView registerView, IView loginView) 
		{
			_registerView = registerView;
			_loginView = loginView;
		}

		public void RunView()
		{
			CommonOutputText.WriteMainHeading();

			Console.WriteLine("Please press 'L' to login, or press 'R' to register");

			ConsoleKey key = Console.ReadKey().Key;

			if (key == ConsoleKey.L)
			{
				RunUserLoginView();
			}
			else if (key == ConsoleKey.R)
			{
				RunUserRegistrationView();
				RunUserLoginView();
			}
			else
			{
				Console.Clear();
				Console.WriteLine("Goodbye");
				Console.ReadKey();
			}
		}

		private void RunUserRegistrationView()
		{
			_registerView.RunView();
		}

		private void RunUserLoginView()
		{
			_loginView.RunView();
		}
	}
}
