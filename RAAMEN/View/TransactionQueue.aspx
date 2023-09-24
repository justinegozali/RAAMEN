<%@ Page Title="" Language="C#" MasterPageFile="~/View/Masterpage.Master" AutoEventWireup="true" CodeBehind="TransactionQueue.aspx.cs" Inherits="RAAMEN.View.TransactionQueue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="headerGV" OnSelectedIndexChanging="headerGV_SelectRow" AutoGenerateSelectButton="true" runat="server"></asp:GridView>
</asp:Content>
