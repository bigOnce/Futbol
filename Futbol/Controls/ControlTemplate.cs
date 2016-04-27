using System;

using Xamarin.Forms;

namespace Futbol
{
	class TealTemplate : Grid
	{
		public TealTemplate ()
		{
			RowDefinitions.Add (new RowDefinition { Height = new GridLength (0.1, GridUnitType.Star) });
			RowDefinitions.Add (new RowDefinition { Height = new GridLength (0.8, GridUnitType.Star) });
			RowDefinitions.Add (new RowDefinition { Height = new GridLength (0.1, GridUnitType.Star) });
			ColumnDefinitions.Add (new ColumnDefinition { Width = new GridLength (0.05, GridUnitType.Star) });
			ColumnDefinitions.Add (new ColumnDefinition { Width = new GridLength (0.95, GridUnitType.Star) });

			var topBoxView = new BoxView { Color = Color.Teal };
			Children.Add (topBoxView, 0, 0);
			Grid.SetColumnSpan (topBoxView, 2);

			var topLabel = new Label {
				TextColor = Color.White,
				VerticalOptions = LayoutOptions.Center
			};
			topLabel.SetBinding (Label.TextProperty, new TemplateBinding ("Parent.HeaderText"));
			Children.Add (topLabel, 1, 0);

			var contentPresenter = new ContentPresenter ();
			Children.Add (contentPresenter, 0, 1);
			Grid.SetColumnSpan (contentPresenter, 2);

			var bottomBoxView = new BoxView { Color = Color.Teal };
			Children.Add (bottomBoxView, 0, 2);
			Grid.SetColumnSpan (bottomBoxView, 2);

			var bottomLabel = new Label {
				TextColor = Color.White,
				VerticalOptions = LayoutOptions.Center
			};
			bottomLabel.SetBinding (Label.TextProperty, new TemplateBinding ("Parent.FooterText"));
			Children.Add (bottomLabel, 1, 2);
		}
	}

	class AquaTemplate : Grid
	{
		public AquaTemplate ()
		{
			RowDefinitions.Add (new RowDefinition { Height = new GridLength (0.1, GridUnitType.Star) });
			RowDefinitions.Add (new RowDefinition { Height = new GridLength (0.8, GridUnitType.Star) });
			RowDefinitions.Add (new RowDefinition { Height = new GridLength (0.1, GridUnitType.Star) });
			ColumnDefinitions.Add (new ColumnDefinition { Width = new GridLength (0.05, GridUnitType.Star) });
			ColumnDefinitions.Add (new ColumnDefinition { Width = new GridLength (0.95, GridUnitType.Star) });

			var topBoxView = new BoxView { Color = Color.Aqua };
			Children.Add (topBoxView, 0, 0);
			Grid.SetColumnSpan (topBoxView, 2);

			var topLabel = new Label {
				TextColor = Color.Blue,
				VerticalOptions = LayoutOptions.Center
			};
			topLabel.SetBinding (Label.TextProperty, new TemplateBinding ("Parent.HeaderText"));
			Children.Add (topLabel, 1, 0);

			var contentPresenter = new ContentPresenter ();
			Children.Add (contentPresenter, 0, 1);
			Grid.SetColumnSpan (contentPresenter, 2);

			var bottomBoxView = new BoxView { Color = Color.Aqua };
			Children.Add (bottomBoxView, 0, 2);
			Grid.SetColumnSpan (bottomBoxView, 2);

			var bottomLabel = new Label {
				TextColor = Color.Blue,
				VerticalOptions = LayoutOptions.Center
			};
			bottomLabel.SetBinding (Label.TextProperty, new TemplateBinding ("Parent.FooterText"));
			Children.Add (bottomLabel, 1, 2);
		}
	}
}

