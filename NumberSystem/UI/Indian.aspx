<%@ Page Title="Indian Number System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Indian.aspx.cs" Inherits="NumberSystem.Indian" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="Head" runat="server">
    <script src="../Scripts/Western.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div>
    <br />
        <br />
        <br />
        <asp:Label ID="lblNumber" runat="server" Text="Label">Enter your number</asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNumber" runat="server" class="txtNum" onkeypress="return allowOnlyNumber(event)"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnConvert" runat="server" Text="Convert" onClientClick="return CheckValue()" OnClick="btnConvert_Click"  />
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID ="btnSave" runat="server" Text ="Save"  visible="false" Width="74px" OnClick="btnSave_Click" />
        &nbsp;
        <asp:Label ID ="lblError" runat="server" Text="Should be a decimal number with a max digit of 26 before and after the decimal" ForeColor="Red" Visible="false"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblAnswer" runat="server" Visible="false">Your Number Is</asp:Label>
        <br />
        <asp:Label ID="lblNumberAnswer" runat="server"></asp:Label> 
        <br />
        <br />        
</div>
<asp:HiddenField ID="hdnfldErrorOutput" runat="server" ClientIDMode="Static" />  
</asp:Content>
