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
using Android.Webkit;


namespace Project.Activities
{
    [Activity(Label = "LocationActivity", Theme = "@android:style/Theme.Holo.Light.NoActionBar.Fullscreen")]

   
    public class LocationActivity : Activity
        
    {
        WebView web_view;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.LocationPage);

            web_view = FindViewById<WebView>(Resource.Id.webView1);
            web_view.Settings.JavaScriptEnabled = true;
            web_view.SetWebViewClient(new HelloWebViewClient());
            web_view.LoadUrl("https://goo.gl/maps/f86Mp1XxpWbGcXes6");

            // Create your application here
        }
        public class HelloWebViewClient : WebViewClient
        {
            public override bool ShouldOverrideUrlLoading(WebView view, string url)
            {
                view.LoadUrl(url);
                return false;
            }
        }
    }
}