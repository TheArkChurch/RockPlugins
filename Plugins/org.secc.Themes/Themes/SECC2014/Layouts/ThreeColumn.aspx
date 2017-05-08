﻿<%@ Page Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" Inherits="Rock.Web.UI.RockPage" %>

<asp:Content ID="ctMain" ContentPlaceHolderID="main" runat="server">

    <Rock:Zone Name="Header Banner" runat="server" />

    <main class="container">
        <!-- Start Content Area -->

        <br />
        <!-- Page Title -->
        <Rock:PageIcon ID="PageIcon" runat="server" />
        <h1 class="copy">
            <Rock:PageTitle ID="PageTitle" runat="server" />
        </h1>
        <Rock:PageBreadCrumbs ID="PageBreadCrumbs" runat="server" />

        <!-- Ajax Error -->
        <div class="alert alert-danger ajax-error" style="display:none">
            <p><strong>Error</strong></p>
            <span class="ajax-error-message"></span>
        </div>

        <Rock:Zone Name="Feature" runat="server" />

        <div class="row">
            <div class="col-md-4">
                <Rock:Zone Name="Sidebar 1" runat="server" />
            </div>
            <div class="col-md-4">
                <Rock:Zone Name="Main" runat="server" />
            </div>
            <div class="col-md-4">
                <Rock:Zone Name="Sidebar 2" runat="server" />
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <Rock:Zone Name="Section A" runat="server" />
            </div>
        </div>

        <div class="row">
            <div class="col-md-4">
                <Rock:Zone Name="Section B" runat="server" />
            </div>
            <div class="col-md-4">
                <Rock:Zone Name="Section C" runat="server" />
            </div>
            <div class="col-md-4">
                <Rock:Zone Name="Section D" runat="server" />
            </div>
        </div>

        <!-- End Content Area -->
        <br />
    </main>

</asp:Content>
