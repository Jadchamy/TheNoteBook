using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms; 
using Xamarin.Forms.Xaml;
using TheNoteBookByRibal.Classes;
using System.IO;

[assembly: ExportFont("Cinzel-VariableFont_wght.ttf",Alias ="Cinzel")]

namespace TheNoteBookv8
{
    public partial class App : Application
    {
        static Database database;
        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
       

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
