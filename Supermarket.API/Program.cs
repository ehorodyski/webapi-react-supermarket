﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Supermarket.API.Persistence.Contexts;

namespace Supermarket.API
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = CreateWebHost(args);

      using (var scope = host.Services.CreateScope())
      using (var context = scope.ServiceProvider.GetService<AppDbContext>())
      {
        context.Database.EnsureCreated();
      }

      host.Run();
    }

    public static IWebHost CreateWebHost(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build();
  }
}
