using System;
using System.IO;
using Xamarin.Forms;
using Remember.iOS;

[assembly:Dependency(typeof(SQLite_iOS))]
namespace Remember.iOS {


	public class SQLite_iOS : ISQLite {

		public SQLite_iOS() {
		}


		public SQLite.SQLiteConnection GetConnection() {
			var path = "/users/jesseliberty/Data/Remember.db";

			File.Open(path, FileMode.OpenOrCreate);

			var conn = new SQLite.SQLiteConnection(path);

			return conn;
		}
	}
}

