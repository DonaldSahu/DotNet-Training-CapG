using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AdoDotNetConnection
{
    class FunctionClass
    {
        public void AddData()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=LIN24004412\\SQLEXPRESS; database=Database1; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm1 = new SqlCommand("insert into tblEmployee values ('Donald Sahu', 40000)", con);
                // Opening Connection  
                con.Open();
                cm1.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something is wrong..." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }


        public void RetrieveData()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=LIN24004412\\SQLEXPRESS; database=Database1; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("select * from tblEmployee", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["EmpID"] + " " + sdr["EmpName"] + " " + sdr["EmpSalary"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something is wrong..." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }


        public void DeleteData()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=LIN24004412\\SQLEXPRESS; database=Database1; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("DELETE FROM tblEmployee WHERE EmpID = 4", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something is wrong..." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }


        public void UpdateData()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=LIN24004412\\SQLEXPRESS; database=Database1; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("UPDATE tblEmployee SET EmpSalary = 45000 WHERE EmpID = 1", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something is wrong..." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }


        public void SearchData()
        {
            SqlConnection con = null;
            try
            {
                Console.WriteLine("Enter the ID of Employee you want to search: ");
                int id = Convert.ToInt32(Console.ReadLine());
                // Creating Connection  
                con = new SqlConnection("data source=LIN24004412\\SQLEXPRESS; database=Database1; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand($"select * from tblEmployee WHERE EmpID = {id}", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();

                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["EmpID"] + " " + sdr["EmpName"] + " " + sdr["EmpSalary"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something is wrong..." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
