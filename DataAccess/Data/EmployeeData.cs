using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class EmployeeData : IEmployeeData
{
    private readonly ISqlDataAccess _db;

    public EmployeeData(ISqlDataAccess db)
    {
        _db = db;
    }


    public Task<IEnumerable<EmployeeModel>> GetAllEmployee() =>
      _db.LoadData<EmployeeModel, dynamic>("dbo.spEmployee_GetAll", new { });

    public async Task<EmployeeModel?> GetEmployee(int id)
    {
        var result = await _db.LoadData<EmployeeModel, dynamic>(
        "dbo.spEmployee_Get",
        new { Id = id });
        return result.FirstOrDefault();
    }

    public Task InsertEmployee(EmployeeModel emp) =>
     _db.SaveData("dbo.spEmployee_Insert", emp);
     //new { emp.EmployeeId, emp.firstName, emp.lastName, emp.IsManager });

    public Task UpdateEmployee(EmployeeModel emp) =>
         _db.SaveData("dbo.spEmployeeUpdate", emp);

    public Task DeleteEmployee(int id) =>
   _db.SaveData("dbo.spEmployee_Delete", new { Id = id });

}
