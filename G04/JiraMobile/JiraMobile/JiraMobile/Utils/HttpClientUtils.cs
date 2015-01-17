using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace JiraMobile.Pages
{
    public class HttpClientUtils
    {
		// TODO : Mock data from Login screen
		private string username = "HoaiLV2";
		private string password = "XXXXX";
		private IProcessBarCallBack _IProcessBarCallBack;

		private string authStrBuild = "";

		private string baseURL = "https://insight.fsoft.com.vn/jira/";

		// TODO : Constructor Mock
		public HttpClientUtils()
		{
			authStrBuild = System.Convert.ToBase64String (Encoding.UTF8.GetBytes (username + ":" + password));
		}

		public HttpClientUtils(string username, string password, IProcessBarCallBack _IProcessBarCallBack)
		{
			// TODO : uncomment
//			this.username = username;
//			this.password = password;
			this._IProcessBarCallBack = _IProcessBarCallBack;
			authStrBuild = System.Convert.ToBase64String (Encoding.UTF8.GetBytes (this.username + ":" + this.password));
		}

		public async Task<RootIssueDetail> getIssuesById(string id)
		{
			var json = await executeApi<RootIssueDetail> ("rest/api/2/issue/537055?fields=id,key,assignee,status,resolution,summary,description,comments,priority,worklog,creator,reporter,project,issuetype");
			return json;
		}

		public async Task<T> executeApi<T>(string url)
		{
			// display processbar
			this._IProcessBarCallBack.Show ();

			var request = new HttpRequestMessage () {

				RequestUri = new Uri(baseURL + url),
				Method = HttpMethod.Get
			};

			request.Headers.Add ("Authorization", "Basic " + authStrBuild);
			request.Headers.Add ("User-Agent", "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:35.0) Gecko/20100101 Firefox/35.0");

			HttpClient client = new HttpClient ();
			var response = await client.SendAsync (request);
			var jsonResponse = await response.Content.ReadAsStringAsync ();

			this._IProcessBarCallBack.Hide ();

			return JsonConvert.DeserializeObject<T> (jsonResponse);
		}

		public interface IProcessBarCallBack
		{
			void Show ();
			void Hide();
		}
    }
}
