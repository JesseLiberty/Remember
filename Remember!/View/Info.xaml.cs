using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using System.Collections;

namespace Remember {
	public partial class Info : ContentPage {

		private int updateId = 0;

		public List<InfoData> Infos { get; set; }

		public Info() {
			InitializeComponent();
		}

		public void OnSaveClicked(object o, EventArgs e) {
			InfoData infoData = new InfoData();
			infoData.Name = Item.Text;
			infoData.InfoValue = Details.Text;
			infoData.ExtraInfo = string.Empty;
			infoData.LastModified = DateTime.Now;
			Clear();
			App.Database.SaveInfo(infoData);
			InfoList.ItemsSource = App.Database.GetInfos();

			
		}

		public void OnCancelClicked(object o, EventArgs e) {
			Clear();
		}

		private void Clear() {
			Item.Text = string.Empty;
			Details.Text = string.Empty;
		}

		protected override void OnAppearing() {
			base.OnAppearing();
			InfoList.ItemsSource = App.Database.GetInfos();
		}

	}
}

