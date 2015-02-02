using System;
using System.Collections.Generic;

using Xamarin.Forms;
using JiraMobile.Pages;

namespace JiraMobile
{

	public partial class Login : ContentPage, JiraMobile.Pages.HttpClientUtils.IProcessBarCallBack
	{
		public static string strUserName = "";
		public static string strPassword = "";
		public Login ()
		{
			InitializeComponent ();
			processBar.IsVisible = false;
		}

		protected void btnLogin_OnClick(object sender, EventArgs e)
		{
			strUserName = txtUserName.Text;
			strPassword = txtPass.Text;
			AuthencationAccount ();
		}

		async void AuthencationAccount(){
			HttpClientUtils client = new HttpClientUtils (this);
			var result = await client.authenAccount ();
			if (!result)
			{
				processBar.IsVisible = false;
				txtUserName.IsVisible = true;
				txtPass.IsVisible = true;
				btnLogin.IsVisible = true;
				await DisplayAlert ("Error", "Username or password is incorrect", "OK");
			}
			else
			{
				await Navigation.PushAsync (new IssueList ());
			}
		}

		public void Show()
		{
			processBar.IsVisible = true;
			txtUserName.IsVisible = false;
			txtPass.IsVisible = false;
			btnLogin.IsVisible = false;
		}

		public void Hide()
		{
			processBar.IsVisible = false;
		}
	}

}

