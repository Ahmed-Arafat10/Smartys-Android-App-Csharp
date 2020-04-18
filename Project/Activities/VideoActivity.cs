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
using Android;

namespace Project
{
    [Activity(Label = "VideoActivity", Theme = "@android:style/Theme.Holo.Light.NoActionBar.Fullscreen")]
    public class VideoActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.VideoPage);
            var videoView = FindViewById<VideoView>(Resource.Id.videoView1);
            string VideoPath = "android.resource://" + PackageName + "/" + Resource.Raw.Trailer;
            var uri = Android.Net.Uri.Parse(VideoPath);
            videoView.SetVideoURI(uri);
            MediaController media = new MediaController(context: this);
            videoView.SetMediaController(media);
            media.SetAnchorView(videoView);
            videoView.Start();
        }

       
    }
}