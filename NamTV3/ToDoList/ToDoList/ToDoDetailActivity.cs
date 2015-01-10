using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ToDoList
{
	[Activity(Label = "ToDo Detail", Icon = "@drawable/icon")]			
	public class ToDoDetailActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.ToDoDetail);

			var editTextName      = FindViewById<TextView >(Resource.Id.editTextName);
			var editTextNote = FindViewById<TextView >(Resource.Id.editTextNote);
			var cbIsFinished = FindViewById<CheckBox >(Resource.Id.checkBoxIsFinished);

			var actionType = Intent.GetStringExtra ("action_type");

			if (actionType == ToDoItem.MODIFY_ITEM) 
			{
				var title = Intent.GetStringExtra ("name");
				var content = Intent.GetStringExtra ("note");
				var isFinished = Intent.GetBooleanExtra("is_finished",false);

				editTextName.Enabled = false;
				editTextName.Text = title;
				editTextNote.Text = content;
				cbIsFinished.Checked = isFinished;
			} 
			else if (actionType == ToDoItem.ADD_ITEM) 
			{
				editTextName.Enabled = true;
				editTextName.Text = "New note";
				editTextNote.Text = "";
				cbIsFinished.Checked = false;
			}

			var buttonOK = FindViewById<Button> (Resource.Id.buttonOK);
			var buttonDelete = FindViewById<Button> (Resource.Id.buttonDelete);
			var buttonCancel = FindViewById<Button> (Resource.Id.buttonCancel);

			buttonOK.Click += delegate {

				Xamarin.Forms.MessagingCenter .Send<ToDoDetailActivity, string> 
				(this, "ToDoItemData", string.Format("{0}{1}{2}{3}{4}{5}{6}",
					actionType,ToDoItem.TODO_SEPARTOR,
					editTextName.Text,ToDoItem.TODO_SEPARTOR,
					editTextNote.Text, ToDoItem.TODO_SEPARTOR, 
					cbIsFinished.Checked.ToString()));

				this.OnBackPressed();
			};

			buttonDelete.Click += delegate {
				actionType = ToDoItem.DELETE_ITEM;
				Xamarin.Forms.MessagingCenter .Send<ToDoDetailActivity, string> 
				(this, "ToDoItemData", string.Format("{0}{1}{2}{3}{4}{5}{6}",
					actionType,ToDoItem.TODO_SEPARTOR,
					editTextName.Text,ToDoItem.TODO_SEPARTOR,
					editTextNote.Text, ToDoItem.TODO_SEPARTOR, 
					cbIsFinished.Checked.ToString()));
				this.OnBackPressed();
			};

			buttonCancel.Click += delegate {
				this.OnBackPressed();
			};
		}
	}
}