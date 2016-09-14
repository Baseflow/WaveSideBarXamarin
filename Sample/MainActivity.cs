using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Views;
using Android.Support.V7.App;
using System;

namespace Sample
{
    [Activity(Label = "WaveSideBar", MainLauncher = true, Icon = "@mipmap/icon", Theme="@style/AppTheme")]
    public class MainActivity : AppCompatActivity, View.IOnClickListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            FindViewById<LinearLayout>(Resource.Id.openLeftPositionSample).SetOnClickListener(this);
        }

        public void openRightPositionSample(View view)
        {
            Intent intent = new Intent(this, typeof(RightPositionActivity));
            StartActivity(intent);
        }

        public void openLeftPositionSample(View view)
        {
            Intent intent = new Intent(this, typeof(LeftPositionActivity));
            StartActivity(intent);
        }

        public void openCustomIndexSample(View view)
        {
            Intent intent = new Intent(this, typeof(CustomIndexActivity));
            StartActivity(intent);
        }

        public void OnClick(View v)
        {
            openLeftPositionSample(v);
        }
    }
}

