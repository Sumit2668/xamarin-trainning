using System;

using Xamarin.Forms;

namespace Reminder
{
	public class App : Application
	{
		static TodoItemDatabase database;
		public static TodoItemDatabase Database {
			get { return database; }
		}

		public App ()
		{
			// The root page of your application
			/*
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						}
					}
				}
			};
			*/
			database = new TodoItemDatabase();

			MainPage = new NavigationPage (new TodoListPage ());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

