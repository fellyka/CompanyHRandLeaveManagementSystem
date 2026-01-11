//This lines create a WebApplicationBuilder instance used to configure the web application
// It sets up services, middleware, and other configurations needed for the application to run.
var builder = WebApplication.CreateBuilder(args);

//Add services for MVC
builder.Services.AddControllersWithViews();

//Access configuration
var myValue = builder.Configuration["MyKey"];
Console.WriteLine($"MyKey = {myValue}");


var app = builder.Build();

//Configure the HHTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

//Serves static files from the wwwroot folder
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

//Map endpoints for controllers
/*app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");*/

app.MapGet("/", () => $"MyKey : {myValue}");

//This line starts the web application and begins listening for incoming HTTP requests
app.Run();
