using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DBTestMockup.Data
{
    public class DatabaseManager
    {
        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmpTest;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public EmpDto getEmployee(int id)
        {
            EmpDto employee = new EmpDto();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand getEmp = new SqlCommand("Select Name from Employees where Id = " + id, sqlConnection))
                {
                    sqlConnection.Open();
                    var reader = getEmp.ExecuteReader();
                    while (reader.Read())
                    {
                        employee.Id = reader.GetInt32(0);
                        employee.Name = reader.GetString(1);
                        employee.Department = reader.GetString(2);
                    }
                }
            }
            return employee;
        }

        public List<EmpDto> GetEmps()
        {
            List<EmpDto> emps = new List<EmpDto>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand getAll = new SqlCommand("Select * From Employees", conn))
                {
                    conn.Open();
                    var reader = getAll.ExecuteReader();
                    while (reader.Read())
                    {
                        EmpDto employee = new EmpDto();
                        employee.Id = reader.GetInt32(0);
                        employee.Name = reader.GetString(1);
                        employee.Department = reader.GetString(2);
                        emps.Add(employee);
                    }
                }
            }
            return emps;
        }
    }
}
