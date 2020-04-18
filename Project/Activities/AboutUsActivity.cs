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
    [Activity(Label = "AboutUsActivity", Theme = "@android:style/Theme.Holo.Light.NoActionBar.Fullscreen")]
    public class AboutUsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.AboutUsPage);



            Button fbbtn = FindViewById<Button>(Resource.Id.fbbtn);


            fbbtn.Click += delegate
            {
                var intent = new Intent(this, typeof(FacebookActivity));
                StartActivity(intent);
            };



            Button websitebtn = FindViewById<Button>(Resource.Id.websitebtn);


            websitebtn.Click += delegate
            {
                var intent = new Intent(this, typeof(WebSiteActivity));
                StartActivity(intent);
            };






        }
    }
}