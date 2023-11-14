using FastCare.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//USE THIS FOR YOUR SQLSERVER DATABASE ON YOUR SYSTEM
// builder.Services.AddDbContext<FastCareDbContext>(options=>{
//     options.UseSqlServer(builder.Configuration.GetConnectionString("Default"), b => b.MigrationsAssembly("FastCare.Api"));
// });


//USE THIS FOR THE OFFLINE SQLITE FILE, LIKE IF YOU DONT WANT THE STRESS OF STARTING SERVER AND ALL ;-)
builder.Services.AddDbContext<FastCareDbContext>(options=>{
    options.UseSqlite(builder.Configuration.GetConnectionString("Offline"),b => b.MigrationsAssembly("FastCare.Api"));
});



//USE THIS FOR THE LIVE SQL DATABASE , NOTE YOU MUST BE CONNECTED TO THE INTERNET,  ,FOR REAL TIME EXPERIENCE
// builder.Services.AddDbContext<FastCareDbContext>(options=>{
//     options.UseSqlServer(builder.Configuration.GetConnectionString("Online"), b => b.MigrationsAssembly("FastCare.Api"));
// });



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
