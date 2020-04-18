using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Project.Adapters;
using Project.Activities;

namespace Project
{
    [Activity(Label = "Project", Icon = "@drawable/icon", Theme = "@android:style/Theme.Holo.Light.NoActionBar.Fullscreen")]
    public class MainPageActivity : Activity
    {
       

        GridView gridView;
        string[] gridViewString = {"     My Location","     Bike","     My Tickets",
                                   "     Trailer","     Profile","     My Schedule",
                                   };
        int[] imageId = {Resource.Drawable.locationicon,Resource.Drawable.bicycleicon,
                         Resource.Drawable.ticketicon,Resource.Drawable.videoicon,
                         Resource.Drawable.profileicon,Resource.Drawable.scheduleicon,};

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainPage);
            CImageAdapter adapter = new CImageAdapter(this, gridViewString, imageId);
            gridView = FindViewById<GridView>(Resource.Id.gridview);
            gridView.Adapter = adapter;
            gridView.ItemClick += (s, e) =>
            {
                //Toast.MakeText(this, " " + gridViewString[e.Position],ToastLength.Short).Show();
                if (gridViewString[e.Position] == gridViewString[0])
                {
                    var intent = new Intent(this, typeof(LocationActivity));
                    StartActivity(intent);
                }
                else if (gridViewString[e.Position] == gridViewString[1])
                {
                    var intent = new Intent(this, typeof(BikeActivity));
                    StartActivity(intent);
                }
                else if (gridViewString[e.Position] == gridViewString[2])
                {
                    var intent = new Intent(this, typeof(MyTicketActivity));
                    StartActivity(intent);
                }
                else if (gridViewString[e.Position] == gridViewString[3])
                {
                    var intent = new Intent(this, typeof(VideoActivity));
                    StartActivity(intent);
                }
                else if (gridViewString[e.Position] == gridViewString[4])
                {
                    var intent = new Intent(this, typeof(ProfileActivity));
                    StartActivity(intent);
                }
                else if (gridViewString[e.Position] == gridViewString[5])
                {
                    var intent = new Intent(this, typeof(ScheduleActivity));
                    StartActivity(intent);
                }
                else if (gridViewString[e.Position] == gridViewString[5])
                {
                }
            };
        }
    }

}
