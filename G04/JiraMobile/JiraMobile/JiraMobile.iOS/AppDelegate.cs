using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;
using JiraMobile.Utils;
using System.Threading;
using MonoTouch.Security;

namespace JiraMobile.Pages
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate, ILoginManager
	{
		// class-level declarations
		UIWindow window;

		private bool isLoginSuccess = false;

		#region ILoginManager implementation

		public void ShowMainPage ()
		{
			isLoginSuccess = true;
			//UINavigationController nav = (UINavigationController)window.RootViewController;

			//nav.PushViewController(App.GetMainPage ().CreateViewController(), true);

			//(UINavigationController )window.RootViewController = App.GetMainPage ().CreateViewController ();

		}

		public void Logout ()
		{
			window.RootViewController = App.GetLoginPage (this).CreateViewController ();

			window.MakeKeyAndVisible ();
		}

		#endregion

		//
		// This method is invoked when the application has loaded and is ready to run. In this
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			Forms.Init ();

			window = new UIWindow (UIScreen.MainScreen.Bounds);

			UIViewController ui = App.GetLoginPage (this).CreateViewController();

			if (isLoginSuccess) {
				window.RootViewController = App.GetMainPage ().CreateViewController ();
			} else {
				window.RootViewController = ui;
			}


			window.MakeKeyAndVisible ();

			return true;
		}

	}
}
