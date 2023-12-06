using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;

namespace AvaloniaGetStarted.Views
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		public void TextBox_TextChanged(object source,  TextChangedEventArgs e)
		{
			if (double.TryParse(celsius.Text, out double C))
			{
				var F = C * (9d / 5d) + 32;
				fahrenheit.Text = F.ToString("0.0");
			}
			else
			{
				celsius.Text = "0";
				fahrenheit.Text = "0";
			}
		}

		public void ButtonClicked(object source, RoutedEventArgs args)
		{
			if (double.TryParse(celsius.Text, out double C)) 
			{
				var F = C * (9d / 5d) + 32;
				fahrenheit.Text = F.ToString("0.0");
			}
			else
			{
				celsius.Text = "0";
				fahrenheit.Text = "0";
			}
		}
	}
}