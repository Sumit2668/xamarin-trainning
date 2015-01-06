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
    public class TodoBL
    {
        public void AddTask(IList<Todo> currentListTodo, Stream sourceStream)
        {
            //add task to current list
            //currentListTodo.Add(newTask);

            //using (StreamWriter writer = new StreamWriter(filePath, false))
            //{
            //    //clear current content file data
            //    writer.WriteLine(string.Empty);

            //    //save new content to file
            //    JsonSerializer jsonSerializer = new JsonSerializer();
            //    jsonSerializer.Serialize(writer, currentListTodo);

            //    writer.Close();
            //}

            using (StreamWriter writer = new StreamWriter(sourceStream))
            {
                //clear current content file data
                //writer.Write(string.Empty);

                //test
                string strSeriaizer = JsonConvert.SerializeObject(currentListTodo);
                
                JsonSerializer jsonSerializer = new JsonSerializer();

                //save new content to file                
                jsonSerializer.Serialize(writer, currentListTodo);

                //close stream
                writer.Close();
            }
        }

        public IList<Todo> GetAllTask(Stream streamSource)
        {
            IList<Todo> listTodo = new List<Todo>();

            //open stream input from file
            using (StreamReader reader = new StreamReader(streamSource))
            {
                //get all text data from file
                string jsonData = reader.ReadToEnd();

                if (!string.IsNullOrEmpty(jsonData))
                {
                    //parse to list todo
                    listTodo = JsonConvert.DeserializeObject<List<Todo>>(jsonData);
                }

                reader.Close();
            }

            return listTodo;
        }
    }
}