
using masroufiServer.models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using masroufiServer.hubs;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddSignalR();


//builder.WebHost.UseUrls("http://localhost:5001");

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("Default");


builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddRoleManager<RoleManager<IdentityRole>>().AddDefaultTokenProviders();


builder.Services.AddAuthorization();





builder.Services.Configure<IdentityOptions>(options =>
 {
     // Very weak passward
     options.Password.RequiredLength = 8;

 });


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII
                        .GetBytes(builder.Configuration.GetSection("AppSettings:Key").Value)),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };

                }).AddFacebook(options=>
                {
                    options.AppId = "791954841862094";
                    options.AppSecret = "c3e02217769ecd359bba937c874baee0";
                   // options.AccessDeniedPath = "/AccessDeniedPathInfo";
                });


builder.Services.AddCors();

//builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});







// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.CustomSchemaIds(type => type.ToString());
});




var app = builder.Build();


app.UseCors(options => options.WithOrigins("http://localhost:4200")
               .AllowAnyMethod()
               .AllowAnyHeader());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapHub<MissionHub>("/missions");
});



app.MapControllers();
app.UseStaticFiles(new StaticFileOptions { FileProvider=new PhysicalFileProvider(Path.Combine(app.Environment.ContentRootPath, "vids")),
    RequestPath="/vids"

});









app.Run();
