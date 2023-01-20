using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomCalendarControl.Views;
using Rg.Plugins.Popup.Services;
using SQLite;
using TheNoteBookByRibal;
using TheNoteBookv8;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheNoteBookByRibal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Stat1 : ContentPage
    {
        public Stat1()
        {
            InitializeComponent();
        }
       
       
       
        async void btsave_Clicked(object sender, EventArgs e)
        {
            string M = Date5.Text;
            collectionView.ItemsSource = await App.Database.GetData1Async(M);
            collectionView1.ItemsSource = await App.Database.GetMeals1Async(M);
            collectionView2.ItemsSource = await App.Database.GetTargets1Async(M);
            collectionView3.ItemsSource = await App.Database.GetWorkout1Async(M);
            collectionView4.ItemsSource = await App.Database.GetLessons1Async(M);
            collectionView5.ItemsSource = await App.Database.GetNote1Async(M);
        }
       
    }
}