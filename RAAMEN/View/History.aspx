<%@ Page Title="" Language="C#" MasterPageFile="~/View/Masterpage.Master" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="RAAMEN.View.History" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="headerGV" OnSelectedIndexChanging="headerGV_SelectRow" AutoGenerateSelectButton="true" runat="server"></asp:GridView>
</asp:Content>
