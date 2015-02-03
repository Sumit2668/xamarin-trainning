using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using JiraMobile.Utils;

namespace JiraMobile
{
    public class App
    {
		static ILoginManager loginManager;

        public static Page GetMainPage()
        {
			return new NavigationPage (new ProjectList ()) {
				BarBackgroundColor = Color.White,
				BarTextColor = Color.Black
			};
        }

		public static Page GetLoginPage(ILoginManager ilm)
		{
			loginManager = ilm;
			return new Login (ilm);
		}

		public static void Logout ()
		{
			loginManager.Logout();
		}
    }
}
