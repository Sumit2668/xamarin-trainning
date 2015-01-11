using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;
using System.Collections.ObjectModel;

namespace JiraMobile
{	
	public partial class IssueList : ContentPage
	{	
		public IssueList ()
		{
			//List<ObservableCollection<Issue>> list = new List<ObservableCollection<Issue>> ();

			//list.Add (DataIssues.issueList);


			//BindingContext = DataIssues.issueList;

			InitializeComponent ();

			BindingContext = DataIssues.issueList;

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
	}
}

