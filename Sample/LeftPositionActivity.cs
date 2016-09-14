using System;
using System.Collections.Generic;
using Android.App;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Com.Gjiazhe.Wavesidebar;
using System.Linq;

namespace Sample
{
    [Activity(Label = "WaveSideBar", Icon = "@mipmap/icon", Theme= "@style/AppTheme")]
    public class LeftPositionActivity : AppCompatActivity, WaveSideBar.IOnSelectIndexItemListener
    {
        private RecyclerView rvContacts;
        private WaveSideBar sideBar;

        private List<Contact> contacts = new List<Contact>();

        protected override void OnCreate(Android.OS.Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            initData();
            initView();
        }

        private void initView()
        {
            SetContentView(Resource.Layout.activity_contacts);
            rvContacts = FindViewById<RecyclerView>(Resource.Id.rv_contacts);
            rvContacts.SetLayoutManager(new LinearLayoutManager(this));
            rvContacts.SetAdapter(new ContactsAdapter(contacts, Resource.Layout.item_contacts_right));

            sideBar = (WaveSideBar)FindViewById(Resource.Id.side_bar);
            sideBar.SetPosition(WaveSideBar.PositionLeft);
            sideBar.SetOnSelectIndexItemListener(this);
        }

        public void OnSelectIndexItem(string index)
        {
            for (int i = 0; i < contacts.Count(); i++)
            {
                if (contacts.ElementAt(i).getIndex().Equals(index))
                {
                    ((LinearLayoutManager)rvContacts.GetLayoutManager()).ScrollToPositionWithOffset(i, 0);
                    return;
                }
            }
        }

        private void initData()
        {
            contacts.AddRange(Contact.getChineseContacts());
        }
    }
}

