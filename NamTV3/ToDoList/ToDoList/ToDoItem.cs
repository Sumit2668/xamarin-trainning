using System;
using System.Runtime.Serialization;

namespace ToDoList
{
	//public enum TaskStatus
	//{
	//	Finished,
	//	UnFinished
	//}

	public class ToDoItem
	{
		public readonly static string ADD_ITEM = "toDo_add";
		public readonly static string DELETE_ITEM = "toDo_delete";
		public readonly static string MODIFY_ITEM = "toDo_modify";
		public readonly static char TODO_SEPARTOR = ';';

		public string Name {get;set;}
		public string Note {get;set;}
		public bool IsFinished {get;set;}
		public string ActionType{ get; set; }
		public ToDoItem ()
		{
			ActionType = string.Empty;
			Name = string.Empty;
			Note = string.Empty;
			IsFinished = false;
		}

		public static ToDoItem Parse(string toDoStringData)
		{
			ToDoItem ret = null;
			if (toDoStringData != null && toDoStringData.Trim ().Length > 0) 
			{
				string[] data = toDoStringData.Split (TODO_SEPARTOR);
				if (data.Length == 4) 
				{
					ret = new ToDoItem ();
					ret.ActionType = data [0];
					ret.Name = data [1];
					ret.Note = data [2];

					bool isBool = false;
					ret.IsFinished = bool.TryParse (data [3], out isBool);
					if (!isBool)
						ret.IsFinished = false;
				}
			}
			return ret;
		}
	}
}

