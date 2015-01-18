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
//		ToolbarItem itemMore; 
		public IssueList ()
		{
			//List<ObservableCollection<Issue>> list = new List<ObservableCollection<Issue>> ();

			//list.Add (DataIssues.issueList);


			//BindingContext = DataIssues.issueList;

			InitializeComponent ();

			GetIssueByProject ("F11B13KFA");

			//allIssueList.HasUnevenRows = true;

//			itemMore = new ToolbarItem() { Name = "Edit" };
			//ToolbarItems.Add (itemMore);
//			itemMore.Activated += OnClickMore;




		}

		async void GetIssueByProject(string projectID){
			HttpClientUtils client = new HttpClientUtils ("", "", this);
			var issueList = await client.getAllIssueByProjectId (projectID);

			BindingContext = issueList;
		}

		void OnToolbarClick(object sender, EventArgs e)
		{
			System.Diagnostics.Debug.WriteLine ("Clicked");
			//ToolbarItems.Remove(itemMore);
			//ToolbarItems.Add(itemMore);
		}

		void OnButtonClicked(object sender, EventArgs args)
		{
			//DataIssues issues = new DataIssues ();
			//Issue issue = issues.issue;
			//List<Issue> list = DataIssues.issueList;


			for (int i = 0; i < DataIssues.issueList.Count; i++) {
				System.Diagnostics.Debug.WriteLine(DataIssues.issueList[0].ToString());
			}


		}

		async void OnItemTapped(object sender, ItemTappedEventArgs e)
		{
			await Navigation.PushAsync (new IssuesDetail ());

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
		}

		public void Hide(){
			this.processBar.IsVisible = false;
		}
	}
}

