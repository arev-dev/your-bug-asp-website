


using Microsoft.EntityFrameworkCore;
using ProjectPosts.BLL;
using ProjectPosts.BLL.Service;
using ProjectPosts.DAL;
using ProjectPosts.DAL.DataContext;
using ProjectPosts.DAL.Repositories;
using ProjectPosts.EN;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DbforoContext>(op => {
    op.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL"));
});

builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<ICommentService, CommentService>();

builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddScoped<IPostService, PostService>();


// builder.Services.AddScoped<IGenericRepository<Like>, LikeRepository>();
// builder.Services.AddScoped<ILikeService, LikeService>();

// builder.Services.AddScoped<IGenericRepository<Report>, ReportRepository>();
// builder.Services.AddScoped<IGenericService<Report>, ReportService>();

// builder.Services.AddScoped<IGenericRepository<Role>, RoleRepository>();
// builder.Services.AddScoped<IGenericService<Role>, RoleService>();

// builder.Services.AddScoped<IGenericRepository<StatusPost>, StatusPostRepository>();
// builder.Services.AddScoped<IGenericService<StatusPost>, StatusPostService>();

// builder.Services.AddScoped<IGenericRepository<TypeLike>, TypeLikeRepository>();
// builder.Services.AddScoped<IGenericService<TypeLike>, TypeLikeService>();

// builder.Services.AddScoped<IGenericRepository<Usuario>, UsuarioRepository>();
// builder.Services.AddScoped<IGenericService<Usuario>, UsuarioService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
    {
    endpoints.MapDefaultControllerRoute();
    });

// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
