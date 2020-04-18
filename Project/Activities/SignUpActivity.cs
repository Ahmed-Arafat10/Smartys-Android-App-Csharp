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
using System.IO;
using SQLite;
using Project.DataBase;

namespace Project.Activities
{
    [Activity(Label = "SignUpActivity", Theme = "@android:style/Theme.Holo.Light.NoActionBar.Fullscreen")]
    public class SignUpActivity : Activity
    {
        EditText txtusername;
        EditText txtPassword;
        Button btncreate;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SignUpPage);
            // Create your application here  
            btncreate = FindViewById<Button>(Resource.Id.signup2);
            txtusername = FindViewById<EditText>(Resource.Id.editText1);
            txtPassword = FindViewById<EditText>(Resource.Id.editText2);
            btncreate.Click += Btncreate_Click;
        }
        private void Btncreate_Click(object sender, EventArgs e)
        {
            try
            {
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3");
                var db = new SQLiteConnection(dpPath);
                db.CreateTable<LoginTable>();
                LoginTable tbl = new LoginTable();
                tbl.Username = txtusername.Text;
                tbl.Password = txtPassword.Text;
                db.Insert(tbl);
                Toast.MakeText(this, "Record Added Successfully", ToastLength.Short).Show();

            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }
        }
    }
}