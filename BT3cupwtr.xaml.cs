using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheNoteBookv8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BTcupwtr : ContentPage
    {
        public BTcupwtr()
        {
            InitializeComponent();
        }
        private int a = 0;
        private void waterclicked(object sender, EventArgs e)
        {

            a++;
            textbox1.Text = a.ToString();
            if (a == 1)
            {
                cup1.IsVisible = true;
            }
            if (a == 2)
            {
                cup2.IsVisible = true;
            }
            if (a == 3)
            {
                cup3.IsVisible = true;
            }
            if (a == 4)
            {
                cup4.IsVisible = true;
            }
            if (a == 5)
            { 
                cup5.IsVisible = true;
            }
            if (a == 6)
            {
                cup6.IsVisible = true;
            }
            if (a == 7)
            {
                cup7.IsVisible = true;
            }
            if (a == 8)
            {
                cup8.IsVisible = true;
            }


        }
    }
}