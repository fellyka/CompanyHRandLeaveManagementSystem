var builder = WebApplication.CreateBuilder(args);

//Add services for MVC
builder.Services.AddControllersWithViews();

//Access configuration
var myValue = builder.Configuration["MyKey"];
Console.WriteLine($"MyKey = {myValue}");






var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();
/*app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");*/

app.MapGet("/", () => $"MyKey : {myValue}");

app.Run();
