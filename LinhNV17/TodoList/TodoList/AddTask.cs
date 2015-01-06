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
using System.IO;

namespace TodoList
{
    [Activity(Label = "AddTask")]
    public class AddTask : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //set view of current activity from the AddTask resource layout (load view for activity)
            SetContentView(Resource.Layout.AddTask);

            #region Create your application here

            #region Code handle button cancel
            Button btnCancel = FindViewById<Button>(Resource.Id.btnCancel);
            btnCancel.Click += (sender, e) => 
            {
                //Close current activity
                this.Finish();
            };
            #endregion

            #region Code handle button add
            Button btnAdd = FindViewById<Button>(Resource.Id.btnAdd);
            btnAdd.Click += btnAdd_OnClick;
            #endregion

            #endregion
        }

        public void btnAdd_OnClick(object sender, EventArgs e)
        {
            //get EditText txtTask from view
            EditText txtTask = FindViewById<EditText>(Resource.Id.txtTask);
            
            //create new task
            Todo objNewTask = new Todo(txtTask.Text) { Location = "", Time = DateTime.Now.Ticks.ToString() };
            
            TodoBL objTodoBL = new TodoBL();
            IList<Todo> currentListTodo = new List<Todo>();

            //get output stream file to write
            using (Stream readStream = this.OpenFileInput(new MainActivity().filePath))
            {
                //get current list task
                currentListTodo = objTodoBL.GetAllTask(readStream);
                currentListTodo.Add(objNewTask);

                readStream.Close();
            }

            Java.IO.File dataFile = this.GetFileStreamPath(new MainActivity().filePath);

            //clear current content file data
            using (Java.IO.FileOutputStream fileOutput = new Java.IO.FileOutputStream(dataFile.AbsolutePath, false))
            {
                Java.IO.FileWriter fWriter = new Java.IO.FileWriter(fileOutput.FD);
                fWriter.Write(string.Empty);
                fWriter.Flush();
                fWriter.Close();
            }



            Stream writeStream = this.OpenFileOutput(new MainActivity().filePath, FileCreationMode.Append);
            objTodoBL.AddTask(currentListTodo, writeStream);

            //return previous activity
            this.Finish();
        }        
    }
}