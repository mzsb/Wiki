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
	public sealed partial class References : Windows.UI.Xaml.Controls.UserControl
	{
		public Windows.UI.Xaml.Controls.StackPanel GetContent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\References.xaml (Line 1:2)
			Windows.UI.Xaml.Controls.StackPanel content = 			new global::Windows.UI.Xaml.Controls.StackPanel
			{
				Orientation = global::Windows.UI.Xaml.Controls.Orientation.Vertical,
				// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\References.xaml (Line 15:6)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.Grid
					{
						Margin = new global::Windows.UI.Xaml.Thickness(0,0,0,5),
						ColumnDefinitions = 
						{
							new global::Windows.UI.Xaml.Controls.ColumnDefinition
							{
								Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star),
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\References.xaml (Line 19:18)
							}
							,
							new global::Windows.UI.Xaml.Controls.ColumnDefinition
							{
								Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star),
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\References.xaml (Line 20:18)
							}
							,
						}
						,
						// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\References.xaml (Line 17:10)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.TextBlock
							{
								Text = "Predicate",
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\References.xaml (Line 23:14)
							}
							.References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply((References_0910519e09c523bbb0fe53cc5e16d51dXamlApplyExtensions.XamlApplyHandler1)(c2 => 
							{
								global::Windows.UI.Xaml.Controls.Grid.SetColumn(c2, 0);
								c2.Foreground = (Windows.UI.Xaml.Media.Brush)global::Wiki.Wasm.GlobalStaticResources.Gray;
								
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c2, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/References.xaml");
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.TextBlock
							{
								Text = "Object",
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\References.xaml (Line 27:14)
							}
							.References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply((References_0910519e09c523bbb0fe53cc5e16d51dXamlApplyExtensions.XamlApplyHandler1)(c4 => 
							{
								global::Windows.UI.Xaml.Controls.Grid.SetColumn(c4, 1);
								c4.Foreground = (Windows.UI.Xaml.Media.Brush)global::Wiki.Wasm.GlobalStaticResources.Gray;
								
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c4, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/References.xaml");
							}
							))
							,
						}
					}
					.References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply((References_0910519e09c523bbb0fe53cc5e16d51dXamlApplyExtensions.XamlApplyHandler2)(c6 => 
					{
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c6, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/References.xaml");
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.ListView
					{
						Background = SolidColorBrushHelper.Transparent,
						SelectionMode = global::Windows.UI.Xaml.Controls.ListViewSelectionMode.None,
						ItemTemplate = 						new global::Windows.UI.Xaml.DataTemplate(() => 						new _References_0910519e09c523bbb0fe53cc5e16d51d_WikiSharedUserControlsReferencesSC0().Build()
						)						,
						ItemContainerStyleSelector = 						new global::Wiki.Shared.StyleSelectors.ClaimDataItemContainerStyleSelector
						{
							White = 							new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.ListViewItem))
							{
								Setters = 
								{
									new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.ListViewItem.BackgroundProperty, () => (Windows.UI.Xaml.Media.Brush)
									(Windows.UI.Xaml.Media.Brush)global::Wiki.Wasm.GlobalStaticResources.White
									),
									new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.ListViewItem.BorderBrushProperty, () => (Windows.UI.Xaml.Media.Brush)
									(Windows.UI.Xaml.Media.Brush)global::Wiki.Wasm.GlobalStaticResources.LightGray
									),
									new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.ListViewItem.BorderThicknessProperty, (Windows.UI.Xaml.Thickness)new global::Windows.UI.Xaml.Thickness(1)),
								}
							}
							,
							Blue = 							new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.ListViewItem))
							{
								Setters = 
								{
									new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.ListViewItem.BackgroundProperty, () => (Windows.UI.Xaml.Media.Brush)
									(Windows.UI.Xaml.Media.Brush)global::Wiki.Wasm.GlobalStaticResources.ListViewItemBlue
									),
									new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.ListViewItem.BorderBrushProperty, () => (Windows.UI.Xaml.Media.Brush)
									(Windows.UI.Xaml.Media.Brush)global::Wiki.Wasm.GlobalStaticResources.LightGray
									),
									new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.ListViewItem.BorderThicknessProperty, (Windows.UI.Xaml.Thickness)new global::Windows.UI.Xaml.Thickness(1)),
								}
							}
							,
							// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\References.xaml (Line 88:18)
						}
						,
						// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\References.xaml (Line 33:10)
					}
					.References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply((References_0910519e09c523bbb0fe53cc5e16d51dXamlApplyExtensions.XamlApplyHandler4)(c8 => 
					{
						c8.SetBinding(global::Windows.UI.Xaml.Controls.ListView.ItemsSourceProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"Values", CompiledSource = this });
												global::Uno.UI.FrameworkElementHelper.SetBaseUri(c8, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/References.xaml");
					}
					))
					,
				}
			}
			.References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply((References_0910519e09c523bbb0fe53cc5e16d51dXamlApplyExtensions.XamlApplyHandler5)(c9 => 
			{
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c9, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/References.xaml");
			}
			))
			;
			
			content
			.Apply((c10 => 
			{
				// Source C:\Users\barna\source\repos\Wiki\Wiki.Shared\UserControls\References.xaml (Line 1:2)
			}
			))
			.Apply((c11 => 
			{
				// Class Wiki.Shared.UserControls.References
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c11, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/References.xaml");
			}
			))
			;
			OnInitializeCompleted();
			InitializeXamlOwner();
			return content;
		}
		public References(bool skipsInitializeComponents)
		{
		}
		private void InitializeComponent()
		{
			Content = (_View)GetContent();
			global::Uno.UI.FrameworkElementHelper.SetBaseUri(this, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/References.xaml");
		}
		partial void OnInitializeCompleted();
		private class _References_0910519e09c523bbb0fe53cc5e16d51d_WikiSharedUserControlsReferencesSC0
		{
			public _View Build()
			{
				var nameScope = new global::Windows.UI.Xaml.NameScope();
				var child = 
				new global::Windows.UI.Xaml.Controls.Grid
				{
					ColumnDefinitions = 
					{
						new global::Windows.UI.Xaml.Controls.ColumnDefinition
						{
							Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star),
							// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\References.xaml (Line 43:30)
						}
						,
						new global::Windows.UI.Xaml.Controls.ColumnDefinition
						{
							Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Pixel),
							// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\References.xaml (Line 44:30)
						}
						,
						new global::Windows.UI.Xaml.Controls.ColumnDefinition
						{
							Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star),
							// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\References.xaml (Line 45:30)
						}
						,
					}
					,
					// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\References.xaml (Line 40:22)
					Children = 
					{
						new global::Windows.UI.Xaml.Controls.HyperlinkButton
						{
							VerticalAlignment = global::Windows.UI.Xaml.VerticalAlignment.Center,
							// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\References.xaml (Line 48:26)
						}
						.References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply((References_0910519e09c523bbb0fe53cc5e16d51dXamlApplyExtensions.XamlApplyHandler6)(c15 => 
						{
							global::Windows.UI.Xaml.Controls.Grid.SetColumn(c15, 0);
							c15.Foreground = (Windows.UI.Xaml.Media.Brush)global::Wiki.Wasm.GlobalStaticResources.LinkBlue;
							
							c15.SetBinding(global::Windows.UI.Xaml.Controls.HyperlinkButton.ContentProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"Predicate.Label" });
														c15.SetBinding(global::Windows.UI.Xaml.Controls.HyperlinkButton.CommandProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"Predicate.Command" });
														global::Uno.UI.FrameworkElementHelper.SetBaseUri(c15, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/References.xaml");
						}
						))
						,
						new global::Windows.UI.Xaml.Shapes.Rectangle
						{
							Width = 1d,
							// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\References.xaml (Line 54:26)
						}
						.References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply((References_0910519e09c523bbb0fe53cc5e16d51dXamlApplyExtensions.XamlApplyHandler7)(c17 => 
						{
							global::Windows.UI.Xaml.Controls.Grid.SetColumn(c17, 1);
							c17.Fill = (Windows.UI.Xaml.Media.Brush)global::Wiki.Wasm.GlobalStaticResources.LightGrayBrush;
							
							global::Uno.UI.FrameworkElementHelper.SetBaseUri(c17, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/References.xaml");
						}
						))
						,
						new global::Windows.UI.Xaml.Controls.ListView
						{
							Background = SolidColorBrushHelper.Transparent,
							SelectionMode = global::Windows.UI.Xaml.Controls.ListViewSelectionMode.None,
							ItemTemplateSelector = 							new global::Wiki.Shared.TemplateSelectors.ClaimDataTemplateSelector
							{
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\References.xaml (Line 64:34)
							}
							.References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply((References_0910519e09c523bbb0fe53cc5e16d51dXamlApplyExtensions.XamlApplyHandler8)(c19 => 
							{
								c19.Entity = (Windows.UI.Xaml.DataTemplate)global::Wiki.Wasm.GlobalStaticResources.EntityClaimDataTemplate;
								
								c19.String = (Windows.UI.Xaml.DataTemplate)global::Wiki.Wasm.GlobalStaticResources.StringClaimDataTemplate;
								
								c19.Quantity = (Windows.UI.Xaml.DataTemplate)global::Wiki.Wasm.GlobalStaticResources.QuantityClaimDataTemplate;
								
								c19.Image = (Windows.UI.Xaml.DataTemplate)global::Wiki.Wasm.GlobalStaticResources.ImageClaimDataTemplate;
								
								c19.Video = (Windows.UI.Xaml.DataTemplate)global::Wiki.Wasm.GlobalStaticResources.VideoClaimDataTemplate;
								
								c19.Audio = (Windows.UI.Xaml.DataTemplate)global::Wiki.Wasm.GlobalStaticResources.AudioClaimDataTemplate;
								
								c19.Unknown = (Windows.UI.Xaml.DataTemplate)global::Wiki.Wasm.GlobalStaticResources.UnknownClaimDataTemplate;
								
							}
							))
							,
							ItemContainerStyle = 							new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.ListViewItem))
							{
								Setters = 
								{
									new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.ListViewItem.BorderBrushProperty, () => (Windows.UI.Xaml.Media.Brush)
									(Windows.UI.Xaml.Media.Brush)global::Wiki.Wasm.GlobalStaticResources.LightGrayBrush
									),
									new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.ListViewItem.BorderThicknessProperty, (Windows.UI.Xaml.Thickness)new global::Windows.UI.Xaml.Thickness(1)),
								}
							}
							,
							// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\References.xaml (Line 58:26)
						}
						.References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply((References_0910519e09c523bbb0fe53cc5e16d51dXamlApplyExtensions.XamlApplyHandler4)(c27 => 
						{
							global::Windows.UI.Xaml.Controls.Grid.SetColumn(c27, 2);
							c27.SetBinding(global::Windows.UI.Xaml.Controls.ListView.ItemsSourceProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"Objects" });
														global::Uno.UI.FrameworkElementHelper.SetBaseUri(c27, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/References.xaml");
						}
						))
						,
					}
				}
				.References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply((References_0910519e09c523bbb0fe53cc5e16d51dXamlApplyExtensions.XamlApplyHandler2)(c28 => 
				{
					global::Uno.UI.FrameworkElementHelper.SetBaseUri(c28, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/References.xaml");
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
	static class References_0910519e09c523bbb0fe53cc5e16d51dXamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.ColumnDefinition instance);
		public static global::Windows.UI.Xaml.Controls.ColumnDefinition References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply(this global::Windows.UI.Xaml.Controls.ColumnDefinition instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.TextBlock instance);
		public static global::Windows.UI.Xaml.Controls.TextBlock References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply(this global::Windows.UI.Xaml.Controls.TextBlock instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Windows.UI.Xaml.Controls.Grid instance);
		public static global::Windows.UI.Xaml.Controls.Grid References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler3(global::Wiki.Shared.StyleSelectors.ClaimDataItemContainerStyleSelector instance);
		public static global::Wiki.Shared.StyleSelectors.ClaimDataItemContainerStyleSelector References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply(this global::Wiki.Shared.StyleSelectors.ClaimDataItemContainerStyleSelector instance, XamlApplyHandler3 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler4(global::Windows.UI.Xaml.Controls.ListView instance);
		public static global::Windows.UI.Xaml.Controls.ListView References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply(this global::Windows.UI.Xaml.Controls.ListView instance, XamlApplyHandler4 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler5(global::Windows.UI.Xaml.Controls.StackPanel instance);
		public static global::Windows.UI.Xaml.Controls.StackPanel References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply(this global::Windows.UI.Xaml.Controls.StackPanel instance, XamlApplyHandler5 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler6(global::Windows.UI.Xaml.Controls.HyperlinkButton instance);
		public static global::Windows.UI.Xaml.Controls.HyperlinkButton References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply(this global::Windows.UI.Xaml.Controls.HyperlinkButton instance, XamlApplyHandler6 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler7(global::Windows.UI.Xaml.Shapes.Rectangle instance);
		public static global::Windows.UI.Xaml.Shapes.Rectangle References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply(this global::Windows.UI.Xaml.Shapes.Rectangle instance, XamlApplyHandler7 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler8(global::Wiki.Shared.TemplateSelectors.ClaimDataTemplateSelector instance);
		public static global::Wiki.Shared.TemplateSelectors.ClaimDataTemplateSelector References_0910519e09c523bbb0fe53cc5e16d51d_XamlApply(this global::Wiki.Shared.TemplateSelectors.ClaimDataTemplateSelector instance, XamlApplyHandler8 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
