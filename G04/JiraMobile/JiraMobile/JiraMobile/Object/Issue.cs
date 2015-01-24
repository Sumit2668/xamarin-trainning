using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JiraMobile
{
	public class Issue
	{
		public string expand { get; set; }
		public string id { get; set; }
		public string self { get; set; }
		public string key { get; set; }
		public Fields fields { get; set; }
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
		public List<WorkLogDetail> worklogs { get; set; }
	}

	public class WorkLogDetail
	{
		public string self { get; set; }
		public Assignee author { get; set; }
		public Assignee updateAuthor { get; set; }
		public string comment { get; set; }
		public string created { get; set; }
		public string updated { get; set; }
		public string started { get; set; }
		public string timeSpent { get; set; }
		public int timeSpentSeconds { get; set; }
		public string id { get; set; }
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

	public class Comment
	{
		public int startAt { get; set; }
		public int maxResults { get; set; }
		public int total { get; set; }
		public List<Comments> comments { get; set; }
	}

	public class Comments
	{
		public string self { get; set; }
		public string id { get; set; }
		public Assignee author { get; set; }
		public string body { get; set; }
		public Assignee updateAuthor { get; set; }
		public string created { get; set; }
		public string updated { get; set; }
	}

	public class Fields
	{
		public string summary { get; set; }
		public Issuetype issuetype { get; set; }
		public Creator creator { get; set; }
		public string created { get; set; }
		public string description { get; set; }
		public Project project { get; set; }
		public Reporter reporter { get; set; }
		public Comment comment { get; set; }
		public Worklog worklog { get; set; }
		public Assignee assignee { get; set; }
		public Priority priority { get; set; }
		public Resolution resolution { get; set; }
		public Status status { get; set; }
		public String updated { get; set; }
	}
}

