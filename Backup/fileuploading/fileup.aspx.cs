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
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
         
        protected void cmdUpload_Click(object sender, EventArgs e)
        {
            string filePath = "C:/Users/sathesh/Desktop/Resume sathesh .T.doc";
            string filename = Path.GetFileName(filePath);

            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            Byte[] bytes = br.ReadBytes((Int32)fs.Length);
            br.Close();
            fs.Close();
           
           String constr = WebConfigurationManager.ConnectionStrings["sathesh"].ConnectionString;
            Response.Write(constr);
            String text1="sathesh";
           
            SqlConnection scon = new SqlConnection(constr);
            scon.Open();
         SqlCommand cmd = new SqlCommand("insert into dbo.file(title,name,data)values(@Name,@ContentType,@Data)",scon);

cmd.Parameters.Add("@Name", SqlDbType.NChar).Value = filename;
cmd.Parameters.Add("@ContentType", SqlDbType.NVarChar).Value = "application/vnd.ms-word";
cmd.Parameters.Add("@Data", SqlDbType.VarBinary).Value = bytes;

             

            
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }


    