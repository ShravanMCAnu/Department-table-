// See https://aka.ms/new-console-template for more information
using Department;

Console.WriteLine("Hello, World!");
DB_Connection objDB_Connection = new DB_Connection();

int choice = 0;
objDB_Connection.InsertDept();
Console.WriteLine(" Firstly,\n\t   Department List inserted into DB sucessfully....");


do
{
    Console.WriteLine("\nWElcome to Employee Table For database operations choose below \n\t1.Update\n\t2.Delete\n\t4.Inserting\n\t5.Close DB");
    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        //case 1:
        //    objDB_Connection.Display();
            //break;
        case 1:
            objDB_Connection.Update();
            break;
        case 2:
            objDB_Connection.Delete();
            break;
        case 3:
            objDB_Connection.Inserting();
            break;

    }
}
while (choice < 4);
objDB_Connection.DBClear();
Console.WriteLine("Database CLosed Press Enter to exit the Console");



