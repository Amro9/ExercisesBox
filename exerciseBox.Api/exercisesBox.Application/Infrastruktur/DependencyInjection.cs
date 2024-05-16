﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace exercisesBox.Application.Infrastruktur;

public static class DependencyInjection
{
    public static IServiceCollection AddApplictaionConfiguration(this IServiceCollection services)
    {
        //Add MedaitR
        var assembly = typeof(DependencyInjection).GetTypeInfo().Assembly;
        services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(assembly));

        return services;
    }
}
