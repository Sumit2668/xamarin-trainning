using System;
using System.Collections.Generic;
using Xamarin.Forms;
using JiraMobile.Pages;

namespace JiraMobile
{
	public partial class ProjectList : ContentPage, JiraMobile.Pages.HttpClientUtils.IProcessBarCallBack
	{
		private List<Project> DataSource;

		HttpClientUtils client;

		public ProjectList ()
		{
			InitializeComponent ();

			client = new HttpClientUtils (this);

			getProjectList ();
		}

		async void getProjectList ()
		{
			DataSource = await client.getAllProjectOfCurrentUser ();
			BindingContext = DataSource;
		}

		async void OnItemTapped (object sender, ItemTappedEventArgs e)
		{
			var selectedItem = (Project)this.projectList.SelectedItem;

			await Navigation.PushAsync (new IssueList (selectedItem.key));

			this.projectList.SelectedItem = null;
		}

		#region IProcessBarCallBack implementation

		public void Show ()
		{
			this.processBar.IsVisible = true;
			projectList.IsVisible = false;
		}

		public void Hide ()
		{
			this.processBar.IsVisible = false;
			projectList.IsVisible = true;
		}

		#endregion
	}
}

