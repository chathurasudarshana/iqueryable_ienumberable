/*
DB Migration Commands
Enable-Migrations
Add-Migration 'name'
Update-Database –Verbose
 */

namespace iqueryable_ienumberable
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                Employee employee = new Employee
                {
                    Name = "EmName1"

                };

                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();

                Employee employee2 = (from e in dbContext.Employees
                                      orderby e.Name
                                      select e).First();


                // IEnumerable
                IEnumerable<Employee> employees1 = dbContext.Employees.Where(e => e.Name == "EmName1");
                employees1 = employees1.Where(e => e.DepartmentId == null);
                employees1 = employees1.Take(3);

                foreach(Employee employee1 in employees1)
                {

                }

                IQueryable<Employee> employees2 = dbContext.Employees.Where(e => e.Name == "EmName1");
                employees2 = employees2.Where(e => e.DepartmentId == null);
                employees2 = employees2.Take(3);

                foreach (Employee emplemployee1oyees2 in employees2)
                {

                }

            }
        }
    }
}
