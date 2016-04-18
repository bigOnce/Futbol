using System;

using Xamarin.Forms;

namespace Futbol
{
	public class TestPage : NavigationPage
	{
		public TestPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


