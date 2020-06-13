<%@ Page Title="Western Number System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Western.aspx.cs" Inherits="NumberSystem.Western" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <br />
            <br />
            <br />
            <asp:Label ID="lblNumber" runat="server" Text="Label">Enter your number</asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnConvert" runat="server" Text="Convert" OnClick="btnConvert_Click" />
            <br />
            <br />
            <asp:Label ID="lblWordNumber" runat="server" Text="You entered"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblNumberAnswer" runat="server"></asp:Label>
            <br />
        </div>
</asp:Content>
