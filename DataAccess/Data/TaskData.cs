using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;


public class TaskData : ITaskData
{
    private readonly ISqlDataAccess _db;

    public TaskData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<TaskModel>> GetAllTasks() =>
      _db.LoadData<TaskModel, dynamic>("dbo.spTask_GetAll", new { });

    public async Task<TaskModel?> GetTask(int id)
    {
        var result = await _db.LoadData<TaskModel, dynamic>(
        "dbo.spTask_Get",
        new { Id = id });
        return result.FirstOrDefault();
    }

    public Task InsertTask(TaskModel task) =>
     _db.SaveData("dbo.spTask_Insert",
     new { task.Assigner, task.AssignedTo, task.TypeOf, task.Initiation, task.Deadline });

    public Task UpdateTask(TaskModel task) =>
         _db.SaveData("dbo.spTaskUpdate", task);

    public Task DeleteTask(int id) =>
   _db.SaveData("dbo.spTask_Delete", new { Id = id });
}
