using System;
using SQLite;

namespace Remember {
	public interface ISQLite {
		SQLiteConnection GetConnection();
	}
}

