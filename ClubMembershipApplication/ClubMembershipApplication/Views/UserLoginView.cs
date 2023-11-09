using ClubMembershipApplication.Data;
using ClubMembershipApplication.FieldValidators;
using ClubMembershipApplication.Models;

namespace ClubMembershipApplication.Views
{
	public class UserLoginView : IView
	{
		ILogin _loginUser = null;
		public IFieldValidator FieldValidator => null;

		public UserLoginView(ILogin login) 
		{
			_loginUser = login;
		}

		public void RunView()
		{
			CommonOutputText.WriteMainHeading();

			CommonOutputText.WriteLoginHeading();

			Console.Write("Please enter your email address: ");

			string emailAddress = Console.ReadLine();

			Console.Write("Please enter your password: ");

			string password = Console.ReadLine();

			User user = _loginUser.Login(emailAddress, password);

			if (user != null)
			{
				WelcomeUserView welcomeUserView = new WelcomeUserView(user);
				welcomeUserView.RunView();
			}
			else
			{
				Console.Clear();
				CommonOutputFormat.ChangeFontColor(FontTheme.Danger);
				Console.WriteLine("The credentials you entered do not match our records");
				CommonOutputFormat.ChangeFontColor(FontTheme.Default);
				Console.ReadKey();
			}
		}
	}
}
