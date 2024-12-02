var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
////
//1st middleware
app.Use(async (context, next) =>
{
    context.Items["UserName"] = "Adi";
    await next();
});
// Another middleware where we retrieve UserName
app.Use(async (context, next) =>
{
    // Retrieve UserName from HttpContext.Items
    if (context.Items.TryGetValue("UserName", out var UserName))
    {
        Console.WriteLine($"UserName: {UserName}"); //O/P: UserName: Adi  // write your code here
    }
    await next();
});
////---------------------------------------------------
//1st middleware
app.Use(async (context, next) =>
{
    // Set custom header
    context.Request.Headers.Add("UserId", "123");
    await next();
});
//2nd middleware
app.Use(async (context, next) =>
{
    var userIdHeader = context.Request.Headers["UserId"];
    Console.WriteLine($"userIdHeader: {userIdHeader}"); //O/P: userIdHeader: 123  // write your code here
    await next();
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
