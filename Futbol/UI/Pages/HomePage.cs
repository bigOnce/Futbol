using System;

using Xamarin.Forms;

namespace Futbol
{
	public class HomePage : MasterDetailPage
	{
		public MenuPage menuPage {
			get;
			set;
		} // menu page


		public HomePage ()
		{
			// Menu 
			menuPage = new MenuPage ();
			this.Master = menuPage;
			menuPage.Menu.ItemSelected += (sender, e) => {
				
				NamedColor nColor =  (NamedColor)e.SelectedItem;
				if (nColor == null) return;
				this.Detail.BindingContext = nColor;

				menuPage.Menu.SelectedItem = null;
				// Show the detail page.
				IsPresented = false;

			};

			// Detail View
			this.Detail = navigationPageWith (new GeneralPage());

		}

		public NavigationPage navigationPageWith (Page p) {
			return new NavigationPage (p) {	
				BarTextColor = ColorDefine.ColorApp
			};
		}

		public void NavigateTo (MenuItem menu)
		{
			Page displayPage = (Page) Activator.CreateInstance (menu.TargetType);

			Detail = navigationPageWith (displayPage);

			IsPresented = false;
		}
	}
}


