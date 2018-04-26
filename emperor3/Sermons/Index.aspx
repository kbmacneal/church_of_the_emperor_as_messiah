<%@ Page Title="Sermon Index" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="emperor3.Index" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h3 style="font-weight: bold">The Sermons of Callixtus Pius</h3>

    <table class="table table-hover" style="font-size: larger">
  <thead>
    <tr>
      <th scope="col">Name</th>
      <th scope="col">Link</th>
    </tr>
  </thead>
  <tbody>
      <tr>
          <td>
              The Ten Virtues
          </td>
          <td><a class="btn btn-secondary" href="SermonOne.aspx">Read</a></td>
      </tr>
      <tr>
          <td>
              The Interconnected Virtue of Justice
          </td>
          <td><a class="btn btn-secondary" href="SermonTwo.aspx">Read</a></td>
      </tr>
      </tbody>
        </table>
    
</asp:Content>