using System;
using System.Collections.Generic;
using Xamarin.Forms;
using JiraMobile.Models;

namespace JiraMobile.Pages
{
	public partial class IssuesFields : ContentPage, JiraMobile.Pages.HttpClientUtils.IProcessBarCallBack
	{
		public IssuesFields ()
		{
			InitializeComponent ();
			InitData ();

			allFieldsList.ItemsSource = FieldModel.FieldModelList;
		}

		async void InitData ()
		{
			var issue = await new HttpClientUtils ("", "", this).getIssuesById ("");
			FieldModel.FieldModelList [0].Value = issue.fields.status.name;
			FieldModel.FieldModelList [1].Value = issue.fields.resolution.name;
			FieldModel.FieldModelList [2].Value = issue.fields.issuetype.name;
			FieldModel.FieldModelList [3].Value = issue.fields.priority.name;
		}

		public void Show()
		{
			processBar.IsVisible = true;
		}

		public void Hide()
		{
			processBar.IsVisible = false;
		}
	}
}

