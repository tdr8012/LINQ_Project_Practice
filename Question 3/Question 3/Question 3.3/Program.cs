using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3._3
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
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Employees", cs.ConnectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Employees");
            foreach (DataRow dr in ds.Tables["Employees"].Rows)
            {
                Console.WriteLine("Id = {0}; Name = {1}", dr["ID"], dr["NAME"]);
                Console.WriteLine("Age = {0}", dr["AGE"]);
                Console.WriteLine("Address = {0}", dr["ADDRESS"]);
                Console.WriteLine("Salary = {0:F2}", dr["SALARY"]);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
