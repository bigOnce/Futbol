using System;

using Xamarin.Forms;

namespace Futbol
{
	public class HomePage : MasterDetailPage
	{
		public HomePage ()
		{

			this.Master = new MenuPage ();
			this.Detail = new KienPage ();

		}
	}
}


