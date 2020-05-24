// <autogenerated />
// Xaml Source Generation is using the System Xaml Parser
#pragma warning disable 618  // Ignore obsolete members warnings
#pragma warning disable 105  // Ignore duplicate namespaces
#pragma warning disable 1591 // Ignore missing XML comment warnings
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using Wiki.Droid;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#elif __WASM__
using _View = Windows.UI.Xaml.UIElement;
#elif NET461
using _View = Windows.UI.Xaml.UIElement;
#endif

namespace Wiki.Shared.UserControls
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	public sealed partial class ClaimObject : Windows.UI.Xaml.Controls.UserControl
	{
		public Windows.UI.Xaml.Controls.StackPanel GetContent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 1:2)
			Windows.UI.Xaml.Controls.StackPanel content = 			new global::Windows.UI.Xaml.Controls.StackPanel
			{
				Orientation = global::Windows.UI.Xaml.Controls.Orientation.Vertical,
				// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 18:6)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.TextBlock
					{
						FontStyle = global::Windows.UI.Text.FontStyle.Italic,
						FontSize = 12d,
						Margin = new global::Windows.UI.Xaml.Thickness(0,0,0,5),
						// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 20:10)
						Inlines = 
						{
							new global::Windows.UI.Xaml.Documents.Run
							{
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 25:18)
								Text = "("							}
							,
							new global::Windows.UI.Xaml.Documents.Run
							{
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 25:30)
							}
							.ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply((ClaimObject_7f81f1628f6d6cc6747507ee800b7b3eXamlApplyExtensions.XamlApplyHandler0)(c0 => 
							{
								c0.SetBinding(global::Windows.UI.Xaml.Documents.Run.TextProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"ClaimData.Rank", CompiledSource = this });
															}
							))
							,
							new global::Windows.UI.Xaml.Documents.Run
							{
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 25:67)
								Text = ")"							}
							,
						}
					}
					.ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply((ClaimObject_7f81f1628f6d6cc6747507ee800b7b3eXamlApplyExtensions.XamlApplyHandler1)(c1 => 
					{
						c1.Foreground = (Windows.UI.Xaml.Media.Brush)global::Wiki.Droid.GlobalStaticResources.Gray;
						
						c1.SetBinding(global::Windows.UI.Xaml.Controls.TextBlock.VisibilityProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"ClaimData.Rank", Converter = (Windows.UI.Xaml.Data.IValueConverter)StaticResources.StringIsEmptyToBoolConverter, CompiledSource = this });
												global::Uno.UI.FrameworkElementHelper.SetBaseUri(c1, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/ClaimObject.xaml");
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.ContentControl
					{
						Background = SolidColorBrushHelper.Transparent,
						Margin = new global::Windows.UI.Xaml.Thickness(0,0,0,5),
						// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 28:10)
					}
					.ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply((ClaimObject_7f81f1628f6d6cc6747507ee800b7b3eXamlApplyExtensions.XamlApplyHandler2)(c3 => 
					{
						c3.SetBinding(global::Windows.UI.Xaml.Controls.ContentControl.ContentProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"InnerContent", CompiledSource = this });
												global::Uno.UI.FrameworkElementHelper.SetBaseUri(c3, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/ClaimObject.xaml");
					}
					))
					,
					new global::Wiki.Shared.UserControls.Panel
					{
						Margin = new global::Windows.UI.Xaml.Thickness(0,0,0,5),
						Header = 						new global::Windows.UI.Xaml.Controls.TextBlock
						{
							// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 35:18)
							Inlines = 
							{
								new global::Windows.UI.Xaml.Documents.Run
								{
									Text = "Qualifiers(",
									// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 36:22)
								}
								,
								new global::Windows.UI.Xaml.Documents.Run
								{
									// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 36:47)
								}
								.ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply((ClaimObject_7f81f1628f6d6cc6747507ee800b7b3eXamlApplyExtensions.XamlApplyHandler0)(c5 => 
								{
									c5.SetBinding(global::Windows.UI.Xaml.Documents.Run.TextProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"ClaimData.Qualifiers.Count", CompiledSource = this });
																	}
								))
								,
								new global::Windows.UI.Xaml.Documents.Run
								{
									// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 36:96)
									Text = ")"								}
								,
							}
						}
						.ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply((ClaimObject_7f81f1628f6d6cc6747507ee800b7b3eXamlApplyExtensions.XamlApplyHandler1)(c6 => 
						{
							c6.Foreground = (Windows.UI.Xaml.Media.Brush)global::Wiki.Droid.GlobalStaticResources.ButtonLightGray;
							
							global::Uno.UI.FrameworkElementHelper.SetBaseUri(c6, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/ClaimObject.xaml");
						}
						))
						,
						InnerContent = 						new global::Wiki.Shared.UserControls.Qualifiers
						{
							// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 40:18)
						}
						.ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply((ClaimObject_7f81f1628f6d6cc6747507ee800b7b3eXamlApplyExtensions.XamlApplyHandler3)(c8 => 
						{
							c8.SetBinding(global::Wiki.Shared.UserControls.Qualifiers.ValuesProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"ClaimData.Qualifiers", CompiledSource = this });
														global::Uno.UI.FrameworkElementHelper.SetBaseUri(c8, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/ClaimObject.xaml");
						}
						))
						,
						// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 32:10)
					}
					.ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply((ClaimObject_7f81f1628f6d6cc6747507ee800b7b3eXamlApplyExtensions.XamlApplyHandler4)(c9 => 
					{
						c9.SetBinding(global::Wiki.Shared.UserControls.Panel.VisibilityProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"ClaimData.Qualifiers", Converter = (Windows.UI.Xaml.Data.IValueConverter)StaticResources.CollectionIsEmptyToBoolConverter, CompiledSource = this });
												global::Uno.UI.FrameworkElementHelper.SetBaseUri(c9, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/ClaimObject.xaml");
					}
					))
					,
					new global::Wiki.Shared.UserControls.Panel
					{
						Header = 						new global::Windows.UI.Xaml.Controls.TextBlock
						{
							// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 46:18)
							Inlines = 
							{
								new global::Windows.UI.Xaml.Documents.Run
								{
									Text = "References(",
									// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 47:22)
								}
								,
								new global::Windows.UI.Xaml.Documents.Run
								{
									// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 47:47)
								}
								.ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply((ClaimObject_7f81f1628f6d6cc6747507ee800b7b3eXamlApplyExtensions.XamlApplyHandler0)(c11 => 
								{
									c11.SetBinding(global::Windows.UI.Xaml.Documents.Run.TextProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"ClaimData.References.Count", CompiledSource = this });
																	}
								))
								,
								new global::Windows.UI.Xaml.Documents.Run
								{
									// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 47:96)
									Text = ")"								}
								,
							}
						}
						.ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply((ClaimObject_7f81f1628f6d6cc6747507ee800b7b3eXamlApplyExtensions.XamlApplyHandler1)(c12 => 
						{
							c12.Foreground = (Windows.UI.Xaml.Media.Brush)global::Wiki.Droid.GlobalStaticResources.ButtonLightGray;
							
							global::Uno.UI.FrameworkElementHelper.SetBaseUri(c12, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/ClaimObject.xaml");
						}
						))
						,
						InnerContent = 						new global::Wiki.Shared.UserControls.References
						{
							// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 51:18)
						}
						.ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply((ClaimObject_7f81f1628f6d6cc6747507ee800b7b3eXamlApplyExtensions.XamlApplyHandler5)(c14 => 
						{
							c14.SetBinding(global::Wiki.Shared.UserControls.References.ValuesProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"ClaimData.References", CompiledSource = this });
														global::Uno.UI.FrameworkElementHelper.SetBaseUri(c14, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/ClaimObject.xaml");
						}
						))
						,
						// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 44:10)
					}
					.ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply((ClaimObject_7f81f1628f6d6cc6747507ee800b7b3eXamlApplyExtensions.XamlApplyHandler4)(c15 => 
					{
						c15.SetBinding(global::Wiki.Shared.UserControls.Panel.VisibilityProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"ClaimData.References", Converter = (Windows.UI.Xaml.Data.IValueConverter)StaticResources.CollectionIsEmptyToBoolConverter, CompiledSource = this });
												global::Uno.UI.FrameworkElementHelper.SetBaseUri(c15, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/ClaimObject.xaml");
					}
					))
					,
				}
			}
			.ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply((ClaimObject_7f81f1628f6d6cc6747507ee800b7b3eXamlApplyExtensions.XamlApplyHandler6)(c16 => 
			{
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c16, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/ClaimObject.xaml");
			}
			))
			;
			
			content
			.Apply((c17 => 
			{
				// Source C:\Users\barna\source\repos\Wiki\Wiki.Shared\UserControls\ClaimObject.xaml (Line 1:2)
			}
			))
			.Apply((c18 => 
			{
				// Class Wiki.Shared.UserControls.ClaimObject
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c18, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/ClaimObject.xaml");
			}
			))
			;
			OnInitializeCompleted();
			InitializeXamlOwner();
			return content;
		}
		public ClaimObject(bool skipsInitializeComponents)
		{
		}
		private void InitializeComponent()
		{
			Content = (_View)GetContent();
			global::Uno.UI.FrameworkElementHelper.SetBaseUri(this, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/ClaimObject.xaml");
		}
		partial void OnInitializeCompleted();
		class StaticResources
		{
			// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 14:10)
			private static bool _StringIsEmptyToBoolConverterInitialized = false;
			private static global::Wiki.Shared.Converters.StringIsEmptyToBoolConverter __StringIsEmptyToBoolConverterBackingField;

			public static global::Wiki.Shared.Converters.StringIsEmptyToBoolConverter StringIsEmptyToBoolConverter
			{
				get
				{
					if(!_StringIsEmptyToBoolConverterInitialized)
					{
						__StringIsEmptyToBoolConverterBackingField = 
							new global::Wiki.Shared.Converters.StringIsEmptyToBoolConverter
							{
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 14:10)
							}
							;
						_StringIsEmptyToBoolConverterInitialized = true;
					}
					return __StringIsEmptyToBoolConverterBackingField;
				}
			}

			// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 15:10)
			private static bool _CollectionIsEmptyToBoolConverterInitialized = false;
			private static global::Wiki.Shared.Converters.CollectionIsEmptyToBoolConverter __CollectionIsEmptyToBoolConverterBackingField;

			public static global::Wiki.Shared.Converters.CollectionIsEmptyToBoolConverter CollectionIsEmptyToBoolConverter
			{
				get
				{
					if(!_CollectionIsEmptyToBoolConverterInitialized)
					{
						__CollectionIsEmptyToBoolConverterBackingField = 
							new global::Wiki.Shared.Converters.CollectionIsEmptyToBoolConverter
							{
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\ClaimObject.xaml (Line 15:10)
							}
							;
						_CollectionIsEmptyToBoolConverterInitialized = true;
					}
					return __CollectionIsEmptyToBoolConverterBackingField;
				}
			}

			public static object FindResource(string name)
			{
				switch(name)
				{
					case "StringIsEmptyToBoolConverter":
						return StringIsEmptyToBoolConverter;
					case "CollectionIsEmptyToBoolConverter":
						return CollectionIsEmptyToBoolConverter;
				}
				return null;
			}
		}
		private void InitializeXamlOwner()
		{
		}
	}
}
namespace Wiki.Droid
{
	static class ClaimObject_7f81f1628f6d6cc6747507ee800b7b3eXamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Documents.Run instance);
		public static global::Windows.UI.Xaml.Documents.Run ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply(this global::Windows.UI.Xaml.Documents.Run instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.TextBlock instance);
		public static global::Windows.UI.Xaml.Controls.TextBlock ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply(this global::Windows.UI.Xaml.Controls.TextBlock instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Windows.UI.Xaml.Controls.ContentControl instance);
		public static global::Windows.UI.Xaml.Controls.ContentControl ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply(this global::Windows.UI.Xaml.Controls.ContentControl instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler3(global::Wiki.Shared.UserControls.Qualifiers instance);
		public static global::Wiki.Shared.UserControls.Qualifiers ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply(this global::Wiki.Shared.UserControls.Qualifiers instance, XamlApplyHandler3 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler4(global::Wiki.Shared.UserControls.Panel instance);
		public static global::Wiki.Shared.UserControls.Panel ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply(this global::Wiki.Shared.UserControls.Panel instance, XamlApplyHandler4 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler5(global::Wiki.Shared.UserControls.References instance);
		public static global::Wiki.Shared.UserControls.References ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply(this global::Wiki.Shared.UserControls.References instance, XamlApplyHandler5 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler6(global::Windows.UI.Xaml.Controls.StackPanel instance);
		public static global::Windows.UI.Xaml.Controls.StackPanel ClaimObject_7f81f1628f6d6cc6747507ee800b7b3e_XamlApply(this global::Windows.UI.Xaml.Controls.StackPanel instance, XamlApplyHandler6 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
