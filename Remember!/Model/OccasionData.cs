using System;
using SQLite;

namespace Remember {
	public class OccasionData {
		
		[PrimaryKeyAttribute, AutoIncrement]
		public int Id { get; set; }

		public string Name { get; set; }

		public DateTime Date { get; set; }

		public bool Yearly { get; set; }

		public int NotificationDays { get; set; }
	}
}

