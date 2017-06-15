<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="test0615_HelloASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="OK" OnClick="Button1_Click"  />
        <br />
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <br />
        

    </div>
    </form>
</body>
</html>
