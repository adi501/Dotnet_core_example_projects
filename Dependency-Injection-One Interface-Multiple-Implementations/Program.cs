using Dependency_Injection_One_Interface_Multiple_Implementations;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddTransient<ShoppingCartAPI>();
builder.Services.AddTransient<ShoppingCartCache>();
builder.Services.AddTransient<ShoppingCartDB>();
builder.Services.AddTransient<ShoppingCartResolver>(serviceProvider => key =>
{
    switch (key)
    {
        case "API":
            return serviceProvider.GetService<ShoppingCartAPI>();
        case "Cache":
            return serviceProvider.GetService<ShoppingCartCache>();
        case "DB":
            return serviceProvider.GetService<ShoppingCartDB>();
        default:
            throw new KeyNotFoundException();
    }
});

builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public delegate IShoppingCart ShoppingCartResolver(string key);

