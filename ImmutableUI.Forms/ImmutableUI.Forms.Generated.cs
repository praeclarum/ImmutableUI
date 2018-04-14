public partial class ElementModel
{
	public ElementModel() {
	}
	public virtual Xamarin.Forms.Element CreateElement() => throw new System.NotSupportedException("Cannot create Xamarin.Forms.Element from " + GetType().FullName);
	public virtual void Apply(Xamarin.Forms.Element target) {
	}
}

public partial class VisualElementModel : ElementModel
{
	public Xamarin.Forms.Color BackgroundColor { get; }
	public bool IsEnabled { get; }
	public VisualElementModel(Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isEnabled = true)
		: base() {
		BackgroundColor = backgroundColor == default(Xamarin.Forms.Color) ? Xamarin.Forms.Color.Default : backgroundColor;
		IsEnabled = isEnabled;
	}
	public VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new VisualElementModel(backgroundColor, IsEnabled);
	public VisualElementModel WithIsEnabled(bool isEnabled) => new VisualElementModel(BackgroundColor, isEnabled);
	public virtual Xamarin.Forms.VisualElement CreateVisualElement() => throw new System.NotSupportedException("Cannot create Xamarin.Forms.VisualElement from " + GetType().FullName);
	public virtual void Apply(Xamarin.Forms.VisualElement target) {
		base.Apply(target);
		target.BackgroundColor = BackgroundColor;
		target.IsEnabled = IsEnabled;
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.VisualElement t) Apply(t);
		else base.Apply(target);
	}
}

public partial class LayoutOptionsModel
{
	public Xamarin.Forms.LayoutAlignment Alignment { get; }
	public bool Expands { get; }
	public LayoutOptionsModel(Xamarin.Forms.LayoutAlignment alignment = Xamarin.Forms.LayoutAlignment.Fill, bool expands = false) {
		Alignment = alignment;
		Expands = expands;
	}
	public LayoutOptionsModel WithAlignment(Xamarin.Forms.LayoutAlignment alignment) => new LayoutOptionsModel(alignment, Expands);
	public LayoutOptionsModel WithExpands(bool expands) => new LayoutOptionsModel(Alignment, expands);
	public virtual Xamarin.Forms.LayoutOptions CreateLayoutOptions() => throw new System.NotSupportedException("Cannot create Xamarin.Forms.LayoutOptions from " + GetType().FullName);
	public virtual void Apply(ref Xamarin.Forms.LayoutOptions target) {
		target.Alignment = Alignment;
		target.Expands = Expands;
	}
}

public partial class ViewModel : VisualElementModel
{
	public LayoutOptionsModel HorizontalOptions { get; }
	public LayoutOptionsModel VerticalOptions { get; }
	public Xamarin.Forms.Thickness Margin { get; }
	public ViewModel(LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isEnabled = true)
		: base(backgroundColor, isEnabled) {
		HorizontalOptions = horizontalOptions;
		VerticalOptions = verticalOptions;
		Margin = margin;
	}
	public ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new ViewModel(horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsEnabled);
	public ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new ViewModel(HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsEnabled);
	public ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new ViewModel(HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsEnabled);
	public new ViewModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ViewModel(HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsEnabled);
	public new ViewModel WithIsEnabled(bool isEnabled) => new ViewModel(HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isEnabled);
	public virtual Xamarin.Forms.View CreateView() => throw new System.NotSupportedException("Cannot create Xamarin.Forms.View from " + GetType().FullName);
	public virtual void Apply(Xamarin.Forms.View target) {
		base.Apply(target);
		target.HorizontalOptions = HorizontalOptions.CreateLayoutOptions();
		target.VerticalOptions = VerticalOptions.CreateLayoutOptions();
		target.Margin = Margin;
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.View t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.View t) Apply(t);
		else base.Apply(target);
	}
}

public partial class ButtonModel : ViewModel
{
	public string Text { get; }
	public ButtonModel(string text = "", LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isEnabled = true)
		: base(horizontalOptions, verticalOptions, margin) {
		Text = text;
	}
	public ButtonModel WithText(string text) => new ButtonModel(text, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsEnabled);
	public new ButtonModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new ButtonModel(Text, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsEnabled);
	public new ButtonModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new ButtonModel(Text, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsEnabled);
	public new ButtonModel WithMargin(Xamarin.Forms.Thickness margin) => new ButtonModel(Text, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsEnabled);
	public new ButtonModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ButtonModel(Text, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsEnabled);
	public new ButtonModel WithIsEnabled(bool isEnabled) => new ButtonModel(Text, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isEnabled);
	public virtual Xamarin.Forms.Button CreateButton() {
		var target = new Xamarin.Forms.Button();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.View CreateView() => CreateButton();
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreateButton();
	public override Xamarin.Forms.Element CreateElement() => CreateButton();
	public virtual void Apply(Xamarin.Forms.Button target) {
		base.Apply(target);
		target.Text = Text;
	}
	public override void Apply(Xamarin.Forms.View target) {
		if (target is Xamarin.Forms.Button t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.Button t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.Button t) Apply(t);
		else base.Apply(target);
	}
}

public partial class ContentViewModel : ViewModel
{
	public ViewModel Content { get; }
	public ContentViewModel(ViewModel content = null, LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isEnabled = true)
		: base(horizontalOptions, verticalOptions, margin) {
		Content = content;
	}
	public ContentViewModel WithContent(ViewModel content) => new ContentViewModel(content, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsEnabled);
	public new ContentViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new ContentViewModel(Content, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsEnabled);
	public new ContentViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new ContentViewModel(Content, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsEnabled);
	public new ContentViewModel WithMargin(Xamarin.Forms.Thickness margin) => new ContentViewModel(Content, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsEnabled);
	public new ContentViewModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ContentViewModel(Content, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsEnabled);
	public new ContentViewModel WithIsEnabled(bool isEnabled) => new ContentViewModel(Content, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isEnabled);
	public virtual Xamarin.Forms.ContentView CreateContentView() {
		var target = new Xamarin.Forms.ContentView();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.View CreateView() => CreateContentView();
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreateContentView();
	public override Xamarin.Forms.Element CreateElement() => CreateContentView();
	public virtual void Apply(Xamarin.Forms.ContentView target) {
		base.Apply(target);
		if (target.Content != null) Content.Apply(target.Content);
		else target.Content = Content.CreateView();
	}
	public override void Apply(Xamarin.Forms.View target) {
		if (target is Xamarin.Forms.ContentView t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.ContentView t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.ContentView t) Apply(t);
		else base.Apply(target);
	}
}

public partial class PageModel : VisualElementModel
{
	public string Title { get; }
	public Xamarin.Forms.Thickness Padding { get; }
	public PageModel(string title = "", Xamarin.Forms.Thickness padding = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isEnabled = true)
		: base(backgroundColor, isEnabled) {
		Title = title;
		Padding = padding;
	}
	public PageModel WithTitle(string title) => new PageModel(title, Padding, BackgroundColor, IsEnabled);
	public PageModel WithPadding(Xamarin.Forms.Thickness padding) => new PageModel(Title, padding, BackgroundColor, IsEnabled);
	public new PageModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new PageModel(Title, Padding, backgroundColor, IsEnabled);
	public new PageModel WithIsEnabled(bool isEnabled) => new PageModel(Title, Padding, BackgroundColor, isEnabled);
	public virtual Xamarin.Forms.Page CreatePage() {
		var target = new Xamarin.Forms.Page();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreatePage();
	public override Xamarin.Forms.Element CreateElement() => CreatePage();
	public virtual void Apply(Xamarin.Forms.Page target) {
		base.Apply(target);
		target.Title = Title;
		target.Padding = Padding;
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.Page t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.Page t) Apply(t);
		else base.Apply(target);
	}
}

public partial class ContentPageModel : PageModel
{
	public ViewModel Content { get; }
	public ContentPageModel(ViewModel content = null, string title = "", Xamarin.Forms.Thickness padding = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isEnabled = true)
		: base(title, padding) {
		Content = content;
	}
	public ContentPageModel WithContent(ViewModel content) => new ContentPageModel(content, Title, Padding, BackgroundColor, IsEnabled);
	public new ContentPageModel WithTitle(string title) => new ContentPageModel(Content, title, Padding, BackgroundColor, IsEnabled);
	public new ContentPageModel WithPadding(Xamarin.Forms.Thickness padding) => new ContentPageModel(Content, Title, padding, BackgroundColor, IsEnabled);
	public new ContentPageModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ContentPageModel(Content, Title, Padding, backgroundColor, IsEnabled);
	public new ContentPageModel WithIsEnabled(bool isEnabled) => new ContentPageModel(Content, Title, Padding, BackgroundColor, isEnabled);
	public virtual Xamarin.Forms.ContentPage CreateContentPage() {
		var target = new Xamarin.Forms.ContentPage();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.Page CreatePage() => CreateContentPage();
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreateContentPage();
	public override Xamarin.Forms.Element CreateElement() => CreateContentPage();
	public virtual void Apply(Xamarin.Forms.ContentPage target) {
		base.Apply(target);
		if (target.Content != null) Content.Apply(target.Content);
		else target.Content = Content.CreateView();
	}
	public override void Apply(Xamarin.Forms.Page target) {
		if (target is Xamarin.Forms.ContentPage t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.ContentPage t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.ContentPage t) Apply(t);
		else base.Apply(target);
	}
}

public partial class CellModel : ElementModel
{
	public double Height { get; }
	public bool IsEnabled { get; }
	public CellModel(double height = -1, bool isEnabled = true)
		: base() {
		Height = height;
		IsEnabled = isEnabled;
	}
	public CellModel WithHeight(double height) => new CellModel(height, IsEnabled);
	public CellModel WithIsEnabled(bool isEnabled) => new CellModel(Height, isEnabled);
	public virtual Xamarin.Forms.Cell CreateCell() => throw new System.NotSupportedException("Cannot create Xamarin.Forms.Cell from " + GetType().FullName);
	public virtual void Apply(Xamarin.Forms.Cell target) {
		base.Apply(target);
		target.Height = Height;
		target.IsEnabled = IsEnabled;
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.Cell t) Apply(t);
		else base.Apply(target);
	}
}

public partial class ViewCellModel : CellModel
{
	public ViewModel View { get; }
	public ViewCellModel(ViewModel view = null, double height = -1, bool isEnabled = true)
		: base(height, isEnabled) {
		View = view;
	}
	public ViewCellModel WithView(ViewModel view) => new ViewCellModel(view, Height, IsEnabled);
	public new ViewCellModel WithHeight(double height) => new ViewCellModel(View, height, IsEnabled);
	public new ViewCellModel WithIsEnabled(bool isEnabled) => new ViewCellModel(View, Height, isEnabled);
	public virtual Xamarin.Forms.ViewCell CreateViewCell() {
		var target = new Xamarin.Forms.ViewCell();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.Cell CreateCell() => CreateViewCell();
	public override Xamarin.Forms.Element CreateElement() => CreateViewCell();
	public virtual void Apply(Xamarin.Forms.ViewCell target) {
		base.Apply(target);
		if (target.View != null) View.Apply(target.View);
		else target.View = View.CreateView();
	}
	public override void Apply(Xamarin.Forms.Cell target) {
		if (target is Xamarin.Forms.ViewCell t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.ViewCell t) Apply(t);
		else base.Apply(target);
	}
}
