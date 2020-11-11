using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options) { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<ITEquipmentOrder> ITEquipmentOrders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<TempInfo> TempInfos { get; set; }
        public DbSet<ITSystem> ITSystems { get; set; }
        public DbSet<EmployeeHire> EmployeeHires { get; set; }
        public DbSet<HireType> HireTypes { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<ITOutage> ITOutages { get; set; }
    }
}
