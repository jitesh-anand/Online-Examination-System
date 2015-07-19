<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" type="text/css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <div style="height: 101px; width: 298px; background-image: url('images/logo.png'); background-repeat: no-repeat;">
    </div>
    <asp:Login ID="Login1" runat="server" Height="264px" 
        style="margin-left: 501px; margin-top: 106px" Width="433px" 
        onauthenticate="Login1_Authenticate">
    </asp:Login>
    </form>
    </body>
</html>
