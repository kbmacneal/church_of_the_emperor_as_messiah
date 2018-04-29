<%@ Page Title="A Sermon by Callixtus Pious" Language="C#" MasterPageFile="~/MasterPages/Site.6_6.Master" AutoEventWireup="true" CodeBehind="SermonYakiyah.aspx.cs" Inherits="emperor3.SermonYakiyah" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-6">
                    <img class="img-thumbnail img-fluid" src="/Assets/Yakiyah.jpg" />
                    <div class="lead">Yakiya, a planet in the Tsatsos system, currently controlled by A.C.R.E.</div>
                </div>
            </div>
        </div>
    <h2>
        <p id="sermon_header" runat="server"></p>
    </h2>
    <div id="sermon_text" runat="server" style="font-size:larger;"></div>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent2" runat="server">

    <h2>
        <p id="sermon_header_right" runat="server"></p>
    </h2>
    <div id="sermon_text_right" runat="server" style="font-size:larger;"></div>
</asp:Content>