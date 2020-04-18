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
    [Activity(Label = "ButTicketPage", Theme = "@android:style/Theme.Holo.Light.NoActionBar.Fullscreen")]
    public class BuyTicketActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.BuyTicketPage);

            Button proceedbtn = FindViewById<Button>(Resource.Id.proceedbtn);
            proceedbtn.Click += delegate { StartActivity(typeof(PaymentActivity)); };


        }
    }
}