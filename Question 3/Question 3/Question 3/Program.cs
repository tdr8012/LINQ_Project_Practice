﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.DataSource = "(local)";
            cs.InitialCatalog = "emp2";
            cs.UserID = "sa";
            cs.Password = "sysadm";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = cs.ConnectionString;
            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT * FROM Employees";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Id = {0}", reader.GetInt32(0));
                Console.WriteLine("Name = {0}", reader.GetString(1));
                Console.WriteLine("Age = {0}", reader.GetInt32(2));
                Console.WriteLine("Address = {0}", reader.GetString(3));
                Console.WriteLine("Salary = {0}", reader.GetDecimal(4));

                Console.WriteLine();
            }
            reader.Close();


 

            con.Close();
            Console.ReadKey();
        }
    }
}
