using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;
using System.Collections.ObjectModel;
using JiraMobile.Pages;

namespace JiraMobile
{	
	public partial class IssueList : ContentPage, JiraMobile.Pages.HttpClientUtils.IProcessBarCallBack
	{
		HttpClientUtils client;

		private static List<Issue> issueList;

		public IssueList ()
		{

			InitializeComponent ();

			client = new HttpClientUtils ("", "", this);

			GetIssueByProject ("F11B13KFA");

			tblMore.Activated += OnToolbarClick;

			//ToolbarItem item = new ToolbarItem();


		}

		async void GetIssueByProject(string projectID){

			issueList = await client.getAllIssueByProjectId (projectID);

			BindingContext = issueList;
		}

		void OnToolbarClick(object sender, EventArgs e)
		{
			GetIssueByProject ("F11B13KFA");
		}

		void OnButtonClicked(object sender, EventArgs args)
		{

		}

		async void OnItemTapped(object sender, ItemTappedEventArgs e)
		{
			var selectedItem = (Issue)this.allIssueList.SelectedItem;

			await Navigation.PushAsync (new IssuesDetail (selectedItem.id));

			this.allIssueList.SelectedItem = null;
		}

//		protected override void OnBindingContextChanged ()
//		{
//			base.OnBindingContextChanged ();
////			if (Device.OS == TargetPlatform.iOS) { // don't bother on the other platforms
////				allIssueList.RowHeight = 100;
////			}
//		}

		public void Show(){
			this.processBar.IsVisible = true;
			allIssueList.IsVisible = false;
		}

		public void Hide(){
			this.processBar.IsVisible = false;
			allIssueList.IsVisible = true;
		}
	}
}

