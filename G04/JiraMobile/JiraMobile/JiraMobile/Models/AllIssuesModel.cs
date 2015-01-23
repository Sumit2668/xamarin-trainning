using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JiraMobile.Models
{
	public class AllIssuesModel
	{
		public string expand { get; set; }
		public int startAt { get; set; }
		public int maxResults { get; set; }
		public int total { get; set; }
		public List<Issue> issues { get; set; }

		public AllIssuesModel ()
		{
		}


	}

	public class Issuetype
	{
		public string self { get; set; }
		public string id { get; set; }
		public string description { get; set; }
		public string iconUrl { get; set; }
		public string name { get; set; }
		public bool subtask { get; set; }
	}

	public class AvatarUrls
	{
		[JsonProperty("48x48")]
		public string avt_48x48 { get; set; }
		[JsonProperty("24x24")]
		public string avt_24x24 { get; set; }
		[JsonProperty("16x16")]
		public string avt_16x16 { get; set; }
		[JsonProperty("32x32")]
		public string avt_32x32 { get; set; }
	}

	public class Creator
	{
		public string self { get; set; }
		public string name { get; set; }
		public string emailAddress { get; set; }
		public AvatarUrls avatarUrls { get; set; }
		public string displayName { get; set; }
		public bool active { get; set; }
	}

	public class Project
	{
		public string self { get; set; }
		public string id { get; set; }
		public string key { get; set; }
		public string name { get; set; }
		public AvatarUrls avatarUrls { get; set; }
	}
		
	public class Reporter
	{
		public string self { get; set; }
		public string name { get; set; }
		public string emailAddress { get; set; }
		public AvatarUrls avatarUrls { get; set; }
		public string displayName { get; set; }
		public bool active { get; set; }
	}

	public class Worklog
	{
		public int startAt { get; set; }
		public int maxResults { get; set; }
		public int total { get; set; }
		public List<object> worklogs { get; set; }
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

	public class Priority
	{
		public string self { get; set; }
		public string iconUrl { get; set; }
		public string name { get; set; }
		public string id { get; set; }
	}

	public class Resolution
	{
		public string self { get; set; }
		public string id { get; set; }
		public string description { get; set; }
		public string name { get; set; }
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
		public string summary { get; set; }
		public Issuetype issuetype { get; set; }
		public Creator creator { get; set; }
		public object description { get; set; }
		public Project project { get; set; }
		public Reporter reporter { get; set; }
		public Worklog worklog { get; set; }
		public Assignee assignee { get; set; }
		public Priority priority { get; set; }
		public Resolution resolution { get; set; }
		public Status status { get; set; }
	}

}

