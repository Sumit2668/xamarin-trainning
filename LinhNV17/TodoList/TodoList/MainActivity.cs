using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;

namespace TodoList
{
    [Activity(Label = "TodoList", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        public string filePath = "data.json";

        protected override void OnCreate(Bundle bundle)
        {
            //call base class first of all
            base.OnCreate(bundle);

            //set view of current activity from the listtak resource layout
            SetContentView(Resource.Layout.ListTask);

            #region Create your application here

            #region Code handle button add

            //looking up control from view by Id (Auto-generated)
            Button btnAdd = FindViewById<Button>(Resource.Id.btnAdd);
            
            //bind click event for button add new task
            btnAdd.Click += (sender, e) => 
            {
                //call other activity from intent
                Intent itentAddTask = new Intent(this, typeof(AddTask));
                
                StartActivity(itentAddTask);
            };

            #endregion

            #region Display todo task from data

            Java.IO.File dataFile = this.GetFileStreamPath(filePath);

            #region Delete file
            //Java.IO.File fileDelete = new Java.IO.File(filePath);
            //bool deleted = fileDelete.Delete();

            //return;
            #endregion

            if (!dataFile.Exists())
            {
                //this.OpenFileOutput(filePath, FileCreationMode.Private);
                //Java.IO.File newFile = new Java.IO.File(new Context().in
                using (StreamWriter writer = new StreamWriter(this.OpenFileOutput(filePath, FileCreationMode.Private)))
                {
                    //writer.Write(string.Empty);

                    writer.Close();
                }
                
            }            
            //if (dataFile.Exists())
            //{
            //    ListView lvTask = FindViewById<ListView>(Resource.Id.lvTask);
            //    TodoAdapter todoAdapter = new TodoAdapter(this, filePath);
            //    lvTask.Adapter = todoAdapter;
            //}

            #endregion

            #endregion
            
        }

        protected override void OnResume()
        {
            base.OnResume();

            Java.IO.File dataFile = this.GetFileStreamPath(filePath);

            if (dataFile.Exists())
            {
                ListView lvTask = FindViewById<ListView>(Resource.Id.lvTask);                
                TodoAdapter todoAdapter = new TodoAdapter(this, filePath);                
                lvTask.Adapter = todoAdapter;
            }
        }
        
    }
}

