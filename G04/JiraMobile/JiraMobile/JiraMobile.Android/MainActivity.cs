using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using JiraMobile.Pages;
using JiraMobile.Utils;

namespace JiraMobile.Pages
{
    [Activity(Label = "JiraMobile", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsApplicationActivity, ILoginManager
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Xamarin.Forms.Forms.Init(this, bundle);

			SetPage(App.GetLoginPage(this));
        }

		#region ILoginManager implementation

		public void ShowMainPage ()
		{
			SetPage(App.GetMainPage());
		}

		public void Logout ()
		{
			SetPage(App.GetMainPage());
		}

		#endregion
    }
}

