using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Wiki.BLL.Interfaces;
using Wiki.BLL.Services;
using Wiki.BLL.ViewModels;

namespace Wiki.BLL.Helpers
{
    public static class ServiceConfigHelper
    {
        private static Uri _corsApiUrl = new Uri("https://localhost:5001/api/cors/");

        public static IServiceCollection Create() => new ServiceCollection().Configure();

        public static IServiceCollection Configure(this IServiceCollection services)
        {
            services.AddSingleton(new HttpClient { BaseAddress = _corsApiUrl });
            services.AddScoped<SearchComponentViewModel>();
            services.AddScoped<EntityPageViewModel>();
            services.AddTransient<ISearchService, SearchService>();
            services.AddTransient<IEntityService, EntityService>();

            return services;
        }
    }
}
