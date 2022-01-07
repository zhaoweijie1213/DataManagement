using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement.Model.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DataManagement.Entity
{
    public class SystemDbContext : DbContext
    {
        public SystemDbContext(DbContextOptions<SystemDbContext> options)
            : base(options)
        {

        }

    }
}
