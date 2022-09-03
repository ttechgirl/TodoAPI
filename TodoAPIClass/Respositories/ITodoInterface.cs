using System.Collections.Generic;

namespace TodoAPIClass.Respositories
{
    public interface ITodoInterface
    {
        List<Todo> GetTodos();
        Todo GetTodo();
        ResponseModel SaveTodo(Todo todo);
        ResponseModel DeleteTodo(long Id);
        ResponseModel UpdateTodo(Todo todo);

        
    } 
}
