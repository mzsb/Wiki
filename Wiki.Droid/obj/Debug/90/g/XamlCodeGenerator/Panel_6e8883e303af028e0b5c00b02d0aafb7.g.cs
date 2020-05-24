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
	public sealed partial class Panel : Windows.UI.Xaml.Controls.UserControl
	{
		public Windows.UI.Xaml.Controls.StackPanel GetContent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\Panel.xaml (Line 1:2)
			Windows.UI.Xaml.Controls.StackPanel content = 			new global::Windows.UI.Xaml.Controls.StackPanel
			{
				Orientation = global::Windows.UI.Xaml.Controls.Orientation.Vertical,
				// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\Panel.xaml (Line 12:6)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.StackPanel
					{
						Orientation = global::Windows.UI.Xaml.Controls.Orientation.Horizontal,
						// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\Panel.xaml (Line 14:10)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.ContentControl
							{
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\Panel.xaml (Line 16:14)
							}
							.Panel_6e8883e303af028e0b5c00b02d0aafb7_XamlApply((Panel_6e8883e303af028e0b5c00b02d0aafb7XamlApplyExtensions.XamlApplyHandler0)(c0 => 
							{
								c0.SetBinding(global::Windows.UI.Xaml.Controls.ContentControl.ContentProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"Header", CompiledSource = this });
																global::Uno.UI.FrameworkElementHelper.SetBaseUri(c0, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/Panel.xaml");
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.Button
							{
								FontFamily = new Windows.UI.Xaml.Media.FontFamily("Segoe MDL2 Assets"),
								Padding = new global::Windows.UI.Xaml.Thickness(0),
								Content = @"",
								Width = 16d,
								Height = 16d,
								FontSize = 8d,
								Margin = new global::Windows.UI.Xaml.Thickness(5,0,0,0),
								// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\Panel.xaml (Line 18:14)
							}
							.Panel_6e8883e303af028e0b5c00b02d0aafb7_XamlApply((Panel_6e8883e303af028e0b5c00b02d0aafb7XamlApplyExtensions.XamlApplyHandler1)(c1 => 
							{
								c1.Background = (Windows.UI.Xaml.Media.Brush)global::Wiki.Droid.GlobalStaticResources.ButtonLightBlue;
								
								c1.Foreground = (Windows.UI.Xaml.Media.Brush)global::Wiki.Droid.GlobalStaticResources.ButtonLightGray;
								
								var Click_Clicked_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
								c1.Click += (Clicked_sender,Clicked_e) => (Click_Clicked_That.Target as Panel)?.Clicked(Clicked_sender,Clicked_e);
								c1.SetBinding(global::Windows.UI.Xaml.Controls.Button.VisibilityProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"IsOpenable", CompiledSource = this });
																global::Uno.UI.FrameworkElementHelper.SetBaseUri(c1, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/Panel.xaml");
							}
							))
							,
						}
					}
					.Panel_6e8883e303af028e0b5c00b02d0aafb7_XamlApply((Panel_6e8883e303af028e0b5c00b02d0aafb7XamlApplyExtensions.XamlApplyHandler2)(c4 => 
					{
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c4, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/Panel.xaml");
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.ContentControl
					{
						Margin = new global::Windows.UI.Xaml.Thickness(10,20,10,20),
						// Source ..\..\..\..\..\..\..\Wiki.Shared\UserControls\Panel.xaml (Line 32:10)
					}
					.Panel_6e8883e303af028e0b5c00b02d0aafb7_XamlApply((Panel_6e8883e303af028e0b5c00b02d0aafb7XamlApplyExtensions.XamlApplyHandler0)(c5 => 
					{
						c5.SetBinding(global::Windows.UI.Xaml.Controls.ContentControl.ContentProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"InnerContent", CompiledSource = this });
												c5.SetBinding(global::Windows.UI.Xaml.Controls.ContentControl.VisibilityProperty, new Windows.UI.Xaml.Data.Binding{ Path = @"IsOpen", CompiledSource = this });
												global::Uno.UI.FrameworkElementHelper.SetBaseUri(c5, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/Panel.xaml");
					}
					))
					,
				}
			}
			.Panel_6e8883e303af028e0b5c00b02d0aafb7_XamlApply((Panel_6e8883e303af028e0b5c00b02d0aafb7XamlApplyExtensions.XamlApplyHandler2)(c6 => 
			{
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c6, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/Panel.xaml");
			}
			))
			;
			
			content
			.Apply((c7 => 
			{
				// Source C:\Users\barna\source\repos\Wiki\Wiki.Shared\UserControls\Panel.xaml (Line 1:2)
			}
			))
			.Apply((c8 => 
			{
				// Class Wiki.Shared.UserControls.Panel
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c8, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/Panel.xaml");
			}
			))
			;
			OnInitializeCompleted();
			InitializeXamlOwner();
			return content;
		}
		public Panel(bool skipsInitializeComponents)
		{
		}
		private void InitializeComponent()
		{
			Content = (_View)GetContent();
			global::Uno.UI.FrameworkElementHelper.SetBaseUri(this, "file:///C:/Users/barna/source/repos/Wiki/Wiki.Shared/UserControls/Panel.xaml");
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
	static class Panel_6e8883e303af028e0b5c00b02d0aafb7XamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.ContentControl instance);
		public static global::Windows.UI.Xaml.Controls.ContentControl Panel_6e8883e303af028e0b5c00b02d0aafb7_XamlApply(this global::Windows.UI.Xaml.Controls.ContentControl instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.Button instance);
		public static global::Windows.UI.Xaml.Controls.Button Panel_6e8883e303af028e0b5c00b02d0aafb7_XamlApply(this global::Windows.UI.Xaml.Controls.Button instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Windows.UI.Xaml.Controls.StackPanel instance);
		public static global::Windows.UI.Xaml.Controls.StackPanel Panel_6e8883e303af028e0b5c00b02d0aafb7_XamlApply(this global::Windows.UI.Xaml.Controls.StackPanel instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
	}
}