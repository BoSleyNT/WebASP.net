<%@ Page Title="Marvel MCU" Language="C#" MasterPageFile="~/MasterPages/Frontend.master" AutoEventWireup="true" CodeFile="Content.aspx.cs" Inherits="Content" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="Server">
    <h1 class="auto-style1">Chào mừng bạn đến với Marvel VN !</h1>
    <p class="auto-style1">Đây là trang giới thiệu về vũ trụ điện ảnh Marvel</p>
    <video src="../Video/Marvel Studios.mp4" controls="controls" style="width:650px" />
</asp:Content>

