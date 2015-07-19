<%@ Page Title="" Language="C#" MasterPageFile="~/student/MasterPage.master" AutoEventWireup="true" CodeFile="questions.aspx.cs" Inherits="student_Default" %>

<script runat="server">

    
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <table 
        style="width:100%; position: relative; top: -53px; left: 0px; height: 210px; border-left-style: solid; border-left-color: #0000FF; border-right-style: solid; border-right-color: #0000FF; border-top-style: none; border-top-color: #0000FF; border-bottom-style: solid; border-bottom-color: #0000FF;">
        <tr>
            <td style="width: 521px; height: 42px;">
                &nbsp;<br />
            </td>
            <td style="width: 641px; height: 42px;">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:Label ID="Label2" runat="server" Text="Time Left :"></asp:Label>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                
                <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="1000" ontick="Timer1_Tick">
                </asp:Timer>
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
             
                </ContentTemplate>
                </asp:UpdatePanel>
                
                
                
            </td>
            <td style="height: 42px">
                                 <asp:Button ID="Button3" runat="server" Text="End Exam" 
                                     onclick="Button3_Click"/>
            </td>
        </tr>
        <tr>
            <td style="height: 111px; " colspan="2" align="center">
                <br />
                <br />
                <asp:Panel ID="Panel2" runat="server" HorizontalAlign="Left">
                    <asp:Label ID="Qno" runat="server" Text="Label" Font-Size="18pt" 
                        ForeColor="Red"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:Label ID="QD" runat="server" Font-Size="15pt" ForeColor="Red" 
                        Text="Label"></asp:Label>
                    <br />
                    <asp:RadioButton ID="A" runat="server" GroupName="ans" AutoPostBack="True" 
                        oncheckedchanged="A_CheckedChanged" />
                    <br />
                    <asp:RadioButton ID="B" runat="server" GroupName="ans" AutoPostBack="True" 
                        oncheckedchanged="B_CheckedChanged" />
                    <br />
                    <asp:RadioButton ID="C" runat="server" GroupName="ans" AutoPostBack="True" 
                        oncheckedchanged="C_CheckedChanged" />
                    <br />
                    <asp:RadioButton ID="D" runat="server" GroupName="ans" AutoPostBack="True" 
                        oncheckedchanged="D_CheckedChanged" />
                </asp:Panel>
             </td>
            <td style="height: 111px">
            <table>
            <tr>
           
            <td> 
                <asp:Button ID="Button1" runat="server" Height="20px" 
                    Text="1" Width="33px" onclick="Button1_Click" />
            </td>
            <td> 
                <asp:Button ID="Button2" runat="server" Height="20px" 
                    Text="2" Width="33px" onclick="Button1_Click" />
            </td>
            <td> 
                <asp:Button ID="Button9" runat="server" Height="20px" 
                    Text="3" Width="33px" onclick="Button1_Click" />
            </td>
            </tr>
             <tr>
            <td> 
                <asp:Button ID="Button8" runat="server" Height="20px"  
                    Text="4" Width="33px" onclick="Button1_Click" />
            </td>
            <td> 
                <asp:Button ID="Button10" runat="server" Height="20px" 
                    Text="5" Width="33px" onclick="Button1_Click" />
            </td>
            <td> 
                <asp:Button ID="Button11" runat="server" Height="20px" 
                                Text="6" Width="33px" onclick="Button1_Click" />
            </td>
            </tr>
            <tr>
            <td> 
                <asp:Button ID="Button12" runat="server" Height="20px" 
                    Text="7" Width="33px" onclick="Button1_Click" />
            </td>
            <td> 
                <asp:Button ID="Button13" runat="server" Height="20px" 
                    Text="8" Width="33px" onclick="Button1_Click" />
            </td>
            <td> 
                <asp:Button ID="Button14" runat="server" Height="20px" 
                    Text="9" Width="33px" onclick="Button1_Click" />
            </td>
            </tr>
            <tr>
             
            <td> 
                <asp:Button ID="Button15" runat="server" Height="20px" 
                    Text="10" Width="33px" onclick="Button1_Click" />
                    </td>
           
             <td> 
                <asp:Button ID="Button16" runat="server" Height="20px" 
                    Text="11" Width="33px" onclick="Button1_Click" />
                    </td>

              
             <td> 
                <asp:Button ID="Button17" runat="server" Height="20px" 
                    Text="12" Width="33px" onclick="Button1_Click" />
                    </td>

             </tr>

             <tr>
             
            <td> 
                <asp:Button ID="Button18" runat="server" Height="20px" 
                    Text="13" Width="33px" onclick="Button1_Click" />
                    </td>
           
             <td> 
                <asp:Button ID="Button19" runat="server" Height="20px" 
                    Text="14" Width="33px" onclick="Button1_Click" />
                    </td>

              
             <td> 
                <asp:Button ID="Button20" runat="server" Height="20px" 
                    Text="15" Width="33px" onclick="Button1_Click" />
                    </td>

             </tr>

             <tr>
             
            <td> 
                <asp:Button ID="Button21" runat="server" Height="20px" 
                    Text="16" Width="33px" onclick="Button1_Click" />
                    </td>
           
             <td> 
                <asp:Button ID="Button22" runat="server" Height="20px" 
                    Text="17" Width="33px" onclick="Button1_Click" />
                    </td>

              
             <td> 
                <asp:Button ID="Button23" runat="server" Height="20px" 
                    Text="18" Width="33px" onclick="Button1_Click" />
                    </td>

             </tr>


             <tr>
             
            <td> 
                <asp:Button ID="Button24" runat="server" Height="20px" 
                    Text="19" Width="33px" onclick="Button1_Click" />
                    </td>
           
             <td> 
                <asp:Button ID="Button25" runat="server" Height="20px" 
                    Text="20" Width="33px" onclick="Button1_Click" />
                    </td>

              
             <td> 
                <asp:Button ID="Button26" runat="server" Height="20px" 
                    Text="21" Width="33px" onclick="Button1_Click" />
                    </td>

             </tr>

             <tr>
             
            <td> 
                <asp:Button ID="Button27" runat="server" Height="20px" 
                    Text="22" Width="33px" onclick="Button1_Click" />
                    </td>
           
             <td> 
                <asp:Button ID="Button28" runat="server" Height="20px" 
                    Text="23" Width="33px" onclick="Button1_Click" />
                    </td>

              
             <td> 
                <asp:Button ID="Button29" runat="server" Height="20px" 
                    Text="24" Width="33px" onclick="Button1_Click" />
                    </td>

             </tr>


             <tr>
             
            <td> 
                <asp:Button ID="Button30" runat="server" Height="20px" 
                    Text="25" Width="33px" onclick="Button1_Click" />
                    </td>
           
             <td> 
                <asp:Button ID="Button31" runat="server" Height="20px" 
                    Text="26" Width="33px" onclick="Button1_Click" />
                    </td>

              
             <td> 
                <asp:Button ID="Button32" runat="server" Height="20px" 
                    Text="27" Width="33px" onclick="Button1_Click" />
                    </td>

             </tr>


             <tr>
             
            <td> 
                <asp:Button ID="Button33" runat="server" Height="20px" 
                    Text="28" Width="33px" onclick="Button1_Click" />
                    </td>
           
             <td> 
                <asp:Button ID="Button34" runat="server" Height="20px" 
                    Text="29" Width="33px" onclick="Button1_Click" />
                    </td>

              
             <td> 
                <asp:Button ID="Button35" runat="server" Height="20px" 
                    Text="30" Width="33px" onclick="Button1_Click" />
                    </td>

             </tr>
           
                </table>
                </td>
        </tr>
        <tr>
            <td style="width: 521px">
                <table style="width:100%;">
                    <tr>
                        <td align="center">
                            <asp:Button ID="Button4" runat="server" Text="First" onclick="Button4_Click" />
                        </td>
                        <td align="center">
                            <asp:Button ID="Button5" runat="server" Text="Previous" 
                                onclick="Button5_Click" /> 
                               
                        </td>
                    </tr>
                </table>
            </td>
            <td style="width: 641px">
            <table style="width:100%;">
                    <tr>
                        <td align="center">
                            <asp:Button  ID="Button6" runat="server" Text="Next" onclick="Button6_Click" />
                        </td>
                        <td align="center">
                            <asp:Button ID="Button7" runat="server" Text="Last" onclick="Button7_Click" />
                        </td>
                    </tr>
                </table>    
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>



