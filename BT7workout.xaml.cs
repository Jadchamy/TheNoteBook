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
    public partial class BT7workout : ContentPage
    {
        public BT7workout()
        {
            InitializeComponent();
        }
        async void SaveWorkoutclicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Cardiowrkt.Text))
            {
                await App.Database.SaveWorkoutAsync(new Workout
                {
                    Cardio = Cardiowrkt.Text,
                    Weights = Weightswrkt.Text,
                    Yoga = Yogawrkt.Text,
                    Others = Otherswrkt.Text,
                    DODW = DateTime.Now.ToString("ddMMyyyy"),
                });

                Cardiowrkt.Text = string.Empty;
                Weightswrkt.Text = string.Empty;
                Yogawrkt.Text = string.Empty;
                Otherswrkt.Text = string.Empty;



            }
        }
    }
}