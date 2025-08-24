var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Enable CORS (Enables call from browser app)
// !!! Remove to block CORS
var AllowAnyFrontend = "_allowAnyFrontend";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowAnyFrontend, policy =>
    {
        policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });
});

var app = builder.Build();

app.UseCors(AllowAnyFrontend);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) // Use swagger only in development environment.
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
