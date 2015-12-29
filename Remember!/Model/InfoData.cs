using System;
using System.Diagnostics.Contracts;
using SQLite;

namespace Remember {
	public class InfoData {
		[PrimaryKeyAttribute, AutoIncrement]
		public int Id { get; set; }

		public string Name { get; set; }

		public string InfoValue { get; set; }

		public string ExtraInfo { get; set; }

		public DateTime LastModified { get; set; }

	}
}

