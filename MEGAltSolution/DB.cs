using MEG;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGAltSolution
{
    public class DBConnectionDatasets
    {
        string connectionString = "Data Source=ealdb1.eal.Local;" + "Initial Catalog=EJL81_DB;" + "User id=ejl81_usr;" + "Password=Baz1nga81;";
        //string connectionString = "server=ealdb1.eal.Local;user=ejl_81_usr;database=EAL81_DB,password=Baz1nga81;database=EJL81_DB";

        string fetchTeachersQuery = "SELECT * FROM Teacher";

        string fetchStudentsQuery = "SELECT * FROM Studets";
        int inc = 0;

        public void AssignTeacher(Teacher t) {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("InsertIntoTeacher", conn);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@TeacherUsername", t.Username));


                        // execute the command
                        try
                        {
                            cmd.ExecuteNonQuery();
                            
                        }
                        catch
                        {
                            Console.WriteLine("Failure to assign teacher to class.");
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public void ÍnsertIntoClassRoom(string classRoomName, string school) {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("InsertIntoClassRoom", conn);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@ClassRoom", classRoomName));
                        cmd.Parameters.Add(new SqlParameter("@School", school));


                        // execute the command
                        try
                        {
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("Teacher was added.");
                        }
                        catch
                        {
                            Console.WriteLine("Failure to add teacher.");
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public void InsertIntoTeachers(Teacher t)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("InsertIntoTeacher", conn);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@TeacherUsername", t.Username));
                        cmd.Parameters.Add(new SqlParameter("@TeacherPassword", t.Password));
                        cmd.Parameters.Add(new SqlParameter("@TeacherFirstName", t.FirstName));
                        cmd.Parameters.Add(new SqlParameter("@TeacherLastName", t.LastName));


                        // execute the command
                        try {
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("Teacher was added.");
                        }
                        catch{
                            Console.WriteLine("Failure to add teacher.");
                        }
                        
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public List<Teacher> FetchAllTeachers() {
            List<Teacher> _teachers = new List<Teacher>();


                    /*
           connection.Open();
           da_1 = new SqlDataAdapter(fetchTeachersQuery, connection);
           DataSet ds = new DataSet();
           da_1.Fill(ds);
           foreach (DataTable table in ds.Tables)
           {
               foreach (DataRow dr in table.Rows)
               {
                   Console.WriteLine("___TEACHER ROW" + dr.ItemArray.GetValue(1).ToString() + "___");
                   Console.WriteLine(dr.ItemArray.GetValue(1).ToString());
                   Console.WriteLine(dr.ItemArray.GetValue(2).ToString());
                   Console.WriteLine(dr.ItemArray.GetValue(3).ToString());
                   Console.WriteLine(dr.ItemArray.GetValue(4).ToString());
               }
           }
           */
            return _teachers;
        }

        public List<Teacher> FetchStudents()
        {
            List<Teacher> _teachers = new List<Teacher>();


            /*
            connection.Open();
            da_1 = new SqlDataAdapter(fetchTeachersQuery, connection);
            DataSet ds = new DataSet();
            da_1.Fill(ds);
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    Console.WriteLine("___TEACHER ROW" + dr.ItemArray.GetValue(1).ToString() + "___");
                    Console.WriteLine(dr.ItemArray.GetValue(1).ToString());
                    Console.WriteLine(dr.ItemArray.GetValue(2).ToString());
                    Console.WriteLine(dr.ItemArray.GetValue(3).ToString());
                    Console.WriteLine(dr.ItemArray.GetValue(4).ToString());
                }
            }
            */
            return _teachers;
        }

    }
}
