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
using Android.Content.PM;

namespace TodoTask.Android
{
    [Activity(Label = "Add new task", Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.Portrait)]
    public class ModifyActivity : Activity
    {
        private int taskID = -1;
        private TodoModel task;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Modify);

            taskID = Intent.GetIntExtra("taskID", -1);

            if (taskID != -1)
            {
                this.task = new Database().Get(taskID);
                FindViewById<EditText>(Resource.Id.etTitle).Text = this.task.Title;
                FindViewById<EditText>(Resource.Id.etContent).Text = this.task.Content;
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_modify, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.saveTask:
                    {
                        if (this.taskID == -1)
                        {
                            new Database().Add(GetModel());
                        }
                        else
                        {
                            new Database().Update(GetModel());
                        }
                        base.OnBackPressed();
                        return true;
                    }

                default:
                    {
                        return base.OnOptionsItemSelected(item);
                    }
            }
        }

        private TodoModel GetModel()
        {
            var title = FindViewById<EditText>(Resource.Id.etTitle).Text;
            var content = FindViewById<EditText>(Resource.Id.etContent).Text;

            if (this.taskID == -1)
            {

                var entity = new TodoModel()
                {
                    Title = title,
                    Content = content
                };

                return entity;
            }
            else
            {
                task.Title = title;
                task.Content = content;

                return task;
            }
        }
    }
}