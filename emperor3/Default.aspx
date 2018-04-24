<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="emperor3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content">
        <%--<asp:Image ImageUrl="~/Twitter_Header.png" runat="server" />--%>
    </div>

    <div class=".container-fluid">
        <div class="row">
            <div class="col-12">
                <div id="imgCarousel" class="carousel slide" data-ride="carousel">
                    <!-- Indicators -->
                    <ol class="carousel-indicators">
                      <li data-target="#imgCarousel" data-slide-to="0" class="active"></li>
                      <li data-target="#imgCarousel" data-slide-to="1"></li>
                    </ol>
                  
                    <!-- Wrapper for slides -->
                    <div class="carousel-inner">
                      <div class="item active">
                        <img src="Propaganda.png" alt="Join the Church">
                        <div class="carousel-caption">
                            <a class="btn btn-secondary btn-lg" href="/Join" role="button">Join the Church Today!</a>
                        </div>
                      </div>
                  
                      <div class="item">
                        <img src="Twitter_Header.png" alt="From the Desk of the High Voice">
                        <div class="carousel-caption">
                            <a class="btn btn-secondary btn-lg" href="/FromTheDesk" role="button">From the High Voice</a>
                        </div>
                      </div>
                  
                    <!-- Left and right controls -->
                    <a class="left carousel-control" href="#imgCarousel" data-slide="prev">
                      <span class="glyphicon glyphicon-chevron-left"></span>
                      <span class="sr-only">Previous</span>
                    </a>
                    <a class="right carousel-control" href="#imgCarousel" data-slide="next">
                      <span class="glyphicon glyphicon-chevron-right"></span>
                      <span class="sr-only">Next</span>
                    </a>
                  </div>
            </div>
        </div>
    </div>

    <div class=".container-fluid">
        <div class="row">
            <div class="col-4">
                <p><a href="https://twitter.com/ExarchTatiana?ref_src=twsrc%5Etfw" class="twitter-follow-button" data-show-count="false">Follow @ExarchTatiana</a><script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script></p>
                <div>
                    <a class="twitter-timeline" href="https://twitter.com/ExarchTatiana?ref_src=twsrc%5Etfw">Tweets by Exarch Tatiana, the High Voice</a>
                    <script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>
                </div>
            </div>
            <div class="col-8">
                <h1>News and Events</h1>
                <div class="jumbotron">
                    <h3 class="display-4">From the Desk of the Grand Voice</h3>
                    <p class="lead"></p>
                    <hr class="my-4">
                    <p class="lead">
                        <a class="btn btn-secondary btn-lg" href="/FromTheDesk" role="button">Read the Words of the Grand Voice &raquo;</a>
                    </p>
                </div>

                <div class="jumbotron">
                    <h3 class="display-4">From the Sermons of High Priest Callixtus Pius</h3>
                    <p class="lead">An Introduction to the Ten Virtues</p>
                    <hr class="my-4">
                    <p class="lead">
                        <a class="btn btn-secondary btn-lg" href="/Sermons/SermonOne" role="button">Read his latest sermon &raquo;</a>
                    </p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>