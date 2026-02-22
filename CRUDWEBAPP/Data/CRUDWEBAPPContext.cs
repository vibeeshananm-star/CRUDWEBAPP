using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDWEBAPP.Model;

namespace CRUDWEBAPP.Data
{
    public class CRUDWEBAPPContext : DbContext
    {
        public CRUDWEBAPPContext (DbContextOptions<CRUDWEBAPPContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDWEBAPP.Model.User> User { get; set; } = default!;
    }
}
