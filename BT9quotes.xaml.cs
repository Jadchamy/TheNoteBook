using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNoteBookByRibal.Classes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;

namespace TheNoteBookv8

{
   
    public partial class BT9quotes : ContentPage
    {
        public BT9quotes()
        {
            InitializeComponent();
        }
      protected override async void OnAppearing()
       {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetDataAsync();
        }
        async void Savetotdclicked(object sender , EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(totdEntry.Text))
            {
                await App.Database.SaveDataAsync(new Data
                {
                   Titleotd = totdEntry.Text,
                   DOD = DateTime.Now.ToString("ddMMyyyy"),
                });

                totdEntry.Text =  string.Empty;
                collectionView.ItemsSource = await App.Database.GetDataAsync();

            }
        }
    }
}