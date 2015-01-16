﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace JiraMobile
{
	public static class DataIssues
	{
		public static IList<Issue> issueList { get; private set; }

		static DataIssues ()
		{
			ObservableCollection<Issue> issueOb = new ObservableCollection<Issue> ();
			List<String> json = new List<String> ();
			json.Add ("{\"expand\":\"renderedFields,names,schema,transitions,operations,editmeta,changelog\",\"id\":\"381632\",\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/issue/381632\",\"key\":\"F17B2CRED14-3338\",\"fields\":{\"summary\":\"[PT][MacOS10-10]: Don't change encryption package to folder when upgrade CCP 02.22.0000 to 02.23.0000\",\"issuetype\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/issuetype/1\",\"id\":\"1\",\"description\":\"A problem which impairs or prevents the functions of the product.\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/issuetypes/bug.png\",\"name\":\"Bug\",\"subtask\":false},\"creator\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=AnhCTK\",\"name\":\"AnhCTK\",\"emailAddress\":\"AnhCTK@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?ownerId=anhctk&avatarId=13115\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&ownerId=anhctk&avatarId=13115\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&ownerId=anhctk&avatarId=13115\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&ownerId=anhctk&avatarId=13115\"},\"displayName\":\"Cao Thi Kim Anh (FSU17.BU2)\",\"active\":true},\"created\":\"2014-10-14T16:11:08.000+0700\",\"description\":\"Title: Don't change encryption package to folder when upgrade CCP 02.22.0000 to 02.23.0000\\r\\n\\r\\nCondition:\\r\\n- Mac OS 10.10\\r\\n- Installed CCP 02.22.0000\\r\\n- Encrypt some folders  => change folders to packages. Add extension (.cf) to encryption folder\\r\\n\\r\\nStep:\\r\\n1. Upgrade CCP 02.22.0000 to 02.23.0000\\r\\n2. Verify encryption folder \\r\\n\\r\\nActual result\\r\\n2. Don't change package that have extension '.cf ' to folder \\r\\n\\r\\nExptect result\\r\\n2. Change packages that have extension '.cf ' to folders \\r\\n\\r\\nNote: after restarting or logout OS, Program will auto change package (.cf) to folder.\\r\\n         This bug does not occur on MacOS 10.9\",\"project\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/project/12601\",\"id\":\"12601\",\"key\":\"F17B2CRED14\",\"name\":\"Credeon2014\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?pid=12601&avatarId=10011\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=small&pid=12601&avatarId=10011\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=xsmall&pid=12601&avatarId=10011\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=medium&pid=12601&avatarId=10011\"}},\"reporter\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=AnhCTK\",\"name\":\"AnhCTK\",\"emailAddress\":\"AnhCTK@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?ownerId=anhctk&avatarId=13115\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&ownerId=anhctk&avatarId=13115\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&ownerId=anhctk&avatarId=13115\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&ownerId=anhctk&avatarId=13115\"},\"displayName\":\"Cao Thi Kim Anh (FSU17.BU2)\",\"active\":true},\"worklog\":{\"startAt\":0,\"maxResults\":20,\"total\":0,\"worklogs\":[]},\"assignee\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=AnhCTK\",\"name\":\"AnhCTK\",\"emailAddress\":\"AnhCTK@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?ownerId=anhctk&avatarId=13115\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&ownerId=anhctk&avatarId=13115\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&ownerId=anhctk&avatarId=13115\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&ownerId=anhctk&avatarId=13115\"},\"displayName\":\"Cao Thi Kim Anh (FSU17.BU2)\",\"active\":true},\"priority\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/priority/3\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/priorities/major.png\",\"name\":\"Major\",\"id\":\"3\"},\"resolution\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/resolution/1\",\"id\":\"1\",\"description\":\"A fix for this issue is checked into the tree and tested.\",\"name\":\"Fixed\"},\"status\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/status/6\",\"description\":\"The issue is considered finished, the resolution is correct. Issues which are closed can be reopened.\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/statuses/closed.png\",\"name\":\"Closed\",\"id\":\"6\",\"statusCategory\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/statuscategory/3\",\"id\":3,\"key\":\"done\",\"colorName\":\"green\",\"name\":\"Complete\"}}}}");
			json.Add ("{\"expand\":\"renderedFields,names,schema,transitions,operations,editmeta,changelog\",\"id\":\"364099\",\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/issue/364099\",\"key\":\"F17B2CRED14-3320\",\"fields\":{\"summary\":\"Delete \\\"OSX 10.8\\\" from HibunCP Management Console.\",\"issuetype\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/issuetype/3\",\"id\":\"3\",\"description\":\"A task that needs to be done.\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/issuetypes/task.png\",\"name\":\"Task\",\"subtask\":false},\"creator\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=masaki.koga.js%40hitachi-solutions.com\",\"name\":\"masaki.koga.js@hitachi-solutions.com\",\"emailAddress\":\"masaki.koga.js@hitachi-solutions.com\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?ownerId=masaki.koga.js%40hitachi-solutions.com&avatarId=14401\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&ownerId=masaki.koga.js%40hitachi-solutions.com&avatarId=14401\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&ownerId=masaki.koga.js%40hitachi-solutions.com&avatarId=14401\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&ownerId=masaki.koga.js%40hitachi-solutions.com&avatarId=14401\"},\"displayName\":\"Masaki Koga\",\"active\":true},\"created\":\"2014-10-06T14:06:33.000+0700\",\"description\":\"Please change the text on client download screen of HibunCP Management Console.\\r\\n\\r\\n- Before\\r\\nOSX 10.8 or 10.9\\r\\n\\r\\n- After\\r\\nOSX 10.9\",\"project\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/project/12601\",\"id\":\"12601\",\"key\":\"F17B2CRED14\",\"name\":\"Credeon2014\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?pid=12601&avatarId=10011\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=small&pid=12601&avatarId=10011\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=xsmall&pid=12601&avatarId=10011\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=medium&pid=12601&avatarId=10011\"}},\"reporter\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=masaki.koga.js%40hitachi-solutions.com\",\"name\":\"masaki.koga.js@hitachi-solutions.com\",\"emailAddress\":\"masaki.koga.js@hitachi-solutions.com\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?ownerId=masaki.koga.js%40hitachi-solutions.com&avatarId=14401\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&ownerId=masaki.koga.js%40hitachi-solutions.com&avatarId=14401\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&ownerId=masaki.koga.js%40hitachi-solutions.com&avatarId=14401\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&ownerId=masaki.koga.js%40hitachi-solutions.com&avatarId=14401\"},\"displayName\":\"Masaki Koga\",\"active\":true},\"worklog\":{\"startAt\":0,\"maxResults\":20,\"total\":0,\"worklogs\":[]},\"assignee\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=BINHLV3\",\"name\":\"BINHLV3\",\"emailAddress\":\"BinhLV3@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10110\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10110\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10110\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10110\"},\"displayName\":\"Le Van Binh (FSU17.BU2)\",\"active\":true},\"priority\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/priority/3\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/priorities/major.png\",\"name\":\"Major\",\"id\":\"3\"},\"resolution\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/resolution/6\",\"id\":\"6\",\"description\":\"\",\"name\":\"Done\"},\"status\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/status/10001\",\"description\":\"\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/subtask.gif\",\"name\":\"Done\",\"id\":\"10001\",\"statusCategory\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/statuscategory/3\",\"id\":3,\"key\":\"done\",\"colorName\":\"green\",\"name\":\"Complete\"}}}}");
			json.Add ("{\"expand\":\"renderedFields,names,schema,transitions,operations,editmeta,changelog\",\"id\":\"361332\",\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/issue/361332\",\"key\":\"F17B2CRED14-3313\",\"fields\":{\"summary\":\"[Server][6-4] Review spec\",\"issuetype\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/issuetype/1\",\"id\":\"1\",\"description\":\"A problem which impairs or prevents the functions of the product.\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/issuetypes/bug.png\",\"name\":\"Bug\",\"subtask\":false},\"creator\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhLT2\",\"name\":\"ThanhLT2\",\"emailAddress\":\"ThanhLT2@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10112\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10112\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10112\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10112\"},\"displayName\":\"La Tien Thanh (FSU17.BU2)\",\"active\":true},\"created\":\"2014-10-03T17:19:38.000+0700\",\"description\":\"1) Về Spec của server thì giá trị của config file đang được mô tả theo chữ in hoa là TRUE/FALSE, ON/OFF nhưng đúng ra phải là chữ in thường nhỉ. Các bạn hãy chỉnh sửa spec nhé.\\r\\n\\r\\n2) Can add them mo ta cho cac gia tri trong file config\\r\\n\\r\\n3) Can update spec man hinh\",\"project\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/project/12601\",\"id\":\"12601\",\"key\":\"F17B2CRED14\",\"name\":\"Credeon2014\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?pid=12601&avatarId=10011\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=small&pid=12601&avatarId=10011\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=xsmall&pid=12601&avatarId=10011\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=medium&pid=12601&avatarId=10011\"}},\"reporter\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhLT2\",\"name\":\"ThanhLT2\",\"emailAddress\":\"ThanhLT2@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10112\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10112\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10112\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10112\"},\"displayName\":\"La Tien Thanh (FSU17.BU2)\",\"active\":true},\"worklog\":{\"startAt\":0,\"maxResults\":20,\"total\":0,\"worklogs\":[]},\"assignee\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhLT2\",\"name\":\"ThanhLT2\",\"emailAddress\":\"ThanhLT2@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10112\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10112\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10112\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10112\"},\"displayName\":\"La Tien Thanh (FSU17.BU2)\",\"active\":true},\"priority\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/priority/3\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/priorities/major.png\",\"name\":\"Major\",\"id\":\"3\"},\"resolution\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/resolution/1\",\"id\":\"1\",\"description\":\"A fix for this issue is checked into the tree and tested.\",\"name\":\"Fixed\"},\"status\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/status/6\",\"description\":\"The issue is considered finished, the resolution is correct. Issues which are closed can be reopened.\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/statuses/closed.png\",\"name\":\"Closed\",\"id\":\"6\",\"statusCategory\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/statuscategory/3\",\"id\":3,\"key\":\"done\",\"colorName\":\"green\",\"name\":\"Complete\"}}}}");
			json.Add ("{\"expand\":\"renderedFields,names,schema,transitions,operations,editmeta,changelog\",\"id\":\"359488\",\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/issue/359488\",\"key\":\"F17B2CRED14-3301\",\"fields\":{\"summary\":\"[Mac][iOS][Android] SSL problem\",\"issuetype\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/issuetype/7\",\"id\":\"7\",\"description\":\"\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/ico_story.png\",\"name\":\"Story\",\"subtask\":false},\"creator\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhLT2\",\"name\":\"ThanhLT2\",\"emailAddress\":\"ThanhLT2@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10112\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10112\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10112\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10112\"},\"displayName\":\"La Tien Thanh (FSU17.BU2)\",\"active\":true},\"created\":\"2014-10-02T22:22:37.000+0700\",\"description\":\"Need to create Pvoucher\\r\\nPv number used to intergrate into src are separate but use the same coverpage, TVP/PCL\",\"project\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/project/12601\",\"id\":\"12601\",\"key\":\"F17B2CRED14\",\"name\":\"Credeon2014\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?pid=12601&avatarId=10011\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=small&pid=12601&avatarId=10011\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=xsmall&pid=12601&avatarId=10011\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=medium&pid=12601&avatarId=10011\"}},\"reporter\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhLT2\",\"name\":\"ThanhLT2\",\"emailAddress\":\"ThanhLT2@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10112\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10112\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10112\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10112\"},\"displayName\":\"La Tien Thanh (FSU17.BU2)\",\"active\":true},\"worklog\":{\"startAt\":0,\"maxResults\":20,\"total\":0,\"worklogs\":[]},\"assignee\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhLT2\",\"name\":\"ThanhLT2\",\"emailAddress\":\"ThanhLT2@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10112\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10112\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10112\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10112\"},\"displayName\":\"La Tien Thanh (FSU17.BU2)\",\"active\":true},\"priority\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/priority/3\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/priorities/major.png\",\"name\":\"Major\",\"id\":\"3\"},\"resolution\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/resolution/6\",\"id\":\"6\",\"description\":\"\",\"name\":\"Done\"},\"status\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/status/10001\",\"description\":\"\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/subtask.gif\",\"name\":\"Done\",\"id\":\"10001\",\"statusCategory\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/statuscategory/3\",\"id\":3,\"key\":\"done\",\"colorName\":\"green\",\"name\":\"Complete\"}}}}");


//			json.Add ("{\"expand\":\"renderedFields,names,schema,transitions,operations,editmeta,changelog\",\"id\":\"359484\",\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/issue/359484\",\"key\":\"F17B2CRED14-3299\",\"fields\":{\"summary\":\"Apply new icon/HowToUse for HCP10-20\",\"issuetype\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/issuetype/7\",\"id\":\"7\",\"description\":\"\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/ico_story.png\",\"name\":\"Story\",\"subtask\":false},\"creator\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhLT2\",\"name\":\"ThanhLT2\",\"emailAddress\":\"ThanhLT2@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10112\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10112\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10112\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10112\"},\"displayName\":\"La Tien Thanh (FSU17.BU2)\",\"active\":true},\"description\":\"1) Apply new icon for All compo (Server + Windows + Mac + iOS + Android)\\r\\n2) Apply new HowToUse for Win + Mac + iOS + Android\\r\\n---\\r\\n\",\"project\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/project/12601\",\"id\":\"12601\",\"key\":\"F17B2CRED14\",\"name\":\"Credeon2014\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?pid=12601&avatarId=10011\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=small&pid=12601&avatarId=10011\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=xsmall&pid=12601&avatarId=10011\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=medium&pid=12601&avatarId=10011\"}},\"reporter\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhLT2\",\"name\":\"ThanhLT2\",\"emailAddress\":\"ThanhLT2@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10112\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10112\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10112\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10112\"},\"displayName\":\"La Tien Thanh (FSU17.BU2)\",\"active\":true},\"worklog\":{\"startAt\":0,\"maxResults\":20,\"total\":0,\"worklogs\":[]},\"assignee\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhLT2\",\"name\":\"ThanhLT2\",\"emailAddress\":\"ThanhLT2@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10112\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10112\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10112\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10112\"},\"displayName\":\"La Tien Thanh (FSU17.BU2)\",\"active\":true},\"priority\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/priority/3\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/priorities/major.png\",\"name\":\"Major\",\"id\":\"3\"},\"resolution\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/resolution/6\",\"id\":\"6\",\"description\":\"\",\"name\":\"Done\"},\"status\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/status/10001\",\"description\":\"\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/subtask.gif\",\"name\":\"Done\",\"id\":\"10001\",\"statusCategory\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/statuscategory/3\",\"id\":3,\"key\":\"done\",\"colorName\":\"green\",\"name\":\"Complete\"}}}}");
//			json.Add ("{\"expand\":\"renderedFields,names,schema,transitions,operations,editmeta,changelog\",\"id\":\"191117\",\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/issue/191117\",\"key\":\"F17B2CRED14-2165\",\"fields\":{\"summary\":\"[PT][x-3] Incorrect file setup hgcgrsen.dll and hgccllck.exe\",\"issuetype\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/issuetype/1\",\"id\":\"1\",\"description\":\"A problem which impairs or prevents the functions of the product.\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/issuetypes/bug.png\",\"name\":\"Bug\",\"subtask\":false},\"creator\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=TanTN\",\"name\":\"TanTN\",\"emailAddress\":\"TanTN@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10108\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10108\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10108\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10108\"},\"displayName\":\"Tran Ngoc Tan (FSU11.BU9)\",\"active\":true},\"description\":\"*1. Outline*: Incorrect file setup hgcgrsen.dll and hgccllck.exe.\\r\\n*2. Conditions:*\\r\\n*3. Steps*\\r\\n 3.1 Install CCP 02.22.0000 (Windows Client)\\r\\n 3.2 Check properties of hgcgrsen.dll and hgccllck.exe in bin folder.\\r\\n*4. Expected result*\\r\\n 3.2 Original filename is hgcgrsen.dll and hgccllck.exe.\\r\\n*5. Actual ressult*\\r\\n 3.5 Original filename is hgqgrsen.dll and hgcllck.exe.\",\"project\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/project/12601\",\"id\":\"12601\",\"key\":\"F17B2CRED14\",\"name\":\"Credeon2014\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?pid=12601&avatarId=10011\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=small&pid=12601&avatarId=10011\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=xsmall&pid=12601&avatarId=10011\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=medium&pid=12601&avatarId=10011\"}},\"reporter\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=TanTN\",\"name\":\"TanTN\",\"emailAddress\":\"TanTN@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10108\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10108\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10108\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10108\"},\"displayName\":\"Tran Ngoc Tan (FSU11.BU9)\",\"active\":true},\"worklog\":{\"startAt\":0,\"maxResults\":20,\"total\":0,\"worklogs\":[]},\"assignee\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhDC3\",\"name\":\"ThanhDC3\",\"emailAddress\":\"ThanhDC3@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10122\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10122\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10122\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10122\"},\"displayName\":\"Du Cong Thanh (FSU11.BU13)\",\"active\":true},\"priority\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/priority/3\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/priorities/major.png\",\"name\":\"Major\",\"id\":\"3\"},\"resolution\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/resolution/1\",\"id\":\"1\",\"description\":\"A fix for this issue is checked into the tree and tested.\",\"name\":\"Fixed\"},\"status\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/status/6\",\"description\":\"The issue is considered finished, the resolution is correct. Issues which are closed can be reopened.\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/statuses/closed.png\",\"name\":\"Closed\",\"id\":\"6\",\"statusCategory\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/statuscategory/3\",\"id\":3,\"key\":\"done\",\"colorName\":\"green\",\"name\":\"Complete\"}}}}");
//			json.Add ("{\"expand\":\"renderedFields,names,schema,transitions,operations,editmeta,changelog\",\"id\":\"153600\",\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/issue/153600\",\"key\":\"F17B2CRED14-1343\",\"fields\":{\"summary\":\"CI\",\"issuetype\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/issuetype/7\",\"id\":\"7\",\"description\":\"\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/ico_story.png\",\"name\":\"Story\",\"subtask\":false},\"creator\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhLT2\",\"name\":\"ThanhLT2\",\"emailAddress\":\"ThanhLT2@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10112\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10112\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10112\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10112\"},\"displayName\":\"La Tien Thanh (FSU17.BU2)\",\"active\":true},\"description\":\"- UT implement (Server): 3pd\\r\\n- Self refresh of SI bat : 3pd\",\"project\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/project/12601\",\"id\":\"12601\",\"key\":\"F17B2CRED14\",\"name\":\"Credeon2014\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?pid=12601&avatarId=10011\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=small&pid=12601&avatarId=10011\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=xsmall&pid=12601&avatarId=10011\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=medium&pid=12601&avatarId=10011\"}},\"reporter\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhLT2\",\"name\":\"ThanhLT2\",\"emailAddress\":\"ThanhLT2@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10112\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10112\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10112\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10112\"},\"displayName\":\"La Tien Thanh (FSU17.BU2)\",\"active\":true},\"worklog\":{\"startAt\":0,\"maxResults\":20,\"total\":0,\"worklogs\":[]},\"assignee\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=AnhDN3\",\"name\":\"AnhDN3\",\"emailAddress\":\"AnhDN3@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10122\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10122\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10122\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10122\"},\"displayName\":\"Duong Ngoc Anh (FSU17.BU2)\",\"active\":true},\"priority\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/priority/3\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/priorities/major.png\",\"name\":\"Major\",\"id\":\"3\"},\"resolution\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/resolution/6\",\"id\":\"6\",\"description\":\"\",\"name\":\"Done\"},\"status\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/status/10001\",\"description\":\"\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/subtask.gif\",\"name\":\"Done\",\"id\":\"10001\",\"statusCategory\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/statuscategory/3\",\"id\":3,\"key\":\"done\",\"colorName\":\"green\",\"name\":\"Complete\"}}}}");
//			json.Add ("{\"expand\":\"renderedFields,names,schema,transitions,operations,editmeta,changelog\",\"id\":\"159212\",\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/issue/159212\",\"key\":\"F17B2CRED14-1722\",\"fields\":{\"summary\":\"About Double click on encryption folder\",\"issuetype\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/issuetype/9\",\"id\":\"9\",\"description\":\"Use to manage Q&A in our project\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/issuetypes/undefined.png\",\"name\":\"Q&A\",\"subtask\":false},\"creator\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhDC3\",\"name\":\"ThanhDC3\",\"emailAddress\":\"ThanhDC3@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10122\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10122\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10122\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10122\"},\"displayName\":\"Du Cong Thanh (FSU11.BU13)\",\"active\":true},\"description\":\"Dear Yoshida san,\\r\\nI would like to confirm about double click on encryption folder.\\r\\n\\r\\nWhen I double click on encryption folder, I will open Credeon folder. But encryption folder still open and Credeon folder will be opened in another window. It does not same as MAC client.\\r\\n\\r\\nIs it ok? Do I have to close encryption folder before open Credeon folder?\\r\\n\",\"project\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/project/12601\",\"id\":\"12601\",\"key\":\"F17B2CRED14\",\"name\":\"Credeon2014\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?pid=12601&avatarId=10011\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=small&pid=12601&avatarId=10011\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=xsmall&pid=12601&avatarId=10011\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=medium&pid=12601&avatarId=10011\"}},\"reporter\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhDC3\",\"name\":\"ThanhDC3\",\"emailAddress\":\"ThanhDC3@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10122\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10122\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10122\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10122\"},\"displayName\":\"Du Cong Thanh (FSU11.BU13)\",\"active\":true},\"worklog\":{\"startAt\":0,\"maxResults\":20,\"total\":0,\"worklogs\":[]},\"assignee\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhDC3\",\"name\":\"ThanhDC3\",\"emailAddress\":\"ThanhDC3@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10122\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10122\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10122\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10122\"},\"displayName\":\"Du Cong Thanh (FSU11.BU13)\",\"active\":true},\"priority\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/priority/3\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/priorities/major.png\",\"name\":\"Major\",\"id\":\"3\"},\"resolution\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/resolution/1\",\"id\":\"1\",\"description\":\"A fix for this issue is checked into the tree and tested.\",\"name\":\"Fixed\"},\"status\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/status/6\",\"description\":\"The issue is considered finished, the resolution is correct. Issues which are closed can be reopened.\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/statuses/closed.png\",\"name\":\"Closed\",\"id\":\"6\",\"statusCategory\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/statuscategory/3\",\"id\":3,\"key\":\"done\",\"colorName\":\"green\",\"name\":\"Complete\"}}}}");
//			json.Add ("{\"expand\":\"renderedFields,names,schema,transitions,operations,editmeta,changelog\",\"id\":\"146377\",\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/issue/146377\",\"key\":\"F17B2CRED14-1303\",\"fields\":{\"summary\":\"[AT Sprint3] [Windows] hgcchpwd project's resource settings\",\"issuetype\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/issuetype/4\",\"id\":\"4\",\"description\":\"An improvement or enhancement to an existing feature or task.\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/issuetypes/improvement.png\",\"name\":\"Improvement\",\"subtask\":false},\"creator\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhLT2\",\"name\":\"ThanhLT2\",\"emailAddress\":\"ThanhLT2@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10112\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10112\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10112\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10112\"},\"displayName\":\"La Tien Thanh (FSU17.BU2)\",\"active\":true},\"description\":\"hgcchpwd project's resource settings is not good about switching resource between CCP/EN and HCP/JP.\\r\\nAnd version info resource is wrong. (file name etc) Please refer to other projects.\",\"project\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/project/12601\",\"id\":\"12601\",\"key\":\"F17B2CRED14\",\"name\":\"Credeon2014\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?pid=12601&avatarId=10011\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=small&pid=12601&avatarId=10011\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=xsmall&pid=12601&avatarId=10011\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/projectavatar?size=medium&pid=12601&avatarId=10011\"}},\"reporter\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhLT2\",\"name\":\"ThanhLT2\",\"emailAddress\":\"ThanhLT2@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10112\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10112\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10112\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10112\"},\"displayName\":\"La Tien Thanh (FSU17.BU2)\",\"active\":true},\"worklog\":{\"startAt\":0,\"maxResults\":20,\"total\":0,\"worklogs\":[]},\"assignee\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/user?username=ThanhDC3\",\"name\":\"ThanhDC3\",\"emailAddress\":\"ThanhDC3@fsoft.com.vn\",\"avatarUrls\":{\"48x48\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?avatarId=10122\",\"24x24\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=small&avatarId=10122\",\"16x16\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=xsmall&avatarId=10122\",\"32x32\":\"https://insight.fsoft.com.vn/jira/secure/useravatar?size=medium&avatarId=10122\"},\"displayName\":\"Du Cong Thanh (FSU11.BU13)\",\"active\":true},\"priority\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/priority/3\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/priorities/major.png\",\"name\":\"Major\",\"id\":\"3\"},\"resolution\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/resolution/6\",\"id\":\"6\",\"description\":\"\",\"name\":\"Done\"},\"status\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/status/10001\",\"description\":\"\",\"iconUrl\":\"https://insight.fsoft.com.vn/jira/images/icons/subtask.gif\",\"name\":\"Done\",\"id\":\"10001\",\"statusCategory\":{\"self\":\"https://insight.fsoft.com.vn/jira/rest/api/2/statuscategory/3\",\"id\":3,\"key\":\"done\",\"colorName\":\"green\",\"name\":\"Complete\"}}}}");

			for (int i = 0; i < json.Count; i++) {
				issueOb.Add (JsonConvert.DeserializeObject<Issue> (json[i]));
			}

			issueList = issueOb;
		}
	}
}
