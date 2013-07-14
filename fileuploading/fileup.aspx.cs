using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace fileuploading
{

    public partial class fileup : System.Web.UI.Page
    {

        String constr = WebConfigurationManager.ConnectionStrings["sathesh"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            

            SqlConnection scon = new SqlConnection(constr);
            scon.Open();

            string selectSQL = "SELECT * FROM dbo.te";


            SqlCommand cmd1 = new SqlCommand(selectSQL, scon);
            SqlDataReader reader;


            reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                Response.Write(reader["name"]);
                Response.Write(reader["age"]);
            }


        }


        protected void cmdUpload_Click(object sender, EventArgs e)
        {
            SqlConnection scon = new SqlConnection(constr);
            scon.Open();

            string t1 = TextBox1.Text;
            string t2 = TextBox2.Text;

            
            SqlCommand cmd = new SqlCommand("insert into dbo.te(name,age)values(@Name,@ContentType)", scon);

            cmd.Parameters.Add("@Name", SqlDbType.NChar).Value = t1;
            cmd.Parameters.Add("@ContentType", SqlDbType.NChar).Value = t2;
            //cmd.Parameters.Add("@Data", SqlDbType.VarBinary).Value = bytes;

            cmd.ExecuteNonQuery();
            




        }
    }
}

    