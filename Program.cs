var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
   // app.UseHsts(); //EU Q COMENTEI ESSA LINHA POIS CRIEI O DOCS ERRADO
}

//app.UseHttpsRedirection(); // EU Q COMENTEI ESSA LINHA POIS CRIEI O DOCS ERRADO
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
   
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
