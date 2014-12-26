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
using TodoTask.Android;

namespace TodoTask
{
    [Activity(Label = "Detail task", Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.Portrait)]
    public class DetailActivity : Activity
    {
        private TodoModel task;
        private int taskID;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.Detail);

            taskID = Intent.GetIntExtra("taskID", 0);

            //initData();
        }

        protected override void OnResume()
        {
            base.OnResume();

            initData();
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_detail, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.detail_menu_done:
                    {
                        markComplete();
                        return true;
                    }
                case Resource.Id.detail_menu_edit:
                    {
                        editTask();
                        return true;
                    }
                case Resource.Id.detail_menu_del:
                    {
                        delTask();
                        return true;
                    }
                default:
                    {
                        return base.OnOptionsItemSelected(item);
                    }
            }
        }

        private void markComplete()
        {
            this.task.Status = 0;
            new Database().Update(new List<TodoModel> { task });
            base.OnBackPressed();
        }

        private void initData()
        {
            task = new Database().Get(taskID);

            var tvTitle = FindViewById<TextView>(Resource.Id.detail_tv_title);
            tvTitle.Text = task.Title;

            var tvContent = FindViewById<TextView>(Resource.Id.detail_tv_content);
            tvContent.Text = task.Content;
        }

        private void delTask()
        {
            new Database().Delete(this.task.ID);
            base.OnBackPressed();
        }

        private void editTask()
        {
            Intent intent = new Intent(this, typeof(ModifyActivity));
            intent.PutExtra("taskID", this.task.ID);
            StartActivity(intent);
        }
    }
}