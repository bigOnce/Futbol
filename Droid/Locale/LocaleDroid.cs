using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms;
using System.Threading;

[assembly : Dependency (typeof (ACE.Droid.LocaleDroid))]

namespace ACE.Droid
{
	public class LocaleDroid : ILocale 
	{

		public void SetLocale () {

			var androidLocale = Java.Util.Locale.Default; // user's preferred locale
			var netLocale = androidLocale.ToString().Replace("_", "-");
			var ci = new System.Globalization.CultureInfo(netLocale);
			Thread.CurrentThread.CurrentCulture = ci;
			Thread.CurrentThread.CurrentUICulture = ci;

		} // Set CurrentCulture


		public string GetCurrent() {

			var androidLocale = Java.Util.Locale.Default; // user's preferred locale

			// en, es, ja
//			var netLanguage = androidLocale.Language.Replace("_", "-");
			// en-US, es-ES, ja-JP
			var netLocale = androidLocale.ToString().Replace("_", "-");

			#region Debugging output
	
			var ci = new System.Globalization.CultureInfo(netLocale);
			Thread.CurrentThread.CurrentCulture = ci;
			Thread.CurrentThread.CurrentUICulture = ci;

			#endregion

			return netLocale;

		}  // Get CurrentCulture

	} // Class LocaleDroid

} // namespace

