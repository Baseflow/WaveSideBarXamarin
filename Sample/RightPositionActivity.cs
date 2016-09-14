using System;
using System.Collections.Generic;
using Android.App;
using Android.Support.V7.Widget;
using Com.Gjiazhe.Wavesidebar;

namespace Sample
{
    [Activity(Label = "WaveSideBar", Icon = "@mipmap/icon", Theme = "@style/AppTheme")]
    public class RightPositionActivity
    {
        private RecyclerView rvContacts;
        private WaveSideBar sideBar;

        private List<Contact> contacts = new List<Contact>();

        public RightPositionActivity()
        {
        }
    }
}

