var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// these are all middleware
// UseHttpsRedirection, UseStaticFiles, UseRouting, UseAuthorization, MapRazorPages etc
app.UseHttpsRedirection();
app.UseStaticFiles(); 
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();// configure the routing of razor pages, it will be able to map the url pages.

app.Run();
