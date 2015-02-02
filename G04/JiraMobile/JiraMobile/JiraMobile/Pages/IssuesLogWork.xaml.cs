using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace JiraMobile.Pages
{	
	public partial class IssuesLogWork : ContentPage
	{	
		public IssuesLogWork ()
		{
			InitializeComponent ();
			BindingContext = IssuesDetail.DataSource;
		}

		protected void OnItemTapped(object sender, ItemTappedEventArgs e)
		{
			listLogWork.SelectedItem = null;
		}
	}
}

