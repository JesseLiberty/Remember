using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Remember {
 
	public partial class Occasion : ContentPage {
 
		private int updateId = 0;

		public List<OccasionData> Occasions { get; set; }

		public Occasion() {
			InitializeComponent();
		}

		public void OnSaveClicked(object o, EventArgs e) {
			OccasionData occasionData = new OccasionData();
			occasionData.Name = OccasionEntry.Text;
			occasionData.Date = OccasionDate.Date;
			occasionData.Yearly = Yearly.IsToggled;
			occasionData.NotificationDays = string.IsNullOrEmpty(Notification.Text) ? 0 : int.Parse(Notification.Text);
			Clear();
			App.Database.SaveOccasion(occasionData);
			OccasionList.ItemsSource = App.Database.GetOccasions();
		}

		public void OnCancelClicked(object o, EventArgs e) {
			Clear();
		}

		private void Clear() {
			OccasionEntry.Text = string.Empty;
			Notification.Text = string.Empty;
			OccasionDate.Date = DateTime.Now;
		}

		protected override void OnAppearing() {
			base.OnAppearing();
			OccasionList.ItemsSource = App.Database.GetOccasions();

		}
	}
}

