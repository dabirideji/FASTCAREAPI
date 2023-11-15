using FastCare.Application.Dependencies.Interfaces.IRepositories;
using FastCare.Application.Dependencies.Interfaces.IServices;
using FastCare.Application.Dependencies.Services;
using FastCare.Infrastructure.Data;
using FastCare.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



//-------------------------------------------------------------------------------------------------------------------------------------------------------------------
//#DATABASE CONFIGURATIONS


//USE THIS FOR YOUR SQLSERVER DATABASE ON YOUR SYSTEM
// builder.Services.AddDbContext<FastCareDbContext>(options=>{
//     options.UseSqlServer(builder.Configuration.GetConnectionString("Default"), b => b.MigrationsAssembly("FastCare.Api"));
// });


//USE THIS FOR THE OFFLINE SQLITE FILE, LIKE IF YOU DONT WANT THE STRESS OF STARTING SERVER AND ALL ;-)
builder.Services.AddDbContext<FastCareDbContext>(options=>{
    options.UseSqlite(builder.Configuration.GetConnectionString("Offline"),b => b.MigrationsAssembly("FastCare.Api"));
});


//USE THIS FOR THE LIVE SQL DATABASE , NOTE YOU MUST BE CONNECTED TO THE INTERNET.
// builder.Services.AddDbContext<FastCareDbContext>(options=>{
//     options.UseSqlServer(builder.Configuration.GetConnectionString("Online"), b => b.MigrationsAssembly("FastCare.Api"));
// });



//--------------------------------------------------------------------------------------------------------------------------------------------------------------------





//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
//DEPENDENCY INJECTIONS AND SERVICE LIFETIMES

//DOCTOR SERVICE AND REPOSITORY
builder.Services.AddScoped<IDoctorService,DoctorService>();
builder.Services.AddScoped<IDoctorRepository,DoctorRepository>();




//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


// Add services to the container.

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
