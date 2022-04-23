using MB.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrustructure.Core.IOC.Context
{
   public class ContextIOC
    {
        public static void ConfigIOC(ServiceCollection services, string ConnectionString)
        {
            services.AddDbContext<MasterBloggerDbContext>(options =>
            {
                options.UseSqlServer(ConnectionString);
            });
        }

    }
}
