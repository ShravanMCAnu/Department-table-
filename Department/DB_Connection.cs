using System.Data.SqlClient;
namespace Department
{
    internal class DB_Connection : Department_List
    {
        readonly SqlConnection sqlCon = new("Server=LAPTOP-BJF2P1AA;Database=DatabaseOne;Trusted_Connection=true;");
       


        //public void Display()
        //{
        //    SqlCommand cmd6 = new SqlCommand("select * from department", sqlCon);
        //    sqlCon.Open();
        //    SqlDataReader reader6 = cmd6.ExecuteReader();
        //    while (reader6.Read())
        //    {
        //        for (int i = 0; i < reader6.VisibleFieldCount; i++)
        //        {
        //            Console.WriteLine("  " + reader6.GetValue(i));

        //        }
        //        Console.WriteLine("------------------------------------------");
        //    }
        //    sqlCon.Close();
        //}
        public void InsertDept()
        {
            Department_List obj = new();
            string query = "insert into department values(@name,@short)";
            var listing = obj.DepartmentMethod();
            foreach (var dept in listing)
            {
                SqlCommand cmd = new(query, sqlCon);
                cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar, 100).Value = dept.Department_Name;
                cmd.Parameters.Add("@short", System.Data.SqlDbType.NVarChar, 100).Value = dept.Department_shortName;
                sqlCon.Open();
                cmd.ExecuteNonQuery();

                sqlCon.Close();
               
            }


        }
        public void Update()
        {

            Console.WriteLine("The Department Table Values are:");
            SqlCommand cmd1 = new("select * from department", sqlCon);
            sqlCon.Open();
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(" " + reader.GetValue(i));

                }
                Console.WriteLine("------------------------------------------");
            }

            sqlCon.Close();
            Console.WriteLine("Enter values into department ID and Department Name You want to Update...");
            sqlCon.Open();
            int deptID = int.Parse(Console.ReadLine());
            string? deptName = Console.ReadLine();


            SqlCommand cmd2 = new("Update department  set Department_Name ='" + deptName + "' Where Department_id=" + deptID + "", sqlCon);

            cmd2.ExecuteNonQuery();
            Console.WriteLine("Updated Sucessfully");
            sqlCon.Close();

            SqlCommand cmd3 = new("select * from department Where Department_id=" + deptID + "", sqlCon);
            sqlCon.Open();
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                for (int i = 0; i < reader3.VisibleFieldCount; i++)
                {
                    Console.WriteLine("  " + reader3.GetValue(i));

                }
                Console.WriteLine("------------------------------------------");
            }
            sqlCon.Close();

        }

        public void Delete()
        {

            Console.WriteLine("The Department Table Values are:");
            SqlCommand cmd1 = new("select * from department", sqlCon);
            sqlCon.Open();
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(" " + reader.GetValue(i));

                }
                Console.WriteLine("------------------------------------------");
            }

            sqlCon.Close();
            Console.WriteLine("Enter values into departmentID You want to delete");
            sqlCon.Open();
            int deptid = int.Parse(Console.ReadLine());



            SqlCommand cmd2 = new("delete from department  Where department_Id=" + deptid + "", sqlCon);

            cmd2.ExecuteNonQuery();
            Console.WriteLine("deleted Sucessfully");
            sqlCon.Close();
        }

        public void Inserting()
        {
            Console.WriteLine("The department Table Values are:");
            SqlCommand cmd4 = new("select * from department", sqlCon);
            sqlCon.Open();
            SqlDataReader reader = cmd4.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(" " + reader.GetValue(i));

                }
                Console.WriteLine("------------------------------------------");
            }

            sqlCon.Close();

            Console.WriteLine("Enter department  details you want to insert into databse..... ");

            Console.WriteLine("Enter department  Name ");
            string? deptName = Console.ReadLine();
            Console.WriteLine("Enter department shortName");
            string? shortname = Console.ReadLine();
            sqlCon.Open();
            SqlCommand cmd5 = new("insert into  Employee values('" + deptName + "', " + shortname + ", )", sqlCon);
            cmd5.ExecuteNonQuery();
            sqlCon.Close();

        }

        public void  DBClear()
        {
            SqlCommand cmdclear = new("truncate table department", sqlCon);
            sqlCon.Open();
            cmdclear.ExecuteNonQuery();
            sqlCon.Close();
        }
    }
}
