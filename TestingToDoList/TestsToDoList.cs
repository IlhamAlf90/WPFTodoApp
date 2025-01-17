using WPFTodoApp;
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

        //tredje test: ogiltig index ska inte p�verka
        [Fact]
        public void RemoveTask_InvalidIndex_ShouldNotThrowException()
        {
            var task = "Valid Task";
            _todoList.AddTask(task);
            _todoList.RemoveTask(10); // Invalid index
            var tasks = _todoList.GetAllTasks();
            Assert.Single(tasks); //Den ursprungliga uppgiften ska fortfarande finnas kvar
        }

        //En till test f�r att hantera stort antal tasks utan att p�verka eller g�ra fel
        [Fact]
        public void AddTask_CouldAddManyTasks()
        {
            for (int i = 0; i < 1000; i++)
            {
                var task = "Task " + i;
                _todoList.AddTask(task);
            }
            var tasks = _todoList.GetAllTasks();
            Assert.Equal(1000, tasks.Count);
        }

    }
}