<%@ Page Title="" Language="C#" MasterPageFile="~/View/Masterpage.Master" AutoEventWireup="true" CodeBehind="Profilepage.aspx.cs" Inherits="RAAMEN.View.Profilepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label>
            <asp:Label ID="usernameLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Email: "></asp:Label>
            <asp:Label ID="emailLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Gender: "></asp:Label>
            <asp:Label ID="genderLbl" runat="server" Text=""></asp:Label>
        </div>
    </div><br />
    <div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Username"></asp:Label><br />
            <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label6" runat="server" Text="Email"></asp:Label><br />
            <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label7" runat="server" Text="Gender"></asp:Label><br />
            <asp:DropDownList ID="genderLst" runat="server">
                <asp:ListItem>Please Select</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:DropDownList><br />

            <asp:Label ID="Label8" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="passwordTxt" runat="server"></asp:TextBox><br />
        </div><br />
        <div>
            <asp:Label ID="infoLbl" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" />
        </div>
    </div>
</asp:Content>
