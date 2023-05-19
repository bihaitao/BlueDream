using BlueDream.WebApi;
using Microsoft.OpenApi.Models;

internal class Program
{
    /*
        
    ���ݿ⣺mysql��bule_dream��
    �ַ�����utf8mb4 -- UTF-8 Unicode 
    �������utf8mb4_0900_ai_ci

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
       
         
        //���Swagger
        builder.Services.AddSwaggerGen();
        //���Header����
        builder.Services.AddSwaggerGen(c =>
        { 
            c.OperationFilter<AddHeaderFilter>(); 
        });

        //��������
        builder.Services.AddCors(policy =>
        {
            policy.AddPolicy("CorsPolicy", opt => opt
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod()
            .WithExposedHeaders("X-Pagination"));
        });

     
        var app = builder.Build();

        //��������
        app.UseCors("CorsPolicy");

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseSession();

        app.UseHttpsRedirection(); 
        
        //Ȩ���м��
        app.UseMiddleware<AuthorizationMW>();
        //app.UseAuthorization();
        //����core����
        app.UseCors("AllRequests");
        
        app.MapControllers();

        app.Run();
    }
}