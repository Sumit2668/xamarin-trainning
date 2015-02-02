using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace JiraMobile
{
	public class BaseModel : INotifyPropertyChanged 
	{
		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;


		protected void SetPropertyValue<T>(ref T oldValue, T newValue, [CallerMemberName]string propertyName = ""){
			var handler = PropertyChanged;
			if(!object.Equals(oldValue, newValue)){
				oldValue = newValue;
				if (handler != null) {
					handler (this, new PropertyChangedEventArgs (propertyName));
				}
			}
		}
		#endregion
	}
	public class Issue : BaseModel
	{
		private string _expand;

		public string expand {
			get{ return _expand; }
			set {
				SetPropertyValue(ref _expand, value);
				
			}
		}

		private string _id;

		public string id {
			get{ return _id; }
			set {
				SetPropertyValue(ref _id, value);
				
			}
		}

		private string _self;

		public string self {
			get{ return _self; }
			set {
				SetPropertyValue(ref _self, value);
				
			}
		}

		private string _key;

		public string key {
			get{ return _key; }
			set {
				SetPropertyValue(ref _key, value);
				
			}
		}

		private Fields _fields;

		public Fields fields {
			get{ return _fields; }
			set {
				SetPropertyValue(ref _fields, value);
				
			}
		}
	}

	public class Issuetype : BaseModel
	{
		private string _self;

		public string self {
			get{ return _self; }
			set {
				SetPropertyValue(ref _self, value);
				
			}
		}

		private string _id;

		public string id {
			get{ return _id; }
			set {
				SetPropertyValue(ref _id, value);
				
			}
		}

		private string _description;

		public string description {
			get{ return _description; }
			set {
				SetPropertyValue(ref _description, value);
				
			}
		}

		private string _iconUrl;

		public string iconUrl {
			get{ return _iconUrl; }
			set {
				SetPropertyValue(ref _iconUrl, value);
				
			}
		}

		private string _name;

		public string name {
			get{ return _name; }
			set {
				SetPropertyValue(ref _name, value);
				
			}
		}

		private bool _subtask;

		public bool subtask {
			get{ return _subtask; }
			set {
				SetPropertyValue(ref _subtask, value);
				
			}
		}
	}

	public class AvatarUrls : BaseModel
	{
		private string _avt_48x48;

		[JsonProperty ("48x48")]
		public string avt_48x48 {
			get{ return _avt_48x48; }
			set {
				SetPropertyValue(ref _avt_48x48, value);
				
			}
		}
			
		private string _avt_24x24;

		[JsonProperty ("24x24")]
		public string avt_24x24 {
			get{ return _avt_24x24; }
			set {
				SetPropertyValue(ref _avt_24x24, value);
				
			}
		}
			
		private string _avt_16x16;

		[JsonProperty ("16x16")]
		public string avt_16x16 {
			get{ return _avt_16x16; }
			set {
				SetPropertyValue(ref _avt_16x16, value);
				
			}
		}
			
		private string _avt_32x32;

		[JsonProperty ("32x32")]
		public string avt_32x32 {
			get{ return _avt_32x32; }
			set {
				SetPropertyValue(ref _avt_32x32, value);
				
			}
		}
	}

	public class User : BaseModel
	{
		private string _self;

		public string self {
			get{ return _self; }
			set {
				SetPropertyValue(ref _self, value);
				
			}
		}

		private string _name;

		public string name {
			get{ return _name; }
			set {
				SetPropertyValue(ref _name, value);
				
			}
		}

		private string _emailAddress;

		public string emailAddress {
			get{ return _emailAddress; }
			set {
				SetPropertyValue(ref _emailAddress, value);
				
			}
		}

		private AvatarUrls _avatarUrls;

		public AvatarUrls avatarUrls {
			get{ return _avatarUrls; }
			set {
				SetPropertyValue(ref _avatarUrls, value);
				
			}
		}

		private string _displayName;

		public string displayName {
			get{ return _displayName; }
			set {
				SetPropertyValue(ref _displayName, value);
				
			}
		}

		private bool _active;

		public bool active {
			get{ return _active; }
			set {
				SetPropertyValue(ref _active, value);
				
			}
		}
	}


	public class Project : BaseModel
	{
		private string _self;

		public string self {
			get{ return _self; }
			set {
				SetPropertyValue(ref _self, value);
				
			}
		}

		private string _id;

		public string id {
			get{ return _id; }
			set {
				SetPropertyValue(ref _id, value);
				
			}
		}

		private string _key;

		public string key {
			get{ return _key; }
			set {
				SetPropertyValue(ref _key, value);
				
			}
		}

		private string _name;

		public string name {
			get{ return _name; }
			set {
				SetPropertyValue(ref _name, value);
				
			}
		}

		private AvatarUrls _avatarUrls;

		public AvatarUrls avatarUrls {
			get{ return _avatarUrls; }
			set {
				SetPropertyValue(ref _avatarUrls, value);
				
			}
		}
	}

	public class Worklog : BaseModel
	{
		private int _startAt;

		public int startAt {
			get{ return _startAt; }
			set {
				SetPropertyValue(ref _startAt, value);
				
			}
		}

		private int _maxResults;

		public int maxResults {
			get{ return _maxResults; }
			set {
				SetPropertyValue(ref _maxResults, value);
				
			}
		}

		private int _total;

		public int total {
			get{ return _total; }
			set {
				SetPropertyValue(ref _total, value);
				
			}
		}

		public List<WorkLogDetail> worklogs { get; set; }
	}

	public class WorkLogDetail : BaseModel
	{
		private string _self;

		public string self {
			get{ return _self; }
			set {
				SetPropertyValue(ref _self, value);
				
			}
		}

		private User _author;

		public User author {
			get{ return _author; }
			set {
				SetPropertyValue(ref _author, value);
				
			}
		}

		private User _updateAuthor;

		public User updateAuthor {
			get{ return _updateAuthor; }
			set {
				SetPropertyValue(ref _updateAuthor, value);
				
			}
		}

		private string _comment;

		public string comment {
			get{ return _comment; }
			set {
				SetPropertyValue(ref _comment, value);
				
			}
		}

		private string _created;

		public string created {
			get{ return _created; }
			set {
				SetPropertyValue(ref _created, value);
				
			}
		}

		private string _updated;

		public string updated {
			get{ return _updated; }
			set {
				SetPropertyValue(ref _updated, value);
				
			}
		}

		private string _started;

		public string started {
			get{ return _started; }
			set {
				SetPropertyValue(ref _started, value);
				
			}
		}

		private string _timeSpent;

		public string timeSpent {
			get{ return _timeSpent; }
			set {
				SetPropertyValue(ref _timeSpent, value);
				
			}
		}

		private int _timeSpentSeconds;

		public int timeSpentSeconds {
			get{ return _timeSpentSeconds; }
			set {
				SetPropertyValue(ref _timeSpentSeconds, value);
				
			}
		}

		private string _id;

		public string id {
			get{ return _id; }
			set {
				SetPropertyValue(ref _id, value);
				
			}
		}
	}

	public class Priority : BaseModel
	{
		private string _self;

		public string self {
			get{ return _self; }
			set {
				SetPropertyValue(ref _self, value);
				
			}
		}

		private string _iconUrl;

		public string iconUrl {
			get{ return _iconUrl; }
			set {
				SetPropertyValue(ref _iconUrl, value);
				
			}
		}

		private string _name;

		public string name {
			get{ return _name; }
			set {
				SetPropertyValue(ref _name, value);
				
			}
		}

		private string _id;

		public string id {
			get{ return _id; }
			set {
				SetPropertyValue(ref _id, value);
				
			}
		}
	}

	public class Resolution : BaseModel
	{
		private string _self;

		public string self {
			get{ return _self; }
			set {
				SetPropertyValue(ref _self, value);
				
			}
		}

		private string _id;

		public string id {
			get{ return _id; }
			set {
				SetPropertyValue(ref _id, value);
				
			}
		}

		private string _description;

		public string description {
			get{ return _description; }
			set {
				SetPropertyValue(ref _description, value);
				
			}
		}

		private string _name;

		public string name {
			get{ return _name; }
			set {
				SetPropertyValue(ref _name, value);
				
			}
		}
	}

	public class StatusCategory : BaseModel
	{
		private string _self;

		public string self {
			get{ return _self; }
			set {
				SetPropertyValue(ref _self, value);
				
			}
		}

		private int _id;

		public int id {
			get{ return _id; }
			set {
				SetPropertyValue(ref _id, value);
				
			}
		}

		private string _key;

		public string key {
			get{ return _key; }
			set {
				SetPropertyValue(ref _key, value);
				
			}
		}

		private string _colorName;

		public string colorName {
			get{ return _colorName; }
			set {
				SetPropertyValue(ref _colorName, value);
				
			}
		}

		private string _name;

		public string name {
			get{ return _name; }
			set {
				SetPropertyValue(ref _name, value);
				
			}
		}
	}

	public class Status : BaseModel
	{
		private string _self;

		public string self {
			get{ return _self; }
			set {
				SetPropertyValue(ref _self, value);
				
			}
		}

		private string _description;

		public string description {
			get{ return _description; }
			set {
				SetPropertyValue(ref _description, value);
				
			}
		}

		private string _iconUrl;

		public string iconUrl {
			get{ return _iconUrl; }
			set {
				SetPropertyValue(ref _iconUrl, value);
				
			}
		}

		private string _name;

		public string name {
			get{ return _name; }
			set {
				SetPropertyValue(ref _name, value);
				
			}
		}

		private string _id;

		public string id {
			get{ return _id; }
			set {
				SetPropertyValue(ref _id, value);
				
			}
		}

		private StatusCategory _statusCategory;

		public StatusCategory statusCategory {
			get{ return _statusCategory; }
			set {
				SetPropertyValue(ref _statusCategory, value);
				
			}
		}
	}

	public class Comment : BaseModel
	{
		private int _startAt;

		public int startAt {
			get{ return _startAt; }
			set {
				SetPropertyValue(ref _startAt, value);
				
			}
		}

		private int _maxResults;

		public int maxResults {
			get{ return _maxResults; }
			set {
				SetPropertyValue(ref _maxResults, value);
				
			}
		}

		private int _total;

		public int total {
			get{ return _total; }
			set {
				SetPropertyValue(ref _total, value);
				
			}
		}

		public List<Comments> comments { get; set; }
	}

	public class Comments : BaseModel
	{
		private string _self;

		public string self {
			get{ return _self; }
			set {
				SetPropertyValue(ref _self, value);
				
			}
		}

		private string _id;

		public string id {
			get{ return _id; }
			set {
				SetPropertyValue(ref _id, value);
				
			}
		}

		private User _author;

		public User author {
			get{ return _author; }
			set {
				SetPropertyValue(ref _author, value);
				
			}
		}

		private string _body;

		public string body {
			get{ return _body; }
			set {
				SetPropertyValue(ref _body, value);
				
			}
		}

		private User _updateAuthor;

		public User updateAuthor {
			get{ return _updateAuthor; }
			set {
				SetPropertyValue(ref _updateAuthor, value);
				
			}
		}

		private string _created;

		public string created {
			get{ return _created; }
			set {
				SetPropertyValue(ref _created, value);
				
			}
		}

		private string _updated;

		public string updated {
			get{ return _updated; }
			set {
				SetPropertyValue(ref _updated, value);
				
			}
		}
	}

	public class Fields : BaseModel
	{
		private string _summary;

		public string summary {
			get{ return _summary; }
			set {
				SetPropertyValue(ref _summary, value);
				
			}
		}

		private Issuetype _issuetype;

		public Issuetype issuetype {
			get{ return _issuetype; }
			set {
				SetPropertyValue(ref _issuetype, value);
				
			}
		}

		private User _creator;

		public User creator {
			get{ return _creator; }
			set {
				SetPropertyValue(ref _creator, value);
				
			}
		}

		private string _created;

		public string created {
			get{ return _created; }
			set {
				SetPropertyValue(ref _created, value);
				
			}
		}

		private string _description;

		public string description {
			get{ return _description; }
			set {
				SetPropertyValue(ref _description, value);
				
			}
		}

		private Project _project;

		public Project project {
			get{ return _project; }
			set {
				SetPropertyValue(ref _project, value);
				
			}
		}

		private User _reporter;

		public User reporter {
			get{ return _reporter; }
			set {
				SetPropertyValue(ref _reporter, value);
				
			}
		}

		private Comment _comment;

		public Comment comment {
			get{ return _comment; }
			set {
				SetPropertyValue(ref _comment, value);
				
			}
		}

		private Worklog _worklog;

		public Worklog worklog {
			get{ return _worklog; }
			set {
				SetPropertyValue(ref _worklog, value);
				
			}
		}

		private User _assignee;

		public User assignee {
			get{ return _assignee; }
			set {
				SetPropertyValue(ref _assignee, value);
				
			}
		}

		private Priority _priority;

		public Priority priority {
			get{ return _priority; }
			set {
				SetPropertyValue(ref _priority, value);
				
			}
		}

		private Resolution _resolution;

		public Resolution resolution {
			get{ return _resolution; }
			set {
				SetPropertyValue(ref _resolution, value);
				
			}
		}

		private Status _status;

		public Status status {
			get{ return _status; }
			set {
				SetPropertyValue(ref _status, value);
				
			}
		}

		private String _updated;

		public String updated {
			get{ return _updated; }
			set {
				SetPropertyValue(ref _updated, value);
				
			}
		}
	}
}

