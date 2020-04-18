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
    [Activity(Label = "FacebookActivity", Theme = "@android:style/Theme.Holo.Light.NoActionBar.Fullscreen")]
    public class FacebookActivity : Activity
    {
      
            WebView web_view;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.FacebookPage);

            web_view = FindViewById<WebView>(Resource.Id.webView1);
            web_view.Settings.JavaScriptEnabled = true;
            web_view.SetWebViewClient(new HelloWebViewClient());
            web_view.LoadUrl(
                "https://www.facebook.com/TECH-Stadium-290138555234859/?__tn__=kCH-R&eid=ARAZe8uoarlKLntNNEptJ4epxGXzWHY_52wDvzUd3jnGzSgBCBdDx-KBqlmmTrnOEmI_KK6f4Npdy1in&hc_ref=ARS4hfrkpgDJnSqYQ1sT_9aRhwAH8pnrQzCvldgGORQI0OcV-DMzgXD3f7Qsu4mVfrs&fref=nf&__xts__[0]=68.ARDlayJKSSrQMBnycfNvp7EmKF7ntBLPH2Czyg8nL9y9KQJFqkFNjTxD6x__eKMJ7f3_cMMCXYs10dRnQ4PajVi41c6KglHDUpioHdwUI_oQSCz3eUvVFopIkQBWKtKdHI5rPymgqE_grKII7myKijcU5rP2whBORToa5z-n1Azsk5tGNHnkMNISMI2kIlMwRu7irHhGT4Ag3MkmH1KNSMWoGJmGlI2UECcl3VOt3W20Rra8GS1uEMRmxmf8igSGZ4W-tXMR8EHocwz55WGNYnXNMAPvteEMtzapwDpBaQF3uC7v4boCueCmCaAjH78xnLkfEY-uHgdZ9Lg");

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