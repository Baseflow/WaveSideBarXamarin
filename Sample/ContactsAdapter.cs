using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System.Linq;

namespace Sample
{
    public class ContactsAdapter : RecyclerView.Adapter
    {
        private List<Contact> contacts;
        private int layoutId;

        public ContactsAdapter(List<Contact> contacts, int layoutId)
        {
            this.contacts = contacts;
            this.layoutId = layoutId;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            LayoutInflater inflater = LayoutInflater.From(parent.Context);
            View view = inflater.Inflate(layoutId, null);
            return new ContactsViewHolder(view) as RecyclerView.ViewHolder;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder h, int position)
        {
            var holder = (ContactsViewHolder)h;

            Contact contact = contacts.ElementAt(position);
            if (position == 0 || !contacts.ElementAt(position - 1).getIndex().Equals(contact.getIndex()))
            {
                holder.tvIndex.Visibility = ViewStates.Visible;
                holder.tvIndex.Text = contact.getIndex();
            }
            else {
                holder.tvIndex.Visibility = ViewStates.Gone;
            }
            holder.tvName.Text = contact.getName();
        }

        public override int ItemCount
        {
            get
            {
                return contacts.Count;
            }
        }

        public class ContactsViewHolder : RecyclerView.ViewHolder
        {
            public TextView tvIndex;
            public ImageView ivAvatar;
            public TextView tvName;

            public ContactsViewHolder(View itemView) : base(itemView)
            {
                tvIndex = itemView.FindViewById<TextView>(Resource.Id.tv_index);
                ivAvatar = itemView.FindViewById<ImageView>(Resource.Id.iv_avatar);
                tvName = itemView.FindViewById<TextView>(Resource.Id.tv_name);
            }
        }
    }
}