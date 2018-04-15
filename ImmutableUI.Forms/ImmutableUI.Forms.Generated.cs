public partial class ElementModel
{
	public ElementModel() {
	}
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (ElementModel)obj;
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
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (VisualElementModel)obj;
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
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (LayoutOptionsModel)obj;
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
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (ViewModel)obj;
		return HorizontalOptions == o.HorizontalOptions && VerticalOptions == o.VerticalOptions && Margin == o.Margin && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
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

public partial class BoxViewModel : ViewModel
{
	public Xamarin.Forms.Color Color { get; }
	public BoxViewModel(Xamarin.Forms.Color color = default(Xamarin.Forms.Color), LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(horizontalOptions, verticalOptions, margin) {
		Color = color == default(Xamarin.Forms.Color) ? Xamarin.Forms.Color.Default : color;
	}
	public virtual BoxViewModel WithColor(Xamarin.Forms.Color color) => new BoxViewModel(color, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new BoxViewModel(Color, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new BoxViewModel(Color, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new BoxViewModel(Color, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new BoxViewModel(Color, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new BoxViewModel(Color, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new BoxViewModel(Color, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new BoxViewModel(Color, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new BoxViewModel(Color, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new BoxViewModel(Color, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (BoxViewModel)obj;
		return Color == o.Color && HorizontalOptions == o.HorizontalOptions && VerticalOptions == o.VerticalOptions && Margin == o.Margin && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + Color.GetHashCode();
		return hash;
	}
	public virtual Xamarin.Forms.BoxView CreateBoxView() {
		var target = new Xamarin.Forms.BoxView();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.View CreateView() => CreateBoxView();
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreateBoxView();
	public override Xamarin.Forms.Element CreateElement() => CreateBoxView();
	public virtual void Apply(Xamarin.Forms.BoxView target) {
		base.Apply(target);
		target.Color = Color;
	}
	public override void Apply(Xamarin.Forms.View target) {
		if (target is Xamarin.Forms.BoxView t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.BoxView t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.BoxView t) Apply(t);
		else base.Apply(target);
	}
}

public partial class ButtonModel : ViewModel
{
	public string Text { get; }
	public System.Windows.Input.ICommand Command { get; }
	public System.Object CommandParameter { get; }
	public Xamarin.Forms.Button.ButtonContentLayout ContentLayout { get; }
	public double FontSize { get; }
	public string FontFamily { get; }
	public Xamarin.Forms.FontAttributes FontAttributes { get; }
	public double BorderWidth { get; }
	public Xamarin.Forms.Color BorderColor { get; }
	public ButtonModel(string text = null, System.Windows.Input.ICommand command = null, System.Object commandParameter = null, Xamarin.Forms.Button.ButtonContentLayout contentLayout = default(Xamarin.Forms.Button.ButtonContentLayout), double fontSize = -1, string fontFamily = null, Xamarin.Forms.FontAttributes fontAttributes = Xamarin.Forms.FontAttributes.None, double borderWidth = -1, Xamarin.Forms.Color borderColor = default(Xamarin.Forms.Color), LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(horizontalOptions, verticalOptions, margin) {
		Text = text;
		Command = command;
		CommandParameter = commandParameter;
		ContentLayout = contentLayout == default(Xamarin.Forms.Button.ButtonContentLayout) ? new Xamarin.Forms.Button.ButtonContentLayout(Xamarin.Forms.Button.ButtonContentLayout.ImagePosition.Left, 10) : contentLayout;
		FontSize = fontSize;
		FontFamily = fontFamily;
		FontAttributes = fontAttributes;
		BorderWidth = borderWidth;
		BorderColor = borderColor == default(Xamarin.Forms.Color) ? Xamarin.Forms.Color.Default : borderColor;
	}
	public virtual ButtonModel WithText(string text) => new ButtonModel(text, Command, CommandParameter, ContentLayout, FontSize, FontFamily, FontAttributes, BorderWidth, BorderColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual ButtonModel WithCommand(System.Windows.Input.ICommand command) => new ButtonModel(Text, command, CommandParameter, ContentLayout, FontSize, FontFamily, FontAttributes, BorderWidth, BorderColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual ButtonModel WithCommandParameter(System.Object commandParameter) => new ButtonModel(Text, Command, commandParameter, ContentLayout, FontSize, FontFamily, FontAttributes, BorderWidth, BorderColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual ButtonModel WithContentLayout(Xamarin.Forms.Button.ButtonContentLayout contentLayout) => new ButtonModel(Text, Command, CommandParameter, contentLayout, FontSize, FontFamily, FontAttributes, BorderWidth, BorderColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual ButtonModel WithFontSize(double fontSize) => new ButtonModel(Text, Command, CommandParameter, ContentLayout, fontSize, FontFamily, FontAttributes, BorderWidth, BorderColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual ButtonModel WithFontFamily(string fontFamily) => new ButtonModel(Text, Command, CommandParameter, ContentLayout, FontSize, fontFamily, FontAttributes, BorderWidth, BorderColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual ButtonModel WithFontAttributes(Xamarin.Forms.FontAttributes fontAttributes) => new ButtonModel(Text, Command, CommandParameter, ContentLayout, FontSize, FontFamily, fontAttributes, BorderWidth, BorderColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual ButtonModel WithBorderWidth(double borderWidth) => new ButtonModel(Text, Command, CommandParameter, ContentLayout, FontSize, FontFamily, FontAttributes, borderWidth, BorderColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual ButtonModel WithBorderColor(Xamarin.Forms.Color borderColor) => new ButtonModel(Text, Command, CommandParameter, ContentLayout, FontSize, FontFamily, FontAttributes, BorderWidth, borderColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new ButtonModel(Text, Command, CommandParameter, ContentLayout, FontSize, FontFamily, FontAttributes, BorderWidth, BorderColor, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new ButtonModel(Text, Command, CommandParameter, ContentLayout, FontSize, FontFamily, FontAttributes, BorderWidth, BorderColor, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new ButtonModel(Text, Command, CommandParameter, ContentLayout, FontSize, FontFamily, FontAttributes, BorderWidth, BorderColor, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ButtonModel(Text, Command, CommandParameter, ContentLayout, FontSize, FontFamily, FontAttributes, BorderWidth, BorderColor, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new ButtonModel(Text, Command, CommandParameter, ContentLayout, FontSize, FontFamily, FontAttributes, BorderWidth, BorderColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new ButtonModel(Text, Command, CommandParameter, ContentLayout, FontSize, FontFamily, FontAttributes, BorderWidth, BorderColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new ButtonModel(Text, Command, CommandParameter, ContentLayout, FontSize, FontFamily, FontAttributes, BorderWidth, BorderColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new ButtonModel(Text, Command, CommandParameter, ContentLayout, FontSize, FontFamily, FontAttributes, BorderWidth, BorderColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new ButtonModel(Text, Command, CommandParameter, ContentLayout, FontSize, FontFamily, FontAttributes, BorderWidth, BorderColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (ButtonModel)obj;
		return Text == o.Text && Command == o.Command && CommandParameter == o.CommandParameter && ContentLayout == o.ContentLayout && FontSize == o.FontSize && FontFamily == o.FontFamily && FontAttributes == o.FontAttributes && BorderWidth == o.BorderWidth && BorderColor == o.BorderColor && HorizontalOptions == o.HorizontalOptions && VerticalOptions == o.VerticalOptions && Margin == o.Margin && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (Text != null ? Text.GetHashCode() : 0);
		hash = hash * 37 + (Command != null ? Command.GetHashCode() : 0);
		hash = hash * 37 + (CommandParameter != null ? CommandParameter.GetHashCode() : 0);
		hash = hash * 37 + (ContentLayout != null ? ContentLayout.GetHashCode() : 0);
		hash = hash * 37 + FontSize.GetHashCode();
		hash = hash * 37 + (FontFamily != null ? FontFamily.GetHashCode() : 0);
		hash = hash * 37 + FontAttributes.GetHashCode();
		hash = hash * 37 + BorderWidth.GetHashCode();
		hash = hash * 37 + BorderColor.GetHashCode();
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
		target.Command = Command;
		target.CommandParameter = CommandParameter;
		target.ContentLayout = ContentLayout;
		target.FontSize = FontSize;
		target.FontFamily = FontFamily;
		target.FontAttributes = FontAttributes;
		target.BorderWidth = BorderWidth;
		target.BorderColor = BorderColor;
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

public partial class ContentViewModel : LayoutModel
{
	public ViewModel Content { get; }
	public ContentViewModel(ViewModel content = null, bool isClippedToBounds = false, Xamarin.Forms.Thickness padding = default(Xamarin.Forms.Thickness), LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(isClippedToBounds, padding) {
		Content = content;
	}
	public virtual ContentViewModel WithContent(ViewModel content) => new ContentViewModel(content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override LayoutModel WithIsClippedToBounds(bool isClippedToBounds) => new ContentViewModel(Content, isClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override LayoutModel WithPadding(Xamarin.Forms.Thickness padding) => new ContentViewModel(Content, IsClippedToBounds, padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new ContentViewModel(Content, IsClippedToBounds, Padding, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new ContentViewModel(Content, IsClippedToBounds, Padding, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new ContentViewModel(Content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ContentViewModel(Content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new ContentViewModel(Content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new ContentViewModel(Content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new ContentViewModel(Content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new ContentViewModel(Content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new ContentViewModel(Content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (ContentViewModel)obj;
		return Content == o.Content && IsClippedToBounds == o.IsClippedToBounds && Padding == o.Padding && HorizontalOptions == o.HorizontalOptions && VerticalOptions == o.VerticalOptions && Margin == o.Margin && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
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
	public override Xamarin.Forms.Layout CreateLayout() => CreateContentView();
	public override Xamarin.Forms.View CreateView() => CreateContentView();
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreateContentView();
	public override Xamarin.Forms.Element CreateElement() => CreateContentView();
	public virtual void Apply(Xamarin.Forms.ContentView target) {
		base.Apply(target);
		if (Content != null) {
			if (target.Content is Xamarin.Forms.View content) Content.Apply(content);
			else target.Content = Content.CreateView();
		} else target.Content = null;
	}
	public override void Apply(Xamarin.Forms.Layout target) {
		if (target is Xamarin.Forms.ContentView t) Apply(t);
		else base.Apply(target);
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

public partial class DatePickerModel : ViewModel
{
	public System.DateTime Date { get; }
	public string Format { get; }
	public System.DateTime MinimumDate { get; }
	public System.DateTime MaximumDate { get; }
	public DatePickerModel(System.DateTime date = default(System.DateTime), string format = "d", System.DateTime minimumDate = default(System.DateTime), System.DateTime maximumDate = default(System.DateTime), LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(horizontalOptions, verticalOptions, margin) {
		Date = date;
		Format = format;
		MinimumDate = minimumDate == default(System.DateTime) ? new System.DateTime(1900, 1, 1) : minimumDate;
		MaximumDate = maximumDate == default(System.DateTime) ? new System.DateTime(2100, 12, 31) : maximumDate;
	}
	public virtual DatePickerModel WithDate(System.DateTime date) => new DatePickerModel(date, Format, MinimumDate, MaximumDate, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual DatePickerModel WithFormat(string format) => new DatePickerModel(Date, format, MinimumDate, MaximumDate, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual DatePickerModel WithMinimumDate(System.DateTime minimumDate) => new DatePickerModel(Date, Format, minimumDate, MaximumDate, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual DatePickerModel WithMaximumDate(System.DateTime maximumDate) => new DatePickerModel(Date, Format, MinimumDate, maximumDate, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new DatePickerModel(Date, Format, MinimumDate, MaximumDate, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new DatePickerModel(Date, Format, MinimumDate, MaximumDate, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new DatePickerModel(Date, Format, MinimumDate, MaximumDate, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new DatePickerModel(Date, Format, MinimumDate, MaximumDate, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new DatePickerModel(Date, Format, MinimumDate, MaximumDate, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new DatePickerModel(Date, Format, MinimumDate, MaximumDate, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new DatePickerModel(Date, Format, MinimumDate, MaximumDate, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new DatePickerModel(Date, Format, MinimumDate, MaximumDate, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new DatePickerModel(Date, Format, MinimumDate, MaximumDate, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (DatePickerModel)obj;
		return Date == o.Date && Format == o.Format && MinimumDate == o.MinimumDate && MaximumDate == o.MaximumDate && HorizontalOptions == o.HorizontalOptions && VerticalOptions == o.VerticalOptions && Margin == o.Margin && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + Date.GetHashCode();
		hash = hash * 37 + (Format != null ? Format.GetHashCode() : 0);
		hash = hash * 37 + MinimumDate.GetHashCode();
		hash = hash * 37 + MaximumDate.GetHashCode();
		return hash;
	}
	public virtual Xamarin.Forms.DatePicker CreateDatePicker() {
		var target = new Xamarin.Forms.DatePicker();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.View CreateView() => CreateDatePicker();
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreateDatePicker();
	public override Xamarin.Forms.Element CreateElement() => CreateDatePicker();
	public virtual void Apply(Xamarin.Forms.DatePicker target) {
		base.Apply(target);
		target.Date = Date;
		target.Format = Format;
		target.MinimumDate = MinimumDate;
		target.MaximumDate = MaximumDate;
	}
	public override void Apply(Xamarin.Forms.View target) {
		if (target is Xamarin.Forms.DatePicker t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.DatePicker t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.DatePicker t) Apply(t);
		else base.Apply(target);
	}
}

public partial class FrameModel : ContentViewModel
{
	public Xamarin.Forms.Color OutlineColor { get; }
	public float CornerRadius { get; }
	public bool HasShadow { get; }
	public FrameModel(Xamarin.Forms.Color outlineColor = default(Xamarin.Forms.Color), float cornerRadius = -1, bool hasShadow = true, ViewModel content = null, bool isClippedToBounds = false, Xamarin.Forms.Thickness padding = default(Xamarin.Forms.Thickness), LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(content) {
		OutlineColor = outlineColor == default(Xamarin.Forms.Color) ? Xamarin.Forms.Color.Default : outlineColor;
		CornerRadius = cornerRadius;
		HasShadow = hasShadow;
	}
	public virtual FrameModel WithOutlineColor(Xamarin.Forms.Color outlineColor) => new FrameModel(outlineColor, CornerRadius, HasShadow, Content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual FrameModel WithCornerRadius(float cornerRadius) => new FrameModel(OutlineColor, cornerRadius, HasShadow, Content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual FrameModel WithHasShadow(bool hasShadow) => new FrameModel(OutlineColor, CornerRadius, hasShadow, Content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ContentViewModel WithContent(ViewModel content) => new FrameModel(OutlineColor, CornerRadius, HasShadow, content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override LayoutModel WithIsClippedToBounds(bool isClippedToBounds) => new FrameModel(OutlineColor, CornerRadius, HasShadow, Content, isClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override LayoutModel WithPadding(Xamarin.Forms.Thickness padding) => new FrameModel(OutlineColor, CornerRadius, HasShadow, Content, IsClippedToBounds, padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new FrameModel(OutlineColor, CornerRadius, HasShadow, Content, IsClippedToBounds, Padding, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new FrameModel(OutlineColor, CornerRadius, HasShadow, Content, IsClippedToBounds, Padding, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new FrameModel(OutlineColor, CornerRadius, HasShadow, Content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new FrameModel(OutlineColor, CornerRadius, HasShadow, Content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new FrameModel(OutlineColor, CornerRadius, HasShadow, Content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new FrameModel(OutlineColor, CornerRadius, HasShadow, Content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new FrameModel(OutlineColor, CornerRadius, HasShadow, Content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new FrameModel(OutlineColor, CornerRadius, HasShadow, Content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new FrameModel(OutlineColor, CornerRadius, HasShadow, Content, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (FrameModel)obj;
		return OutlineColor == o.OutlineColor && CornerRadius == o.CornerRadius && HasShadow == o.HasShadow && Content == o.Content && IsClippedToBounds == o.IsClippedToBounds && Padding == o.Padding && HorizontalOptions == o.HorizontalOptions && VerticalOptions == o.VerticalOptions && Margin == o.Margin && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + OutlineColor.GetHashCode();
		hash = hash * 37 + CornerRadius.GetHashCode();
		hash = hash * 37 + HasShadow.GetHashCode();
		return hash;
	}
	public virtual Xamarin.Forms.Frame CreateFrame() {
		var target = new Xamarin.Forms.Frame();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.ContentView CreateContentView() => CreateFrame();
	public override Xamarin.Forms.Layout CreateLayout() => CreateFrame();
	public override Xamarin.Forms.View CreateView() => CreateFrame();
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreateFrame();
	public override Xamarin.Forms.Element CreateElement() => CreateFrame();
	public virtual void Apply(Xamarin.Forms.Frame target) {
		base.Apply(target);
		target.OutlineColor = OutlineColor;
		target.CornerRadius = CornerRadius;
		target.HasShadow = HasShadow;
	}
	public override void Apply(Xamarin.Forms.ContentView target) {
		if (target is Xamarin.Forms.Frame t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Layout target) {
		if (target is Xamarin.Forms.Frame t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.View target) {
		if (target is Xamarin.Forms.Frame t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.Frame t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.Frame t) Apply(t);
		else base.Apply(target);
	}
}

public partial class ImageModel : ViewModel
{
	public Xamarin.Forms.ImageSource Source { get; }
	public Xamarin.Forms.Aspect Aspect { get; }
	public bool IsOpaque { get; }
	public ImageModel(Xamarin.Forms.ImageSource source = null, Xamarin.Forms.Aspect aspect = Xamarin.Forms.Aspect.AspectFit, bool isOpaque = true, LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(horizontalOptions, verticalOptions, margin) {
		Source = source;
		Aspect = aspect;
		IsOpaque = isOpaque;
	}
	public virtual ImageModel WithSource(Xamarin.Forms.ImageSource source) => new ImageModel(source, Aspect, IsOpaque, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual ImageModel WithAspect(Xamarin.Forms.Aspect aspect) => new ImageModel(Source, aspect, IsOpaque, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual ImageModel WithIsOpaque(bool isOpaque) => new ImageModel(Source, Aspect, isOpaque, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new ImageModel(Source, Aspect, IsOpaque, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new ImageModel(Source, Aspect, IsOpaque, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new ImageModel(Source, Aspect, IsOpaque, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new ImageModel(Source, Aspect, IsOpaque, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new ImageModel(Source, Aspect, IsOpaque, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new ImageModel(Source, Aspect, IsOpaque, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new ImageModel(Source, Aspect, IsOpaque, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new ImageModel(Source, Aspect, IsOpaque, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new ImageModel(Source, Aspect, IsOpaque, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (ImageModel)obj;
		return Source == o.Source && Aspect == o.Aspect && IsOpaque == o.IsOpaque && HorizontalOptions == o.HorizontalOptions && VerticalOptions == o.VerticalOptions && Margin == o.Margin && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (Source != null ? Source.GetHashCode() : 0);
		hash = hash * 37 + Aspect.GetHashCode();
		hash = hash * 37 + IsOpaque.GetHashCode();
		return hash;
	}
	public virtual Xamarin.Forms.Image CreateImage() {
		var target = new Xamarin.Forms.Image();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.View CreateView() => CreateImage();
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreateImage();
	public override Xamarin.Forms.Element CreateElement() => CreateImage();
	public virtual void Apply(Xamarin.Forms.Image target) {
		base.Apply(target);
		target.Source = Source;
		target.Aspect = Aspect;
		target.IsOpaque = IsOpaque;
	}
	public override void Apply(Xamarin.Forms.View target) {
		if (target is Xamarin.Forms.Image t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.Image t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.Image t) Apply(t);
		else base.Apply(target);
	}
}

public partial class InputViewModel : ViewModel
{
	public Xamarin.Forms.Keyboard Keyboard { get; }
	public InputViewModel(Xamarin.Forms.Keyboard keyboard = default(Xamarin.Forms.Keyboard), LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(horizontalOptions, verticalOptions, margin) {
		Keyboard = keyboard == default(Xamarin.Forms.Keyboard) ? Xamarin.Forms.Keyboard.Default : keyboard;
	}
	public virtual InputViewModel WithKeyboard(Xamarin.Forms.Keyboard keyboard) => new InputViewModel(keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new InputViewModel(Keyboard, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new InputViewModel(Keyboard, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new InputViewModel(Keyboard, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new InputViewModel(Keyboard, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new InputViewModel(Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new InputViewModel(Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new InputViewModel(Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new InputViewModel(Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new InputViewModel(Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (InputViewModel)obj;
		return Keyboard == o.Keyboard && HorizontalOptions == o.HorizontalOptions && VerticalOptions == o.VerticalOptions && Margin == o.Margin && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (Keyboard != null ? Keyboard.GetHashCode() : 0);
		return hash;
	}
	public virtual Xamarin.Forms.InputView CreateInputView() => throw new System.NotSupportedException("Cannot create Xamarin.Forms.InputView from " + GetType().FullName);
	public virtual void Apply(Xamarin.Forms.InputView target) {
		base.Apply(target);
		target.Keyboard = Keyboard;
	}
	public override void Apply(Xamarin.Forms.View target) {
		if (target is Xamarin.Forms.InputView t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.InputView t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.InputView t) Apply(t);
		else base.Apply(target);
	}
}

public partial class EditorModel : InputViewModel
{
	public string Text { get; }
	public double FontSize { get; }
	public string FontFamily { get; }
	public Xamarin.Forms.FontAttributes FontAttributes { get; }
	public Xamarin.Forms.Color TextColor { get; }
	public EditorModel(string text = null, double fontSize = -1, string fontFamily = null, Xamarin.Forms.FontAttributes fontAttributes = Xamarin.Forms.FontAttributes.None, Xamarin.Forms.Color textColor = default(Xamarin.Forms.Color), Xamarin.Forms.Keyboard keyboard = default(Xamarin.Forms.Keyboard), LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(keyboard) {
		Text = text;
		FontSize = fontSize;
		FontFamily = fontFamily;
		FontAttributes = fontAttributes;
		TextColor = textColor == default(Xamarin.Forms.Color) ? Xamarin.Forms.Color.Default : textColor;
	}
	public virtual EditorModel WithText(string text) => new EditorModel(text, FontSize, FontFamily, FontAttributes, TextColor, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual EditorModel WithFontSize(double fontSize) => new EditorModel(Text, fontSize, FontFamily, FontAttributes, TextColor, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual EditorModel WithFontFamily(string fontFamily) => new EditorModel(Text, FontSize, fontFamily, FontAttributes, TextColor, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual EditorModel WithFontAttributes(Xamarin.Forms.FontAttributes fontAttributes) => new EditorModel(Text, FontSize, FontFamily, fontAttributes, TextColor, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual EditorModel WithTextColor(Xamarin.Forms.Color textColor) => new EditorModel(Text, FontSize, FontFamily, FontAttributes, textColor, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override InputViewModel WithKeyboard(Xamarin.Forms.Keyboard keyboard) => new EditorModel(Text, FontSize, FontFamily, FontAttributes, TextColor, keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new EditorModel(Text, FontSize, FontFamily, FontAttributes, TextColor, Keyboard, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new EditorModel(Text, FontSize, FontFamily, FontAttributes, TextColor, Keyboard, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new EditorModel(Text, FontSize, FontFamily, FontAttributes, TextColor, Keyboard, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new EditorModel(Text, FontSize, FontFamily, FontAttributes, TextColor, Keyboard, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new EditorModel(Text, FontSize, FontFamily, FontAttributes, TextColor, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new EditorModel(Text, FontSize, FontFamily, FontAttributes, TextColor, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new EditorModel(Text, FontSize, FontFamily, FontAttributes, TextColor, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new EditorModel(Text, FontSize, FontFamily, FontAttributes, TextColor, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new EditorModel(Text, FontSize, FontFamily, FontAttributes, TextColor, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (EditorModel)obj;
		return Text == o.Text && FontSize == o.FontSize && FontFamily == o.FontFamily && FontAttributes == o.FontAttributes && TextColor == o.TextColor && Keyboard == o.Keyboard && HorizontalOptions == o.HorizontalOptions && VerticalOptions == o.VerticalOptions && Margin == o.Margin && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (Text != null ? Text.GetHashCode() : 0);
		hash = hash * 37 + FontSize.GetHashCode();
		hash = hash * 37 + (FontFamily != null ? FontFamily.GetHashCode() : 0);
		hash = hash * 37 + FontAttributes.GetHashCode();
		hash = hash * 37 + TextColor.GetHashCode();
		return hash;
	}
	public virtual Xamarin.Forms.Editor CreateEditor() {
		var target = new Xamarin.Forms.Editor();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.InputView CreateInputView() => CreateEditor();
	public override Xamarin.Forms.View CreateView() => CreateEditor();
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreateEditor();
	public override Xamarin.Forms.Element CreateElement() => CreateEditor();
	public virtual void Apply(Xamarin.Forms.Editor target) {
		base.Apply(target);
		target.Text = Text;
		target.FontSize = FontSize;
		target.FontFamily = FontFamily;
		target.FontAttributes = FontAttributes;
		target.TextColor = TextColor;
	}
	public override void Apply(Xamarin.Forms.InputView target) {
		if (target is Xamarin.Forms.Editor t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.View target) {
		if (target is Xamarin.Forms.Editor t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.Editor t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.Editor t) Apply(t);
		else base.Apply(target);
	}
}

public partial class EntryModel : InputViewModel
{
	public string Text { get; }
	public string Placeholder { get; }
	public Xamarin.Forms.TextAlignment HorizontalTextAlignment { get; }
	public double FontSize { get; }
	public string FontFamily { get; }
	public Xamarin.Forms.FontAttributes FontAttributes { get; }
	public Xamarin.Forms.Color TextColor { get; }
	public Xamarin.Forms.Color PlaceholderColor { get; }
	public bool IsPassword { get; }
	public EntryModel(string text = null, string placeholder = null, Xamarin.Forms.TextAlignment horizontalTextAlignment = Xamarin.Forms.TextAlignment.Start, double fontSize = -1, string fontFamily = null, Xamarin.Forms.FontAttributes fontAttributes = Xamarin.Forms.FontAttributes.None, Xamarin.Forms.Color textColor = default(Xamarin.Forms.Color), Xamarin.Forms.Color placeholderColor = default(Xamarin.Forms.Color), bool isPassword = false, Xamarin.Forms.Keyboard keyboard = default(Xamarin.Forms.Keyboard), LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(keyboard) {
		Text = text;
		Placeholder = placeholder;
		HorizontalTextAlignment = horizontalTextAlignment;
		FontSize = fontSize;
		FontFamily = fontFamily;
		FontAttributes = fontAttributes;
		TextColor = textColor == default(Xamarin.Forms.Color) ? Xamarin.Forms.Color.Default : textColor;
		PlaceholderColor = placeholderColor == default(Xamarin.Forms.Color) ? Xamarin.Forms.Color.Default : placeholderColor;
		IsPassword = isPassword;
	}
	public virtual EntryModel WithText(string text) => new EntryModel(text, Placeholder, HorizontalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, PlaceholderColor, IsPassword, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual EntryModel WithPlaceholder(string placeholder) => new EntryModel(Text, placeholder, HorizontalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, PlaceholderColor, IsPassword, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual EntryModel WithHorizontalTextAlignment(Xamarin.Forms.TextAlignment horizontalTextAlignment) => new EntryModel(Text, Placeholder, horizontalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, PlaceholderColor, IsPassword, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual EntryModel WithFontSize(double fontSize) => new EntryModel(Text, Placeholder, HorizontalTextAlignment, fontSize, FontFamily, FontAttributes, TextColor, PlaceholderColor, IsPassword, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual EntryModel WithFontFamily(string fontFamily) => new EntryModel(Text, Placeholder, HorizontalTextAlignment, FontSize, fontFamily, FontAttributes, TextColor, PlaceholderColor, IsPassword, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual EntryModel WithFontAttributes(Xamarin.Forms.FontAttributes fontAttributes) => new EntryModel(Text, Placeholder, HorizontalTextAlignment, FontSize, FontFamily, fontAttributes, TextColor, PlaceholderColor, IsPassword, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual EntryModel WithTextColor(Xamarin.Forms.Color textColor) => new EntryModel(Text, Placeholder, HorizontalTextAlignment, FontSize, FontFamily, FontAttributes, textColor, PlaceholderColor, IsPassword, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual EntryModel WithPlaceholderColor(Xamarin.Forms.Color placeholderColor) => new EntryModel(Text, Placeholder, HorizontalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, placeholderColor, IsPassword, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual EntryModel WithIsPassword(bool isPassword) => new EntryModel(Text, Placeholder, HorizontalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, PlaceholderColor, isPassword, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override InputViewModel WithKeyboard(Xamarin.Forms.Keyboard keyboard) => new EntryModel(Text, Placeholder, HorizontalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, PlaceholderColor, IsPassword, keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new EntryModel(Text, Placeholder, HorizontalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, PlaceholderColor, IsPassword, Keyboard, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new EntryModel(Text, Placeholder, HorizontalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, PlaceholderColor, IsPassword, Keyboard, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new EntryModel(Text, Placeholder, HorizontalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, PlaceholderColor, IsPassword, Keyboard, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new EntryModel(Text, Placeholder, HorizontalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, PlaceholderColor, IsPassword, Keyboard, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new EntryModel(Text, Placeholder, HorizontalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, PlaceholderColor, IsPassword, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new EntryModel(Text, Placeholder, HorizontalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, PlaceholderColor, IsPassword, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new EntryModel(Text, Placeholder, HorizontalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, PlaceholderColor, IsPassword, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new EntryModel(Text, Placeholder, HorizontalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, PlaceholderColor, IsPassword, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new EntryModel(Text, Placeholder, HorizontalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, PlaceholderColor, IsPassword, Keyboard, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (EntryModel)obj;
		return Text == o.Text && Placeholder == o.Placeholder && HorizontalTextAlignment == o.HorizontalTextAlignment && FontSize == o.FontSize && FontFamily == o.FontFamily && FontAttributes == o.FontAttributes && TextColor == o.TextColor && PlaceholderColor == o.PlaceholderColor && IsPassword == o.IsPassword && Keyboard == o.Keyboard && HorizontalOptions == o.HorizontalOptions && VerticalOptions == o.VerticalOptions && Margin == o.Margin && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (Text != null ? Text.GetHashCode() : 0);
		hash = hash * 37 + (Placeholder != null ? Placeholder.GetHashCode() : 0);
		hash = hash * 37 + HorizontalTextAlignment.GetHashCode();
		hash = hash * 37 + FontSize.GetHashCode();
		hash = hash * 37 + (FontFamily != null ? FontFamily.GetHashCode() : 0);
		hash = hash * 37 + FontAttributes.GetHashCode();
		hash = hash * 37 + TextColor.GetHashCode();
		hash = hash * 37 + PlaceholderColor.GetHashCode();
		hash = hash * 37 + IsPassword.GetHashCode();
		return hash;
	}
	public virtual Xamarin.Forms.Entry CreateEntry() {
		var target = new Xamarin.Forms.Entry();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.InputView CreateInputView() => CreateEntry();
	public override Xamarin.Forms.View CreateView() => CreateEntry();
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreateEntry();
	public override Xamarin.Forms.Element CreateElement() => CreateEntry();
	public virtual void Apply(Xamarin.Forms.Entry target) {
		base.Apply(target);
		target.Text = Text;
		target.Placeholder = Placeholder;
		target.HorizontalTextAlignment = HorizontalTextAlignment;
		target.FontSize = FontSize;
		target.FontFamily = FontFamily;
		target.FontAttributes = FontAttributes;
		target.TextColor = TextColor;
		target.PlaceholderColor = PlaceholderColor;
		target.IsPassword = IsPassword;
	}
	public override void Apply(Xamarin.Forms.InputView target) {
		if (target is Xamarin.Forms.Entry t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.View target) {
		if (target is Xamarin.Forms.Entry t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.Entry t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.Entry t) Apply(t);
		else base.Apply(target);
	}
}

public partial class LabelModel : ViewModel
{
	public string Text { get; }
	public Xamarin.Forms.TextAlignment HorizontalTextAlignment { get; }
	public Xamarin.Forms.TextAlignment VerticalTextAlignment { get; }
	public double FontSize { get; }
	public string FontFamily { get; }
	public Xamarin.Forms.FontAttributes FontAttributes { get; }
	public Xamarin.Forms.Color TextColor { get; }
	public LabelModel(string text = null, Xamarin.Forms.TextAlignment horizontalTextAlignment = Xamarin.Forms.TextAlignment.Start, Xamarin.Forms.TextAlignment verticalTextAlignment = Xamarin.Forms.TextAlignment.Start, double fontSize = -1, string fontFamily = null, Xamarin.Forms.FontAttributes fontAttributes = Xamarin.Forms.FontAttributes.None, Xamarin.Forms.Color textColor = default(Xamarin.Forms.Color), LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(horizontalOptions, verticalOptions, margin) {
		Text = text;
		HorizontalTextAlignment = horizontalTextAlignment;
		VerticalTextAlignment = verticalTextAlignment;
		FontSize = fontSize;
		FontFamily = fontFamily;
		FontAttributes = fontAttributes;
		TextColor = textColor == default(Xamarin.Forms.Color) ? Xamarin.Forms.Color.Default : textColor;
	}
	public virtual LabelModel WithText(string text) => new LabelModel(text, HorizontalTextAlignment, VerticalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual LabelModel WithHorizontalTextAlignment(Xamarin.Forms.TextAlignment horizontalTextAlignment) => new LabelModel(Text, horizontalTextAlignment, VerticalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual LabelModel WithVerticalTextAlignment(Xamarin.Forms.TextAlignment verticalTextAlignment) => new LabelModel(Text, HorizontalTextAlignment, verticalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual LabelModel WithFontSize(double fontSize) => new LabelModel(Text, HorizontalTextAlignment, VerticalTextAlignment, fontSize, FontFamily, FontAttributes, TextColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual LabelModel WithFontFamily(string fontFamily) => new LabelModel(Text, HorizontalTextAlignment, VerticalTextAlignment, FontSize, fontFamily, FontAttributes, TextColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual LabelModel WithFontAttributes(Xamarin.Forms.FontAttributes fontAttributes) => new LabelModel(Text, HorizontalTextAlignment, VerticalTextAlignment, FontSize, FontFamily, fontAttributes, TextColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual LabelModel WithTextColor(Xamarin.Forms.Color textColor) => new LabelModel(Text, HorizontalTextAlignment, VerticalTextAlignment, FontSize, FontFamily, FontAttributes, textColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new LabelModel(Text, HorizontalTextAlignment, VerticalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new LabelModel(Text, HorizontalTextAlignment, VerticalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new LabelModel(Text, HorizontalTextAlignment, VerticalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new LabelModel(Text, HorizontalTextAlignment, VerticalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new LabelModel(Text, HorizontalTextAlignment, VerticalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new LabelModel(Text, HorizontalTextAlignment, VerticalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new LabelModel(Text, HorizontalTextAlignment, VerticalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new LabelModel(Text, HorizontalTextAlignment, VerticalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new LabelModel(Text, HorizontalTextAlignment, VerticalTextAlignment, FontSize, FontFamily, FontAttributes, TextColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (LabelModel)obj;
		return Text == o.Text && HorizontalTextAlignment == o.HorizontalTextAlignment && VerticalTextAlignment == o.VerticalTextAlignment && FontSize == o.FontSize && FontFamily == o.FontFamily && FontAttributes == o.FontAttributes && TextColor == o.TextColor && HorizontalOptions == o.HorizontalOptions && VerticalOptions == o.VerticalOptions && Margin == o.Margin && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (Text != null ? Text.GetHashCode() : 0);
		hash = hash * 37 + HorizontalTextAlignment.GetHashCode();
		hash = hash * 37 + VerticalTextAlignment.GetHashCode();
		hash = hash * 37 + FontSize.GetHashCode();
		hash = hash * 37 + (FontFamily != null ? FontFamily.GetHashCode() : 0);
		hash = hash * 37 + FontAttributes.GetHashCode();
		hash = hash * 37 + TextColor.GetHashCode();
		return hash;
	}
	public virtual Xamarin.Forms.Label CreateLabel() {
		var target = new Xamarin.Forms.Label();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.View CreateView() => CreateLabel();
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreateLabel();
	public override Xamarin.Forms.Element CreateElement() => CreateLabel();
	public virtual void Apply(Xamarin.Forms.Label target) {
		base.Apply(target);
		target.Text = Text;
		target.HorizontalTextAlignment = HorizontalTextAlignment;
		target.VerticalTextAlignment = VerticalTextAlignment;
		target.FontSize = FontSize;
		target.FontFamily = FontFamily;
		target.FontAttributes = FontAttributes;
		target.TextColor = TextColor;
	}
	public override void Apply(Xamarin.Forms.View target) {
		if (target is Xamarin.Forms.Label t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.Label t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.Label t) Apply(t);
		else base.Apply(target);
	}
}

public partial class LayoutModel : ViewModel
{
	public bool IsClippedToBounds { get; }
	public Xamarin.Forms.Thickness Padding { get; }
	public LayoutModel(bool isClippedToBounds = false, Xamarin.Forms.Thickness padding = default(Xamarin.Forms.Thickness), LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(horizontalOptions, verticalOptions, margin) {
		IsClippedToBounds = isClippedToBounds;
		Padding = padding;
	}
	public virtual LayoutModel WithIsClippedToBounds(bool isClippedToBounds) => new LayoutModel(isClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual LayoutModel WithPadding(Xamarin.Forms.Thickness padding) => new LayoutModel(IsClippedToBounds, padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new LayoutModel(IsClippedToBounds, Padding, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new LayoutModel(IsClippedToBounds, Padding, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new LayoutModel(IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new LayoutModel(IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new LayoutModel(IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new LayoutModel(IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new LayoutModel(IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new LayoutModel(IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new LayoutModel(IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (LayoutModel)obj;
		return IsClippedToBounds == o.IsClippedToBounds && Padding == o.Padding && HorizontalOptions == o.HorizontalOptions && VerticalOptions == o.VerticalOptions && Margin == o.Margin && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + IsClippedToBounds.GetHashCode();
		hash = hash * 37 + Padding.GetHashCode();
		return hash;
	}
	public virtual Xamarin.Forms.Layout CreateLayout() => throw new System.NotSupportedException("Cannot create Xamarin.Forms.Layout from " + GetType().FullName);
	public virtual void Apply(Xamarin.Forms.Layout target) {
		base.Apply(target);
		target.IsClippedToBounds = IsClippedToBounds;
		target.Padding = Padding;
	}
	public override void Apply(Xamarin.Forms.View target) {
		if (target is Xamarin.Forms.Layout t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.Layout t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.Layout t) Apply(t);
		else base.Apply(target);
	}
}

public partial class StackLayoutModel : LayoutModel
{
	public System.Collections.Generic.IList<ViewModel> Children { get; }
	public Xamarin.Forms.StackOrientation Orientation { get; }
	public double Spacing { get; }
	public StackLayoutModel(System.Collections.Generic.IList<ViewModel> children = null, Xamarin.Forms.StackOrientation orientation = Xamarin.Forms.StackOrientation.Vertical, double spacing = 6, bool isClippedToBounds = false, Xamarin.Forms.Thickness padding = default(Xamarin.Forms.Thickness), LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(isClippedToBounds, padding) {
		Children = children;
		Orientation = orientation;
		Spacing = spacing;
	}
	public virtual StackLayoutModel WithChildren(System.Collections.Generic.IList<ViewModel> children) => new StackLayoutModel(children, Orientation, Spacing, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual StackLayoutModel WithOrientation(Xamarin.Forms.StackOrientation orientation) => new StackLayoutModel(Children, orientation, Spacing, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual StackLayoutModel WithSpacing(double spacing) => new StackLayoutModel(Children, Orientation, spacing, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override LayoutModel WithIsClippedToBounds(bool isClippedToBounds) => new StackLayoutModel(Children, Orientation, Spacing, isClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override LayoutModel WithPadding(Xamarin.Forms.Thickness padding) => new StackLayoutModel(Children, Orientation, Spacing, IsClippedToBounds, padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new StackLayoutModel(Children, Orientation, Spacing, IsClippedToBounds, Padding, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new StackLayoutModel(Children, Orientation, Spacing, IsClippedToBounds, Padding, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new StackLayoutModel(Children, Orientation, Spacing, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new StackLayoutModel(Children, Orientation, Spacing, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new StackLayoutModel(Children, Orientation, Spacing, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new StackLayoutModel(Children, Orientation, Spacing, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new StackLayoutModel(Children, Orientation, Spacing, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new StackLayoutModel(Children, Orientation, Spacing, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new StackLayoutModel(Children, Orientation, Spacing, IsClippedToBounds, Padding, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (StackLayoutModel)obj;
		return Children == o.Children && Orientation == o.Orientation && Spacing == o.Spacing && IsClippedToBounds == o.IsClippedToBounds && Padding == o.Padding && HorizontalOptions == o.HorizontalOptions && VerticalOptions == o.VerticalOptions && Margin == o.Margin && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (Children != null ? Children.GetHashCode() : 0);
		hash = hash * 37 + Orientation.GetHashCode();
		hash = hash * 37 + Spacing.GetHashCode();
		return hash;
	}
	public virtual Xamarin.Forms.StackLayout CreateStackLayout() {
		var target = new Xamarin.Forms.StackLayout();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.Layout CreateLayout() => CreateStackLayout();
	public override Xamarin.Forms.View CreateView() => CreateStackLayout();
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreateStackLayout();
	public override Xamarin.Forms.Element CreateElement() => CreateStackLayout();
	public virtual void Apply(Xamarin.Forms.StackLayout target) {
		base.Apply(target);
		if (Children == null || Children.Count == 0) target.Children?.Clear();
		else {
			while (target.Children.Count > Children.Count) target.Children.RemoveAt(target.Children.Count - 1);
			var n = target.Children.Count;
			for (var i = n; i < Children.Count; i++) target.Children.Insert(i, Children[i].CreateView());
			for (var i = 0; i < n; i++) Children[i].Apply(target.Children[i]);
		}
		target.Orientation = Orientation;
		target.Spacing = Spacing;
	}
	public override void Apply(Xamarin.Forms.Layout target) {
		if (target is Xamarin.Forms.StackLayout t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.View target) {
		if (target is Xamarin.Forms.StackLayout t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.StackLayout t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.StackLayout t) Apply(t);
		else base.Apply(target);
	}
}

public partial class TimePickerModel : ViewModel
{
	public System.TimeSpan Time { get; }
	public string Format { get; }
	public Xamarin.Forms.Color TextColor { get; }
	public TimePickerModel(System.TimeSpan time = default(System.TimeSpan), string format = "t", Xamarin.Forms.Color textColor = default(Xamarin.Forms.Color), LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(horizontalOptions, verticalOptions, margin) {
		Time = time == default(System.TimeSpan) ? new System.TimeSpan(0) : time;
		Format = format;
		TextColor = textColor == default(Xamarin.Forms.Color) ? Xamarin.Forms.Color.Default : textColor;
	}
	public virtual TimePickerModel WithTime(System.TimeSpan time) => new TimePickerModel(time, Format, TextColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual TimePickerModel WithFormat(string format) => new TimePickerModel(Time, format, TextColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual TimePickerModel WithTextColor(Xamarin.Forms.Color textColor) => new TimePickerModel(Time, Format, textColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new TimePickerModel(Time, Format, TextColor, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new TimePickerModel(Time, Format, TextColor, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new TimePickerModel(Time, Format, TextColor, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new TimePickerModel(Time, Format, TextColor, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new TimePickerModel(Time, Format, TextColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new TimePickerModel(Time, Format, TextColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new TimePickerModel(Time, Format, TextColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new TimePickerModel(Time, Format, TextColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new TimePickerModel(Time, Format, TextColor, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (TimePickerModel)obj;
		return Time == o.Time && Format == o.Format && TextColor == o.TextColor && HorizontalOptions == o.HorizontalOptions && VerticalOptions == o.VerticalOptions && Margin == o.Margin && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + Time.GetHashCode();
		hash = hash * 37 + (Format != null ? Format.GetHashCode() : 0);
		hash = hash * 37 + TextColor.GetHashCode();
		return hash;
	}
	public virtual Xamarin.Forms.TimePicker CreateTimePicker() {
		var target = new Xamarin.Forms.TimePicker();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.View CreateView() => CreateTimePicker();
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreateTimePicker();
	public override Xamarin.Forms.Element CreateElement() => CreateTimePicker();
	public virtual void Apply(Xamarin.Forms.TimePicker target) {
		base.Apply(target);
		target.Time = Time;
		target.Format = Format;
		target.TextColor = TextColor;
	}
	public override void Apply(Xamarin.Forms.View target) {
		if (target is Xamarin.Forms.TimePicker t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.TimePicker t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.TimePicker t) Apply(t);
		else base.Apply(target);
	}
}

public partial class WebViewModel : ViewModel
{
	public Xamarin.Forms.WebViewSource Source { get; }
	public WebViewModel(Xamarin.Forms.WebViewSource source = null, LayoutOptionsModel horizontalOptions = null, LayoutOptionsModel verticalOptions = null, Xamarin.Forms.Thickness margin = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(horizontalOptions, verticalOptions, margin) {
		Source = source;
	}
	public virtual WebViewModel WithSource(Xamarin.Forms.WebViewSource source) => new WebViewModel(source, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithHorizontalOptions(LayoutOptionsModel horizontalOptions) => new WebViewModel(Source, horizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithVerticalOptions(LayoutOptionsModel verticalOptions) => new WebViewModel(Source, HorizontalOptions, verticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override ViewModel WithMargin(Xamarin.Forms.Thickness margin) => new WebViewModel(Source, HorizontalOptions, VerticalOptions, margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new WebViewModel(Source, HorizontalOptions, VerticalOptions, Margin, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new WebViewModel(Source, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new WebViewModel(Source, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new WebViewModel(Source, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new WebViewModel(Source, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new WebViewModel(Source, HorizontalOptions, VerticalOptions, Margin, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (WebViewModel)obj;
		return Source == o.Source && HorizontalOptions == o.HorizontalOptions && VerticalOptions == o.VerticalOptions && Margin == o.Margin && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (Source != null ? Source.GetHashCode() : 0);
		return hash;
	}
	public virtual Xamarin.Forms.WebView CreateWebView() {
		var target = new Xamarin.Forms.WebView();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.View CreateView() => CreateWebView();
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreateWebView();
	public override Xamarin.Forms.Element CreateElement() => CreateWebView();
	public virtual void Apply(Xamarin.Forms.WebView target) {
		base.Apply(target);
		target.Source = Source;
	}
	public override void Apply(Xamarin.Forms.View target) {
		if (target is Xamarin.Forms.WebView t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.WebView t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.WebView t) Apply(t);
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
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (PageModel)obj;
		return Title == o.Title && Padding == o.Padding && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
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

public partial class CarouselPageModel : PageModel
{
	public System.Collections.IEnumerable ItemsSource { get; }
	public Xamarin.Forms.DataTemplate ItemTemplate { get; }
	public System.Object SelectedItem { get; }
	public ContentPageModel CurrentPage { get; }
	public CarouselPageModel(System.Collections.IEnumerable itemsSource = null, Xamarin.Forms.DataTemplate itemTemplate = null, System.Object selectedItem = null, ContentPageModel currentPage = null, string title = "", Xamarin.Forms.Thickness padding = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(title, padding) {
		ItemsSource = itemsSource;
		ItemTemplate = itemTemplate;
		SelectedItem = selectedItem;
		CurrentPage = currentPage;
	}
	public virtual CarouselPageModel WithItemsSource(System.Collections.IEnumerable itemsSource) => new CarouselPageModel(itemsSource, ItemTemplate, SelectedItem, CurrentPage, Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual CarouselPageModel WithItemTemplate(Xamarin.Forms.DataTemplate itemTemplate) => new CarouselPageModel(ItemsSource, itemTemplate, SelectedItem, CurrentPage, Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual CarouselPageModel WithSelectedItem(System.Object selectedItem) => new CarouselPageModel(ItemsSource, ItemTemplate, selectedItem, CurrentPage, Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual CarouselPageModel WithCurrentPage(ContentPageModel currentPage) => new CarouselPageModel(ItemsSource, ItemTemplate, SelectedItem, currentPage, Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override PageModel WithTitle(string title) => new CarouselPageModel(ItemsSource, ItemTemplate, SelectedItem, CurrentPage, title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override PageModel WithPadding(Xamarin.Forms.Thickness padding) => new CarouselPageModel(ItemsSource, ItemTemplate, SelectedItem, CurrentPage, Title, padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new CarouselPageModel(ItemsSource, ItemTemplate, SelectedItem, CurrentPage, Title, Padding, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new CarouselPageModel(ItemsSource, ItemTemplate, SelectedItem, CurrentPage, Title, Padding, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new CarouselPageModel(ItemsSource, ItemTemplate, SelectedItem, CurrentPage, Title, Padding, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new CarouselPageModel(ItemsSource, ItemTemplate, SelectedItem, CurrentPage, Title, Padding, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new CarouselPageModel(ItemsSource, ItemTemplate, SelectedItem, CurrentPage, Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new CarouselPageModel(ItemsSource, ItemTemplate, SelectedItem, CurrentPage, Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (CarouselPageModel)obj;
		return ItemsSource == o.ItemsSource && ItemTemplate == o.ItemTemplate && SelectedItem == o.SelectedItem && CurrentPage == o.CurrentPage && Title == o.Title && Padding == o.Padding && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (ItemsSource != null ? ItemsSource.GetHashCode() : 0);
		hash = hash * 37 + (ItemTemplate != null ? ItemTemplate.GetHashCode() : 0);
		hash = hash * 37 + (SelectedItem != null ? SelectedItem.GetHashCode() : 0);
		hash = hash * 37 + (CurrentPage != null ? CurrentPage.GetHashCode() : 0);
		return hash;
	}
	public virtual Xamarin.Forms.CarouselPage CreateCarouselPage() {
		var target = new Xamarin.Forms.CarouselPage();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.Page CreatePage() => CreateCarouselPage();
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreateCarouselPage();
	public override Xamarin.Forms.Element CreateElement() => CreateCarouselPage();
	public virtual void Apply(Xamarin.Forms.CarouselPage target) {
		base.Apply(target);
		target.ItemsSource = ItemsSource;
		target.ItemTemplate = ItemTemplate;
		target.SelectedItem = SelectedItem;
		if (CurrentPage != null) {
			if (target.CurrentPage is Xamarin.Forms.ContentPage currentPage) CurrentPage.Apply(currentPage);
			else target.CurrentPage = CurrentPage.CreateContentPage();
		} else target.CurrentPage = null;
	}
	public override void Apply(Xamarin.Forms.Page target) {
		if (target is Xamarin.Forms.CarouselPage t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.CarouselPage t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.CarouselPage t) Apply(t);
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
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (ContentPageModel)obj;
		return Content == o.Content && Title == o.Title && Padding == o.Padding && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
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
		if (Content != null) {
			if (target.Content is Xamarin.Forms.View content) Content.Apply(content);
			else target.Content = Content.CreateView();
		} else target.Content = null;
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

public partial class MasterDetailPageModel : PageModel
{
	public PageModel Master { get; }
	public PageModel Detail { get; }
	public MasterDetailPageModel(PageModel master = null, PageModel detail = null, string title = "", Xamarin.Forms.Thickness padding = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(title, padding) {
		Master = master;
		Detail = detail;
	}
	public virtual MasterDetailPageModel WithMaster(PageModel master) => new MasterDetailPageModel(master, Detail, Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual MasterDetailPageModel WithDetail(PageModel detail) => new MasterDetailPageModel(Master, detail, Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override PageModel WithTitle(string title) => new MasterDetailPageModel(Master, Detail, title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override PageModel WithPadding(Xamarin.Forms.Thickness padding) => new MasterDetailPageModel(Master, Detail, Title, padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new MasterDetailPageModel(Master, Detail, Title, Padding, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new MasterDetailPageModel(Master, Detail, Title, Padding, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new MasterDetailPageModel(Master, Detail, Title, Padding, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new MasterDetailPageModel(Master, Detail, Title, Padding, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new MasterDetailPageModel(Master, Detail, Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new MasterDetailPageModel(Master, Detail, Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (MasterDetailPageModel)obj;
		return Master == o.Master && Detail == o.Detail && Title == o.Title && Padding == o.Padding && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (Master != null ? Master.GetHashCode() : 0);
		hash = hash * 37 + (Detail != null ? Detail.GetHashCode() : 0);
		return hash;
	}
	public virtual Xamarin.Forms.MasterDetailPage CreateMasterDetailPage() {
		var target = new Xamarin.Forms.MasterDetailPage();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.Page CreatePage() => CreateMasterDetailPage();
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreateMasterDetailPage();
	public override Xamarin.Forms.Element CreateElement() => CreateMasterDetailPage();
	public virtual void Apply(Xamarin.Forms.MasterDetailPage target) {
		base.Apply(target);
		if (Master != null) {
			if (target.Master is Xamarin.Forms.Page master) Master.Apply(master);
			else target.Master = Master.CreatePage();
		} else target.Master = null;
		if (Detail != null) {
			if (target.Detail is Xamarin.Forms.Page detail) Detail.Apply(detail);
			else target.Detail = Detail.CreatePage();
		} else target.Detail = null;
	}
	public override void Apply(Xamarin.Forms.Page target) {
		if (target is Xamarin.Forms.MasterDetailPage t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.MasterDetailPage t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.MasterDetailPage t) Apply(t);
		else base.Apply(target);
	}
}

public partial class TabbedPageModel : PageModel
{
	public System.Collections.IEnumerable ItemsSource { get; }
	public Xamarin.Forms.DataTemplate ItemTemplate { get; }
	public System.Object SelectedItem { get; }
	public TabbedPageModel(System.Collections.IEnumerable itemsSource = null, Xamarin.Forms.DataTemplate itemTemplate = null, System.Object selectedItem = null, string title = "", Xamarin.Forms.Thickness padding = default(Xamarin.Forms.Thickness), Xamarin.Forms.Color backgroundColor = default(Xamarin.Forms.Color), bool isVisible = true, double opacity = 1, double widthRequest = -1, double heightRequest = -1, bool isEnabled = true)
		: base(title, padding) {
		ItemsSource = itemsSource;
		ItemTemplate = itemTemplate;
		SelectedItem = selectedItem;
	}
	public virtual TabbedPageModel WithItemsSource(System.Collections.IEnumerable itemsSource) => new TabbedPageModel(itemsSource, ItemTemplate, SelectedItem, Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual TabbedPageModel WithItemTemplate(Xamarin.Forms.DataTemplate itemTemplate) => new TabbedPageModel(ItemsSource, itemTemplate, SelectedItem, Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public virtual TabbedPageModel WithSelectedItem(System.Object selectedItem) => new TabbedPageModel(ItemsSource, ItemTemplate, selectedItem, Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override PageModel WithTitle(string title) => new TabbedPageModel(ItemsSource, ItemTemplate, SelectedItem, title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override PageModel WithPadding(Xamarin.Forms.Thickness padding) => new TabbedPageModel(ItemsSource, ItemTemplate, SelectedItem, Title, padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithBackgroundColor(Xamarin.Forms.Color backgroundColor) => new TabbedPageModel(ItemsSource, ItemTemplate, SelectedItem, Title, Padding, backgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithIsVisible(bool isVisible) => new TabbedPageModel(ItemsSource, ItemTemplate, SelectedItem, Title, Padding, BackgroundColor, isVisible, Opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithOpacity(double opacity) => new TabbedPageModel(ItemsSource, ItemTemplate, SelectedItem, Title, Padding, BackgroundColor, IsVisible, opacity, WidthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithWidthRequest(double widthRequest) => new TabbedPageModel(ItemsSource, ItemTemplate, SelectedItem, Title, Padding, BackgroundColor, IsVisible, Opacity, widthRequest, HeightRequest, IsEnabled);
	public override VisualElementModel WithHeightRequest(double heightRequest) => new TabbedPageModel(ItemsSource, ItemTemplate, SelectedItem, Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, heightRequest, IsEnabled);
	public override VisualElementModel WithIsEnabled(bool isEnabled) => new TabbedPageModel(ItemsSource, ItemTemplate, SelectedItem, Title, Padding, BackgroundColor, IsVisible, Opacity, WidthRequest, HeightRequest, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (TabbedPageModel)obj;
		return ItemsSource == o.ItemsSource && ItemTemplate == o.ItemTemplate && SelectedItem == o.SelectedItem && Title == o.Title && Padding == o.Padding && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (ItemsSource != null ? ItemsSource.GetHashCode() : 0);
		hash = hash * 37 + (ItemTemplate != null ? ItemTemplate.GetHashCode() : 0);
		hash = hash * 37 + (SelectedItem != null ? SelectedItem.GetHashCode() : 0);
		return hash;
	}
	public virtual Xamarin.Forms.TabbedPage CreateTabbedPage() {
		var target = new Xamarin.Forms.TabbedPage();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.Page CreatePage() => CreateTabbedPage();
	public override Xamarin.Forms.VisualElement CreateVisualElement() => CreateTabbedPage();
	public override Xamarin.Forms.Element CreateElement() => CreateTabbedPage();
	public virtual void Apply(Xamarin.Forms.TabbedPage target) {
		base.Apply(target);
		target.ItemsSource = ItemsSource;
		target.ItemTemplate = ItemTemplate;
		target.SelectedItem = SelectedItem;
	}
	public override void Apply(Xamarin.Forms.Page target) {
		if (target is Xamarin.Forms.TabbedPage t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.VisualElement target) {
		if (target is Xamarin.Forms.TabbedPage t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.TabbedPage t) Apply(t);
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
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (CellModel)obj;
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

public partial class TextCellModel : CellModel
{
	public string Text { get; }
	public string Detail { get; }
	public Xamarin.Forms.Color TextColor { get; }
	public Xamarin.Forms.Color DetailColor { get; }
	public System.Windows.Input.ICommand Command { get; }
	public System.Object CommandParameter { get; }
	public TextCellModel(string text = null, string detail = null, Xamarin.Forms.Color textColor = default(Xamarin.Forms.Color), Xamarin.Forms.Color detailColor = default(Xamarin.Forms.Color), System.Windows.Input.ICommand command = null, System.Object commandParameter = null, double height = -1, bool isEnabled = true)
		: base(height, isEnabled) {
		Text = text;
		Detail = detail;
		TextColor = textColor == default(Xamarin.Forms.Color) ? Xamarin.Forms.Color.Default : textColor;
		DetailColor = detailColor == default(Xamarin.Forms.Color) ? Xamarin.Forms.Color.Default : detailColor;
		Command = command;
		CommandParameter = commandParameter;
	}
	public virtual TextCellModel WithText(string text) => new TextCellModel(text, Detail, TextColor, DetailColor, Command, CommandParameter, Height, IsEnabled);
	public virtual TextCellModel WithDetail(string detail) => new TextCellModel(Text, detail, TextColor, DetailColor, Command, CommandParameter, Height, IsEnabled);
	public virtual TextCellModel WithTextColor(Xamarin.Forms.Color textColor) => new TextCellModel(Text, Detail, textColor, DetailColor, Command, CommandParameter, Height, IsEnabled);
	public virtual TextCellModel WithDetailColor(Xamarin.Forms.Color detailColor) => new TextCellModel(Text, Detail, TextColor, detailColor, Command, CommandParameter, Height, IsEnabled);
	public virtual TextCellModel WithCommand(System.Windows.Input.ICommand command) => new TextCellModel(Text, Detail, TextColor, DetailColor, command, CommandParameter, Height, IsEnabled);
	public virtual TextCellModel WithCommandParameter(System.Object commandParameter) => new TextCellModel(Text, Detail, TextColor, DetailColor, Command, commandParameter, Height, IsEnabled);
	public override CellModel WithHeight(double height) => new TextCellModel(Text, Detail, TextColor, DetailColor, Command, CommandParameter, height, IsEnabled);
	public override CellModel WithIsEnabled(bool isEnabled) => new TextCellModel(Text, Detail, TextColor, DetailColor, Command, CommandParameter, Height, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (TextCellModel)obj;
		return Text == o.Text && Detail == o.Detail && TextColor == o.TextColor && DetailColor == o.DetailColor && Command == o.Command && CommandParameter == o.CommandParameter && Height == o.Height && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (Text != null ? Text.GetHashCode() : 0);
		hash = hash * 37 + (Detail != null ? Detail.GetHashCode() : 0);
		hash = hash * 37 + TextColor.GetHashCode();
		hash = hash * 37 + DetailColor.GetHashCode();
		hash = hash * 37 + (Command != null ? Command.GetHashCode() : 0);
		hash = hash * 37 + (CommandParameter != null ? CommandParameter.GetHashCode() : 0);
		return hash;
	}
	public virtual Xamarin.Forms.TextCell CreateTextCell() {
		var target = new Xamarin.Forms.TextCell();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.Cell CreateCell() => CreateTextCell();
	public override Xamarin.Forms.Element CreateElement() => CreateTextCell();
	public virtual void Apply(Xamarin.Forms.TextCell target) {
		base.Apply(target);
		target.Text = Text;
		target.Detail = Detail;
		target.TextColor = TextColor;
		target.DetailColor = DetailColor;
		target.Command = Command;
		target.CommandParameter = CommandParameter;
	}
	public override void Apply(Xamarin.Forms.Cell target) {
		if (target is Xamarin.Forms.TextCell t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.TextCell t) Apply(t);
		else base.Apply(target);
	}
}

public partial class ImageCellModel : TextCellModel
{
	public Xamarin.Forms.ImageSource ImageSource { get; }
	public ImageCellModel(Xamarin.Forms.ImageSource imageSource = null, string text = null, string detail = null, Xamarin.Forms.Color textColor = default(Xamarin.Forms.Color), Xamarin.Forms.Color detailColor = default(Xamarin.Forms.Color), System.Windows.Input.ICommand command = null, System.Object commandParameter = null, double height = -1, bool isEnabled = true)
		: base(text, detail, textColor, detailColor, command, commandParameter) {
		ImageSource = imageSource;
	}
	public virtual ImageCellModel WithImageSource(Xamarin.Forms.ImageSource imageSource) => new ImageCellModel(imageSource, Text, Detail, TextColor, DetailColor, Command, CommandParameter, Height, IsEnabled);
	public override TextCellModel WithText(string text) => new ImageCellModel(ImageSource, text, Detail, TextColor, DetailColor, Command, CommandParameter, Height, IsEnabled);
	public override TextCellModel WithDetail(string detail) => new ImageCellModel(ImageSource, Text, detail, TextColor, DetailColor, Command, CommandParameter, Height, IsEnabled);
	public override TextCellModel WithTextColor(Xamarin.Forms.Color textColor) => new ImageCellModel(ImageSource, Text, Detail, textColor, DetailColor, Command, CommandParameter, Height, IsEnabled);
	public override TextCellModel WithDetailColor(Xamarin.Forms.Color detailColor) => new ImageCellModel(ImageSource, Text, Detail, TextColor, detailColor, Command, CommandParameter, Height, IsEnabled);
	public override TextCellModel WithCommand(System.Windows.Input.ICommand command) => new ImageCellModel(ImageSource, Text, Detail, TextColor, DetailColor, command, CommandParameter, Height, IsEnabled);
	public override TextCellModel WithCommandParameter(System.Object commandParameter) => new ImageCellModel(ImageSource, Text, Detail, TextColor, DetailColor, Command, commandParameter, Height, IsEnabled);
	public override CellModel WithHeight(double height) => new ImageCellModel(ImageSource, Text, Detail, TextColor, DetailColor, Command, CommandParameter, height, IsEnabled);
	public override CellModel WithIsEnabled(bool isEnabled) => new ImageCellModel(ImageSource, Text, Detail, TextColor, DetailColor, Command, CommandParameter, Height, isEnabled);
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (ImageCellModel)obj;
		return ImageSource == o.ImageSource && Text == o.Text && Detail == o.Detail && TextColor == o.TextColor && DetailColor == o.DetailColor && Command == o.Command && CommandParameter == o.CommandParameter && Height == o.Height && IsEnabled == o.IsEnabled;
	}
	public override int GetHashCode() {
		var hash = base.GetHashCode();
		hash = hash * 37 + (ImageSource != null ? ImageSource.GetHashCode() : 0);
		return hash;
	}
	public virtual Xamarin.Forms.ImageCell CreateImageCell() {
		var target = new Xamarin.Forms.ImageCell();
		Apply(target);
		return target;
	}
	public override Xamarin.Forms.TextCell CreateTextCell() => CreateImageCell();
	public override Xamarin.Forms.Cell CreateCell() => CreateImageCell();
	public override Xamarin.Forms.Element CreateElement() => CreateImageCell();
	public virtual void Apply(Xamarin.Forms.ImageCell target) {
		base.Apply(target);
		target.ImageSource = ImageSource;
	}
	public override void Apply(Xamarin.Forms.TextCell target) {
		if (target is Xamarin.Forms.ImageCell t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Cell target) {
		if (target is Xamarin.Forms.ImageCell t) Apply(t);
		else base.Apply(target);
	}
	public override void Apply(Xamarin.Forms.Element target) {
		if (target is Xamarin.Forms.ImageCell t) Apply(t);
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
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (ViewCellModel)obj;
		return View == o.View && Height == o.Height && IsEnabled == o.IsEnabled;
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
		if (View != null) {
			if (target.View is Xamarin.Forms.View view) View.Apply(view);
			else target.View = View.CreateView();
		} else target.View = null;
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
	public override bool Equals(object obj) {
		if (obj == null || GetType() != obj.GetType()) return false;
		var o = (ListViewModel)obj;
		return ItemsSource == o.ItemsSource && ItemTemplate == o.ItemTemplate && SelectedItem == o.SelectedItem && SeparatorVisibility == o.SeparatorVisibility && SeparatorColor == o.SeparatorColor && HasUnevenRows == o.HasUnevenRows && RowHeight == o.RowHeight && HorizontalOptions == o.HorizontalOptions && VerticalOptions == o.VerticalOptions && Margin == o.Margin && BackgroundColor == o.BackgroundColor && IsVisible == o.IsVisible && Opacity == o.Opacity && WidthRequest == o.WidthRequest && HeightRequest == o.HeightRequest && IsEnabled == o.IsEnabled;
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
