<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm15.aspx.cs" Inherits="okull.WebForm15" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>DERS SEÇİM</title>
    <style type="text/css">
        body{
            background-color: brown
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style4 {
            height: 39px;
        }
        .auto-style5 {
            height: 38px;
        }
        .auto-style6 {
            width: 831px;
        }
    </style>
</head>
<body>

        <!-- Image and text -->
<nav class="navbar navbar-yellow bg-danger">
  <a class="navbar-brand bg-danger " href="https://localhost:44353/WebForm4">
      <svg xmlns="http://www.w3.org/2000/svg" width="35" height="35" fill="currentColor" class="bi bi-book-half" viewBox="0 0 16 16">
  <path d="M8.5 2.687c.654-.689 1.782-.886 3.112-.752 1.234.124 2.503.523 3.388.893v9.923c-.918-.35-2.107-.692-3.287-.81-1.094-.111-2.278-.039-3.213.492V2.687zM8 1.783C7.015.936 5.587.81 4.287.94c-1.514.153-3.042.672-3.994 1.105A.5.5 0 0 0 0 2.5v11a.5.5 0 0 0 .707.455c.882-.4 2.303-.881 3.68-1.02 1.409-.142 2.59.087 3.223.877a.5.5 0 0 0 .78 0c.633-.79 1.814-1.019 3.222-.877 1.378.139 2.8.62 3.681 1.02A.5.5 0 0 0 16 13.5v-11a.5.5 0 0 0-.293-.455c-.952-.433-2.48-.952-3.994-1.105C10.413.809 8.985.936 8 1.783z"/>
</svg>
    E-BİLGİ
  </a>

  
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="TARİH: " ForeColor="Aqua"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Teacher Name: " ForeColor="Aqua"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <table class="auto-style1">
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style6">
                                <asp:Label ID="Label6" runat="server" Text="GÜN: " ForeColor="Aqua"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList1" runat="server" Font-Size="Medium" Height="30px" Width="166px">
                                    <asp:ListItem>PAZARTESİ</asp:ListItem>
                                    <asp:ListItem>SALI</asp:ListItem>
                                    <asp:ListItem>ÇARŞAMBA</asp:ListItem>
                                    <asp:ListItem>PERŞEMBE</asp:ListItem>
                                    <asp:ListItem>CUMA</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">&nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="8AM-9AM: " ForeColor="Aqua"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList2" runat="server" Font-Size="Medium">
                        <asp:ListItem>MATEMATİK</asp:ListItem>
                        <asp:ListItem>FİZİK</asp:ListItem>
                        <asp:ListItem>KİMYA</asp:ListItem>
                        <asp:ListItem>TARİH</asp:ListItem>
                        <asp:ListItem>İNGİLİZCE</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="9AM-10AM: " ForeColor="Aqua"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList3" runat="server" Font-Size="Medium">
                        <asp:ListItem>MATEMATİK</asp:ListItem>
                        <asp:ListItem>FİZİK</asp:ListItem>
                        <asp:ListItem>KİMYA</asp:ListItem>
                        <asp:ListItem>TARİH</asp:ListItem>
                        <asp:ListItem>İNİGLİZCE</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <table class="auto-style1">
                        <tr>
                            <td>&nbsp;&nbsp; </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="10AM-11AM: " ForeColor="Aqua"></asp:Label>
&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList4" runat="server" Font-Size="Medium">
                                    <asp:ListItem>MATEMATİK</asp:ListItem>
                                    <asp:ListItem>FİZİK</asp:ListItem>
                                    <asp:ListItem>KİMYA</asp:ListItem>
                                    <asp:ListItem>TARİH</asp:ListItem>
                                    <asp:ListItem>İNGİLİZCE</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2"></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label5" runat="server" Text="12PM-1PM: " ForeColor="Aqua"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList5" runat="server" Font-Size="Medium">
                        <asp:ListItem>MATEMATİK</asp:ListItem>
                        <asp:ListItem>FİZİK</asp:ListItem>
                        <asp:ListItem>KİMYA</asp:ListItem>
                        <asp:ListItem>TARİH</asp:ListItem>
                        <asp:ListItem>İNGİLİZCE</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Font-Size="Medium" OnClick="Button1_Click" Text="Kaydet" BackColor="Lime" Height="30px" Width="70px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" BackColor="Blue" Font-Size="Medium" Height="30px" OnClick="Button2_Click" Text="GÜNCELLE" Width="110px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" BackColor="Red" Font-Size="Medium" Height="30px" OnClick="Button3_Click" Text="SİL" Width="70px" />
                    <br />
        <asp:GridView ID="GridView1" runat="server" Height="130px" Width="1341px" ForeColor="Aqua">
        </asp:GridView>
                </td>
            </tr>
            </table>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
  
</body>
</html>
