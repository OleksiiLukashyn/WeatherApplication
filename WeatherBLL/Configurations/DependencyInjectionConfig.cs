﻿using Microsoft.Extensions.DependencyInjection;
using Refit;
using System;
using WeatherBLL.Interfaces;
using WeatherBLL.Services;


namespace WeatherBLL.Configurations
{
    public static class DependencyInjectionConfig
    {
        private const string WeaterApiUrl = "http://api.openweathermap.org";

        public static void ConfigureDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IWeatherService, WeatherService>();

            services.AddRefitClient<IWeatherDataProvider>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(WeaterApiUrl));

        }
    }
}
