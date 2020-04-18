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
    [Activity(Label = "RentBikeActivity", Theme = "@android:style/Theme.Holo.Light.NoActionBar.Fullscreen")]
    public class RentBikeActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            int i = 1;
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.RentBikePage);
            Button rentbtn = FindViewById<Button>(Resource.Id.rentbtn);

            rentbtn.Click += (o, e) =>
            {
                Toast.MakeText(this, "Confirmed", ToastLength.Short).Show();
              

                Notification.BigTextStyle textStyle = new Notification.BigTextStyle();

                textStyle.BigText("Your Code is 31-85-38");
                // Set the summary text:
                textStyle.SetSummaryText("Enjoy :)");

                var notificationBuilder = new Notification.Builder(this)

                    .SetContentTitle("Smarty's Notification")
                    .SetContentText("Body goes here...........This is a big Notificaiton in Notification Tray")
                    .SetAutoCancel(true)

                        .SetPriority((int)NotificationPriority.Max)
                    .SetDefaults(NotificationDefaults.Sound | NotificationDefaults.Vibrate | NotificationDefaults.Lights)
                .SetStyle(textStyle);

                if ((int)Android.OS.Build.VERSION.SdkInt >= 21)
                {
                    notificationBuilder.SetVisibility(NotificationVisibility.Public);
                    notificationBuilder.SetCategory(Notification.CategoryAlarm);
                    //notificationBuilder.SetSmallIcon(Resource.Drawable.transparentNotification);
                    notificationBuilder.SetSmallIcon(Resource.Drawable.logo);
                    //notificationBuilder.SetColor(Resources.GetColor(Resource));
                    notificationBuilder.SetVibrate(new long[] { 100, 200, 300 });
                }
                else
                    notificationBuilder.SetSmallIcon(Resource.Drawable.logo);

                var notificationManager = (NotificationManager)GetSystemService(Context.NotificationService);
                notificationManager.Notify(i++, notificationBuilder.Build());
            };

           
        }
    }
}