<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/MasterPages/Site.3_9.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="emperor3._Default" %>

<asp:Content ID="BodyContent1" ContentPlaceHolderID="MainContent1" runat="server">
    <div class="container" style="width:auto;">
        <div class="row-fluid">
            <p>
                <a href="https://twitter.com/ExarchTatiana?ref_src=twsrc%5Etfw" class="twitter-follow-button" data-show-count="false">Follow @ExarchTatiana</a>
                <script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>
            </p>
        </div>
        <div class="row-fluid">
            <div class="pre-scrollable">
                <a class="twitter-timeline" href="https://twitter.com/ExarchTatiana?ref_src=twsrc%5Etfw">Tweets by Exarch Tatiana, the High Voice</a>
                <script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent2" runat="server">

        <div class="row" style="width:auto;">
            <h3>News and Events</h3>
        </div>
    <div class="row">
            <div class="jumbotron">
                <h4 class="display-4">A Sermon On Yakiyah</h4>
                <p class="lead">
                    <a class="btn btn-secondary btn-lg" href="/Sermons/SermonYakiyah" role="button">Read &raquo;</a>
                </p>
            </div>
        </div>
    <div class="row">
            <div class="jumbotron">
                <h4 class="display-4">Today's Reading</h4>
                <p class="lead">
                    <a class="btn btn-secondary btn-lg" href="/Reading" role="button">Read &raquo;</a>
                </p>
            </div>
        </div>
        <div class="row">
            <div class="jumbotron">
                <h4 class="display-4">From the Desk of the Grand Voice</h4>
                <p class="lead">
                    <a class="btn btn-secondary btn-lg" href="/FromTheDesk" role="button">Read &raquo;</a>
                </p>
            </div>
        </div>
        <div class="row" style="width:auto;">
            <div class="jumbotron">
                <h4 class="display-4">The Sermons of High Priest Callixtus Pius</h4>
                <p class="lead"></p>
                <p class="lead">
                    <a class="btn btn-secondary btn-lg" href="/Sermons/Index" role="button">Read &raquo;</a>
                </p>
            </div>
        </div>
</asp:Content>