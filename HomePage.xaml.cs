using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomCalendarControl.Views;
using Rg.Plugins.Popup.Services;
using SQLite;
using TheNoteBookByRibal;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheNoteBookv8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        

        public HomePage()
        {
            InitializeComponent();

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetDataAsync();
         

        }
        public async void btnCalendar_Clicked(object sender, EventArgs e)
        {
            CalendarPage calendarPage = new CalendarPage(DateTime.Now,
                new CustomCalendarControl.Models.CalendarTheme
                {
                    HeaderBackgroundColor = Color.Black

                })



            {
                SelectedDateCommand = new Command<DateTime>((item) =>
                {

                    //Dateotd.Text = item.ToString("ddMMyyyy");
                    
                })
            };
            await PopupNavigation.Instance.PushAsync(calendarPage);
        }

        private async void bt2_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BTsleephr());
        }
        private async void bt3_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BTcupwtr());
        }
        private async void bt4_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BTcalendretm());
        }
        private async void bt5_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BTtarget());
        }
        private async void bt6_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BTfood());
        }
        private async void bt7_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BT7workout());
        }
        private async void bt8_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BT8book());
        }
        private async void bt9_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BT9quotes());
        }
        private async void bt10_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BT10note());
        }
        private async void bt11_clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Sorry", "This feature will be available soon", "Ok");
        }
        private async void bt12_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Stat1());
        }
        private async void Desc_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Description());
        }
    }
}