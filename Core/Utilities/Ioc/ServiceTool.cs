﻿using Microsoft.Extensions.DependencyInjection;
using System;

namespace Core.Utilities.Ioc
{
    public static class ServiceTool
    {
        public static IServiceProvider ServiceProvider { get; set; }
        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}