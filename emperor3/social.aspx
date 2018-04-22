<%@ Page Title="Social Media" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Social.aspx.cs" Inherits="emperor3.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    
    <p>Follow the Church on Social Media</p>
    <a class="btn btn-secondary btn-lg" href="http://far-verona.wikia.com/wiki/The_High_Church_of_Messiah-as-Emperor" role="button">Read the wiki &raquo;</a>
    <div style="height:16px;"></div>
    <p><a href="https://twitter.com/ExarchTatiana?ref_src=twsrc%5Etfw" class="twitter-follow-button" data-show-count="false">Follow @ExarchTatiana</a><script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script></p>
    <div style="height:600px;width:40%">
        <a class="twitter-timeline" href="https://twitter.com/ExarchTatiana?ref_src=twsrc%5Etfw">Tweets by ExarchTatiana</a> <script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>
       </div> 
</asp:Content>
