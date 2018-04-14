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
	public virtual VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new VisualElementModel(backgroundColor, IsEnabled);
	public virtual VisualElementModel WithIsEnabled(bool isEnabled) => new VisualElementModel(BackgroundColor, isEnabled);
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
	public virtual LayoutOptionsModel WithAlignment(Xamarin.Forms.LayoutAlignment alignment) => new LayoutOptionsModel(alignment, Expands);
	public virtual LayoutOptionsModel WithExpands(bool expands) => new LayoutOptionsModel(Alignment, expands);
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
	public virtual ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new ViewModel(horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsEnabled);
	public virtual ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new ViewModel(HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsEnabled);
	public virtual ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new ViewModel(HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ViewModel(HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new ViewModel(HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isEnabled);
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
	public virtual ButtonModel WithText(string text) => new ButtonModel(text, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new ButtonModel(Text, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new ButtonModel(Text, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new ButtonModel(Text, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ButtonModel(Text, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new ButtonModel(Text, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isEnabled);
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
	public virtual ContentViewModel WithContent(ViewModel content) => new ContentViewModel(content, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new ContentViewModel(Content, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new ContentViewModel(Content, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new ContentViewModel(Content, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ContentViewModel(Content, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new ContentViewModel(Content, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isEnabled);
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
	public virtual PageModel WithTitle(string title) => new PageModel(title, Padding, BackgroundColor, IsEnabled);
	public virtual PageModel WithPadding(Xamarin.Forms.Thickness padding) => new PageModel(Title, padding, BackgroundColor, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new PageModel(Title, Padding, backgroundColor, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new PageModel(Title, Padding, BackgroundColor, isEnabled);
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
	public virtual ContentPageModel WithContent(ViewModel content) => new ContentPageModel(content, Title, Padding, BackgroundColor, IsEnabled);
	public override PageModel WithTitle(string title) => new ContentPageModel(Content, title, Padding, BackgroundColor, IsEnabled);
	public override PageModel WithPadding(Xamarin.Forms.Thickness padding) => new ContentPageModel(Content, Title, padding, BackgroundColor, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ContentPageModel(Content, Title, Padding, backgroundColor, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new ContentPageModel(Content, Title, Padding, BackgroundColor, isEnabled);
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
	public virtual CellModel WithHeight(double height) => new CellModel(height, IsEnabled);
	public virtual CellModel WithIsEnabled(bool isEnabled) => new CellModel(Height, isEnabled);
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
	public virtual ViewCellModel WithView(ViewModel view) => new ViewCellModel(view, Height, IsEnabled);
	public override CellModel WithHeight(double height) => new ViewCellModel(View, height, IsEnabled);
	public override CellModel WithIsEnabled(bool isEnabled) => new ViewCellModel(View, Height, isEnabled);
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
