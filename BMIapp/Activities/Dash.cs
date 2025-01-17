﻿using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Snackbar;
using Android.Util;
using AndroidX.Fragment.App;
using BMIapp.Fragments;
using Google.Android.Material.BottomNavigation;

namespace BMIapp.Activities
{
    [Activity(Label = "BeMeAPP", Theme = "@style/AppTheme.NoActionBar")]
    public class Dash : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        AndroidX.Fragment.App.FragmentManager fragmentManager;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.ActivityMain);

            //Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            //SetSupportActionBar(toolbar);
            fragmentManager = SupportFragmentManager;

            ReplaceFragment(new FeedFragment(), "Feed");

            BottomNavigationView bottom = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);
            bottom.SetOnNavigationItemSelectedListener(this);
        }


        public bool OnNavigationItemSelected(IMenuItem item)
        {
            int id = item.ItemId;

            if (id == Resource.Id.messages)
            {

            }

            return true;

        }

        public void ReplaceFragment(AndroidX.Fragment.App.Fragment fragment, string tag)
        {
            fragmentManager = SupportFragmentManager;

            fragmentManager.BeginTransaction().Replace(Resource.Id.content_frame, fragment, tag)
                .Commit();
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

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View)sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (View.IOnClickListener)null).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

    }
}