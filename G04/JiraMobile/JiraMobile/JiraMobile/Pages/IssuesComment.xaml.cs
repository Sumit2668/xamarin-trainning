using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace JiraMobile.Pages
{	
	public partial class IssuesComment : ContentPage
	{	
		public IssuesComment ()
		{
			InitializeComponent ();
			BindingContext = IssuesDetail.DataSource;
		}
	}
}

