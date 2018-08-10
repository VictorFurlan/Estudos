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
        string connectionString = "server=127.0.0.1;uid=root;" + "pwd=123456;database=vj";

        //To View all employees details    
        public IEnumerable<Employee> GetAllEmployees()
        {
            List<Employee> lstemployee = new List<Employee>();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                //----------------------GET Employee-----------------------------------
                MySqlCommand cmd = new MySqlCommand("spGetAllEmployees", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Employee employee = new Employee();

                    employee.ID = Convert.ToInt32(rdr["EmployeeID"]);
                    employee.Name = rdr["Name"].ToString();
                    employee.Salary = Convert.ToInt32(rdr["Salary"]);
                    employee.Email = rdr["Email"].ToString();
                    employee.Phone = rdr["Phone"].ToString();
                    employee.GenderName = rdr["NameGender"].ToString();
                    employee.DepartamentName = rdr["Departname"].ToString();
                    employee.ProfessionName = rdr["Profname"].ToString();

                    lstemployee.Add(employee);
                }
                con.Close();
            }
            return lstemployee;
        }

        //To Add new employee record    
        public void AddEmployee(Employee employee)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string sqlQueryDepart = "SELECT LAST_INSERT_ID() FROM tblDepartament";
                MySqlCommand cmdDepartID = new MySqlCommand(sqlQueryDepart, con);
                MySqlDataReader rdrDpart = cmdDepartID.ExecuteReader();
                int IdDepart = Convert.ToInt32(rdrDpart.Read());
                con.Close();

                con.Open();
                string sqlQueryProf = "SELECT LAST_INSERT_ID() FROM tblProfession";
                MySqlCommand cmdProfID = new MySqlCommand(sqlQueryProf, con);
                MySqlDataReader rdrProf = cmdProfID.ExecuteReader();
                int IdProf = Convert.ToInt32(rdrProf.Read());
                con.Close();

                MySqlCommand cmdDepart = new MySqlCommand("spAddDepartament", con);
                cmdDepart.CommandType = CommandType.StoredProcedure;

                MySqlCommand cmdProf = new MySqlCommand("spAddProfession", con);
                cmdProf.CommandType = CommandType.StoredProcedure;

                MySqlCommand cmd = new MySqlCommand("spAddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //--------------------ADD EMPLOYEE---------------------------
                cmd.Parameters.AddWithValue("p_Name", employee.Name);
                cmd.Parameters.AddWithValue("p_Salary", employee.Salary);
                cmd.Parameters.AddWithValue("p_Email", employee.Email);
                cmd.Parameters.AddWithValue("p_Phone", employee.Phone);
                cmd.Parameters.AddWithValue("p_Gender", employee.GenderId);
                cmd.Parameters.AddWithValue("p_Departament", IdDepart+1);
                cmd.Parameters.AddWithValue("p_Profession", IdProf+1);

                //--------------------ADD DEPARTAMENT---------------------------
                cmdDepart.Parameters.AddWithValue("p_DepartamentId", IdDepart+1);
                cmdDepart.Parameters.AddWithValue("p_Name", employee.DepartamentName);

                //--------------------ADD PROFESSIONT---------------------------
                cmdProf.Parameters.AddWithValue("p_ProfessionId", IdProf+1);
                cmdProf.Parameters.AddWithValue("p_Name", employee.ProfessionName);

                con.Open();
                cmdDepart.ExecuteNonQuery();
                cmdProf.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //To Update the records of a particluar employee  
        public void UpdateEmployee(Employee employee)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand("spAddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_EmpId", employee.ID);
                cmd.Parameters.AddWithValue("p_Name", employee.Name);
                cmd.Parameters.AddWithValue("p_Salary", employee.Salary);
                cmd.Parameters.AddWithValue("p_Email", employee.Email);
                cmd.Parameters.AddWithValue("p_Phone", employee.Phone);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //Get the details of a particular employee  
        public Employee GetEmployeeData(int? id)
        {
            Employee employee = new Employee();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM tblEmployee WHERE EmployeeID= " + id;
                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    employee.ID = Convert.ToInt32(rdr["EmployeeID"]);
                    employee.Name = rdr["Name"].ToString();
                    employee.GenderId = Convert.ToInt32(rdr["CodGender"]);
                    employee.Salary = Convert.ToInt32(rdr["Salary"]);
                    employee.Email = rdr["Email"].ToString();
                    employee.Phone = rdr["Phone"].ToString();
                    employee.DepartamentId = Convert.ToInt32(rdr["CodDepartament"]);
                    employee.ProfessionId = Convert.ToInt32(rdr["CodDepartament"]);

                }
                con.Close();
            }
            return employee;
        }

        //To Delete the record on a particular employee  
        public void DeleteEmployee(int? id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand("spDeleteEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_EmpId", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
