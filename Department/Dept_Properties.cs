using System.ComponentModel.DataAnnotations;

namespace Department
{
    internal class Dept_Properties
    {
        [Key]
        public int Department_id { get; set; }
        public string? Department_Name { get; set; }
        public string? Department_shortName { get; set; }
    }
}
