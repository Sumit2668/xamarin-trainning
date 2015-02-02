using System;
using System.ComponentModel;

namespace JiraMobile
{
	public class RootIssueDetail : BaseModel
	{
		private Fields _fields;

		public string expand { get; set; }

		public string id { get; set; }

		public string self { get; set; }

		public string key { get; set; }

		public Fields fields {
			get { return _fields; }
			set {
				SetPropertyValue (ref _fields, value);
			}
		}
	}
}

