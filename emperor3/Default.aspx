<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="emperor3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content">
        <%--<asp:Image ImageUrl="~/Twitter_Header.png" runat="server"/>--%>
    </div>

    <h1>News and Events</h1>

    <div class="jumbotron">
  <h3 class="display-3">From the Desk of the Grand Voice</h3>
  <p class="lead"></p>
  <hr class="my-4">
  <p class="lead">
    <a class="btn btn-secondary btn-lg" href="/FromTheDesk" role="button">Read the Words of the Grand Voice &raquo;</a>
  </p>
</div>

    <div class="jumbotron">
  <h3 class="display-3">From the Sermons of High Priest Callixtus Pius</h3>
  <p class="lead">An Introduction to the Ten Virtues</p>
  <hr class="my-4">
  <p class="lead">
    <a class="btn btn-secondary btn-lg" href="/Sermons/SermonOne" role="button">Read his latest sermon &raquo;</a>
  </p>
</div>

</asp:Content>
