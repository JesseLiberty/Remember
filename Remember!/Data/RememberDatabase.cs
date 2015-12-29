using System;
using SQLite;
using Xamarin.Forms;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace Remember {
	
	public class RememberDatabase {
		SQLiteConnection database;
		static object locker = new object();

		public RememberDatabase() {
			database = DependencyService.Get<ISQLite>().GetConnection();
			database.CreateTable<OccasionData>();
			database.CreateTable<InfoData>();
		}

		public int SaveOccasion(OccasionData occasion) {
			lock (locker) {
				if (occasion.Id != 0) {
					database.Update(occasion);
					return occasion.Id;
				} else {
					return database.Insert(occasion);
				}
			}
		}

		public int SaveInfo(InfoData info) {
			lock (locker) {
				if (info.Id != 0) {
					database.Update(info);
					return info.Id;
				} else {
					return database.Insert(info);
				}
			}
		}

		public IEnumerable<OccasionData> GetOccasions() {
			lock (locker) {
				return (from o in database.Table<OccasionData>()
				        select o).ToList();
			}
		}

		public IEnumerable<InfoData> GetInfos() {
			lock (locker) {
				return (from i in database.Table<InfoData>()
				        select i).ToList();
			}
		}

		public OccasionData GetOccasion(int id) {
			lock (locker) {
				return database.Table<OccasionData>().Where(o => o.Id == id).FirstOrDefault();
			}
		}

		public InfoData GetInfo(int id) {
			lock (locker) {
				return database.Table<InfoData>().Where(i => i.Id == id).FirstOrDefault();
			}
		}

	}
}

