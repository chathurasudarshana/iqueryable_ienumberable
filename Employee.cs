namespace iqueryable_ienumberable
{
    using System.ComponentModel.DataAnnotations;

    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}