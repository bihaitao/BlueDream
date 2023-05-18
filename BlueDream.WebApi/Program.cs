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

        //���Swagger
        builder.Services.AddSwaggerGen();
        //���Header����
        builder.Services.AddSwaggerGen(c =>
        { 
            c.OperationFilter<AddHeaderFilter>(); 
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

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