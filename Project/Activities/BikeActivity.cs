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
    [Activity(Label = "BikeActivity", Theme = "@android:style/Theme.Holo.Light.NoActionBar.Fullscreen")]
    public class BikeActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.BikePage);

            Button rentbtn = FindViewById<Button>(Resource.Id.rentbtn);


            rentbtn.Click += delegate
            {
                var intent = new Intent(this, typeof(RentBikeActivity));
                StartActivity(intent);
            };

            Button viewcodebtn = FindViewById<Button>(Resource.Id.viewcodebtn);


            viewcodebtn.Click += delegate
            {
                var intent = new Intent(this, typeof(ViewCodeActivity));
                StartActivity(intent);
            };



        }
    }
}