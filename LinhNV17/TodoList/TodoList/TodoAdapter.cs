using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Newtonsoft.Json;

namespace TodoList
{
    public class TodoAdapter : BaseAdapter<Todo>
    {
        Activity context;
        List<Todo> listTodo;

        public TodoAdapter(Activity c, string filePath)
        {
            context = c;

            //open stream input from file
            using (StreamReader reader = new StreamReader(c.OpenFileInput(filePath)))
            {
                //get all text data from file
                string jsonData = reader.ReadToEnd();

                if (!string.IsNullOrEmpty(jsonData))
                    //parse to list todo
                    listTodo = JsonConvert.DeserializeObject<List<Todo>>(jsonData);
                else listTodo = new List<Todo>();

                reader.Close();
            }
        }

        public override Todo this[int position]
        {
            get { return listTodo != null && listTodo.Count > 0 ? listTodo[position] : new Todo(); }
        }

        public override int Count
        {
            get { return listTodo != null && listTodo.Count > 0 ? listTodo.Count : 0; }
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            //View view = convertView; // re-use an existing view, if one is available
            //if (view == null) // otherwise create a new one
            //    view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);
            //view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = listTodo[position].Task;

            //Button viewButton = new Button(context);
            //viewButton.Text = listTodo[position].Task;

            Todo objTodo = listTodo[position];

            View viewTask = convertView;

            //reference to custom row view
            if (viewTask == null)
                viewTask = context.LayoutInflater.Inflate(Resource.Layout.CustomRowView, null);
            
            //reference to txtTaskName
            viewTask.FindViewById<TextView>(Resource.Id.txtTaskName).Text = objTodo.Task;

            //reference to txtTaskWhere
            if (!string.IsNullOrEmpty(objTodo.Location))
                viewTask.FindViewById<TextView>(Resource.Id.txtTaskWhere).Text = objTodo.Location;
            else
                viewTask.FindViewById<TextView>(Resource.Id.txtTaskWhere).Text = "NO LOCATION";

            //if (viewTask == null)
            //{
            //    viewTask = new TextView(context);
            //}

            //((TextView)viewTask).Text = listTodo[position].Task;            



            return viewTask;
        }
    }
}