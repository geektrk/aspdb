<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fileup.aspx.cs" Inherits="fileuploading.fileup" %>
<% @Import Namespace="System.Data" %>
<% @Import Namespace="System.Data.SqlClient" %>
<% @Import Namespace="System.Web.Configuration " %>                      
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
       <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="cmdUpload_Click" Text="Button" />
        <table border="1">
<% String constr = WebConfigurationManager.ConnectionStrings["sathesh"].ConnectionString;
           SqlConnection scon = new SqlConnection(constr);
          scon.Open();

          string selectSQL = "SELECT * FROM dbo.te";


          SqlCommand cmd1 = new SqlCommand(selectSQL, scon);
          SqlDataReader reader;


          reader = cmd1.ExecuteReader();
          while (reader.Read())
          {%>
        
            <tr><td><% Response.Write(reader["name"]); %></td>
                <td><% Response.Write(reader["age"]); }%></td>

            </tr>
    
    
</table>
    </form>
</body>
</html>
