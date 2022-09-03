using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TodoAPIClass.Respositories
{
    
    public class TodoRepository : ITodoInterface
    {
        private TodoDBContext _dbContext;
        public TodoRepository(TodoDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ResponseModel DeleteTodo(long Id)
        {
            throw new System.NotImplementedException();
        }

        public Todo GetTodo()
        {
            throw new System.NotImplementedException();
        }

        public List<Todo> GetTodos()
        {
            throw new System.NotImplementedException();
        }

        public ResponseModel SaveTodo(Todo todo)
        {
            throw new System.NotImplementedException();
        }

        public ResponseModel UpdateTodo(Todo todo)
        {
            throw new System.NotImplementedException();
        }
    }
}
