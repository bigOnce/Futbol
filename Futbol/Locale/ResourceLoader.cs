using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;

using Xamarin.Forms;

namespace ACE
{
	public class ResourceLoader
	{
		
		public static void SetLocale () {
			
			DependencyService.Get<ILocale>().SetLocale();

		} // SetLocale

		public static String Locale () {
			
			return DependencyService.Get<ILocale>().GetCurrent();

		} // GetCurrent

		public static String LocalizeString (string key, string comment) {

			var netLanguage = Locale();
			// Platform-specific
			ResourceManager temp = new ResourceManager("Futbol.Resources.LocalizableString", typeof(ResourceLoader).GetTypeInfo().Assembly);
			Debug.WriteLine("Localize " + key);
			string result = temp.GetString(key, new CultureInfo(netLanguage));

			return result;

		} // LocalizeString

	}// Class LocalizedString

} // namespace

