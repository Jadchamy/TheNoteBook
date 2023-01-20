using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.LocalNotification;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheNoteBookv8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BTcalendretm : ContentPage
    {
        public BTcalendretm()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), onTimerTick);
           
            
        }
       
        bool onTimerTick()
        {

            var notification = new NotificationRequest
            {

                BadgeNumber = 1,
                Description = entrymsg.Text,
                NotificationId = 1337,
                Title = "REMINDER",
                
                
               

            };
           
            if (swtch.IsToggled && (DateTime.Now.TimeOfDay.Seconds == tmpicker.Time.Seconds))
            {
                swtch.IsToggled = false;
                
                NotificationCenter.Current.Show(notification);
                NotificationPriority max = NotificationPriority.Max;
                
            }
            return true;
            
        }
    }
}