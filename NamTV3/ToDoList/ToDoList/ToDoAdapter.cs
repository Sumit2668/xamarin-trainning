using System;
using System.Collections.Generic;
using System.IO;
using Android.App;
using Android.Graphics.Drawables;
using Android.Views;
using Android.Widget;
using System.Collections.ObjectModel;

namespace ToDoList
{
	public class ToDoAdapter : BaseAdapter<ToDoItem>//, ISectionIndexer
	{
		Activity         context;
		List<ToDoItem>   toDoItems;

		public ToDoAdapter(Activity context, List<ToDoItem> toDoItems)
		{
			this.context    = context;
			this.toDoItems 	= toDoItems;
		}

		public override ToDoItem this[int position]
		{
			get
			{
				return toDoItems[position];
			}
		}

		public override int Count
		{
			get
			{
				return toDoItems.Count;
			}
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var view = convertView;

			if (view == null)
			{
				view = context.LayoutInflater.Inflate(Resource.Layout.ToDoRow, parent, false);

				var name = view.FindViewById<TextView> (Resource.Id.titleTextView);
				var note = view.FindViewById<TextView >(Resource.Id.contentTextView);
				var status = view.FindViewById<TextView >(Resource.Id.statusTextView);

				view.Tag = new ViewHolder() { ToDoName = name, ToDoNote = note, ToDoStatus = status };
			}

			var holder = (ViewHolder)view.Tag;

			holder.ToDoStatus.Text = toDoItems[position].IsFinished?"Finished":"Not done yet";
			holder.ToDoName.Text = toDoItems[position].Name;
			holder.ToDoNote.Text = toDoItems[position].Note;

			return view;
		}

		// ISectionIndexer implementation
		/*
		Java.Lang.Object[]   sectionHeaders        = SectionIndexerBuilder.BuildSectionHeaders       (InstructorData.Instructors);
		Dictionary<int, int> positionForSectionMap = SectionIndexerBuilder.BuildPositionForSectionMap(InstructorData.Instructors);
		Dictionary<int, int> sectionForPositionMap = SectionIndexerBuilder.BuildSectionForPositionMap(InstructorData.Instructors);

		public Java.Lang.Object[] GetSections()
		{
			return sectionHeaders;
		}

		public int GetPositionForSection(int section)
		{
			return positionForSectionMap[section];
		}

		public int GetSectionForPosition(int position)
		{
			return sectionForPositionMap[position];
		}*/
	}
}