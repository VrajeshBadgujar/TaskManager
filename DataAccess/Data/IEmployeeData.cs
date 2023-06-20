using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IEmployeeData
    {
        Task DeleteEmployee(int id);
        Task<IEnumerable<EmployeeModel>> GetAllEmployee();
        Task<EmployeeModel?> GetEmployee(int id);
        Task InsertEmployee(EmployeeModel emp);
        Task UpdateEmployee(EmployeeModel emp);
    }
}