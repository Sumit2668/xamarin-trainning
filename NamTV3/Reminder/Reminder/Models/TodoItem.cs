using System;
using SQLite;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Reminder
{
	public class TodoItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged = delegate {};

		public TodoItem ()
		{
			this.eventTime = DateTime.Today;
		}

		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		string name;
		public string Name { 
			get { return name; }
			set { SetProperty(ref name, value);	}
		}

		string notes;
		public string Notes { 
			get{ return notes; }
			set{ SetProperty (ref notes, value); }
		}

		bool done;
		public bool Done {
			get{ return done;} 
			set{ SetProperty (ref done, value); }
		}

		DateTime eventTime;
		public DateTime EventTime {
			get{ return eventTime;} 
			set{ SetProperty (ref eventTime, value); }
		}

		bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = "") 
		{
			if (!object.Equals(field, value)) {
				field = value;
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
				return true;
			}
			return false;
		}
	}
}

