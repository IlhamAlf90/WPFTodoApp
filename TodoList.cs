using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTodoApp
{
    
    public class TodoList
    {
        private List<string> tasks = new List<string>();
        //lägga till metod
        public void AddTask(string task)
        {
            tasks.Add(task);
        }
        //ta bort metoden
        public void RemoveTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {

                tasks.RemoveAt(index);
            }
        }
        //metod att hämta alla task
        public List<string> GetAllTasks()
        {
            return tasks;
        }
        //metod att rensa 
        public void ClearTasks()
        {
            tasks.Clear();

        }

    }
}
