using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
                    employee.DepartName = rdr["Departname"].ToString();
                    employee.ProfName = rdr["Profname"].ToString();

                    lstemployee.Add(employee);
                }
                con.Close();
            }
            return lstemployee;
        }

        //To Add new employee record    
        public void AddEmployee(MyViewModel employee)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                MySqlCommand cmd = new MySqlCommand("spAddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //--------------------ADD EMPLOYEE---------------------------
                cmd.Parameters.AddWithValue("p_Name", employee.employee.Name);
                cmd.Parameters.AddWithValue("p_Salary", employee.employee.Salary);
                cmd.Parameters.AddWithValue("p_Email", employee.employee.Email);
                cmd.Parameters.AddWithValue("p_Phone", employee.employee.Phone);
                cmd.Parameters.AddWithValue("p_Gender", employee.employee.GenderId);
                cmd.Parameters.AddWithValue("p_DepartamentId", employee.employee.DepartamentId);
                cmd.Parameters.AddWithValue("p_ProfessionId", employee.employee.ProfessionId);

                con.Open();
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
        public void AddDepartament(string depart)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string sqlQueryDepart = "SELECT MAX(DepartamentId) FROM tblDepartament";
                MySqlCommand cmdDepartID = new MySqlCommand(sqlQueryDepart, con);
                MySqlDataReader rdrDpart = cmdDepartID.ExecuteReader();
                int IdDepart = Convert.ToInt32(rdrDpart.Read());
                con.Close();

                MySqlCommand cmd = new MySqlCommand("spAddDepartament", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //--------------------ADD EMPLOYEE---------------------------
                cmd.Parameters.AddWithValue("p_DepartName", depart);
                cmd.Parameters.AddWithValue("p_DepartamentId", IdDepart + 1);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void AddProfession(Profession prof)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string sqlQueryProf = "SELECT MAX(ProfessionId) FROM tblProfession";
                MySqlCommand cmdProfID = new MySqlCommand(sqlQueryProf, con);
                MySqlDataReader rdrProf = cmdProfID.ExecuteReader();
                int IdProf = Convert.ToInt32(rdrProf.Read());
                con.Close();

                MySqlCommand cmd = new MySqlCommand("spAddProfession", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //--------------------ADD EMPLOYEE---------------------------
                cmd.Parameters.AddWithValue("p_ProfName", prof.ProfName);
                cmd.Parameters.AddWithValue("p_ProfessionId", IdProf + 1);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
