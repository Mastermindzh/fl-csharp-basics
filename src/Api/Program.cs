using Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Express like :P
// this puts logic into a separate class that governs that concern, way better already
app.MapGet("/3-largest-prime", () =>
{
    return 1;
})
.WithName("SumOfEvenFibonacci")
.WithOpenApi();

await app.RunAsync();
