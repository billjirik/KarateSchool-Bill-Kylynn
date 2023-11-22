<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="KarateSchool.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>Members</div>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    
    <div>
        <asp:TextBox runat="server" OnTextChanged="Unnamed2_TextChanged" ID="txtBox1"></asp:TextBox>
        <asp:Button runat="server" Text="Search" OnClick="Unnamed1_Click"></asp:Button>
    </div>
    


        <div>Instructors</div>

    <asp:GridView ID="GridView2" runat="server">
    </asp:GridView>

    <div>
        <asp:TextBox runat="server" ID="txtBox2"></asp:TextBox>
        <asp:Button runat="server" Text="Search" OnClick="Unnamed4_Click"></asp:Button>
</div>
    

</asp:Content>
