using System.Linq;

using KobeIsNogSteedsCool.Models;

namespace KobeIsNogSteedsCool.Data
    {
    internal class ToDoRepository
        {
        public ToDo GetToDo(int id)
            {
            using (var dbContext = new KobeIsNogSteedsCoolContext())
                {
                return dbContext.ToDos.FirstOrDefault(x => x.Id == id);
                }
            }

        public void SaveToDo(ToDo todo)
            {
            using (var dbContext = new KobeIsNogSteedsCoolContext())
                {
                if (todo.Id == 0)
                    dbContext.ToDos.Add(todo);
                else
                    dbContext.ToDos.Update(todo);

                dbContext.SaveChanges();
                }
            }

        public void DeleteToDo(ToDo todo)
            {
            using (var dbContext = new KobeIsNogSteedsCoolContext())
                {
                dbContext.ToDos.Remove(todo);
                dbContext.SaveChanges();
                }
            }
        }
    }