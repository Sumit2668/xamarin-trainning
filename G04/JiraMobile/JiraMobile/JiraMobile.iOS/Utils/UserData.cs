using System;
using JiraMobile.Utils;
using Xamarin.Forms;
using System.Threading;
using MonoTouch.Security;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using JiraMobile.Droid;

[assembly: Dependency (typeof(UserData))]
namespace JiraMobile.Droid
{
	public class UserData : IUserData
	{
		public UserData ()
		{
		}

		#region IsUserData implementation

		public void saveAuth (string token)
		{
			var rec = new SecRecord (SecKind.GenericPassword) {
				Generic = NSData.FromString ("jira-login-uid:pw")
			};

			var s = new SecRecord (SecKind.GenericPassword) {
				Label = "Jira login username and password",
				Description = "Jira login username and password",
				Account = "Jira account",
				Service = "Jira mobile application",
				Comment = "This is jira's username and password that used to login jira",
				ValueData = NSData.FromString (token),
				Generic = NSData.FromString ("jira-login-uid:pw")
			};

			var err = SecKeyChain.Add (s);

			if (err == SecStatusCode.DuplicateItem) {
				err = SecKeyChain.Remove (rec);
				if (err == SecStatusCode.Success) {
					err = SecKeyChain.Add (s);
				}
			}

			if (err != SecStatusCode.Success) {
				//DisplayMessage ("Error adding record: {0}", err);
			}
		}

		public string getAuth ()
		{
			var rec = new SecRecord (SecKind.GenericPassword) {
				Generic = NSData.FromString ("jira-login-uid:pw")
			};

			SecStatusCode res;
			var match = SecKeyChain.QueryAsRecord (rec, out res);

			if (res == SecStatusCode.Success) {

//				return "";
				return NSString.FromData (match.ValueData, NSStringEncoding.UTF8);
			}

			return "";


		}

		#endregion

	}

	public class UserLogin
	{
		public string Token { get; set; }
	}
}

