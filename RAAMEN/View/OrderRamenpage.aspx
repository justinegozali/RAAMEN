<%@ Page Title="" Language="C#" MasterPageFile="~/View/Masterpage.Master" AutoEventWireup="true" CodeBehind="OrderRamenpage.aspx.cs" Inherits="RAAMEN.View.OrderRamenpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="RamenGV" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id"  />
            <asp:BoundField DataField="MeatId" HeaderText="Meat" />
            <asp:BoundField DataField="Broth" HeaderText="Broth" />
            <asp:BoundField DataField="Price" HeaderText="Price" />
        </Columns>
    </asp:GridView><br />
    <div>
        <asp:Label ID="Label1" runat="server" Text="Menu Id"></asp:Label><br />
        <asp:TextBox ID="menuIdTxt" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label2" runat="server" Text="Quantity"></asp:Label><br />
        <asp:TextBox ID="quantityTxt" runat="server"></asp:TextBox><br />
    </div><br />
    <div>
        <asp:Label ID="infoLbl" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="addCartBtn" runat="server" Text="Add Cart" OnClick="addCartBtn_Click" />
        <asp:Button ID="clearCartBtn" runat="server" Text="Clear Cart" OnClick="clearCartBtn_Click" />
        <asp:Button ID="buyCartBtn" runat="server" Text="Buy Cart" OnClick="buyCartBtn_Click" />
    </div><br />
    <asp:GridView ID="CartGV" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="UserId" HeaderText="UserId"  />
            <asp:BoundField DataField="RamenId" HeaderText="RamenId" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
        </Columns>
    </asp:GridView><br />
</asp:Content>
