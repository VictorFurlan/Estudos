using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Contab.Data;

namespace Contab.Models
{
    public class EmployeeDataAccessLayer
    {
        Connection_Query con = new Connection_Query();

        //To View all employees details    
        public IEnumerable<Employee> GetAllEmployees()
        {
            List<Employee> lstemployee = new List<Employee>();

            MySqlDataReader rdr = con.DataReader("spGetAllEmployees");
            con.Open();

            while (rdr.Read())
            {
                Employee employee = new Employee();

                employee.ID = Convert.ToInt32(rdr["EmployeeID"]);
                employee.Name = rdr["Name"].ToString();
                employee.Gender = Convert.ToInt32(rdr["Gender"]);
                employee.Salary = Convert.ToInt32(rdr["Salary"]);
                employee.Email = rdr["Email"].ToString();
                employee.Phone = rdr["Phone"].ToString();
                employee.Departament = Convert.ToInt32(rdr["Departament"]);
                employee.Profession = Convert.ToInt32(rdr["Prefession"]);

                lstemployee.Add(employee);
            }
         con.Close();
         return lstemployee;
        }

        //To Add new employee record    
        public void AddEmployee(Employee employee)
        {
            MySqlCommand cmd = new MySqlCommand("spAddEmployee", con.Connection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("p_Name", employee.Name);
            cmd.Parameters.AddWithValue("p_Gender", employee.Gender);
            cmd.Parameters.AddWithValue("p_Salary", employee.Salary);
            cmd.Parameters.AddWithValue("p_Email", employee.Email);
            cmd.Parameters.AddWithValue("p_Phone", employee.Phone);
            cmd.Parameters.AddWithValue("p_Departament", employee.Departament);
            cmd.Parameters.AddWithValue("p_Profession", employee.Profession);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //To Update the records of a particluar employee  
        public void UpdateEmployee(Employee employee)
        {
            MySqlCommand cmd = new MySqlCommand("spUpdateEmployee", con.Connection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("p_EmpId", employee.ID);
            cmd.Parameters.AddWithValue("p_Name", employee.Name);
            cmd.Parameters.AddWithValue("p_Gender", employee.Gender);
            cmd.Parameters.AddWithValue("p_Salary", employee.Salary);
            cmd.Parameters.AddWithValue("p_Email", employee.Email);
            cmd.Parameters.AddWithValue("p_Phone", employee.Phone);
            cmd.Parameters.AddWithValue("p_Departament", employee.Departament);
            cmd.Parameters.AddWithValue("p_Profession", employee.Profession);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Get the details of a particular employee  
        public Employee GetEmployeeData(int? id)
        {
            Employee employee = new Employee();
            con.Open();
            MySqlDataReader rdr = con.DataReader("SELECT * FROM tblEmployee WHERE EmployeeID= " + id);

            while (rdr.Read())
            {
                employee.ID = Convert.ToInt32(rdr["EmployeeID"]);
                employee.Name = rdr["Name"].ToString();
                employee.Gender = Convert.ToInt32(rdr["Gender"]);
                employee.Salary = Convert.ToInt32(rdr["Salary"]);
                employee.Email = rdr["Email"].ToString();
                employee.Phone = rdr["Phone"].ToString();
                employee.Departament = Convert.ToInt32(rdr["Departament"]);
                employee.Profession = Convert.ToInt32(rdr["Prefession"]);

            }
            con.Close();
            return employee;
        }

        //To Delete the record on a particular employee  
        public void DeleteEmployee(int? id)
        {
                MySqlCommand cmd = new MySqlCommand("spDeleteEmployee", con.Connection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_EmpId", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
        }
    }
}
