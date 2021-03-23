
namespace iqueryable_ienumberable
{
    using System.Data.Entity;

    internal class DataClassesDataContext : DbContext
    {
        public DataClassesDataContext() //: base("name=iquryable_ienumberable_db")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(e => e.Name).HasColumnName("EmName");
            modelBuilder.Entity<Employee>().Property(e => e.DepartmentId).IsOptional();
        }
    }
}
