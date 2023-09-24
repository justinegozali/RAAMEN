<%@ Page Title="" Language="C#" MasterPageFile="~/View/Masterpage.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="RAAMEN.View.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label>
        <asp:Label ID="usernameLbl" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Role: "></asp:Label>
        <asp:Label ID="roleLbl" runat="server" Text=""></asp:Label>
    </div><br />
    <asp:GridView ID="customerGV" AutoGenerateColumns="false" runat="server">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id"  />
            <asp:BoundField DataField="RoleId" HeaderText="Role" />
            <asp:BoundField DataField="Username" HeaderText="Username" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
            <asp:BoundField DataField="Gender" HeaderText="Gender" />
            <asp:BoundField DataField="Password" HeaderText="Password" />
        </Columns>
    </asp:GridView><br />
    <asp:GridView ID="staffGV" AutoGenerateColumns="false" runat="server">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id"  />
            <asp:BoundField DataField="RoleId" HeaderText="Role" />
            <asp:BoundField DataField="Username" HeaderText="Username" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
            <asp:BoundField DataField="Gender" HeaderText="Gender" />
            <asp:BoundField DataField="Password" HeaderText="Password" />
        </Columns>
    </asp:GridView><br />
</asp:Content>
