#region Services
///////////////////////////////////////////////////////
// Application services/DI Container configures ///////
///////////////////////////////////////////////////////

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

#endregion

#region App
///////////////////////////////////////////////////////
// Application middlewares and entrypoint /////////////
///////////////////////////////////////////////////////

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();
app.MapControllers();
app.Run();

#endregion
