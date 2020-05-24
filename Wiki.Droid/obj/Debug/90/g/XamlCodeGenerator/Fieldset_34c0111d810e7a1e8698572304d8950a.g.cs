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
	public sealed partial class Fieldset : Windows.UI.Xaml.Controls.UserControl
	{
		public Windows.UI.Xaml.Controls.Grid GetContent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\Fieldset.xaml (Line 1:2)
			Windows.UI.Xaml.Controls.Grid content = 			new global::Windows.UI.Xaml.Controls.Grid
			{
				RowDefinitions = 
				{
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto),
						// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\Fieldset.xaml (Line 14:14)
					}
					,
				}
				,
				// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\Fieldset.xaml (Line 12:6)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.Grid
					{
						MinHeight = 16d,
						BorderThickness = new global::Windows.UI.Xaml.Thickness(1),
						Margin = new global::Windows.UI.Xaml.Thickness(5,5,5,5),
						// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\Fieldset.xaml (Line 17:10)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.ContentControl
							{
								Margin = new global::Windows.UI.Xaml.Thickness(10,20,10,20),
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\Fieldset.xaml (Line 25:14)
							}
							.Fieldset_34c0111d810e7a1e8698572304d8950a_XamlApply((Fieldset_34c0111d810e7a1e8698572304d8950aXamlApplyExtensions.XamlApplyHandler1)(c1 => 
							{
								c1.SetBinding(global::Windows.UI.Xaml.Controls.ContentControl.ContentProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"InnerContent", CompiledSource = this });
																c1.SetBinding(global::Windows.UI.Xaml.Controls.ContentControl.VisibilityProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"IsOpen", CompiledSource = this });
																global::Uno.UI.FrameworkElementHelper.SetBaseUri(c1, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/Fieldset.xaml");
							}
							))
							,
						}
					}
					.Fieldset_34c0111d810e7a1e8698572304d8950a_XamlApply((Fieldset_34c0111d810e7a1e8698572304d8950aXamlApplyExtensions.XamlApplyHandler2)(c2 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c2, 0);
						global::Windows.UI.Xaml.Controls.Grid.SetColumn(c2, 0);
						c2.SetBinding(global::Windows.UI.Xaml.Controls.Grid.MinWidthProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"WindowWidth", CompiledSource = this });
												c2.BorderBrush = (Windows.UI.Xaml.Media.Brush)global::Wiki.Droid.GlobalStaticResources.LightGray;
						
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c2, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/Fieldset.xaml");
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.StackPanel
					{
						Orientation = global::Windows.UI.Xaml.Controls.Orientation.Horizontal,
						VerticalAlignment = global::Windows.UI.Xaml.VerticalAlignment.Top,
						HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Left,
						Margin = new global::Windows.UI.Xaml.Thickness(10,-5,0,0),
						Padding = new global::Windows.UI.Xaml.Thickness(10,0,10,0),
						// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\Fieldset.xaml (Line 30:10)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.Button
							{
								FontFamily = new Windows.UI.Xaml.Media.FontFamily("Segoe MDL2 Assets"),
								Padding = new global::Windows.UI.Xaml.Thickness(0),
								Content = @"",
								Width = 16d,
								Height = 16d,
								FontSize = 8d,
								Margin = new global::Windows.UI.Xaml.Thickness(0,0,5,0),
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\Fieldset.xaml (Line 37:14)
							}
							.Fieldset_34c0111d810e7a1e8698572304d8950a_XamlApply((Fieldset_34c0111d810e7a1e8698572304d8950aXamlApplyExtensions.XamlApplyHandler3)(c4 => 
							{
								c4.Background = (Windows.UI.Xaml.Media.Brush)global::Wiki.Droid.GlobalStaticResources.ButtonLightBlue;
								
								c4.Foreground = (Windows.UI.Xaml.Media.Brush)global::Wiki.Droid.GlobalStaticResources.ButtonLightGray;
								
								var Click_Clicked_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
								c4.Click += (Clicked_sender,Clicked_e) => (Click_Clicked_That.Target as Fieldset)?.Clicked(Clicked_sender,Clicked_e);
								c4.SetBinding(global::Windows.UI.Xaml.Controls.Button.VisibilityProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"IsOpenable", CompiledSource = this });
																global::Uno.UI.FrameworkElementHelper.SetBaseUri(c4, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/Fieldset.xaml");
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.ContentControl
							{
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\Fieldset.xaml (Line 49:14)
							}
							.Fieldset_34c0111d810e7a1e8698572304d8950a_XamlApply((Fieldset_34c0111d810e7a1e8698572304d8950aXamlApplyExtensions.XamlApplyHandler1)(c7 => 
							{
								c7.SetBinding(global::Windows.UI.Xaml.Controls.ContentControl.ContentProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"Header", CompiledSource = this });
																global::Uno.UI.FrameworkElementHelper.SetBaseUri(c7, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/Fieldset.xaml");
							}
							))
							,
						}
					}
					.Fieldset_34c0111d810e7a1e8698572304d8950a_XamlApply((Fieldset_34c0111d810e7a1e8698572304d8950aXamlApplyExtensions.XamlApplyHandler4)(c8 => 
					{
						c8.SetBinding(global::Windows.UI.Xaml.Controls.StackPanel.BackgroundProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"Background", CompiledSource = this });
												global::Uno.UI.FrameworkElementHelper.SetBaseUri(c8, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/Fieldset.xaml");
					}
					))
					,
				}
			}
			.Fieldset_34c0111d810e7a1e8698572304d8950a_XamlApply((Fieldset_34c0111d810e7a1e8698572304d8950aXamlApplyExtensions.XamlApplyHandler2)(c9 => 
			{
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c9, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/Fieldset.xaml");
			}
			))
			;
			
			content
			.Apply((c10 => 
			{
				// Source C:\Users\barna\source\repos\Wiki\Wiki.Shared\UserControls\Fieldset.xaml (Line 1:2)
			}
			))
			.Apply((c11 => 
			{
				// Class Wiki.Shared.UserControls.Fieldset
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c11, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/Fieldset.xaml");
			}
			))
			;
			OnInitializeCompleted();
			InitializeXamlOwner();
			return content;
		}
		public Fieldset(bool skipsInitializeComponents)
		{
		}
		private void InitializeComponent()
		{
			Content = (_View)GetContent();
			global::Uno.UI.FrameworkElementHelper.SetBaseUri(this, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/Fieldset.xaml");
		}
		partial void OnInitializeCompleted();
		class StaticResources
		{
		}
		private void InitializeXamlOwner()
		{
		}
	}
}
namespace Wiki.Droid
{
	static class Fieldset_34c0111d810e7a1e8698572304d8950aXamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.RowDefinition instance);
		public static global::Windows.UI.Xaml.Controls.RowDefinition Fieldset_34c0111d810e7a1e8698572304d8950a_XamlApply(this global::Windows.UI.Xaml.Controls.RowDefinition instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.ContentControl instance);
		public static global::Windows.UI.Xaml.Controls.ContentControl Fieldset_34c0111d810e7a1e8698572304d8950a_XamlApply(this global::Windows.UI.Xaml.Controls.ContentControl instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Windows.UI.Xaml.Controls.Grid instance);
		public static global::Windows.UI.Xaml.Controls.Grid Fieldset_34c0111d810e7a1e8698572304d8950a_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler3(global::Windows.UI.Xaml.Controls.Button instance);
		public static global::Windows.UI.Xaml.Controls.Button Fieldset_34c0111d810e7a1e8698572304d8950a_XamlApply(this global::Windows.UI.Xaml.Controls.Button instance, XamlApplyHandler3 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler4(global::Windows.UI.Xaml.Controls.StackPanel instance);
		public static global::Windows.UI.Xaml.Controls.StackPanel Fieldset_34c0111d810e7a1e8698572304d8950a_XamlApply(this global::Windows.UI.Xaml.Controls.StackPanel instance, XamlApplyHandler4 handler)
		{
			handler(instance);
			return instance;
		}
	}
}