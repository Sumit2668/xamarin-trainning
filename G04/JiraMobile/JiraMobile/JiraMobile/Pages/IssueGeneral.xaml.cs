using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace JiraMobile.Pages
{	
	public partial class IssueGeneral : ContentPage, JiraMobile.Pages.HttpClientUtils.IProcessBarCallBack
	{
		public IssueGeneral ()
		{
			InitializeComponent ();
			//lbTest.Text = new HttpClientUtils ().getAllIssues ();
		}

		public void Show()
		{
			processBar.IsVisible = true;
			viewContent.IsVisible = false;
		}

		public void Hide()
		{
			processBar.IsVisible = false;
			viewContent.IsVisible = true;
		}
	}
}

