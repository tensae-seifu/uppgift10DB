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

               
                // Pass the connection to the SqlCommand
                SqlCommand cmd = new SqlCommand("SELECT * FROM Students  ", connection);

                // SQL internal object that reads data from a table is called a SqlDataReader
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("\t\t\t{0}\t{1}\t{2}\t{3}\t\t{4}", "Student ID", "Student Name", "Student Age", "Student Class","Student Gender");

                    while (reader.Read())
                    {


                        Console.WriteLine("\t\t\t{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4));
                    }
                }
                else
                {
                    Console.WriteLine("No rows");
                }

                reader.Close();

                //  close the connection when  done.
                connection.Close();
            }
        }
        }

    }

    




