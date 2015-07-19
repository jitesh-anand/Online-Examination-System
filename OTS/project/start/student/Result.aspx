<%@ Page Title="" Language="C#" MasterPageFile="~/student/MasterPage.master" AutoEventWireup="true" CodeFile="Result.aspx.cs" Inherits="student_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
    <div style="height: 298px">
        <table style="width:100%;">
            <tr>
                <td align="center" style="width: 507px">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" 
                        ForeColor="Red" Text="Your no of correct answers are:"></asp:Label>
                    <br />
                    <br />
                </td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
              
            </tr>
            <tr>
                <td align="center" style="width: 507px">
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Large" 
                        ForeColor="Red" Text="Your no wrong answers are:"></asp:Label>
                    <br />
                    <br />
                </td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </td>
               
            </tr>
            <tr>
                <td align="center" style="width: 507px">
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Large" 
                        ForeColor="Red" Text="No of attempts"></asp:Label>
                    <br />
                    <br />
                </td>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                </td>
                
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td align="center" style="width: 506px">
                    <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Large" 
                        ForeColor="Red" Text="Not attempted"></asp:Label>
                    <br />
                    <br />
                </td>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                </td>
               
            </tr>
            <tr>
                <td align="center" style="width: 506px">
                    <br />
                    <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="X-Large" 
                        ForeColor="#000066" Text="Your Score is:"></asp:Label>
                    <br />
                    <br />
                </td>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
                </td>
               
            </tr>
            
        </table>
    </div>

    
</asp:Content>

