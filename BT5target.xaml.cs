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
    public partial class BTtarget : ContentPage
    {
        public BTtarget()
        {
            InitializeComponent();
        }
        async void Savetargetsclicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(goal1.Text))
            {
                await App.Database.SaveTargetsAsync(new Targets
                {
                    Target1 = goal1.Text,
                    Target2 = goal2.Text,
                    Target3 = goal3.Text,
                    Target4 = goal4.Text,
                    Target5 = goal5.Text,
                    DODT = DateTime.Now.ToString("ddMMyyyy"),
                }) ;

                goal1.Text = string.Empty;
                goal2.Text = string.Empty;
                goal3.Text = string.Empty;
                goal4.Text = string.Empty;
                goal5.Text = string.Empty;

                

            }
        }
    }
}