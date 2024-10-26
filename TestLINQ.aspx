<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TestLINQ.aspx.cs" Inherits="WebApplication11.TestLINQ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>search</p>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="search" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="give me" OnClick="Button2_Click" />
    <asp:Button ID="Button3" runat="server" Text="search Name" OnClick="Button3_Click" />
    <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged1"></asp:GridView>


</asp:Content>
