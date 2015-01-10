using System;
using Android.Widget;

namespace ToDoList
{
	public class ViewHolder : Java.Lang.Object
	{
		//public ImageView Photo     { get; set; }
		public TextView  ToDoName      { get; set; }
		public TextView  ToDoNote 	{ get; set; }
		public TextView ToDoStatus 		{ get; set; }
	}
}

