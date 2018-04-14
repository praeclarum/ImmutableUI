public partial class LayoutOptionsModel
{
	public Xamarin.Forms.LayoutAlignment Alignment { get; }
	public System.Boolean Expands { get; }
	public LayoutOptionsModel(Xamarin.Forms.LayoutAlignment alignment = Xamarin.Forms.LayoutAlignment.Fill, System.Boolean expands = false) {
		Alignment = alignment;
		Expands = expands;
	}
	public LayoutOptionsModel WithAlignment(Xamarin.Forms.LayoutAlignment alignment) => new LayoutOptionsModel(alignment, Expands);
	public LayoutOptionsModel WithExpands(System.Boolean expands) => new LayoutOptionsModel(Alignment, expands);
}

public partial class ElementModel
{
	public ElementModel() {
	}
}

public partial class VisualElementModel : ElementModel
{
	public Xamarin.Forms.Color BackgroundColor { get; }
	public System.Boolean IsEnabled { get; }
	public VisualElementModel(Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), System.Boolean isEnabled = true)
		: base() {
		BackgroundColor = backgroundColor == default(Xamarin.Forms.Color) ? Xamarin.Forms.Color.Default : backgroundColor;
		IsEnabled = isEnabled;
	}
	public VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new VisualElementModel(backgroundColor, IsEnabled);
	public VisualElementModel WithIsEnabled(System.Boolean isEnabled) => new VisualElementModel(BackgroundColor, isEnabled);
}

public partial class ViewModel : VisualElementModel
{
	public LayoutOptionsModel HorizontalOptions { get; }
	public LayoutOptionsModel VerticalOptions { get; }
	public Xamarin.Forms.Thickness Margin { get; }
	public ViewModel(LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), System.Boolean isEnabled = true)
		: base(backgroundColor, isEnabled) {
		HorizontalOptions = horizontalOptions;
		VerticalOptions = verticalOptions;
		Margin = margin;
	}
	public ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new ViewModel(horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsEnabled);
	public ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new ViewModel(HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsEnabled);
	public ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new ViewModel(HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsEnabled);
	public new ViewModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ViewModel(HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsEnabled);
	public new ViewModel WithIsEnabled(System.Boolean isEnabled) => new ViewModel(HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isEnabled);
}

public partial class ButtonModel : ViewModel
{
	public string Text { get; }
	public ButtonModel(string text = "", LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), System.Boolean isEnabled = true)
		: base(horizontalOptions, verticalOptions, margin) {
		Text = text;
	}
	public ButtonModel WithText(string text) => new ButtonModel(text, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsEnabled);
	public new ButtonModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new ButtonModel(Text, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsEnabled);
	public new ButtonModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new ButtonModel(Text, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsEnabled);
	public new ButtonModel WithMargin(Xamarin.Forms.Thickness margin) => new ButtonModel(Text, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsEnabled);
	public new ButtonModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ButtonModel(Text, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsEnabled);
	public new ButtonModel WithIsEnabled(System.Boolean isEnabled) => new ButtonModel(Text, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isEnabled);
}

public partial class ContentViewModel : ViewModel
{
	public ViewModel Content { get; }
	public ContentViewModel(ViewModel content = null, LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), System.Boolean isEnabled = true)
		: base(horizontalOptions, verticalOptions, margin) {
		Content = content;
	}
	public ContentViewModel WithContent(ViewModel content) => new ContentViewModel(content, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsEnabled);
	public new ContentViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new ContentViewModel(Content, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsEnabled);
	public new ContentViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new ContentViewModel(Content, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsEnabled);
	public new ContentViewModel WithMargin(Xamarin.Forms.Thickness margin) => new ContentViewModel(Content, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsEnabled);
	public new ContentViewModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ContentViewModel(Content, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsEnabled);
	public new ContentViewModel WithIsEnabled(System.Boolean isEnabled) => new ContentViewModel(Content, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isEnabled);
}

public partial class PageModel : VisualElementModel
{
	public string Title { get; }
	public Xamarin.Forms.Thickness Padding { get; }
	public PageModel(string title = "", Xamarin.Forms.Thickness padding = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), System.Boolean isEnabled = true)
		: base(backgroundColor, isEnabled) {
		Title = title;
		Padding = padding;
	}
	public PageModel WithTitle(string title) => new PageModel(title, Padding, BackgroundColor, IsEnabled);
	public PageModel WithPadding(Xamarin.Forms.Thickness padding) => new PageModel(Title, padding, BackgroundColor, IsEnabled);
	public new PageModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new PageModel(Title, Padding, backgroundColor, IsEnabled);
	public new PageModel WithIsEnabled(System.Boolean isEnabled) => new PageModel(Title, Padding, BackgroundColor, isEnabled);
}

public partial class ContentPageModel : PageModel
{
	public ViewModel Content { get; }
	public ContentPageModel(ViewModel content = null, string title = "", Xamarin.Forms.Thickness padding = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), System.Boolean isEnabled = true)
		: base(title, padding) {
		Content = content;
	}
	public ContentPageModel WithContent(ViewModel content) => new ContentPageModel(content, Title, Padding, BackgroundColor, IsEnabled);
	public new ContentPageModel WithTitle(string title) => new ContentPageModel(Content, title, Padding, BackgroundColor, IsEnabled);
	public new ContentPageModel WithPadding(Xamarin.Forms.Thickness padding) => new ContentPageModel(Content, Title, padding, BackgroundColor, IsEnabled);
	public new ContentPageModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ContentPageModel(Content, Title, Padding, backgroundColor, IsEnabled);
	public new ContentPageModel WithIsEnabled(System.Boolean isEnabled) => new ContentPageModel(Content, Title, Padding, BackgroundColor, isEnabled);
}

public partial class CellModel : ElementModel
{
	public System.Double Height { get; }
	public System.Boolean IsEnabled { get; }
	public CellModel(System.Double height = -1, System.Boolean isEnabled = true)
		: base() {
		Height = height;
		IsEnabled = isEnabled;
	}
	public CellModel WithHeight(System.Double height) => new CellModel(height, IsEnabled);
	public CellModel WithIsEnabled(System.Boolean isEnabled) => new CellModel(Height, isEnabled);
}

public partial class ViewCellModel : CellModel
{
	public ViewModel View { get; }
	public ViewCellModel(ViewModel view = null, System.Double height = -1, System.Boolean isEnabled = true)
		: base(height, isEnabled) {
		View = view;
	}
	public ViewCellModel WithView(ViewModel view) => new ViewCellModel(view, Height, IsEnabled);
	public new ViewCellModel WithHeight(System.Double height) => new ViewCellModel(View, height, IsEnabled);
	public new ViewCellModel WithIsEnabled(System.Boolean isEnabled) => new ViewCellModel(View, Height, isEnabled);
}
