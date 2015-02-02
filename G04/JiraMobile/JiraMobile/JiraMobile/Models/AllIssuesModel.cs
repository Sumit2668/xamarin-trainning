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
	}
}

