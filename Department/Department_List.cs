using System.Data;

namespace Department
{
    internal class Department_List : Dept_Properties
    {
        public List<Dept_Properties> DepartmentMethod()
        {
            List<Dept_Properties> listDept_Properties = new List<Dept_Properties>
            {
            new Dept_Properties{Department_Name="Human Resources",Department_shortName="HR"},
            new Dept_Properties{Department_Name="Information Technology",Department_shortName="IT"},
            new Dept_Properties{Department_Name="Marketing Department",Department_shortName="MD"},
            new Dept_Properties{Department_Name="Operations Department",Department_shortName="OD"},
            new Dept_Properties{Department_Name="Finaance Department",Department_shortName="FD"},
            new Dept_Properties{Department_Name="Sales Department",Department_shortName="SD"}
            };
            return listDept_Properties;
        }
    }
}
