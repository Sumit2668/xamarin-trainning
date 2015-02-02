using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using JiraMobile.Models;

namespace JiraMobile.Pages
{
    public class HttpClientUtils
    {
		private IProcessBarCallBack _IProcessBarCallBack;

		private string authStrBuild = "";

		private string baseURL = "https://insight.fsoft.com.vn/jira/";

		public HttpClientUtils(IProcessBarCallBack _IProcessBarCallBack)
		{
			this._IProcessBarCallBack = _IProcessBarCallBack;
			authStrBuild = System.Convert.ToBase64String (Encoding.UTF8.GetBytes (Login.strUserName + ":" + Login.strPassword));

			// TODO : hardcode
			authStrBuild = "dGhhbmhkYzM6QCNoaXBpQCM0NQ==";
		}

		public async Task<RootIssueDetail> getIssuesById(string id)
		{
			var json = await executeApi<RootIssueDetail> ("rest/api/2/issue/"+id+"?fields=id,key,assignee,status,resolution,summary,description,comment,priority,worklog,creator,reporter,project,issuetype,updated");
			System.Diagnostics.Debug.WriteLine ("aaa" + id);
			return json;
		}

		public async Task<List<Issue>> getAllIssueByProjectId(string key){
			var json = await executeApi<AllIssuesModel> ("rest/api/2/search?jql=project="+ key+"&maxResults=10&&fields=id,key,assignee,status,summary,priority,creator,reporter,project,issuetype,created");

			if (json != null) {
				return json.issues;
			} 

			return null;
		}

		public async Task<bool> authenAccount()
		{
			System.Net.HttpStatusCode resultAuthen =  await executeLogin("rest/auth/latest/session");
			return resultAuthen != System.Net.HttpStatusCode.Unauthorized;
		}

		public async Task<T> executeApi<T>(string url)
		{
			// display processbar
			this._IProcessBarCallBack.Show ();

			if (String.IsNullOrEmpty(Login.strUserName) || String.IsNullOrEmpty(Login.strPassword)) {

				return default(T);
			}

			var request = new HttpRequestMessage () {

				RequestUri = new Uri(baseURL + url),
				Method = HttpMethod.Get
			};

			request.Headers.Add ("Authorization", "Basic " + authStrBuild);
			request.Headers.Add ("User-Agent", "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:35.0) Gecko/20100101 Firefox/35.0");

			HttpClient client = new HttpClient ();
			var response = await client.SendAsync (request);
			var jsonResponse = await response.Content.ReadAsStringAsync ();

			var jsonResult = JsonConvert.DeserializeObject<T> (jsonResponse);

			this._IProcessBarCallBack.Hide ();

			return jsonResult;
		}

		public interface IProcessBarCallBack
		{
			void Show ();
			void Hide();
		}

		public async Task<System.Net.HttpStatusCode> executeLogin(string url)
		{
			// display processbar
			this._IProcessBarCallBack.Show ();

			if (String.IsNullOrEmpty(Login.strUserName) || String.IsNullOrEmpty(Login.strUserName)) {

				return System.Net.HttpStatusCode.NonAuthoritativeInformation;
			}

			var request = new HttpRequestMessage () {

				RequestUri = new Uri(baseURL + url),
				Method = HttpMethod.Get
			};

			request.Headers.Add ("Authorization", "Basic " + authStrBuild);
			request.Headers.Add ("User-Agent", "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:35.0) Gecko/20100101 Firefox/35.0");

			HttpClient client = new HttpClient ();
			var response = await client.SendAsync (request);

			System.Net.HttpStatusCode resultResponse = response.StatusCode;

			return resultResponse;
		}

    }
}
