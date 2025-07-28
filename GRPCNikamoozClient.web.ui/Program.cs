using GRPCNikamoozClient.DLL.Repositories;
using GRPCNikamoozClient.Domain.Services;
using GRPCNikamoozClient.BLL.Services;
using static GRPCNikamoozClient.DLL.Protos.v1.StudentService;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<StudentRepository, StudentRepository>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddGrpcClient<StudentServiceClient>(c =>
{
    c.Address = new Uri(" https://localhost:7064");
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
