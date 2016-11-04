using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace FlatUIKit
{
	// @interface FUITextField : UITextField
	[BaseType(typeof(UITextField))]
	interface FUITextField
	{
		// @property (assign, nonatomic) UIEdgeInsets edgeInsets __attribute__((annotate("ui_appearance_selector")));
		[Export("edgeInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets EdgeInsets { get; set; }

		// @property (nonatomic, strong) UIColor * textFieldColor __attribute__((annotate("ui_appearance_selector")));
		[Export("textFieldColor", ArgumentSemantic.Strong)]
		UIColor TextFieldColor { get; set; }

		// @property (nonatomic, strong) UIColor * borderColor __attribute__((annotate("ui_appearance_selector")));
		[Export("borderColor", ArgumentSemantic.Strong)]
		UIColor BorderColor { get; set; }

		// @property (assign, nonatomic) CGFloat borderWidth __attribute__((annotate("ui_appearance_selector")));
		[Export("borderWidth")]
		nfloat BorderWidth { get; set; }

		// @property (assign, nonatomic) CGFloat cornerRadius __attribute__((annotate("ui_appearance_selector")));
		[Export("cornerRadius")]
		nfloat CornerRadius { get; set; }
	}

	// @interface FUIAlertView : UIView
	[BaseType(typeof(UIView))]
	interface FUIAlertView
	{
		// -(id)initWithTitle:(NSString *)title message:(NSString *)message delegate:(id<FUIAlertViewDelegate>)delegate cancelButtonTitle:(NSString *)cancelButtonTitle otherButtonTitles:(NSString *)otherButtonTitles, ... __attribute__((sentinel(0, 1)));
		[Internal]
		[Export("initWithTitle:message:delegate:cancelButtonTitle:otherButtonTitles:", IsVariadic = true)]
		IntPtr Constructor(string title, string message, FUIAlertViewDelegate @delegate, string cancelButtonTitle, string otherButtonTitles, IntPtr varArgs);

		[Wrap("WeakDelegate")]
		FUIAlertViewDelegate Delegate { get; set; }

		// @property (assign, nonatomic) id<FUIAlertViewDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; set; }

		// @property (copy, nonatomic) void (^onOkAction)();
		[Export("onOkAction", ArgumentSemantic.Copy)]
		Action OnOkAction { get; set; }

		// @property (copy, nonatomic) void (^onCancelAction)();
		[Export("onCancelAction", ArgumentSemantic.Copy)]
		Action OnCancelAction { get; set; }

		// @property (copy, nonatomic) void (^onDismissAction)();
		[Export("onDismissAction", ArgumentSemantic.Copy)]
		Action OnDismissAction { get; set; }

		// @property (readonly, assign, nonatomic) NSInteger dismissButtonIndex;
		[Export("dismissButtonIndex")]
		nint DismissButtonIndex { get; }

		// @property (copy, nonatomic) NSString * title;
		[Export("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSString * message;
		[Export("message")]
		string Message { get; set; }

		// -(NSInteger)addButtonWithTitle:(NSString *)title;
		[Export("addButtonWithTitle:")]
		nint AddButtonWithTitle(string title);

		// -(NSString *)buttonTitleAtIndex:(NSInteger)buttonIndex;
		[Export("buttonTitleAtIndex:")]
		string ButtonTitleAtIndex(nint buttonIndex);

		// @property (readonly, nonatomic) NSInteger numberOfButtons;
		[Export("numberOfButtons")]
		nint NumberOfButtons { get; }

		// @property (nonatomic) NSInteger cancelButtonIndex;
		[Export("cancelButtonIndex")]
		nint CancelButtonIndex { get; set; }

		// @property (nonatomic) NSInteger maxHeight;
		[Export("maxHeight")]
		nint MaxHeight { get; set; }

		// @property (readonly, getter = isVisible, nonatomic) BOOL visible;
		[Export("visible")]
		bool Visible { [Bind("isVisible")] get; }

		// @property (assign, nonatomic) FUIAlertViewStyle alertViewStyle;
		[Export("alertViewStyle", ArgumentSemantic.Assign)]
		FUIAlertViewStyle AlertViewStyle { get; set; }

		// -(void)show;
		[Export("show")]
		void Show();

		// -(void)dismissWithClickedButtonIndex:(NSInteger)buttonIndex animated:(BOOL)animated;
		[Export("dismissWithClickedButtonIndex:animated:")]
		void DismissWithClickedButtonIndex(nint buttonIndex, bool animated);

		// -(void)clickButtonAtIndex:(NSInteger)buttonIndex;
		[Export("clickButtonAtIndex:")]
		void ClickButtonAtIndex(nint buttonIndex);

		// -(FUITextField *)textFieldAtIndex:(NSInteger)textFieldIndex;
		[Export("textFieldAtIndex:")]
		FUITextField TextFieldAtIndex(nint textFieldIndex);

		// @property (nonatomic, strong) NSMutableArray * buttons;
		[Export("buttons", ArgumentSemantic.Strong)]
		NSMutableArray Buttons { get; set; }

		// @property (readonly, nonatomic, weak) UILabel * titleLabel;
		[Export("titleLabel", ArgumentSemantic.Weak)]
		UILabel TitleLabel { get; }

		// @property (readonly, nonatomic, weak) UILabel * messageLabel;
		[Export("messageLabel", ArgumentSemantic.Weak)]
		UILabel MessageLabel { get; }

		// @property (readonly, nonatomic, weak) UIView * backgroundOverlay;
		[Export("backgroundOverlay", ArgumentSemantic.Weak)]
		UIView BackgroundOverlay { get; }

		// @property (readonly, nonatomic, weak) UIView * alertContainer;
		[Export("alertContainer", ArgumentSemantic.Weak)]
		UIView AlertContainer { get; }

		// @property (nonatomic) CGFloat buttonSpacing __attribute__((annotate("ui_appearance_selector")));
		[Export("buttonSpacing")]
		nfloat ButtonSpacing { get; set; }

		// @property (nonatomic) CGFloat animationDuration __attribute__((annotate("ui_appearance_selector")));
		[Export("animationDuration")]
		nfloat AnimationDuration { get; set; }

		// @property (nonatomic) BOOL hasCancelButton;
		[Export("hasCancelButton")]
		bool HasCancelButton { get; set; }

		// @property (nonatomic, strong) UIFont * defaultButtonFont __attribute__((annotate("ui_appearance_selector")));
		[Export("defaultButtonFont", ArgumentSemantic.Strong)]
		UIFont DefaultButtonFont { get; set; }

		// @property (nonatomic, strong) UIColor * defaultButtonTitleColor __attribute__((annotate("ui_appearance_selector")));
		[Export("defaultButtonTitleColor", ArgumentSemantic.Strong)]
		UIColor DefaultButtonTitleColor { get; set; }

		// @property (nonatomic, strong) UIColor * defaultButtonColor __attribute__((annotate("ui_appearance_selector")));
		[Export("defaultButtonColor", ArgumentSemantic.Strong)]
		UIColor DefaultButtonColor { get; set; }

		// @property (nonatomic, strong) UIColor * defaultButtonShadowColor __attribute__((annotate("ui_appearance_selector")));
		[Export("defaultButtonShadowColor", ArgumentSemantic.Strong)]
		UIColor DefaultButtonShadowColor { get; set; }

		// @property (readwrite, nonatomic) CGFloat defaultButtonCornerRadius __attribute__((annotate("ui_appearance_selector")));
		[Export("defaultButtonCornerRadius")]
		nfloat DefaultButtonCornerRadius { get; set; }

		// @property (readwrite, nonatomic) CGFloat defaultButtonShadowHeight __attribute__((annotate("ui_appearance_selector")));
		[Export("defaultButtonShadowHeight")]
		nfloat DefaultButtonShadowHeight { get; set; }
	}

	// @protocol FUIAlertViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface FUIAlertViewDelegate
	{
		// @optional -(void)alertView:(FUIAlertView *)alertView clickedButtonAtIndex:(NSInteger)buttonIndex;
		[Export("alertView:clickedButtonAtIndex:")]
		void AlertView(FUIAlertView alertView, nint buttonIndex);

		// @optional -(void)willPresentAlertView:(FUIAlertView *)alertView;
		[Export("willPresentAlertView:")]
		void WillPresentAlertView(FUIAlertView alertView);

		// @optional -(void)didPresentAlertView:(FUIAlertView *)alertView;
		[Export("didPresentAlertView:")]
		void DidPresentAlertView(FUIAlertView alertView);

	}

	// @interface FUIButton : UIButton
	[BaseType(typeof(UIButton))]
	interface FUIButton
	{
		// @property (readwrite, nonatomic, strong) UIColor * buttonColor __attribute__((annotate("ui_appearance_selector")));
		[Export("buttonColor", ArgumentSemantic.Strong)]
		UIColor ButtonColor { get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * shadowColor __attribute__((annotate("ui_appearance_selector")));
		[Export("shadowColor", ArgumentSemantic.Strong)]
		UIColor ShadowColor { get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * highlightedColor __attribute__((annotate("ui_appearance_selector")));
		[Export("highlightedColor", ArgumentSemantic.Strong)]
		UIColor HighlightedColor { get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * disabledColor __attribute__((annotate("ui_appearance_selector")));
		[Export("disabledColor", ArgumentSemantic.Strong)]
		UIColor DisabledColor { get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * disabledShadowColor __attribute__((annotate("ui_appearance_selector")));
		[Export("disabledShadowColor", ArgumentSemantic.Strong)]
		UIColor DisabledShadowColor { get; set; }

		// @property (readwrite, nonatomic) CGFloat shadowHeight __attribute__((annotate("ui_appearance_selector")));
		[Export("shadowHeight")]
		nfloat ShadowHeight { get; set; }

		//[Static]
		//// @property (readwrite, nonatomic) CGFloat cornerRadius __attribute__((annotate("ui_appearance_selector")));
		[Export("cornerRadius")]
		nfloat CornerRadius { get; set; }
	}

	// @interface FUICellBackgroundView : UIView
	[BaseType(typeof(UIView))]
	interface FUICellBackgroundView
	{
		// @property (nonatomic, strong) UIColor * backgroundColor __attribute__((annotate("ui_appearance_selector")));
		[Export("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic) CGFloat cornerRadius __attribute__((annotate("ui_appearance_selector")));
		[Export("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (nonatomic, strong) UIColor * separatorColor __attribute__((annotate("ui_appearance_selector")));
		[Export("separatorColor", ArgumentSemantic.Strong)]
		UIColor SeparatorColor { get; set; }

		//// @property (nonatomic) CGFloat separatorHeight __attribute__((annotate("ui_appearance_selector")));
		//[Static]
		[Export("separatorHeight")]
		nfloat SeparatorHeight { get; set; }

		// @property (nonatomic) UIRectCorner roundedCorners;
		[Export("roundedCorners", ArgumentSemantic.Assign)]
		UIRectCorner RoundedCorners { get; set; }
	}

	// @interface FUIPopoverBackgroundView : UIPopoverBackgroundView
	[BaseType(typeof(UIPopoverBackgroundView))]
	interface FUIPopoverBackgroundView
	{
		// +(void)setBackgroundColor:(UIColor *)backgroundColor;
		[Static]
		[Export("setBackgroundColor:")]
		void SetBackgroundColor(UIColor backgroundColor);

		// +(void)setCornerRadius:(CGFloat)cornerRadius;
		[Static]
		[Export("setCornerRadius:")]
		void SetCornerRadius(nfloat cornerRadius);
	}

	// @interface FUISegmentedControl : UISegmentedControl
	[BaseType(typeof(UISegmentedControl))]
	interface FUISegmentedControl
	{
		// @property (readwrite, nonatomic, strong) UIColor * selectedColor __attribute__((annotate("ui_appearance_selector")));
		[Export("selectedColor", ArgumentSemantic.Strong)]
		UIColor SelectedColor { get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * disabledColor __attribute__((annotate("ui_appearance_selector")));
		[Export("disabledColor", ArgumentSemantic.Strong)]
		UIColor DisabledColor { get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * deselectedColor __attribute__((annotate("ui_appearance_selector")));
		[Export("deselectedColor", ArgumentSemantic.Strong)]
		UIColor DeselectedColor { get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * highlightedColor __attribute__((annotate("ui_appearance_selector")));
		[Export("highlightedColor", ArgumentSemantic.Strong)]
		UIColor HighlightedColor { get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * dividerColor __attribute__((annotate("ui_appearance_selector")));
		[Export("dividerColor", ArgumentSemantic.Strong)]
		UIColor DividerColor { get; set; }

		// @property (readwrite, nonatomic) CGFloat cornerRadius __attribute__((annotate("ui_appearance_selector")));
		[Export("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (readwrite, nonatomic, strong) UIFont * selectedFont __attribute__((annotate("ui_appearance_selector")));
		[Export("selectedFont", ArgumentSemantic.Strong)]
		UIFont SelectedFont { get; set; }

		// @property (readwrite, nonatomic, strong) UIFont * disabledFont __attribute__((annotate("ui_appearance_selector")));
		[Export("disabledFont", ArgumentSemantic.Strong)]
		UIFont DisabledFont { get; set; }

		// @property (readwrite, nonatomic, strong) UIFont * deselectedFont __attribute__((annotate("ui_appearance_selector")));
		[Export("deselectedFont", ArgumentSemantic.Strong)]
		UIFont DeselectedFont { get; set; }

		// @property (readwrite, nonatomic, strong) UIFont * highlightedFont __attribute__((annotate("ui_appearance_selector")));
		[Export("highlightedFont", ArgumentSemantic.Strong)]
		UIFont HighlightedFont { get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * selectedFontColor __attribute__((annotate("ui_appearance_selector")));
		[Export("selectedFontColor", ArgumentSemantic.Strong)]
		UIColor SelectedFontColor { get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * deselectedFontColor __attribute__((annotate("ui_appearance_selector")));
		[Export("deselectedFontColor", ArgumentSemantic.Strong)]
		UIColor DeselectedFontColor { get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * disabledFontColor __attribute__((annotate("ui_appearance_selector")));
		[Export("disabledFontColor", ArgumentSemantic.Strong)]
		UIColor DisabledFontColor { get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * highlightedFontColor __attribute__((annotate("ui_appearance_selector")));
		[Export("highlightedFontColor", ArgumentSemantic.Strong)]
		UIColor HighlightedFontColor { get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * borderColor __attribute__((annotate("ui_appearance_selector")));
		[Export("borderColor", ArgumentSemantic.Strong)]
		UIColor BorderColor { get; set; }

		// @property (readwrite, nonatomic) CGFloat borderWidth __attribute__((annotate("ui_appearance_selector")));
		[Export("borderWidth")]
		nfloat BorderWidth { get; set; }
	}

	// @interface FUISwitch : UIControl
	[BaseType(typeof(UIControl))]
	interface FUISwitch
	{
		// @property (getter = isOn, nonatomic) BOOL on;
		[Export("on")]
		bool On { [Bind("isOn")] get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * onBackgroundColor __attribute__((annotate("ui_appearance_selector")));
		[Export("onBackgroundColor", ArgumentSemantic.Strong)]
		UIColor OnBackgroundColor { get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * offBackgroundColor __attribute__((annotate("ui_appearance_selector")));
		[Export("offBackgroundColor", ArgumentSemantic.Strong)]
		UIColor OffBackgroundColor { get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * onColor __attribute__((annotate("ui_appearance_selector")));
		[Export("onColor", ArgumentSemantic.Strong)]
		UIColor OnColor { get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * offColor __attribute__((annotate("ui_appearance_selector")));
		[Export("offColor", ArgumentSemantic.Strong)]
		UIColor OffColor { get; set; }

		// @property (readwrite, nonatomic, strong) UIColor * highlightedColor __attribute__((annotate("ui_appearance_selector")));
		[Export("highlightedColor", ArgumentSemantic.Strong)]
		UIColor HighlightedColor { get; set; }

		// @property (readwrite, nonatomic) CGFloat switchCornerRadius __attribute__((annotate("ui_appearance_selector")));
		[Export("switchCornerRadius")]
		nfloat SwitchCornerRadius { get; set; }

		// @property (readwrite, nonatomic) CGFloat percentOn;
		[Export("percentOn")]
		nfloat PercentOn { get; set; }

		// @property (readwrite, nonatomic, weak) UILabel * offLabel;
		[Export("offLabel", ArgumentSemantic.Weak)]
		UILabel OffLabel { get; set; }

		// @property (readwrite, nonatomic, weak) UILabel * onLabel;
		[Export("onLabel", ArgumentSemantic.Weak)]
		UILabel OnLabel { get; set; }

		// -(void)setOn:(BOOL)on animated:(BOOL)animated;
		[Export("setOn:animated:")]
		void SetOn(bool on, bool animated);
	}

	// @interface FlatUI (UIBarButtonItem)
	[Category]
	[BaseType(typeof(UIBarButtonItem))]
	interface UIBarButtonItem_FlatUI
	{
		// -(void)configureFlatButtonWithColor:(UIColor *)color highlightedColor:(UIColor *)highlightedColor cornerRadius:(CGFloat)cornerRadius __attribute__((annotate("ui_appearance_selector")));
		[Export("configureFlatButtonWithColor:highlightedColor:cornerRadius:")]
		void ConfigureFlatButtonWithColor(UIColor color, UIColor highlightedColor, nfloat cornerRadius);

		// +(void)configureFlatButtonsWithColor:(UIColor *)color highlightedColor:(UIColor *)highlightedColor cornerRadius:(CGFloat)cornerRadius whenContainedIn:(Class<UIAppearanceContainer>)containerClass, ... __attribute__((sentinel(0, 1)));
		[Static, Internal]
		[Export("configureFlatButtonsWithColor:highlightedColor:cornerRadius:whenContainedIn:", IsVariadic = true)]
		void ConfigureFlatButtonsWithColor(UIColor color, UIColor highlightedColor, nfloat cornerRadius, UIAppearanceContainer containerClass, IntPtr varArgs);

		// +(void)configureFlatButtonsWithColor:(UIColor *)color highlightedColor:(UIColor *)highlightedColor cornerRadius:(CGFloat)cornerRadius;
		[Static]
		[Export("configureFlatButtonsWithColor:highlightedColor:cornerRadius:")]
		void ConfigureFlatButtonsWithColor(UIColor color, UIColor highlightedColor, nfloat cornerRadius);

		// -(void)removeTitleShadow;
		[Export("removeTitleShadow")]
		void RemoveTitleShadow();
	}

	// @interface FlatUI (UIColor)
	[Category]
	[BaseType(typeof(UIColor))]
	interface UIColor_FlatUI
	{
		// +(UIColor *)colorFromHexCode:(NSString *)hexString;
		[Static]
		[Export("colorFromHexCode:")]
		UIColor ColorFromHexCode(string hexString);

		// +(UIColor *)turquoiseColor;
		[Static]
		[Export("turquoiseColor")]
		UIColor TurquoiseColor { get; }

		// +(UIColor *)greenSeaColor;
		[Static]
		[Export("greenSeaColor")]
		UIColor GreenSeaColor { get; }

		// +(UIColor *)emerlandColor;
		[Static]
		[Export("emerlandColor")]
		UIColor EmerlandColor { get; }

		// +(UIColor *)nephritisColor;
		[Static]
		[Export("nephritisColor")]
		UIColor NephritisColor { get; }

		// +(UIColor *)peterRiverColor;
		[Static]
		[Export("peterRiverColor")]
		UIColor PeterRiverColor { get; }

		// +(UIColor *)belizeHoleColor;
		[Static]
		[Export("belizeHoleColor")]
		UIColor BelizeHoleColor { get; }

		// +(UIColor *)amethystColor;
		[Static]
		[Export("amethystColor")]
		UIColor AmethystColor { get; }

		// +(UIColor *)wisteriaColor;
		[Static]
		[Export("wisteriaColor")]
		UIColor WisteriaColor { get; }

		// +(UIColor *)wetAsphaltColor;
		[Static]
		[Export("wetAsphaltColor")]
		UIColor WetAsphaltColor { get; }

		// +(UIColor *)midnightBlueColor;
		[Static]
		[Export("midnightBlueColor")]
		UIColor MidnightBlueColor { get; }

		// +(UIColor *)sunflowerColor;
		[Static]
		[Export("sunflowerColor")]
		UIColor SunflowerColor { get; }

		// +(UIColor *)tangerineColor;
		[Static]
		[Export("tangerineColor")]
		UIColor TangerineColor { get; }

		// +(UIColor *)carrotColor;
		[Static]
		[Export("carrotColor")]
		UIColor CarrotColor { get; }

		// +(UIColor *)pumpkinColor;
		[Static]
		[Export("pumpkinColor")]
		UIColor PumpkinColor { get; }

		// +(UIColor *)alizarinColor;
		[Static]
		[Export("alizarinColor")]
		UIColor AlizarinColor { get; }

		// +(UIColor *)pomegranateColor;
		[Static]
		[Export("pomegranateColor")]
		UIColor PomegranateColor { get; }

		// +(UIColor *)cloudsColor;
		[Static]
		[Export("cloudsColor")]
		UIColor CloudsColor { get; }

		// +(UIColor *)silverColor;
		[Static]
		[Export("silverColor")]
		UIColor SilverColor { get; }

		// +(UIColor *)concreteColor;
		[Static]
		[Export("concreteColor")]
		UIColor ConcreteColor { get; }

		// +(UIColor *)asbestosColor;
		[Static]
		[Export("asbestosColor")]
		UIColor AsbestosColor { get; }

		// +(UIColor *)blendedColorWithForegroundColor:(UIColor *)foregroundColor backgroundColor:(UIColor *)backgroundColor percentBlend:(CGFloat)percentBlend;
		[Static]
		[Export("blendedColorWithForegroundColor:backgroundColor:percentBlend:")]
		UIColor BlendedColorWithForegroundColor(UIColor foregroundColor, UIColor backgroundColor, nfloat percentBlend);
	}

	// @interface FlatUI (UIFont)
	[Category]
	[BaseType(typeof(UIFont))]
	interface UIFont_FlatUI
	{
		// +(UIFont *)flatFontOfSize:(CGFloat)size;
		[Static]
		[Export("flatFontOfSize:")]
		UIFont FlatFontOfSize(nfloat size);

		// +(UIFont *)boldFlatFontOfSize:(CGFloat)size;
		[Static]
		[Export("boldFlatFontOfSize:")]
		UIFont BoldFlatFontOfSize(nfloat size);

		// +(UIFont *)italicFlatFontOfSize:(CGFloat)size;
		[Static]
		[Export("italicFlatFontOfSize:")]
		UIFont ItalicFlatFontOfSize(nfloat size);

		// +(UIFont *)lightFlatFontOfSize:(CGFloat)size;
		[Static]
		[Export("lightFlatFontOfSize:")]
		UIFont LightFlatFontOfSize(nfloat size);

		// +(UIFont *)iconFontWithSize:(CGFloat)size;
		[Static]
		[Export("iconFontWithSize:")]
		UIFont IconFontWithSize(nfloat size);
	}

	// @interface FlatUI (UIImage)
	[Category]
	[BaseType(typeof(UIImage))]
	interface UIImage_FlatUI
	{
		// +(UIImage *)imageWithColor:(UIColor *)color cornerRadius:(CGFloat)cornerRadius;
		[Static]
		[Export("imageWithColor:cornerRadius:")]
		UIImage ImageWithColor(UIColor color, nfloat cornerRadius);

		// +(UIImage *)buttonImageWithColor:(UIColor *)color cornerRadius:(CGFloat)cornerRadius shadowColor:(UIColor *)shadowColor shadowInsets:(UIEdgeInsets)shadowInsets;
		[Static]
		[Export("buttonImageWithColor:cornerRadius:shadowColor:shadowInsets:")]
		UIImage ButtonImageWithColor(UIColor color, nfloat cornerRadius, UIColor shadowColor, UIEdgeInsets shadowInsets);

		// +(UIImage *)circularImageWithColor:(UIColor *)color size:(CGSize)size;
		[Static]
		[Export("circularImageWithColor:size:")]
		UIImage CircularImageWithColor(UIColor color, CGSize size);

		// -(UIImage *)imageWithMinimumSize:(CGSize)size;
		[Export("imageWithMinimumSize:")]
		UIImage ImageWithMinimumSize(CGSize size);

		// +(UIImage *)stepperPlusImageWithColor:(UIColor *)color;
		[Static]
		[Export("stepperPlusImageWithColor:")]
		UIImage StepperPlusImageWithColor(UIColor color);

		// +(UIImage *)stepperMinusImageWithColor:(UIColor *)color;
		[Static]
		[Export("stepperMinusImageWithColor:")]
		UIImage StepperMinusImageWithColor(UIColor color);

		// +(UIImage *)backButtonImageWithColor:(UIColor *)color barMetrics:(UIBarMetrics)metrics cornerRadius:(CGFloat)cornerRadius;
		[Static]
		[Export("backButtonImageWithColor:barMetrics:cornerRadius:")]
		UIImage BackButtonImageWithColor(UIColor color, UIBarMetrics metrics, nfloat cornerRadius);
	}

	// @interface FlatUI (UINavigationBar)
	[Category]
	[BaseType(typeof(UINavigationBar))]
	interface UINavigationBar_FlatUI
	{
		// -(void)configureFlatNavigationBarWithColor:(UIColor *)color __attribute__((annotate("ui_appearance_selector")));
		[Export("configureFlatNavigationBarWithColor:")]
		void ConfigureFlatNavigationBarWithColor(UIColor color);
	}

	// @interface FlatUI (UIProgressView)
	[Category]
	[BaseType(typeof(UIProgressView))]
	interface UIProgressView_FlatUI
	{
		// -(void)configureFlatProgressViewWithTrackColor:(UIColor *)trackColor __attribute__((annotate("ui_appearance_selector")));
		[Export("configureFlatProgressViewWithTrackColor:")]
		void ConfigureFlatProgressViewWithTrackColor(UIColor trackColor);

		// -(void)configureFlatProgressViewWithProgressColor:(UIColor *)progressColor __attribute__((annotate("ui_appearance_selector")));
		[Export("configureFlatProgressViewWithProgressColor:")]
		void ConfigureFlatProgressViewWithProgressColor(UIColor progressColor);

		// -(void)configureFlatProgressViewWithTrackColor:(UIColor *)trackColor progressColor:(UIColor *)progressColor;
		[Export("configureFlatProgressViewWithTrackColor:progressColor:")]
		void ConfigureFlatProgressViewWithTrackColor(UIColor trackColor, UIColor progressColor);
	}

	// @interface FlatUI (UIStepper)
	[Category]
	[BaseType(typeof(UIStepper))]
	interface UIStepper_FlatUI
	{
		// -(void)configureFlatStepperWithColor:(UIColor *)color highlightedColor:(UIColor *)highlightedColor disabledColor:(UIColor *)disabledColor iconColor:(UIColor *)iconColor;
		[Export("configureFlatStepperWithColor:highlightedColor:disabledColor:iconColor:")]
		void ConfigureFlatStepperWithColor(UIColor color, UIColor highlightedColor, UIColor disabledColor, UIColor iconColor);
	}

	// @interface FlatUI (UISlider)
	[Category]
	[BaseType(typeof(UISlider))]
	interface UISlider_FlatUI
	{
		// -(void)configureFlatSliderWithTrackColor:(UIColor *)trackColor progressColor:(UIColor *)progressColor thumbColor:(UIColor *)thumbColor;
		[Export("configureFlatSliderWithTrackColor:progressColor:thumbColor:")]
		void ConfigureFlatSliderWithTrackColor(UIColor trackColor, UIColor progressColor, UIColor thumbColor);

		// -(void)configureFlatSliderWithTrackColor:(UIColor *)trackColor progressColor:(UIColor *)progressColor thumbColorNormal:(UIColor *)thumbColorNormal thumbColorHighlighted:(UIColor *)highlightedThumbColor;
		[Export("configureFlatSliderWithTrackColor:progressColor:thumbColorNormal:thumbColorHighlighted:")]
		void ConfigureFlatSliderWithTrackColor(UIColor trackColor, UIColor progressColor, UIColor thumbColorNormal, UIColor highlightedThumbColor);
	}

	// @interface FlatUI (UITabBar)
	[Category]
	[BaseType(typeof(UITabBar))]
	interface UITabBar_FlatUI
	{
		// -(void)configureFlatTabBarWithColor:(UIColor *)color __attribute__((annotate("ui_appearance_selector")));
		[Export("configureFlatTabBarWithColor:")]
		void ConfigureFlatTabBarWithColor(UIColor color);

		// -(void)configureFlatTabBarWithSelectedColor:(UIColor *)selectedColor __attribute__((annotate("ui_appearance_selector")));
		[Export("configureFlatTabBarWithSelectedColor:")]
		void ConfigureFlatTabBarWithSelectedColor(UIColor selectedColor);

		// -(void)configureFlatTabBarWithColor:(UIColor *)color selectedColor:(UIColor *)selectedColor;
		[Export("configureFlatTabBarWithColor:selectedColor:")]
		void ConfigureFlatTabBarWithColor(UIColor color, UIColor selectedColor);
	}

	// @interface FlatUI (UITableViewCell)
	[Category]
	[BaseType(typeof(UITableViewCell))]
	interface UITableViewCell_FlatUI
	{
		//// @property (nonatomic) CGFloat cornerRadius;
		//[Export("cornerRadius")]
		//nfloat CornerRadius { get; set; }

		//// @property (nonatomic) CGFloat separatorHeight;
		//[Export("separatorHeight")]
		//nfloat SeparatorHeight { get; set; }

		// -(void)configureFlatCellWithColor:(UIColor *)color selectedColor:(UIColor *)selectedColor;
		[Export("configureFlatCellWithColor:selectedColor:")]
		void ConfigureFlatCellWithColor(UIColor color, UIColor selectedColor);

		// -(void)configureFlatCellWithColor:(UIColor *)color selectedColor:(UIColor *)selectedColor roundingCorners:(UIRectCorner)corners;
		[Export("configureFlatCellWithColor:selectedColor:roundingCorners:")]
		void ConfigureFlatCellWithColor(UIColor color, UIColor selectedColor, UIRectCorner corners);
	}

	// @interface FlatUI (UIToolbar)
	[Category]
	[BaseType(typeof(UIToolbar))]
	interface UIToolbar_FlatUI
	{
		// -(void)configureFlatToolbarWithColor:(UIColor *)color __attribute__((annotate("ui_appearance_selector")));
		[Export("configureFlatToolbarWithColor:")]
		void ConfigureFlatToolbarWithColor(UIColor color);
	}

	// @interface Icons (NSString)
	[Category]
	[BaseType(typeof(NSString))]
	interface NSString_Icons
	{
		// +(NSString *)iconStringForEnum:(FlatUIIcon)value;
		[Static]
		[Export("iconStringForEnum:")]
		string IconStringForEnum(FlatUIIcon value);

		// +(NSArray *)iconUnicodeStrings;
		[Static]
		[Export("iconUnicodeStrings")]
		NSObject[] IconUnicodeStrings { get; }
	}

	// @interface FlatUI (UIPopoverController)
	[Category]
	[BaseType(typeof(UIPopoverController))]
	interface UIPopoverController_FlatUI
	{
		// -(void)configureFlatPopoverWithBackgroundColor:(UIColor *)backgroundColor cornerRadius:(CGFloat)cornerRadius;
		[Export("configureFlatPopoverWithBackgroundColor:cornerRadius:")]
		void ConfigureFlatPopoverWithBackgroundColor(UIColor backgroundColor, nfloat cornerRadius);
	}
}
