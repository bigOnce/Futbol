using System;

using Xamarin.Forms;

namespace Futbol
{
	public class TemplatePage : ContentPage
	{
		bool originalTemplate = true;
		ControlTemplate tealTemplate = new ControlTemplate (typeof(TealTemplate));
		ControlTemplate aquaTemplate = new ControlTemplate (typeof(AquaTemplate));

		public static readonly BindableProperty HeaderTextProperty = BindableProperty.Create ("HeaderText", typeof(string), typeof(TemplatePage), "Control Template Demo App");
		public static readonly BindableProperty FooterTextProperty = BindableProperty.Create ("FooterText", typeof(string), typeof(TemplatePage), "(c) Xamarin 2016");

		public string HeaderText {
			get { return (string)GetValue (HeaderTextProperty); }
		}

		public string FooterText {
			get { return (string)GetValue (FooterTextProperty); }
		}

		public TemplatePage ()
		{

			var button = new Button { Text = "Change Theme" };
			var contentView = new ContentView {
				Padding = new Thickness (0, 20, 0, 0),
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.CenterAndExpand,
					Children = {
						new Label { Text = "Welcome to the app!", HorizontalOptions = LayoutOptions.Center },
						button
					}
				},
				ControlTemplate = tealTemplate
			};

			button.Clicked += (sender, e) => {
				originalTemplate = !originalTemplate;
				contentView.ControlTemplate = (originalTemplate) ? tealTemplate : aquaTemplate;
			};

			Content = contentView;

		}

	}
}


