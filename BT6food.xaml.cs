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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BTfood : ContentPage
    {
        public BTfood()
        {
            InitializeComponent();
        }
        
        async void Savemealsclicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(brkfst.Text))
            {
                await App.Database.SaveMealsAsync(new Meals
                {
                    Breakfast = brkfst.Text,
                    Lunch = lunch.Text,
                    Snacks = snacks.Text,
                    Dinner = diner.Text,
                    DODM = DateTime.Now.ToString("ddMMyyyy"),
                });

                brkfst.Text = string.Empty;
                lunch.Text = string.Empty;
                snacks.Text = string.Empty;
                diner.Text = string.Empty;


            }
        }
    }
}