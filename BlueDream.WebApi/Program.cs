using BlueDream.WebApi;
using Microsoft.OpenApi.Models;

internal class Program
{
    /*
        
    数据库：mysql（bule_dream）
    字符集：utf8mb4 -- UTF-8 Unicode 
    排序规则：utf8mb4_0900_ai_ci

     */ 

    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container. 
        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();


        builder.Services.AddDistributedMemoryCache();
        builder.Services.AddSession(options => {
            options.IdleTimeout = TimeSpan.FromSeconds(60);
            options.Cookie.HttpOnly = true;
        });
       
         
        //添加Swagger
        builder.Services.AddSwaggerGen();
        //添加Header参数
        builder.Services.AddSwaggerGen(c =>
        { 
            c.OperationFilter<AddHeaderFilter>(); 
        });

        //跨域设置
        builder.Services.AddCors(policy =>
        {
            policy.AddPolicy("CorsPolicy", opt => opt
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod()
            .WithExposedHeaders("X-Pagination"));
        });

     
        var app = builder.Build();

        //跨域设置
        app.UseCors("CorsPolicy");

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseSession();

        app.UseHttpsRedirection(); 
        
        //权限中间件
        app.UseMiddleware<AuthorizationMW>();
        //app.UseAuthorization();
        //允许core跨域
        app.UseCors("AllRequests");
        
        app.MapControllers();

        app.Run();
    }
}