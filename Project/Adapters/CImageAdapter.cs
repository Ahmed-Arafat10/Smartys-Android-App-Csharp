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

namespace Project.Adapters
{

    public class CImageAdapter : BaseAdapter
    {
        private Context context;
        private string[] gridViewString;
        private int[] gridViewImage;

        public CImageAdapter(Context c, string[] gridViewStr, int[] gridViewImg)
        {
            context = c;
            gridViewImage = gridViewImg;
            gridViewString = gridViewStr;
        }

        public override int Count
        {
            get { return gridViewString.Length; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view;
            LayoutInflater inflater = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
            if (convertView == null)
            {
                view = new View(context);
                view = inflater.Inflate(Resource.Layout.MainPage, null);
                TextView txtview = view.FindViewById<TextView>(Resource.Id.textView1);
                ImageView imgview = view.FindViewById<ImageView>(Resource.Id.imageView1);
                txtview.Text = gridViewString[position];
                imgview.SetImageResource(gridViewImage[position]);
            }
            else
            {
                view = (View)convertView;
            }
            return view;
        }

    }
}
