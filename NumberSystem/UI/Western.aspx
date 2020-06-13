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
            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID ="btnSave" runat="server" Text ="Save"  visible="false" Width="74px" OnClick="btnSave_Click"/>
            <br />
            <br />
            <asp:Label ID="lblAnswer" runat="server" Visible="false">Your Number Is</asp:Label>
            <br />
            <asp:Label ID="lblNumberAnswer" runat="server"></asp:Label>            
            <br />
            <br />
        </div>
</asp:Content>
