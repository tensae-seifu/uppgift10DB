﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using tesddb2;

namespace uppgift1
{
    internal class Action
    {

        public static void AddStudentToDB(Student student, SqlConnection conn)
        {
            {
                // Insert data into the Students table
                Console.WriteLine("\n\t\t\tInserting data into the Students table.");
                Console.WriteLine("\t\t\t=========================================\n\n");

                SqlCommand insertStudentCmd = new SqlCommand("INSERT INTO Students (StudentName, Age, Class, Gender) VALUES (@studentName, @studentAge, @studentClass, @studentGender)", conn);

                insertStudentCmd.Parameters.AddWithValue("@studentName", student.Name);
                insertStudentCmd.Parameters.AddWithValue("@studentAge", student.Age);
                insertStudentCmd.Parameters.AddWithValue("@studentClass", student.Class);
                insertStudentCmd.Parameters.AddWithValue("@studentGender", student.Gender);

                int rowsAffected = insertStudentCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("\t\t\tData inserted into the Students table.\n");
                }
                else
                {
                    Console.WriteLine("\t\t\tFailed to insert data into the Students table.");
                }
            }
        }
        public static void UpdateStudentToDB( SqlConnection connection)
        {
            {

         
            }
        } 
        public static void DeleteStudentFromDB( SqlConnection connection)
        {
            {


                // Delete data in the student table
                Console.WriteLine("Deleteing data from Students table...");
                int StudentId;
                Console.WriteLine("Enter Student ID to Delete: ");
                StudentId = Convert.ToInt32(Console.ReadLine());


                connection.Open();

                //Deleting data from the students Table
                SqlCommand deleteStudentCmd = new SqlCommand("DELETE FROM Students WHERE StudentID = @studentId", connection);
                deleteStudentCmd.Parameters.AddWithValue("@studentId", StudentId);



                


                int rowsAffectedStudents = deleteStudentCmd.ExecuteNonQuery();
              

                if (rowsAffectedStudents > 0 )
                {
                    Console.WriteLine("Data Deleted from the DB.");
                }
                else
                {
                    Console.WriteLine("No records updated in CUSTOMER table.");
                }





                // Close the connection
                //  close the connection when  done.
                connection.Close();
            }
        }
        public static void GetStudentsFromDB( SqlConnection conn)
        {
            {

               
                // Pass the connection to the SqlCommand
                SqlCommand cmd = new SqlCommand("SELECT * FROM Students  ", conn);

                // SQL internal object that reads data from a table is called a SqlDataReader
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("\t\t\t{0}\t{1}\t{2}\t{3}\t\t{4}", "Student ID", "Student Name", "Student Age", "Student Class", "Student Gender");
                    Console.WriteLine("\t\t\t{0}\t{1}\t{2}\t{3}\t\t{4}", "==========", "============", "===========", "=============", "==============");
            

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
                conn.Close();
            }
        }

        }

    }

    




