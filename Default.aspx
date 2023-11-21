<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KarateSchool._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
       <body>
           &nbsp;<asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
               <LayoutTemplate>
    <table cellspacing="0" cellpadding="1" style="border-collapse: collapse;">
        <tr>
            <td>
                <table cellpadding="0">
                    <tr>
                        <td align="center" colspan="2">Log In</td>
                    </tr>
                    <tr>
                        <td align="right">
                            <asp:Label runat="server" AssociatedControlID="UserName" ID="UserNameLabel">User Name:</asp:Label></td>
                        <td>
                            <asp:TextBox runat="server" ID="UserName"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ValidationGroup="Login1" ToolTip="User Name is required." ID="UserNameRequired">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <asp:Label runat="server" AssociatedControlID="Password" ID="PasswordLabel">Password:</asp:Label></td>
                        <td>
                            <asp:TextBox runat="server" TextMode="Password" ID="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ValidationGroup="Login1" ToolTip="Password is required." ID="PasswordRequired">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:CheckBox runat="server" Text="Remember me next time." ID="RememberMe"></asp:CheckBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2" style="color: Red;">
                            <asp:Literal runat="server" ID="FailureText" EnableViewState="False"></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" colspan="2">
                            <asp:Button runat="server" CommandName="Login" Text="Log In" ValidationGroup="Login1" ID="LoginButton"></asp:Button>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</LayoutTemplate>
           </asp:Login>
       </body> 
        
        
    </main>

</asp:Content>
