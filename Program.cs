using Microsoft.EntityFrameworkCore;
using Biblio.Models;

var builder = WebApplication.CreateBuilder(args);

// Ajouter la cha�ne de connexion et configurer le DbContext
builder.Services.AddDbContext<BiblioDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));

// Ajouter les services n�cessaires pour les contr�leurs et vues
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurer le pipeline de requ�tes HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
