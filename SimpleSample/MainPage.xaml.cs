namespace SimpleSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void tabScroll_Scrolled(object sender, ScrolledEventArgs e)
	{
		if (hstack.Children.Count < 10)
		{
			hstack.Children.Add(new Grid
			{
				HeightRequest = 48,
				WidthRequest = 200,
				BackgroundColor = Colors.Red,
				Margin = new Thickness(2, 0),
				Children =
				{
					new Label
					{
						Text = "text 9",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center,
						TextColor = Colors.White
					}
				}
			});
		}
    }
}

