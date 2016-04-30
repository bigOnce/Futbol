using System;

using Xamarin.Forms;

namespace Futbol
{
	public class UIHelper
	{

		public static Font CaptionFont = Device.OnPlatform(
			iOS:      Font.OfSize ("MarkerFelt-Thin", NamedSize.Medium),
			Android:  Font.OfSize ("Droid Sans Mono", NamedSize.Medium),
			WinPhone: Font.OfSize ("Comic Sans MS", NamedSize.Medium)
		);

		public static readonly Color ColorPrimary = Color.FromHex ("#4f62d8"); 
		public static readonly Color BarBackgroundColor = Color.FromHex("#15304E");
		public static readonly Color BackgroundColor = Color.FromHex("#3B99D4");
		public static readonly Color ForegroundColor = Color.White;
		public static readonly Color ForegroundColor2 = Color.FromHex("#A956A0");
		public static readonly Color TintColor = Color.FromHex("#7EC368");
		public static readonly Color TintColor2 = Color.FromHex("#A956A0");
	}
}

