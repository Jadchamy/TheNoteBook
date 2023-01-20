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
    public partial class BT10note : ContentPage
    {
        public BT10note()
        {
            InitializeComponent();
        }
        async void SaveNoteclicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(note1.Text))
            {
                await App.Database.SaveNoteAsync(new Note
                {
                    Note1 = note1.Text,
                    Note2 = note2.Text,
                    Note3 = note3.Text,
                    Note4 = note4.Text,
                    DODN = DateTime.Now.ToString("ddMMyyyy"),
                });

                note1.Text = string.Empty;
                note2.Text = string.Empty;
                note3.Text = string.Empty;
                note4.Text = string.Empty;


            }
        }
    }
}