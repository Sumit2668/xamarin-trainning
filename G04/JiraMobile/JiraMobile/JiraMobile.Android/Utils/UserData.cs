using System;
using JiraMobile.Utils;
using SQLite;
using Android.App;
using Android.Content;

[assembly: Xamarin.Forms.Dependency (typeof(JiraMobile.Droid.UserData))]
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
//			string folder = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
//			var conn = new SQLiteConnection (System.IO.Path.Combine (folder, "jira.db"));
//			conn.CreateTable<UserLogin> ();
//			conn.DeleteAll<UserLogin> ();
//			var data = new UserLogin {
//				Token = token
//			};
//			conn.Insert (data);

			var prefs = Application.Context.GetSharedPreferences("JiraApp", FileCreationMode.Private);
			var prefsEditor = prefs.Edit();
			prefsEditor.PutString("Login", token);
			prefsEditor.Commit();
		}

		public string getAuth ()
		{
//			string folder = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
//			var conn = new SQLiteConnection (System.IO.Path.Combine (folder, "jira.db"));
//			return conn.Table<	UserLogin> ().FirstOrDefault ().Token;
			var prefs = Application.Context.GetSharedPreferences("JiraApp", FileCreationMode.Private);
			var value = prefs.GetString ("Login", null);
			return value;
		}

		#endregion
	}

	public class UserLogin
	{
		public string Token { get; set; }
	}
}

