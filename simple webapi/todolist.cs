using Microsoft.AspNetCore.Mvc;

namespace MyTodo.Controllers
{
    [ApiController]
    //is an attribute indicating that this class is an API controller and performs automatic model validation.

    [Route("api/todos")]  //the base route for all actions within this controller
    public class MyTodoController : ControllerBase
    {
        //private  List<Todo> todoList = new List<Todo>();
        private static List<Todo> todoList = new List<Todo>();
        //so that new list is not created everytime

        [HttpGet]
        public List<Todo> GetAllTodos()
        {
            return todoList;
        }

        [HttpPost]
        public Todo Create(Todo todo)
        {
            //set id, add the item and return the item
            todo.id = todoList.Count + 1;
            todoList.Add(todo);

            return todo;
        }

        [HttpPut("{id}")]
        public Todo Update(int id, Todo todo)
        {
            var existingTodo = todoList.FirstOrDefault(x => x.id == id);

            if (existingTodo != null)
            {
                existingTodo.text = todo.text;
                existingTodo.done = todo.done;
                return existingTodo;
            }

            return null;
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var existingTodo = todoList.FirstOrDefault(x => x.id == id);

            if (existingTodo != null)
            {
                todoList.Remove(existingTodo);
                return true;
            }

            return false;
        }
    }

    public class Todo
    {
        public int id { get; set; }
        public string text { get; set; }
        public bool done { get; set; }
    }
}