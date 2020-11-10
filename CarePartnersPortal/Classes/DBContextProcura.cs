using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class DBContextProcura : DbContext
    {

        public DBContextProcura(DbContextOptions<DBContextProcura> options)
            : base(options) { }
        public DbSet<ProcuraFile> ProcuraFiles { get; set; }

    }
}
