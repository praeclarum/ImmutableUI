public partial class View
{
	public Xamarin.Forms.LayoutOptions HorizontalOptions { get; }
	public Xamarin.Forms.LayoutOptions VerticalOptions { get; }
	public Xamarin.Forms.Thickness Margin { get; }
	public View(Xamarin.Forms.LayoutOptions horizontalOptions, Xamarin.Forms.LayoutOptions verticalOptions, Xamarin.Forms.Thickness margin) {
	}
}

public partial class Button : View
{
	public string Text { get; }
	public Button(string text, Xamarin.Forms.LayoutOptions horizontalOptions, Xamarin.Forms.LayoutOptions verticalOptions, Xamarin.Forms.Thickness margin)
		: base(horizontalOptions, verticalOptions, margin) {
	}
}

public partial class ContentView : View
{
	public Xamarin.Forms.View Content { get; }
	public ContentView(Xamarin.Forms.View content, Xamarin.Forms.LayoutOptions horizontalOptions, Xamarin.Forms.LayoutOptions verticalOptions, Xamarin.Forms.Thickness margin)
		: base(horizontalOptions, verticalOptions, margin) {
	}
}
