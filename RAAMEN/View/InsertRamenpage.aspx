<%@ Page Title="" Language="C#" MasterPageFile="~/View/Masterpage.Master" AutoEventWireup="true" CodeBehind="InsertRamenpage.aspx.cs" Inherits="RAAMEN.View.InsertRamenpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <asp:Label ID="nameLbl" runat="server" Text="Name"></asp:Label><br />
            <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox><br />

            <asp:Label ID="meatLbl" runat="server" Text="Meat"></asp:Label><br />
            <asp:DropDownList ID="meatLst" runat="server">
                <asp:ListItem>Please Select</asp:ListItem>
                <asp:ListItem>Chicken</asp:ListItem>
                <asp:ListItem>Karaage</asp:ListItem>
                <asp:ListItem>Beef</asp:ListItem>
                <asp:ListItem>Ebi Tempura</asp:ListItem>
            </asp:DropDownList><br />

            <asp:Label ID="brothLbl" runat="server" Text="Broth"></asp:Label><br />
            <asp:TextBox ID="brothTxt" runat="server"></asp:TextBox><br />

            <asp:Label ID="priceLbl" runat="server" Text="Price"></asp:Label><br />
            <asp:TextBox ID="priceTxt" runat="server"></asp:TextBox>
        </div><br />
        <div>
            <asp:Label ID="infoLbl" runat="server" Text=""></asp:Label><br />

            <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click" />
            <asp:Button ID="insertBtn" runat="server" Text="Insert" OnClick="insertBtn_Click" />
        </div>
    </div>
</asp:Content>
