﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Fiver.Mvc.FileUpload
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //add my custom comment
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
