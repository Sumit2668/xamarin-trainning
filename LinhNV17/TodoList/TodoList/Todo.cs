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
using Newtonsoft.Json;

namespace TodoList
{
    public class Todo
    {
        public string Task { get; set; }
        public string Location { get; set; }
        public string Time { get; set; }

        public Todo()
        {

        }

        public Todo(string task)
        {
            Task = task;
        }
    }
}