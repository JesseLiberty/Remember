using System;

using Xamarin.Forms;

namespace Remember {
	public class App : Application {


		static RememberDatabase database;

		public static RememberDatabase Database {
			get {
				if (database == null) {
					database = new RememberDatabase();
				}
				return database;
			}
		}


		public App() {
			// The root page of your application
			MainPage = new MainPage();
		}

		protected override void OnStart() {
			// Handle when your app starts
		}

		protected override void OnSleep() {
			// Handle when your app sleeps
		}

		protected override void OnResume() {
			// Handle when your app resumes
		}
	}
}

