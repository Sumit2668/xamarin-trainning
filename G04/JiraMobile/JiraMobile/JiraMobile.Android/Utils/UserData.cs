using System;
using JiraMobile.Utils;
using Xamarin.Forms;
using SQLite;

[assembly: Dependency (typeof(JiraMobile.Droid.UserData))]
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
			string folder = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			var conn = new SQLiteConnection (System.IO.Path.Combine (folder, "jira.db"));
			conn.CreateTable<UserLogin> ();
			conn.DeleteAll<UserLogin> ();
			var data = new UserLogin {
				Token = token
			};
			conn.Insert (data);
		}

		public string getAuth ()
		{
			string folder = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			var conn = new SQLiteConnection (System.IO.Path.Combine (folder, "jira.db"));
			return conn.Table<	UserLogin> ().FirstOrDefault ().Token;
		}

		#endregion
	}

	public class UserLogin
	{
		public string Token { get; set; }
	}
}

