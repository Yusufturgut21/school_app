<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="okull.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ÖĞRENCİ KAYIT UYGULAMASI</title>
    <style type="text/css">
        body {
  background-color: orange;
}
        .btnkd{
            
             color:white;
             border-radius: 30rem;
             cursor:pointer;
        }
        .btngn{
            
             color:white;
             border-radius: 30rem;
             cursor:pointer;
        }
        .btndl{
            
             color:white;
             border-radius: 30rem;
             cursor:pointer;
        }
        .btntm{
            
             color:white;
             border-radius: 30rem;
             cursor:pointer;
        }

        .auto-style1 {
            width: 100%;
            height: 208px;
        }
        .auto-style2 {
            width: 151px;
        }
        .auto-style3 {
            width: 151px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            width: 151px;
            height: 34px;
        }
        .auto-style6 {
            height: 34px;
        }
        .auto-style7 {
            width: 151px;
            height: 29px;
        }
        .auto-style8 {
            height: 29px;
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
            ÖĞRENCİ&nbsp;&nbsp; KAYIT</div>
        <br />
        </div>
    
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">ÖĞRENCİ NO:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox1" runat="server" Font-Size="Medium" Width="249px"></asp:TextBox>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style2">ÖĞRENCİ İSİM:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Font-Size="Medium" Width="251px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">İLÇE:</td>
                <td class="auto-style8">
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="93px">
                        <asp:ListItem>AHLAT</asp:ListItem>
                        <asp:ListItem>MERKEZ</asp:ListItem>
                        <asp:ListItem>RAHVA</asp:ListItem>
                        <asp:ListItem>TATVAN</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style2">YAŞ:</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Font-Size="Medium" Width="253px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">İLETİŞİM:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox4" runat="server" Font-Size="Medium" Width="252px"></asp:TextBox>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" BackColor="#CC00FF" Font-Size="Medium" OnClick="Button1_Click" Text="KAYDET" Width="101px" CssClass="btnkd" />
                    &nbsp;
                    <asp:Button ID="Button2" runat="server" BackColor="Lime" Font-Size="Medium" OnClick="Button2_Click" Text="GÜNCELLE" CssClass="btngn" />
                    &nbsp;
                    <asp:Button ID="Button3" runat="server" BackColor="Red" Font-Size="Medium" OnClick="Button3_Click" Text="SİL" CssClass="btndl" />
                    &nbsp;
                    <asp:Button ID="Button4" runat="server" BackColor="#FF0066" CssClass="btntm" Font-Size="Medium" OnClick="Button4_Click" Text="TEMİZLE" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" BackColor="#00CCFF" Height="179px" Width="787px" BorderColor="Red" BorderStyle="Double" Font-Italic="True" ForeColor="Maroon" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
    </form>
    
    
</body>
</html>
