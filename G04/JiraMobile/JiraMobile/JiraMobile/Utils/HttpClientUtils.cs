using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JiraMobile.Pages
{
    public class HttpClientUtils
    {
		// TODO : Mock data from Login screen
		private string username = "HoaiLV2";
		private string password = "XXXXXXX";
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
			this.username = username;
			this.password = password;
			this._IProcessBarCallBack = _IProcessBarCallBack;
		}

		public string getAllIssues()
		{
			return executeApi ("rest/api/2/search?jql=assignee=hoailv2").ToString();
		}

		public async Task<string> executeApi(string url)
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
			var response = await client.SendAsync (request).Result.Content.ReadAsStringAsync ();

			this._IProcessBarCallBack.Hide ();

			return response;
		}

		public interface IProcessBarCallBack
		{
			void Show ();
			void Hide();
		}
    }
}
