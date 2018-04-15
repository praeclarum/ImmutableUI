public partial class ElementModel
{
	public ElementModel() {
	}
	public override bool Equals(object other) {
		if (!(other is ElementModel o)) return false;
		return true;
	}
	public override int GetHashCode() {
		var hash = 17;
		return hash;
	}
	public virtual Xamarin.Forms.Element CreateElement() => throw new System.NotSupportedException("Cannot create Xamarin.Forms.Element from " + GetType().FullName);
	public virtual void Apply(Xamarin.Forms.Element target) {
	}
}

public partial class VisualElementModel : ElementModel
{
	public Xamarin.Forms.Color BackgroundColor { get; }
	public bool IsVisible { get; }
	public double Opacity { get; }
	public double WidthRequest { get; }
	public double HeightRequest { get; }
	public bool IsEnabled { get; }
	public VisualElementModel(Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base() {
		BackgroundColor = backgroundColor == default(Xamarin.Forms.Color) ? Xamarin.Forms.Color.Default : backgroundColor;
		IsVisible = isVisible;
		Opacity = opacity;
		WidthRequest = widthRequest;
		HeightRequest = heightRequest;
		IsEnabled = isEnabled;
	}
	public virtual VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new VisualElementModel(backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual VisualElementModel WithIsVisible(bool isVisible) => new VisualElementModel(BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual VisualElementModel WithOpacity(double opacity) => new VisualElementModel(BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual VisualElementModel WithWidthRequest(double widthRequest) => new VisualElementModel(BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public virtual VisualElementModel WithHeightRequest(double heightRequest) => new VisualElementModel(BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public virtual VisualElementModel WithIsEnabled(bool isEnabled) => new VisualElementModel(BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object other) {
		if (!(other is VisualElementModel o)) return false;
		if (!base.Equals(other)) return false;
		return BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + BackgroundColor.GetHashCode();
		hash = hash * 37 + IsVisible.GetHashCode();
		hash = hash * 37 + Opacity.GetHashCode();
		hash = hash * 37 + WidthRequest.GetHashCode();
		hash = hash * 37 + HeightRequest.GetHashCode();
		hash = hash * 37 + IsEnabled.GetHashCode();
		return hash;
	}
	public virtual Xamarin.Forms.VisualElement CreateVisualElement() => throw new System.NotSupportedException("Cannot create Xamarin.Forms.VisualElement from " + GetType().FullName);
	public virtual void Apply(Xamarin.Forms.VisualElement target) {
		base.Apply(target);
		target.BackgroundColor = BackgroundColor;
		target.IsVisible = IsVisible;
		target.Opacity = Opacity;
		target.WidthRequest = WidthRequest;
		target.HeightRequest = HeightRequest;
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
	public override bool Equals(object other) {
		if (!(other is LayoutOptionsModel o)) return false;
		return Alignment == o.Alignment && Expands == o.Expands;
	}
	public override int GetHashCode() {
		var hash = 17;
		hash = hash * 37 + Alignment.GetHashCode();
		hash = hash * 37 + Expands.GetHashCode();
		return hash;
	}
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
	public ViewModel(LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(backgroundColor, isVisible, opacity, widthRequest, heightRequest, isEnabled) {
		HorizontalOptions = horizontalOptions;
		VerticalOptions = verticalOptions;
		Margin = margin;
	}
	public virtual ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new ViewModel(horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new ViewModel(HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new ViewModel(HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ViewModel(HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new ViewModel(HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new ViewModel(HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new ViewModel(HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new ViewModel(HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new ViewModel(HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object other) {
		if (!(other is ViewModel o)) return false;
		if (!base.Equals(other)) return false;
		return HorizontalOptions == o.HorizontalOptions && VerticalOptions == o.VerticalOptions && Margin == o.Margin;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + HorizontalOptions.GetHashCode();
		hash = hash * 37 + VerticalOptions.GetHashCode();
		hash = hash * 37 + Margin.GetHashCode();
		return hash;
	}
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
	public ButtonModel(string text = "", LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(horizontalOptions, verticalOptions, margin) {
		Text = text;
	}
	public virtual ButtonModel WithText(string text) => new ButtonModel(text, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new ButtonModel(Text, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new ButtonModel(Text, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new ButtonModel(Text, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ButtonModel(Text, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new ButtonModel(Text, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new ButtonModel(Text, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new ButtonModel(Text, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new ButtonModel(Text, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new ButtonModel(Text, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object other) {
		if (!(other is ButtonModel o)) return false;
		if (!base.Equals(other)) return false;
		return Text == o.Text;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (Text != null ? Text.GetHashCode() : 0);
		return hash;
	}
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
	public ContentViewModel(ViewModel content = null, LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(horizontalOptions, verticalOptions, margin) {
		Content = content;
	}
	public virtual ContentViewModel WithContent(ViewModel content) => new ContentViewModel(content, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new ContentViewModel(Content, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new ContentViewModel(Content, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new ContentViewModel(Content, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ContentViewModel(Content, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new ContentViewModel(Content, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new ContentViewModel(Content, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new ContentViewModel(Content, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new ContentViewModel(Content, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new ContentViewModel(Content, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object other) {
		if (!(other is ContentViewModel o)) return false;
		if (!base.Equals(other)) return false;
		return Content == o.Content;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (Content != null ? Content.GetHashCode() : 0);
		return hash;
	}
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
		if (target.Content is Xamarin.Forms.View t) Content.Apply(t);
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
	public PageModel(string title = "", Xamarin.Forms.Thickness padding = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(backgroundColor, isVisible, opacity, widthRequest, heightRequest, isEnabled) {
		Title = title;
		Padding = padding;
	}
	public virtual PageModel WithTitle(string title) => new PageModel(title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual PageModel WithPadding(Xamarin.Forms.Thickness padding) => new PageModel(Title, padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new PageModel(Title, Padding, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new PageModel(Title, Padding, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new PageModel(Title, Padding, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new PageModel(Title, Padding, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new PageModel(Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new PageModel(Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object other) {
		if (!(other is PageModel o)) return false;
		if (!base.Equals(other)) return false;
		return Title == o.Title && Padding == o.Padding;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (Title != null ? Title.GetHashCode() : 0);
		hash = hash * 37 + Padding.GetHashCode();
		return hash;
	}
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
	public ContentPageModel(ViewModel content = null, string title = "", Xamarin.Forms.Thickness padding = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(title, padding) {
		Content = content;
	}
	public virtual ContentPageModel WithContent(ViewModel content) => new ContentPageModel(content, Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override PageModel WithTitle(string title) => new ContentPageModel(Content, title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override PageModel WithPadding(Xamarin.Forms.Thickness padding) => new ContentPageModel(Content, Title, padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ContentPageModel(Content, Title, Padding, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new ContentPageModel(Content, Title, Padding, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new ContentPageModel(Content, Title, Padding, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new ContentPageModel(Content, Title, Padding, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new ContentPageModel(Content, Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new ContentPageModel(Content, Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object other) {
		if (!(other is ContentPageModel o)) return false;
		if (!base.Equals(other)) return false;
		return Content == o.Content;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (Content != null ? Content.GetHashCode() : 0);
		return hash;
	}
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
		if (target.Content is Xamarin.Forms.View t) Content.Apply(t);
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
	public override bool Equals(object other) {
		if (!(other is CellModel o)) return false;
		if (!base.Equals(other)) return false;
		return Height == o.Height && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + Height.GetHashCode();
		hash = hash * 37 + IsEnabled.GetHashCode();
		return hash;
	}
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
	public override bool Equals(object other) {
		if (!(other is ViewCellModel o)) return false;
		if (!base.Equals(other)) return false;
		return View == o.View;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (View != null ? View.GetHashCode() : 0);
		return hash;
	}
	public virtual Xamarin.Forms.ViewCell CreateViewCell() {
		var target = new Xamarin.Forms.ViewCell();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.Cell CreateCell() => CreateViewCell();
	public override Xamarin.Forms.Element CreateElement() => CreateViewCell();
	public virtual void Apply(Xamarin.Forms.ViewCell target) {
		base.Apply(target);
		if (target.View is Xamarin.Forms.View t) View.Apply(t);
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

public partial class ListViewModel : ViewModel
{
	public System.Collections.IEnumerable ItemsSource { get; }
	public Xamarin.Forms.DataTemplate ItemTemplate { get; }
	public System.Object SelectedItem { get; }
	public Xamarin.Forms.SeparatorVisibility SeparatorVisibility { get; }
	public Xamarin.Forms.Color SeparatorColor { get; }
	public bool HasUnevenRows { get; }
	public int RowHeight { get; }
	public ListViewModel(System.Collections.IEnumerable itemsSource = null, Xamarin.Forms.DataTemplate itemTemplate = null, System.Object selectedItem = null, Xamarin.Forms.SeparatorVisibility separatorVisibility = Xamarin.Forms.SeparatorVisibility.Default, Xamarin.Forms.Color separatorColor = default(Xamarin.Forms.Color), bool hasUnevenRows = false, int rowHeight = -1, LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(horizontalOptions, verticalOptions, margin) {
		ItemsSource = itemsSource;
		ItemTemplate = itemTemplate;
		SelectedItem = selectedItem;
		SeparatorVisibility = separatorVisibility;
		SeparatorColor = separatorColor == default(Xamarin.Forms.Color) ? Xamarin.Forms.Color.Default : separatorColor;
		HasUnevenRows = hasUnevenRows;
		RowHeight = rowHeight;
	}
	public virtual ListViewModel WithItemsSource(System.Collections.IEnumerable itemsSource) => new ListViewModel(itemsSource, ItemTemplate, SelectedItem, SeparatorVisibility, SeparatorColor, HasUnevenRows, RowHeight, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual ListViewModel WithItemTemplate(Xamarin.Forms.DataTemplate itemTemplate) => new ListViewModel(ItemsSource, itemTemplate, SelectedItem, SeparatorVisibility, SeparatorColor, HasUnevenRows, RowHeight, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual ListViewModel WithSelectedItem(System.Object selectedItem) => new ListViewModel(ItemsSource, ItemTemplate, selectedItem, SeparatorVisibility, SeparatorColor, HasUnevenRows, RowHeight, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual ListViewModel WithSeparatorVisibility(Xamarin.Forms.SeparatorVisibility separatorVisibility) => new ListViewModel(ItemsSource, ItemTemplate, SelectedItem, separatorVisibility, SeparatorColor, HasUnevenRows, RowHeight, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual ListViewModel WithSeparatorColor(Xamarin.Forms.Color separatorColor) => new ListViewModel(ItemsSource, ItemTemplate, SelectedItem, SeparatorVisibility, separatorColor, HasUnevenRows, RowHeight, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual ListViewModel WithHasUnevenRows(bool hasUnevenRows) => new ListViewModel(ItemsSource, ItemTemplate, SelectedItem, SeparatorVisibility, SeparatorColor, hasUnevenRows, RowHeight, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual ListViewModel WithRowHeight(int rowHeight) => new ListViewModel(ItemsSource, ItemTemplate, SelectedItem, SeparatorVisibility, SeparatorColor, HasUnevenRows, rowHeight, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new ListViewModel(ItemsSource, ItemTemplate, SelectedItem, SeparatorVisibility, SeparatorColor, HasUnevenRows, RowHeight, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new ListViewModel(ItemsSource, ItemTemplate, SelectedItem, SeparatorVisibility, SeparatorColor, HasUnevenRows, RowHeight, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new ListViewModel(ItemsSource, ItemTemplate, SelectedItem, SeparatorVisibility, SeparatorColor, HasUnevenRows, RowHeight, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ListViewModel(ItemsSource, ItemTemplate, SelectedItem, SeparatorVisibility, SeparatorColor, HasUnevenRows, RowHeight, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new ListViewModel(ItemsSource, ItemTemplate, SelectedItem, SeparatorVisibility, SeparatorColor, HasUnevenRows, RowHeight, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new ListViewModel(ItemsSource, ItemTemplate, SelectedItem, SeparatorVisibility, SeparatorColor, HasUnevenRows, RowHeight, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new ListViewModel(ItemsSource, ItemTemplate, SelectedItem, SeparatorVisibility, SeparatorColor, HasUnevenRows, RowHeight, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new ListViewModel(ItemsSource, ItemTemplate, SelectedItem, SeparatorVisibility, SeparatorColor, HasUnevenRows, RowHeight, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new ListViewModel(ItemsSource, ItemTemplate, SelectedItem, SeparatorVisibility, SeparatorColor, HasUnevenRows, RowHeight, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object other) {
		if (!(other is ListViewModel o)) return false;
		if (!base.Equals(other)) return false;
		return ItemsSource == o.ItemsSource && ItemTemplate == o.ItemTemplate && SelectedItem == o.SelectedItem && SeparatorVisibility == o.SeparatorVisibility && SeparatorColor == o.SeparatorColor && HasUnevenRows == o.HasUnevenRows && RowHeight == o.RowHeight;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (ItemsSource != null ? ItemsSource.GetHashCode() : 0);
		hash = hash * 37 + (ItemTemplate != null ? ItemTemplate.GetHashCode() : 0);
		hash = hash * 37 + (SelectedItem != null ? SelectedItem.GetHashCode() : 0);
		hash = hash * 37 + SeparatorVisibility.GetHashCode();
		hash = hash * 37 + SeparatorColor.GetHashCode();
		hash = hash * 37 + HasUnevenRows.GetHashCode();
		hash = hash * 37 + RowHeight.GetHashCode();
		return hash;
	}
	public virtual Xamarin.Forms.ListView CreateListView() {
		var target = new Xamarin.Forms.ListView();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.View CreateView() => CreateListView();
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreateListView();
	public override Xamarin.Forms.Element CreateElement() => CreateListView();
	public virtual void Apply(Xamarin.Forms.ListView target) {
		base.Apply(target);
		target.ItemsSource = ItemsSource;
		target.ItemTemplate = ItemTemplate;
		target.SelectedItem = SelectedItem;
		target.SeparatorVisibility = SeparatorVisibility;
		target.SeparatorColor = SeparatorColor;
		target.HasUnevenRows = HasUnevenRows;
		target.RowHeight = RowHeight;
	}
	public override void Apply(Xamarin.Forms.View target) {
		if (target is Xamarin.Forms.ListView t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.ListView t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.ListView t) Apply(t);
		else base.Apply(target);
	}
}
