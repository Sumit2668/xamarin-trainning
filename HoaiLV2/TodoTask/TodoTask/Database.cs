using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.IO;

namespace TodoTask.Android
{
    class Database
    {
        private SQLiteConnection conn;
        public Database()
        {
            string pathDb = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "todo.db3");
            conn = new SQLiteConnection(pathDb);
        }

        public void Add(TodoModel entity)
        {
            this.conn.CreateTable<TodoModel>();

            // mock data
            entity.Create = DateTime.Now;
            entity.Status = 1;

            this.conn.Insert(entity);
        }

        public List<TodoModel> GetAll()
        {
            try
            {
                return this.conn.Table<TodoModel>().ToList();
            }
            catch (Exception e)
            {
                return new List<TodoModel>();
            }
        }

        public bool Update(List<TodoModel> model)
        {
            this.conn.UpdateAll(model);
            return true;
        }

        public bool Update(TodoModel model)
        {
            this.conn.Update(model);
            return true;
        }

        public bool Delete(int id)
        {
            this.conn.Delete<TodoModel>(id);
            return true;
        }

        public TodoModel Get(int id)
        {
            return this.conn.Get<TodoModel>(id);
        }
    }
}