using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tesddb2;

namespace uppgift1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the DbConnect class to establish a database connection
            DbCOnnect conn = new DbCOnnect(new SqlConnection());

            // Call the Connect method to establish the database connection
            conn.Connect();

            // Create a new Student object
            Student newStudent = new Student(0, "", 0, "", "");

            Console.WriteLine("Enter Student Name: ");
            newStudent.Name = Console.ReadLine();

            Console.WriteLine("Enter Student Age: ");
            newStudent.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Class: ");
            newStudent.Class = Console.ReadLine();

            Console.WriteLine("Enter Student Gender: ");
            newStudent.Gender = Console.ReadLine();

            // Insert the Student object into the database
           Action.AddStudentToDB(newStudent, conn._Conn);

            

            Action.GetStudentsFromDB(conn._Conn);


            Action.DeleteStudentFromDB( conn._Conn);

            // Close the connection
            conn._Conn.Close();
        }
    }
}
