﻿using Microsoft.AspNetCore.Cors.Infrastructure;

namespace BlueDream.WebApi
{
    public class CorsMW
    {
        private readonly RequestDelegate next;

        public CorsMW(RequestDelegate next) 
        { 
            this.next = next; 
        }

        public async Task Invoke(HttpContext context) 
        { 
            if (context.Request.Headers.ContainsKey(CorsConstants.Origin)) 
            { 
                context.Response.Headers.Add("Access-Control-Allow-Origin", context.Request.Headers["Origin"]);
                context.Response.Headers.Add("Access-Control-Allow-Methods", "PUT,POST,GET,DELETE,OPTIONS,HEAD,PATCH");
                context.Response.Headers.Add("Access-Control-Allow-Headers", context.Request.Headers["Access-Control-Request-Headers"]);
                context.Response.Headers.Add("Access-Control-Allow-Credentials", "true");
               
                if (context.Request.Method.Equals("OPTIONS"))
                {
                    context.Response.StatusCode = StatusCodes.Status200OK;
                    return;
                }
            }

            await next(context);
        } 
    }
}
