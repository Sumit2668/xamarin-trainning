﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SimpleTasklist
{
	[Activity (Label = "Simple Tasklist", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.HomeLayout);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.addNewTask);

			button.Click += (sender, e) => {
				var intent = new Intent (this, typeof(NewTaskActivity));
				StartActivity (intent);
			};
		}
	}
}


