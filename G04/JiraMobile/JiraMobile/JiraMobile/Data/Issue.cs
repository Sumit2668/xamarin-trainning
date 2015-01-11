using System;

namespace JiraMobile
{

	public class Issue
	{
		public string expand { get; set; }
		public string id { get; set; }
		public string self { get; set; }
		public string key { get; set; }
		public Fields fields { get; set; }

		public Issue ()
		{

		}
	}



	public class AvatarUrls
	{
		public string __invalid_name__48x48 { get; set; }
		public string __invalid_name__24x24 { get; set; }
		public string __invalid_name__16x16 { get; set; }
		public string __invalid_name__32x32 { get; set; }
	}

	public class Assignee
	{
		public string self { get; set; }
		public string name { get; set; }
		public string emailAddress { get; set; }
		public AvatarUrls avatarUrls { get; set; }
		public string displayName { get; set; }
		public bool active { get; set; }
	}

	public class StatusCategory
	{
		public string self { get; set; }
		public int id { get; set; }
		public string key { get; set; }
		public string colorName { get; set; }
		public string name { get; set; }
	}

	public class Status
	{
		public string self { get; set; }
		public string description { get; set; }
		public string iconUrl { get; set; }
		public string name { get; set; }
		public string id { get; set; }
		public StatusCategory statusCategory { get; set; }
	}

	public class Fields
	{
		public Assignee assignee { get; set; }
		public Status status { get; set; }
	}
}

