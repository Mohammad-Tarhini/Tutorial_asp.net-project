<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication11.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>search:</p>

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="search" OnClick="Button1_Click" />
   
    <asp:Button ID="Button2" runat="server" Text="add" OnClick="Button2_Click" />
    <asp:Button ID="Button3" runat="server" Text="updata" OnClick="Button3_Click" />

    <br />

    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1"></asp:GridView>
</asp:Content>
