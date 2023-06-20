namespace TaskManagerApi.Controllers;

public static class EmployeeApi
{
    public static void ConfigureEmployeeApi(this WebApplication app)
    {
        //All of my EmployeeAPI endpoint mapping
        app.MapGet("/AllEmployee", GetAllEmployees);
        app.MapGet("/Employee/{id}", GetEmployee);
        app.MapPost("/StoreEmployee", InsertEmployee);
        app.MapPut("/UpdateEmployee", UpdateEmployee);
        app.MapDelete("/DeleteEmployee", DeleteEmployee);
    }

    private static async Task<IResult> GetAllEmployees(IEmployeeData data)
    {
        try
        {
            return Results.Ok(await data.GetAllEmployee());
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }
    private static async Task<IResult> GetEmployee(int id, IEmployeeData data)
    {
        try
        {
            var results = await data.GetEmployee(id);
            if (results == null) return Results.NotFound();
            return Results.Ok(results);
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertEmployee(EmployeeModel task, IEmployeeData data)
    {
        try
        {
            await data.InsertEmployee(task);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateEmployee(EmployeeModel task,
    IEmployeeData data)
    {
        try
        {
            await data.UpdateEmployee(task);

            return Results.Ok();
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteEmployee(int id,
    IEmployeeData data)
    {
        try
        {
            await data.DeleteEmployee(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }
}
