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
    [Activity(Label = "SigninupActivity", Theme = "@android:style/Theme.Holo.Light.NoActionBar.Fullscreen")]
    public class SigninupActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SigninupPage);

            Button signup1 = FindViewById<Button>(Resource.Id.signup1);
            

            signup1.Click += delegate
            {
                var intent = new Intent(this, typeof(SignUpActivity));
                StartActivity(intent);
            };


            Button login1 = FindViewById<Button>(Resource.Id.login1);
           

            login1.Click += delegate
            {
                var intent = new Intent(this, typeof(loginActivity));
                StartActivity(intent);
            };

            Button aboutbtn = FindViewById<Button>(Resource.Id.aboutbtn);


            aboutbtn.Click += delegate
            {
                var intent = new Intent(this, typeof(AboutUsActivity));
                StartActivity(intent);
            };


        }
    }
}

