using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mattiasgenomgång_territory_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string cns = @"Server=(localdb)\MSSQLLocalDB;Database=NORTHWND;Trustd_Connection=Yes";
            SqlConnection cn = new SqlConnection(cns);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "InsertRegion";
            cmd.Parameters.AddWithValue("@RegionID", "Moon");
            cmd.Parameters.AddWithValue("@RegionDescription", "Tranquility");
            SqlParameter pRegionID = cmd.Parameters.Add("RegionID", SqlDbType.Int);
            pRegionID.Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            Console.WriteLine("New RegionID is {0}");
            cn.Close();


        }
    }
}
