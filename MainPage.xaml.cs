using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TheNoteBookv8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }

        
    }
}
