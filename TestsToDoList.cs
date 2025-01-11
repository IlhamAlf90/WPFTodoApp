using WPFTodoApp;
using Xunit;
namespace TestingToDoList
{
    public class TestsToDoList
    {
        private TodoList _todoList;
        public TestsToDoList()
        {
            _todoList = new TodoList();
        }
        //F�rsta test: att l�gga till task
        [Fact]
        public void AddTask_ShouldAddTaskToList()
        {
            var task = "Test task";
            _todoList.AddTask(task);
            var tasks = _todoList.GetAllTasks();
            Assert.Contains(task, tasks);
        }
        //Andra test: att ta bort task
        [Fact]
        public void RemoveTask_ShouldRemoveTaskToList()
        {
            var task = "Task to remove";
            _todoList.AddTask(task);
            _todoList.RemoveTask(0);
            var tasks = _todoList.GetAllTasks();
            Assert.DoesNotContain(task, tasks);
        }
        
      

        
    }
}
