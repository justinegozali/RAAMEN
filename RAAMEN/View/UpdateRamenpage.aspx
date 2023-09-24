<%@ Page Title="" Language="C#" MasterPageFile="~/View/Masterpage.Master" AutoEventWireup="true" CodeBehind="UpdateRamenpage.aspx.cs" Inherits="RAAMEN.View.UpdateRamenpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
            <asp:Label ID="nameLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Meat: "></asp:Label>
            <asp:Label ID="meatLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Broth: "></asp:Label>
            <asp:Label ID="brothLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Price: "></asp:Label>
            <asp:Label ID="priceLbl" runat="server" Text=""></asp:Label>
        </div>
    </div><br />
    <div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Name"></asp:Label><br />
            <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label6" runat="server" Text="Meat"></asp:Label><br />
            <asp:DropDownList ID="meatLst" runat="server">
                <asp:ListItem>Please Select</asp:ListItem>
                <asp:ListItem>Chicken</asp:ListItem>
                <asp:ListItem>Karaage</asp:ListItem>
                <asp:ListItem>Beef</asp:ListItem>
                <asp:ListItem>Ebi Tempura</asp:ListItem>
            </asp:DropDownList><br />

            <asp:Label ID="Label7" runat="server" Text="Broth"></asp:Label><br />
            <asp:TextBox ID="brothTxt" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label8" runat="server" Text="Price"></asp:Label><br />
            <asp:TextBox ID="priceTxt" runat="server"></asp:TextBox><br />
        </div><br />
        <div>
            <asp:Label ID="infoLbl" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" />
        </div>
    </div>
</asp:Content>
