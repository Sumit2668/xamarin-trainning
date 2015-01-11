using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JiraMobile
{
	public class DataIssues
	{
		public static IList<Issue> Characters { get; private set; }

		public DataIssues ()
		{
			String json = "{\n    \"expand\": \"renderedFields,names,schema,transitions,operations,editmeta,changelog\",\n    \"id\": \"89612\",\n    \"self\": \"https://insight.fsoft.com.vn/jira/rest/api/2/issue/89612\",\n    \"key\": \"F17B2CRED14-66\",\n    \"fields\": {\n        \"assignee\": {\n            \"self\": \"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhDC3\",\n            \"name\": \"ThanhDC3\",\n            \"emailAddress\": \"ThanhDC3@fsoft.com.vn\",\n            \"avatarUrls\": {\n                \"48x48\": \"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10122\",\n                \"24x24\": \"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10122\",\n                \"16x16\": \"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10122\",\n                \"32x32\": \"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10122\"\n            },\n            \"displayName\": \"Du Cong Thanh (FSU11.BU13)\",\n            \"active\": true\n        },\n        \"status\": {\n            \"self\": \"https://insight.fsoft.com.vn/jira/rest/api/2/status/10001\",\n            \"description\": \"\",\n            \"iconUrl\": \"https://insight.fsoft.com.vn/jira/images/icons/subtask.gif\",\n            \"name\": \"Done\",\n            \"id\": \"10001\",\n            \"statusCategory\": {\n                \"self\": \"https://insight.fsoft.com.vn/jira/rest/api/2/statuscategory/3\",\n                \"id\": 3,\n                \"key\": \"done\",\n                \"colorName\": \"green\",\n                \"name\": \"Complete\"\n            }\n        }\n    }\n}";
			return JsonConvert.DeserializeObject<Issue> (json);

		}
	}
}

