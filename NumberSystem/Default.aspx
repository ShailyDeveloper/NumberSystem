<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NumberSystem.UI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Number System</h1>
        <p class="lead">This application converts the number entered by the user into a text format based on the available Numeral system.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Western Number System</h2>
            <p>
                This page converts the entered number into the Western Numeral System.
            </p>
            <p>
                <a class="btn btn-default" href="UI/Western">Try Now &raquo;</a>
            </p>
        </div>
        
        <div class="col-md-4">
            <h2>Contact</h2>
            <p>
                Has the contact of the Developer of this application.
            </p>
            <p>
                <a class="btn btn-default" href="UI/Contact">Contact Now &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
