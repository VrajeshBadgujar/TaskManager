using DataAccess.Models;

namespace DataAccess.Data
{
    public interface ITaskData
    {
        Task DeleteTask(int id);
        Task<IEnumerable<TaskModel>> GetAllTasks();
        Task<TaskModel?> GetTask(int id);
        Task InsertTask(TaskModel task);
        Task UpdateTask(TaskModel task);
    }
}