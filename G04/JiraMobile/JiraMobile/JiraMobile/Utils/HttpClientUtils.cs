using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JiraMobile.Pages
{
    public class HttpClientUtils
    {
		private string username = "HoaiLV2";
		private string password = "XXXXXXX";

		private string authStrBuild = "";

		private string baseURL = "https://insight.fsoft.com.vn/jira/";

		public HttpClientUtils()
		{
			authStrBuild = System.Convert.ToBase64String (Encoding.UTF8.GetBytes (username + ":" + password));
		}

		public string getAllIssues()
		{
			return executeApi ("rest/api/2/search?jql=assignee=hoailv2");
		}

		public string executeApi(string url)
		{
			var request = new HttpRequestMessage () {

				RequestUri = new Uri(baseURL + url),
				Method = HttpMethod.Get
			};

			HttpClient client = new HttpClient ();
			client.DefaultRequestHeaders.Add ("Authorization", "Basic " + authStrBuild);
			client.DefaultRequestHeaders.Add ("User-Agent", "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:35.0) Gecko/20100101 Firefox/35.0");
			request.Headers.Add ("Authorization", "Basic " + authStrBuild);
			request.Headers.Add ("User-Agent", "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:35.0) Gecko/20100101 Firefox/35.0");

			HttpClient client2 = new HttpClient ();
			var response = client2.SendAsync (request).Result.Content.ReadAsStringAsync().Result;

			return client.GetStringAsync (baseURL + url).Result;
		}
    }
}
