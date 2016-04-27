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

			// Detail View
			this.Detail = navigationPageWith (new GeneralPage());
		
		}

		public NavigationPage navigationPageWith (Page p) {
			return new NavigationPage (p) {	
				BarTextColor = ColorDefine.ColorApp
			};
		}
			
	}
}


