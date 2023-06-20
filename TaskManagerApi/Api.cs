namespace TaskManagerApi;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        //All of my API endpoint mapping
        app.MapGet("/AllTasks", GetAllTasks);
        app.MapGet("/Task/{id}", GetTask);
        app.MapPost("/StoreTasks", InsertTask);
        app.MapPut("/UpdateTasks", UpdateTask);
        app.MapDelete("/DeleteTasks", DeleteTask);
    }

    private static async Task<IResult> GetAllTasks(ITaskData data)
    {
        try
        {
            return Results.Ok(await data.GetAllTasks());
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }
    private static async Task<IResult> GetTask(int id, ITaskData data)
    {
        try
        {
            var results = await data.GetTask(id);
            if (results == null) return Results.NotFound();
            return Results.Ok(results);
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertTask(TaskModel task, ITaskData data)
    {
        try
        {
            await data.InsertTask(task);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateTask(TaskModel task,
    ITaskData data)
    {
        try
        {
            await data.UpdateTask(task);

            return Results.Ok();
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteTask(int id,
    ITaskData data)
    {
        try
        {
            await data.DeleteTask(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }
}
