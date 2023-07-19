using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SkillAssessment.Models;
using SkillAssessment.Repository.AssessmentServices;
using SkillAssessment.Repository.HistoryTableRepository;
using SkillAssessment.Repository.Interfaces;
using SkillAssessment.Repository.TestHistoryRepository;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SkillAssessment.Data.SkillAssessmentDbContext>(optionsAction: options => options.UseSqlServer(builder.Configuration.GetConnectionString(name: "AdminSkill")));
/*builder.Services.AddScoped<UserService>();*/
builder.Services.AddScoped<IAssessmentDataServices, AssessmentDataServices>();
builder.Services.AddScoped<IHistoryTableService, HistoryTableService>();
builder.Services.AddScoped<ITestHistoryService, TestHistoryService>();
/*builder.Services.AddScoped<ITokenGenerate, TokenService>();*/
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["TokenKey"])),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });

builder.Services.AddCors(option =>
{
    option.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
        builder.AllowAnyOrigin();
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();

