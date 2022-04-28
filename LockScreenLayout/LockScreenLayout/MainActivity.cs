using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using Google.Android.Material.Button;
using Android.Widget;

namespace LockScreenLayout
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        MaterialButton viewDetail;
        MaterialButton dismiss;
        MaterialButton snooze;
        TextView textView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            viewDetail = FindViewById<MaterialButton>(Resource.Id.view_detail);
            dismiss = FindViewById<MaterialButton>(Resource.Id.dismiss);
            snooze = FindViewById<MaterialButton>(Resource.Id.snooze);
            textView = FindViewById<TextView>(Resource.Id.textView1);

            viewDetail.Click += ViewDetailOnClick;
            dismiss.Click += DismissOnClick;
            snooze.Click += SnoozeOnClick;
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void ViewDetailOnClick(object sender, EventArgs eventArgs)
        {
            textView.Text = "View Detail Clicked";
        }

        private void DismissOnClick(object sender, EventArgs eventArgs)
        {
            textView.Text = "Dismiss Clicked";
        }

        private void SnoozeOnClick(object sender, EventArgs eventArgs)
        {
            textView.Text = "Snooze Clicked";
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}