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
    public partial class BT8book : ContentPage
    {
        public BT8book()
        {
            InitializeComponent();
        }
        async void SaveLessonsclicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lesson1.Text))
            {
                await App.Database.SaveLessonsAsync(new Lessons
                {
                    lesson1 = lesson1.Text,
                    lesson2 = lesson2.Text,
                    lesson3 = lesson3.Text,
                    lesson4 = lesson4.Text,
                    DODL = DateTime.Now.ToString("ddMMyyyy"),
                });

                lesson1.Text = string.Empty;
                lesson2.Text = string.Empty;
                lesson3.Text = string.Empty;
                lesson4.Text = string.Empty;



            }
        }
    }
}