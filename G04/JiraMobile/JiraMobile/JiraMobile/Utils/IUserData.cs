using System;

namespace JiraMobile.Utils
{
	public interface IUserData
	{
		void saveAuth(String token);
		string getAuth();
	}
}

