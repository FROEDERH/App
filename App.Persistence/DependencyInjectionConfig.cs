﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Interfaces.Repositories;
using App.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace App.Persistence
{
    public class DependencyInjectionConfig
    {

        public static void Inject(IServiceCollection services)
        {

            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            
        }
    }
}
