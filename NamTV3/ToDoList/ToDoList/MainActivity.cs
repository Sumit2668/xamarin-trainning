using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ToDoList
{
	[Activity (Label = "ToDoList", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		List<ToDoItem> toDoItems = new List<ToDoItem>();

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			ToDoData.CreateToDoData (ref this.toDoItems);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			var buttonAdd = FindViewById<Button> (Resource.Id.buttonAdd);
			buttonAdd.Click += delegate {
				var intent = new Intent (this, typeof(ToDoDetailActivity));
				intent.PutExtra ("action_type", ToDoItem.ADD_ITEM);
				StartActivity (intent);
			};

			var listView = FindViewById<ListView> (Resource.Id.listView);
			//toDoList.FastScrollEnabled = true;
			listView.ItemClick += OnItemClick;
			listView.Adapter = new ToDoAdapter (this, toDoItems);


			Xamarin.Forms.MessagingCenter.Subscribe<ToDoDetailActivity, string> (this, "ToDoItemData", (sender, arg) => {
				ToDoItem item = ToDoItem.Parse (arg.ToString ());
				if (item != null) {
					if(item.ActionType==ToDoItem.ADD_ITEM)
					{
						ToDoItem toDoItem = toDoItems.Find(x=>x.Name==item.Name);
						if(toDoItem!=null) item.Name += "_new";
						toDoItems.Add(item);
					}
					else if(item.ActionType==ToDoItem.MODIFY_ITEM)
					{
						ToDoItem toDoItem = toDoItems.Find(x=>x.Name==item.Name);
						{
							toDoItem.Name = item.Name;
							toDoItem.Note = item.Note;
							toDoItem.IsFinished = item.IsFinished;
						}
					}
					else if(item.ActionType == ToDoItem.DELETE_ITEM)
					{
						ToDoItem toDoItem = toDoItems.Find(x=>x.Name==item.Name);
						toDoItems.Remove(toDoItem);
					}
					((BaseAdapter)listView.Adapter).NotifyDataSetChanged();
				}
			});
		}

		void OnItemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			var intent = new Intent(this, typeof(ToDoDetailActivity));

			ToDoItem item = toDoItems [e.Position];
			intent.PutExtra("action_type", ToDoItem.MODIFY_ITEM);
			intent.PutExtra("name", item.Name);
			intent.PutExtra("note", item.Note);
			intent.PutExtra("is_finished", item.IsFinished);
			StartActivity(intent);
		}


	}
}


