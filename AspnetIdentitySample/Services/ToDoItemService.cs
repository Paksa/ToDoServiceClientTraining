using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoManager.Data;
using ToDoManager.Models;
using ToDoManager.ToDoRemoteService;

namespace ToDoManager.Services
{
	public class ToDoItemService : IToDoItemService
	{
		// this is fake solution! !NEVER TRY TO ACCESS DB FROM SERVICES WITHOUT A REASON!
		private static IList<ToDoModel> _db = new List<ToDoModel>();
		private IUserRetrieverService _userService;
	    private IToDoItemService _toDoItemService;
        private readonly ToDoRemoteService.ToDoManager _toDoManager = new ToDoRemoteService.ToDoManager();
		public ToDoItemService(IUserRetrieverService userService, IToDoItemService toDoItemService)
		{
			_userService = userService;
		    _toDoItemService = toDoItemService;
		}

		public Task<IEnumerable<ToDoModel>> GetAll()
		{
		    
            ToDoItem[] todos = _toDoManager.GetTodoList(_userService.GetCurrentUser().UserId, true);
			// Filter by user here
			//return Task.FromResult((IEnumerable<ToDoModel>)_db);
		    var model = new List<ToDoModel>();
		    
            
            using (var context = new TransactionCacheDbContext())
            {
                foreach (var todo in todos)
                {
                    var todoModel = new ToDoModel() {Description = todo.Name, IsDone = todo.IsCompleted};
                    model.Add(todoModel);
                    context.Set<ToDoModel>().Attach(todoModel);
                }
                context.SaveChangesAsync();
            }
		    return Task.FromResult((IEnumerable<ToDoModel>)model);
		}

		public Task<ToDoModel> Create(ToDoModel todo)
		{
            
			todo.Id = Guid.NewGuid().GetHashCode(); // almost random
		    ToDoItemLocal toDoCreateTransaction = null;
		    using (var context = new TransactionCacheDbContext())
		    {
		        toDoCreateTransaction = new ToDoItemLocal(TransactionType.Create, todo);
		        context.Set<ToDoItemLocal>().Add(toDoCreateTransaction);
		        context.SaveChanges();
		    }
		    var task = Task.Run(() =>
		        {
		            bool operationSuccess = true;
		            try
		            {
		                var toDoManager = new ToDoRemoteService.ToDoManager();
		                var todoItem = new ToDoItem();
		                todoItem.IsCompleted = todo.IsDone;
		                todoItem.Name = todo.Description;
		                todoItem.UserId = _userService.GetCurrentUser().UserId;
		                todoItem.ToDoId = todo.Id;
		                toDoManager.CreateToDoItem(todoItem);
		            }
		            catch (Exception ex)
		            {
		                operationSuccess = false;
		            }
		            if (operationSuccess)
		            {
		                using (var context = new TransactionCacheDbContext())
		                {
		                    context.Set<ToDoItemLocal>().Remove(toDoCreateTransaction);
		                    context.SaveChanges();
		                }
		            }
		        });

			return Task.FromResult(todo);
		}

		public Task<ToDoModel> GetById(int id)
		{
			return Task.FromResult(_db.FirstOrDefault(x => x.Id == id));
		}

		public Task<bool> RemoveById(int id)
		{
			_db.Remove(_db.FirstOrDefault(x => x.Id == id));

			return Task.FromResult(true);
		}

		public Task<ToDoModel> Update(ToDoModel todo)
		{
			var existingTodo = _db.FirstOrDefault(x => x.Id == todo.Id);
			_db.Remove(existingTodo);
			_db.Add(todo);

			return Task.FromResult(todo);
		}
	}
}