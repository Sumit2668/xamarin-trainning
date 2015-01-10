using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ToDoList
{
	public static class ToDoData
	{
		//public static ObservableCollection<ToDoItem> ToDoItems { get; private set; }

		static ToDoData()
		{
			//var ToDoItems = new ObservableCollection<ToDoItem>();

			//AddToDoItems(ToDoItems);
			//AddInstructors(temp);

			//temp.OrderBy(i => i.Name).ToList().CopyTo(ToDoItems);
		}

		public static void CreateToDoData(ref List<ToDoItem> toDoItem)
		{
			toDoItem.Add(new ToDoItem()
				{
					Name      = "Task1",
					Note = "Task1 note",
					IsFinished  = false,
				});
			toDoItem.Add(new ToDoItem()
				{
					Name      = "Task2",
					Note = "Task2 note",
					IsFinished  = true,
				});
			toDoItem.Add(new ToDoItem()
				{
					Name      = "Task3",
					Note = "Task3 note",
					IsFinished  = false,
				});
			toDoItem.Add(new ToDoItem()
				{
					Name      = "Task4",
					Note = "Task4 note",
					IsFinished  = true,
				});
		}
	}
}