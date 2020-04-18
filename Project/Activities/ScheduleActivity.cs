using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Project.Activities
{
    [Activity(Label = "ScheduleActivity", Theme = "@android:style/Theme.Holo.Light.NoActionBar.Fullscreen")]
    public class ScheduleActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.SchedulePage);

            Button button = FindViewById<Button>(Resource.Id.schedulebtn);
            button.Click += delegate { StartActivity(typeof(BuyTicketActivity)); };


        }
        
    }
}