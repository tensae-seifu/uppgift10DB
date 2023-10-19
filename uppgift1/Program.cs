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
            char choice;
          

            Console.WriteLine($"\t\t WELCOME TO CHAS ACADEMY\n");


     do {

            Console.WriteLine($"\t\t Press {"V"} to view list of students , Press {"+"} to add student , Press {"-"} to delete student");
            choice=Convert.ToChar( Console.ReadLine() );
               
                
                
                DbCOnnect conn = new DbCOnnect(new SqlConnection());
                conn.Connect();
              
                switch (choice )
            {


                case '+':

                     
                

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
                        conn._Conn.Close();
                        break;

                case '-':
                        conn._Conn.Close();
                        Action.DeleteStudentFromDB( conn._Conn);
                      

                        break;


                case 'v':
                      
                        Action.GetStudentsFromDB(conn._Conn);
                        conn._Conn.Close();
                   break;

                        default:

                        Console.WriteLine("Wrong Choice");

                       break;  
            }


               

            } while (true);


          


        }
    }
}
