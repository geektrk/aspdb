<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fileup.aspx.cs" Inherits="fileuploading.fileup" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:FileUpload runat="server" ID="fileUploadImage" />
<asp:Button runat="server" ID="cmdUpload" Text="Upload File" OnClick="cmdUpload_Click" />
<asp:Repeater runat="server" ID="rptrFiles">
    <HeaderTemplate>
        <table>
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblFilename" Text='<%# Eval("FileName")%>' />
            </td>
            <td>
              <asp:HyperLink runat="server" Target="_blank" ID="lbtDownload" Text="Download" NavigateUrl='<%# "Download.aspx?File="  + Eval("FileId").ToString() %>' />
            </td>
        </tr>
    </ItemTemplate>
    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:Repeater>
    </form>
</body>
</html>
