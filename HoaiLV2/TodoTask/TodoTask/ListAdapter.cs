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


namespace TodoTask.Android
{
    public class ListAdapter : BaseAdapter
    {
        private Context ctx;
        public List<TodoModel> DataSource { get; set; }

        public List<TodoModel> SelectedList { get; set; }

        public ListAdapter(Context ctx, List<TodoModel> resource)
        {
            this.ctx = ctx;
            this.DataSource = resource;
            this.SelectedList = new List<TodoModel>();
        }

        public override int Count
        {
            get { return this.DataSource.Count; }
        }

        public override long GetItemId(int position)
        {
            return this.DataSource[position].ID;
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            if (convertView == null)
            {
                convertView = LayoutInflater.From(this.ctx).Inflate(Resource.Layout.ListViewItem, parent, false);
            }

            var tv = convertView.FindViewById<TextView>(Resource.Id.tvTitle);
            tv.Text = this.DataSource[position].Title;

            var tvDate = convertView.FindViewById<TextView>(Resource.Id.tvDate);
            tvDate.Text = this.DataSource[position].Create.ToShortDateString();

            var img = convertView.FindViewById<ImageView>(Resource.Id.imgStatus);

            if (this.DataSource[position].Status == 0) // done
            {
                img.SetImageResource(Resource.Drawable.done);
            } else
            {
                img.SetImageResource(Resource.Drawable.processing);
            }

            var cb = convertView.FindViewById<CheckBox>(Resource.Id.cbSl);
            cb.Click += delegate
            {
                if (!cb.Selected)
                {
                    this.SelectedList.Add(this.DataSource[position]);
                } 
                else
                {
                    this.SelectedList.RemoveAt(position);
                }
            };

            return convertView;
        }
    }
}