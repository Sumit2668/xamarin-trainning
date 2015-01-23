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
			IssuesDetail.DataSource = await new HttpClientUtils ("", "", this).getIssuesById ("537055");
			FieldModel.FieldModelList [0].Value = IssuesDetail.DataSource.fields.project.name;
			FieldModel.FieldModelList [1].Value = IssuesDetail.DataSource.fields.creator.name;
			FieldModel.FieldModelList [2].Value = IssuesDetail.DataSource.fields.assignee.name;
			FieldModel.FieldModelList [3].Value = IssuesDetail.DataSource.fields.status.name;
			FieldModel.FieldModelList [4].Value = IssuesDetail.DataSource.fields.resolution.name;
			FieldModel.FieldModelList [5].Value = IssuesDetail.DataSource.fields.issuetype.name;
			FieldModel.FieldModelList [6].Value = IssuesDetail.DataSource.fields.priority.name;

			IssuesDetail.DataSource.fields.updated = "Update " + IssuesDetail.DataSource.fields.updated;
			IssuesDetail.DataSource.fields.creator.displayName = "by " + IssuesDetail.DataSource.fields.creator.displayName;
		}

		public void Show()
		{
			processBar.IsVisible = true;
			allFieldsList.IsVisible = false;
		}

		public void Hide()
		{
			processBar.IsVisible = false;
			allFieldsList.IsVisible = true;
		}

		public void OnItemTapped(object sender, ItemTappedEventArgs e)
		{
			this.allFieldsList.SelectedItem = null;
		}
	}
}

