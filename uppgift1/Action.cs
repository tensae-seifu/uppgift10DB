using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using tesddb2;

namespace uppgift1
{
    internal class Action
    {

        public static void AddStudentToDB(Student student, SqlConnection connection)
        {
            {
                // Insert data into the Students table
                Console.WriteLine("\nInserting data into the Students table.");
                Console.WriteLine("===========================\n\n");

                SqlCommand insertStudentCmd = new SqlCommand("INSERT INTO Students (StudentName, Age, Class, Gender) VALUES (@studentName, @studentAge, @studentClass, @studentGender)", connection);

                insertStudentCmd.Parameters.AddWithValue("@studentName", student.Name);
                insertStudentCmd.Parameters.AddWithValue("@studentAge", student.Age);
                insertStudentCmd.Parameters.AddWithValue("@studentClass", student.Class);
                insertStudentCmd.Parameters.AddWithValue("@studentGender", student.Gender);

                int rowsAffected = insertStudentCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Data inserted into the Students table.");
                }
                else
                {
                    Console.WriteLine("Failed to insert data into the Students table.");
                }
            }
        }
        public static void UpdateStudentToDB(Student student, SqlConnection connection)
        {
            {
            }
        }
        public static void DeleteStudentToDB(Student student, SqlConnection connection)
        {
            {
            }
        }
        public static void GetStudentsFromDB(Student student, SqlConnection connection)
        {
            {
            }
        }

    }
}
    




