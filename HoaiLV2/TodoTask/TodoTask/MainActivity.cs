using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using System.Collections.Generic;

namespace TodoTask.Android
{
    [Activity(Label = "List task", MainLauncher = true, Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : Activity, ListView.IOnItemClickListener
    {
        private ListAdapter adapter;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
           
            // Get our button from the layout resource,
            // and attach an event to it
            ListView lv = FindViewById<ListView>(Resource.Id.listTodo);
            lv.DescendantFocusability = DescendantFocusability.BlockDescendants;
            lv.OnItemClickListener = this;

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.addTask:
                    {
                        StartActivity(typeof(ModifyActivity));
                        return true;
                    }
                case Resource.Id.delTask:
                    {
                        delTask();
                        return true;
                    }
                case Resource.Id.doneTask:
                    {
                        markComplete();
                        return true;
                    }
                default:
                    {
                        return base.OnOptionsItemSelected(item);
                    }
            }
        }

        public void OnItemClick(AdapterView parent, View view, int position, long id)
        {
            Intent intent = new Intent(this, typeof(DetailActivity));
            intent.PutExtra("taskID", this.adapter.DataSource[position].ID);
            StartActivity(intent);
        }

        protected override void OnResume()
        {
            base.OnResume();

            reloadListData();
        }

        private void delTask()
        {
            ListView gr = FindViewById<ListView>(Resource.Id.listTodo);
            List<TodoModel> listSelected = ((ListAdapter)gr.Adapter).SelectedList;

            if (listSelected.Count == 0)
            {
                Toast.MakeText(this, "You must select a task", ToastLength.Short);
                return;
            }

            Database db = new Database();
            foreach(TodoModel model in listSelected)
            {
                db.Delete(model.ID);
            }

            reloadListData();
        }

        private void markComplete()
        {
            ListView gr = FindViewById<ListView>(Resource.Id.listTodo);
            List<TodoModel> listSelected = ((ListAdapter)gr.Adapter).SelectedList;

            if (listSelected.Count == 0)
            {
                Toast.MakeText(this, "You must select a task", ToastLength.Short);
                return;
            }

            Database db = new Database();
            foreach (TodoModel model in listSelected)
            {
                model.Status = 0;
            }
            db.Update(listSelected);

            reloadListData();
        }

        private void reloadListData()
        {
            ListView gr = FindViewById<ListView>(Resource.Id.listTodo);
            adapter = new ListAdapter(this, new Database().GetAll());
            gr.Adapter = adapter;
        }
    }
}

