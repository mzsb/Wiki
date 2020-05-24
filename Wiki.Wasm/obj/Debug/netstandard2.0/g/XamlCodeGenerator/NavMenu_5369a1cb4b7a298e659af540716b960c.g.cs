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
using Wiki.Wasm;

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
	public sealed partial class NavMenu : Windows.UI.Xaml.Controls.UserControl
	{
		public Windows.UI.Xaml.Controls.Grid GetContent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\NavMenu.xaml (Line 1:2)
			Windows.UI.Xaml.Controls.Grid content = 			new global::Windows.UI.Xaml.Controls.Grid
			{
				RowDefinitions = 
				{
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto),
						// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\NavMenu.xaml (Line 14:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star),
						// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\NavMenu.xaml (Line 15:14)
					}
					,
				}
				,
				// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\NavMenu.xaml (Line 12:6)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.Grid
					{
						Background = SolidColorBrushHelper.White,
						Height = 50d,
						VerticalAlignment = global::Windows.UI.Xaml.VerticalAlignment.Top,
						ColumnDefinitions = 
						{
							new global::Windows.UI.Xaml.Controls.ColumnDefinition
							{
								Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star),
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\NavMenu.xaml (Line 24:18)
							}
							,
							new global::Windows.UI.Xaml.Controls.ColumnDefinition
							{
								Width = new Windows.UI.Xaml.GridLength(2f, Windows.UI.Xaml.GridUnitType.Star),
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\NavMenu.xaml (Line 25:18)
							}
							,
							new global::Windows.UI.Xaml.Controls.ColumnDefinition
							{
								Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star),
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\NavMenu.xaml (Line 26:18)
							}
							,
						}
						,
						// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\NavMenu.xaml (Line 18:10)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.HyperlinkButton
							{
								Content = @"WikiAssembly",
								FontSize = 26d,
								FontFamily = new Windows.UI.Xaml.Media.FontFamily("MS PGothic"),
								HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Left,
								VerticalAlignment = global::Windows.UI.Xaml.VerticalAlignment.Center,
								Margin = new global::Windows.UI.Xaml.Thickness(10,0,0,0),
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\NavMenu.xaml (Line 29:14)
							}
							.NavMenu_5369a1cb4b7a298e659af540716b960c_XamlApply((NavMenu_5369a1cb4b7a298e659af540716b960cXamlApplyExtensions.XamlApplyHandler2)(c5 => 
							{
								global::Windows.UI.Xaml.Controls.Grid.SetColumn(c5, 0);
								c5.Foreground = (Windows.UI.Xaml.Media.Brush)global::Wiki.Wasm.GlobalStaticResources.LinkBlue;
								
								var Click_LabelClicked_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
								c5.Click += (LabelClicked_sender,LabelClicked_e) => (Click_LabelClicked_That.Target as NavMenu)?.LabelClicked(LabelClicked_sender,LabelClicked_e);
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c5, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/NavMenu.xaml");
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.AutoSuggestBox
							{
								Width = 400d,
								HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Center,
								VerticalAlignment = global::Windows.UI.Xaml.VerticalAlignment.Center,
								PlaceholderText = "Search",
								ItemContainerStyle = 								new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.ListViewItem))
								{
									Setters = 
									{
										new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.ListViewItem.BackgroundProperty, () => (Windows.UI.Xaml.Media.Brush)
										(Windows.UI.Xaml.Media.Brush)global::Wiki.Wasm.GlobalStaticResources.White
										),
									}
								}
								,
								ItemTemplate = 								new global::Windows.UI.Xaml.DataTemplate(() => 								new _NavMenu_5369a1cb4b7a298e659af540716b960c_WikiSharedUserControlsNavMenuSC0().Build()
								)								,
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\NavMenu.xaml (Line 39:14)
							}
							.NavMenu_5369a1cb4b7a298e659af540716b960c_XamlApply((NavMenu_5369a1cb4b7a298e659af540716b960cXamlApplyExtensions.XamlApplyHandler3)(c7 => 
							{
								global::Windows.UI.Xaml.Controls.Grid.SetColumn(c7, 1);
								var TextChanged_TextChanged_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
								c7.TextChanged += (TextChanged_sender,TextChanged_args) => (TextChanged_TextChanged_That.Target as NavMenu)?.TextChanged(TextChanged_sender,TextChanged_args);
								c7.SetBinding(global::Windows.UI.Xaml.Controls.AutoSuggestBox.ItemsSourceProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"viewModel.SearchResultItemViewModels", CompiledSource = this });
																var SuggestionChosen_SuggestionChosen_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
								c7.SuggestionChosen += (SuggestionChosen_sender,SuggestionChosen_args) => (SuggestionChosen_SuggestionChosen_That.Target as NavMenu)?.SuggestionChosen(SuggestionChosen_sender,SuggestionChosen_args);
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c7, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/NavMenu.xaml");
							}
							))
							,
						}
					}
					.NavMenu_5369a1cb4b7a298e659af540716b960c_XamlApply((NavMenu_5369a1cb4b7a298e659af540716b960cXamlApplyExtensions.XamlApplyHandler4)(c8 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c8, 0);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c8, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/NavMenu.xaml");
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.ContentControl
					{
						Background = SolidColorBrushHelper.Transparent,
						// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\NavMenu.xaml (Line 76:10)
					}
					.NavMenu_5369a1cb4b7a298e659af540716b960c_XamlApply((NavMenu_5369a1cb4b7a298e659af540716b960cXamlApplyExtensions.XamlApplyHandler5)(c9 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c9, 1);
						c9.SetBinding(global::Windows.UI.Xaml.Controls.ContentControl.ContentProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"InnerContent", CompiledSource = this });
												global::Uno.UI.FrameworkElementHelper.SetBaseUri(c9, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/NavMenu.xaml");
					}
					))
					,
				}
			}
			.NavMenu_5369a1cb4b7a298e659af540716b960c_XamlApply((NavMenu_5369a1cb4b7a298e659af540716b960cXamlApplyExtensions.XamlApplyHandler4)(c10 => 
			{
				c10.Background = (Windows.UI.Xaml.Media.Brush)global::Wiki.Wasm.GlobalStaticResources.LightBlue;
				
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c10, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/NavMenu.xaml");
			}
			))
			;
			
			content
			.Apply((c12 => 
			{
				// Source C:\Users\barna\source\repos\Wiki\Wiki.Shared\UserControls\NavMenu.xaml (Line 1:2)
			}
			))
			.Apply((c13 => 
			{
				// Class Wiki.Shared.UserControls.NavMenu
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c13, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/NavMenu.xaml");
			}
			))
			;
			OnInitializeCompleted();
			InitializeXamlOwner();
			return content;
		}
		public NavMenu(bool skipsInitializeComponents)
		{
		}
		private void InitializeComponent()
		{
			Content = (_View)GetContent();
			global::Uno.UI.FrameworkElementHelper.SetBaseUri(this, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/NavMenu.xaml");
		}
		partial void OnInitializeCompleted();
		private class _NavMenu_5369a1cb4b7a298e659af540716b960c_WikiSharedUserControlsNavMenuSC0
		{
			public _View Build()
			{
				var nameScope = new global::Windows.UI.Xaml.NameScope();
				var child = 
				new global::Windows.UI.Xaml.Controls.StackPanel
				{
					Orientation = global::Windows.UI.Xaml.Controls.Orientation.Vertical,
					Background = SolidColorBrushHelper.White,
					// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\NavMenu.xaml (Line 56:26)
					Children = 
					{
						new global::Windows.UI.Xaml.Controls.TextBlock
						{
							Foreground = SolidColorBrushHelper.Black,
							FontSize = 16d,
							// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\NavMenu.xaml (Line 59:30)
						}
						.NavMenu_5369a1cb4b7a298e659af540716b960c_XamlApply((NavMenu_5369a1cb4b7a298e659af540716b960cXamlApplyExtensions.XamlApplyHandler6)(c14 => 
						{
							c14.SetBinding(global::Windows.UI.Xaml.Controls.TextBlock.TextProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"Label" });
														global::Uno.UI.FrameworkElementHelper.SetBaseUri(c14, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/NavMenu.xaml");
						}
						))
						,
						new global::Windows.UI.Xaml.Controls.TextBlock
						{
							FontStyle = global::Windows.UI.Text.FontStyle.Italic,
							Foreground = SolidColorBrushHelper.Gray,
							FontSize = 14d,
							// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\NavMenu.xaml (Line 63:30)
						}
						.NavMenu_5369a1cb4b7a298e659af540716b960c_XamlApply((NavMenu_5369a1cb4b7a298e659af540716b960cXamlApplyExtensions.XamlApplyHandler6)(c15 => 
						{
							c15.SetBinding(global::Windows.UI.Xaml.Controls.TextBlock.TextProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"Description" });
														global::Uno.UI.FrameworkElementHelper.SetBaseUri(c15, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/NavMenu.xaml");
						}
						))
						,
					}
				}
				.NavMenu_5369a1cb4b7a298e659af540716b960c_XamlApply((NavMenu_5369a1cb4b7a298e659af540716b960cXamlApplyExtensions.XamlApplyHandler7)(c16 => 
				{
					global::Uno.UI.FrameworkElementHelper.SetBaseUri(c16, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/NavMenu.xaml");
				}
				))
				;
				if (child is DependencyObject d) Windows.UI.Xaml.NameScope.SetNameScope(d, nameScope);
				return child;
			}
		}
		class StaticResources
		{
		}
		private void InitializeXamlOwner()
		{
		}
	}
}
namespace Wiki.Wasm
{
	static class NavMenu_5369a1cb4b7a298e659af540716b960cXamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.RowDefinition instance);
		public static global::Windows.UI.Xaml.Controls.RowDefinition NavMenu_5369a1cb4b7a298e659af540716b960c_XamlApply(this global::Windows.UI.Xaml.Controls.RowDefinition instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.ColumnDefinition instance);
		public static global::Windows.UI.Xaml.Controls.ColumnDefinition NavMenu_5369a1cb4b7a298e659af540716b960c_XamlApply(this global::Windows.UI.Xaml.Controls.ColumnDefinition instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Windows.UI.Xaml.Controls.HyperlinkButton instance);
		public static global::Windows.UI.Xaml.Controls.HyperlinkButton NavMenu_5369a1cb4b7a298e659af540716b960c_XamlApply(this global::Windows.UI.Xaml.Controls.HyperlinkButton instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler3(global::Windows.UI.Xaml.Controls.AutoSuggestBox instance);
		public static global::Windows.UI.Xaml.Controls.AutoSuggestBox NavMenu_5369a1cb4b7a298e659af540716b960c_XamlApply(this global::Windows.UI.Xaml.Controls.AutoSuggestBox instance, XamlApplyHandler3 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler4(global::Windows.UI.Xaml.Controls.Grid instance);
		public static global::Windows.UI.Xaml.Controls.Grid NavMenu_5369a1cb4b7a298e659af540716b960c_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler4 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler5(global::Windows.UI.Xaml.Controls.ContentControl instance);
		public static global::Windows.UI.Xaml.Controls.ContentControl NavMenu_5369a1cb4b7a298e659af540716b960c_XamlApply(this global::Windows.UI.Xaml.Controls.ContentControl instance, XamlApplyHandler5 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler6(global::Windows.UI.Xaml.Controls.TextBlock instance);
		public static global::Windows.UI.Xaml.Controls.TextBlock NavMenu_5369a1cb4b7a298e659af540716b960c_XamlApply(this global::Windows.UI.Xaml.Controls.TextBlock instance, XamlApplyHandler6 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler7(global::Windows.UI.Xaml.Controls.StackPanel instance);
		public static global::Windows.UI.Xaml.Controls.StackPanel NavMenu_5369a1cb4b7a298e659af540716b960c_XamlApply(this global::Windows.UI.Xaml.Controls.StackPanel instance, XamlApplyHandler7 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
