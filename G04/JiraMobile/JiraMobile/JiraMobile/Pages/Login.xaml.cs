using System;
using System.Collections.Generic;

using Xamarin.Forms;
using JiraMobile.Pages;
using JiraMobile.Utils;

namespace JiraMobile
{

	public partial class Login : ContentPage, JiraMobile.Pages.HttpClientUtils.IProcessBarCallBack
	{
		public static string strUserName = "";
		public static string strPassword = "";
		private ILoginManager ilm;

		public Login (ILoginManager ilm)
		{
			InitializeComponent ();
			imgLogo.Source = ImageSource.FromResource ("JiraMobile.Images.logo.png");
			processBar.IsVisible = false;
			this.ilm = ilm;
			IUserData userData = DependencyService.Get<IUserData> ();
			string token = userData.getAuth ();
			if (string.IsNullOrEmpty (token)) {

				AuthencationToken (token);
			}
		}

		protected void btnLogin_OnClick (object sender, EventArgs e)
		{
			strUserName = txtUserName.Text;
			strPassword = txtPass.Text;
			AuthencationAccount ();
		}

		async void AuthencationToken (string token)
		{

			HttpClientUtils client = new HttpClientUtils (this);
			var result = await client.authenToken (token);
			if (result) {

				ilm.ShowMainPage ();
			}
		}

		async void AuthencationAccount ()
		{
			HttpClientUtils client = new HttpClientUtils (this);
			var result = await client.authenAccount ();
			if (!result) {
				processBar.IsVisible = false;
				txtUserName.IsVisible = true;
				txtPass.IsVisible = true;
				btnLogin.IsVisible = true;
				await DisplayAlert ("Error", "Username or password is incorrect", "OK");
			} else {
				if (remember.IsToggled) {

					IUserData userData = DependencyService.Get<IUserData> ();
					userData.saveAuth (client.authStrBuild);
				}

				//await Navigation.PushAsync (new ProjectList ());
				ilm.ShowMainPage ();
			}
		}

		public void Show ()
		{
			processBar.IsVisible = true;
			txtUserName.IsVisible = false;
			txtPass.IsVisible = false;
			btnLogin.IsVisible = false;
		}

		public void Hide ()
		{
			processBar.IsVisible = false;
		}
	}

}

