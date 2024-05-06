<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="okull.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ÖĞRETMEN KAYIT UYGULAMASI</title>
    <style type="text/css">
        body {
            background-color: forestgreen;
        }
      
        .auto-style2 {
             color:white;
             border-radius: 30rem;
             cursor: pointer;
             background-color:red;
             margin-left:1.5rem;
        }
      
    </style>
</head>
<body>

           <!-- Image and text -->
<nav class="navbar navbar-light bg-danger">
  <a class="navbar-brand bg-danger " href="https://localhost:44353/WebForm4">
      <svg xmlns="http://www.w3.org/2000/svg" width="35" height="35" fill="currentColor" class="bi bi-book-half" viewBox="0 0 16 16">
  <path d="M8.5 2.687c.654-.689 1.782-.886 3.112-.752 1.234.124 2.503.523 3.388.893v9.923c-.918-.35-2.107-.692-3.287-.81-1.094-.111-2.278-.039-3.213.492V2.687zM8 1.783C7.015.936 5.587.81 4.287.94c-1.514.153-3.042.672-3.994 1.105A.5.5 0 0 0 0 2.5v11a.5.5 0 0 0 .707.455c.882-.4 2.303-.881 3.68-1.02 1.409-.142 2.59.087 3.223.877a.5.5 0 0 0 .78 0c.633-.79 1.814-1.019 3.222-.877 1.378.139 2.8.62 3.681 1.02A.5.5 0 0 0 16 13.5v-11a.5.5 0 0 0-.293-.455c-.952-.433-2.48-.952-3.994-1.105C10.413.809 8.985.936 8 1.783z"/>
</svg>
    E-BİLGİ
  </a>
    </nav>


      <form id="form1" runat="server">
      <div>
      <div style="font-size:x-large" align="center" title="czxc">
          ÖĞRETMEN&nbsp;&nbsp; KAYIT</div>
      <br />
      </div>
    
          <table class="auto-style1">
              <tr>
                  <td>Öğretmen Adı:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TextBox1" runat="server" Font-Size="Medium" Width="246px"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td>Öğretmen Soyadı:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:TextBox ID="TextBox2" runat="server" Font-Size="Medium" Width="248px"></asp:TextBox>
&nbsp; </td>
              </tr>
              <tr>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td>Öğretmen Yaş:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:TextBox ID="TextBox3" runat="server" Font-Size="Medium" Width="243px"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td>Öğretmen Ders:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:DropDownList ID="DropDownList1" runat="server" Width="136px">
                          <asp:ListItem>FİZİK</asp:ListItem>
                          <asp:ListItem>MATEMATİK</asp:ListItem>
                          <asp:ListItem>KİMYA</asp:ListItem>
                          <asp:ListItem>GEOMETRİ</asp:ListItem>
                          <asp:ListItem>BİYOLOJİ</asp:ListItem>
                          <asp:ListItem>EDEBİYAT</asp:ListItem>
                          <asp:ListItem>TÜRKÇE</asp:ListItem>
                          <asp:ListItem>TARİH</asp:ListItem>
                          <asp:ListItem>COĞRAFYA</asp:ListItem>
                          <asp:ListItem>DİN KÜLTÜRÜ</asp:ListItem>
                          <asp:ListItem>FELSEFE</asp:ListItem>
                      </asp:DropDownList>
                      <table class="auto-style1">
                          <tr>
                              <td>ÖğretmenID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                  <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                              </td>
                          </tr>
                      </table>
                  </td>
              </tr>
          </table>
          <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Font-Size="Medium" OnClick="Button1_Click" Text="KAYIT" Width="170px" Height="36px" CssClass="auto-style2" />
              &nbsp;&nbsp;&nbsp;
              <asp:Button ID="Button4" runat="server" BackColor="Aqua" CssClass="auto-style2" Font-Size="Medium" ForeColor="White"  OnClick="Button4_Click" Text="GÜNCELLE" Height="36px" Width="170px"  />
&nbsp;&nbsp;&nbsp;
              <asp:Button ID="Button2" runat="server" Font-Size="Medium" Height="36px" OnClick="Button2_Click" Text="DELETE" Width="170px" CssClass="auto-style2" />
              &nbsp;&nbsp;
              <asp:Button ID="Button3" runat="server" BackColor="Fuchsia" CssClass="auto-style2" Font-Size="Medium" Height="36px" OnClick="Button3_Click" Text="TEMİZLE" Width="170" />
          </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:GridView ID="GridView1" runat="server" Height="230px" Width="691px" BackColor="White" ForeColor="Red">
          </asp:GridView>
      </form>
    
    </body>
</html>
