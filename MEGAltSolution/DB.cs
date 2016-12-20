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

        SqlDataAdapter da_1;

        public DBConnectionDatasets() {
                
        }

        public void FetchTeachers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
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
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public void PrintTeachers() {
         
        }

        public void FetchStudents()
        {

        }

    }
}
