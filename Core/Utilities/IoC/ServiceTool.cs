﻿using Microsoft.Extensions.DependencyInjection;

namespace Core.Utilities.IoC;

public static class ServiceTool
{   //.NET 'in service coleection yani servislerini kullnarak servislerini al ve onları build et
    //bu kod bizim web api de veya autofax te oluşturduğumuz injectionları oluştura bilmemizi yarıyor
    public static IServiceProvider ServiceProvider { get; private set; }

    public static IServiceCollection Create(IServiceCollection services)
    {
        ServiceProvider = services.BuildServiceProvider();
        return services;
    }
}